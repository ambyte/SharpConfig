using System;
using System.Collections.Generic;
using System.IO;

namespace SharpConfig
{
    /// <summary>
    /// Represents a configuration from object.
    /// Configuration sections is the mapping from the user objects.
    /// </summary>
    public class ObjectConfiguration
    {
        #region Fields

        Dictionary<Type, object> _settingsObjects;
        private static Configuration _configuration;

        #endregion

        #region Construction

        public ObjectConfiguration()
        {
            _settingsObjects = new Dictionary<Type, object>();
            _configuration = new Configuration();
        }

        #endregion

        #region Init Method

        /// <summary>
        /// Creates an object of a specific type and maps the settings
        /// from the public properties of the object to the section of the same name.
        /// </summary>
        /// <typeparam name="T">Object Type</typeparam>
        /// <returns>The created object.</returns>
        public T AddObject<T>() where T : class
        {
            Type type = typeof(T);

            try
            {
                var obj = Activator.CreateInstance<T>();
                _configuration[type.Name].MapTo(obj);
                _settingsObjects.Add(type, obj);
                return obj;
            }
            catch (Exception)
            {
                throw new ArgumentException(string.Format(
                    "The type '{0}' does not have a default public constructor.",
                    type.Name));
            }
        }

        #endregion

        #region Load

        /// <summary>
        /// Loads a configuration from a file.
        /// </summary>
        /// <param name="fileName">The location of the configuration file.</param>
        public void Load(string fileName)
        {
            LoadConfig(fileName, false);
        }

        /// <summary>
        /// Loads a configuration from a binary file.
        /// </summary>
        /// <param name="fileName">The location of the configuration file.</param>
        public void LoadBinary(string fileName)
        {
            LoadConfig(fileName, true);
        }

        /// <summary>
        /// Loads a configuration from an encrypted file.
        /// </summary>
        /// <param name="fileName">The location of the configuration file.</param>
        /// <param name="key">Secure key</param>
        public void LoadSecure(string fileName, string key)
        {
            var configTempName = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            if (File.Exists(fileName) && new FileInfo(fileName).Length != 0)
            {
                if (Secure.DecryptFile(fileName, configTempName, Environment.MachineName))
                {
                    LoadConfig(configTempName, false);
                    File.Delete(configTempName);
                }
            }
        }

        /// <summary>
        /// Loads a configuration from a file or a binary file.
        /// </summary>
        /// <param name="fileName">The location of the configuration file.</param>
        /// <param name="loadBinary">Whether to load from binary file</param>
        private void LoadConfig(string fileName, bool loadBinary)
        {
            if (File.Exists(fileName) && new FileInfo(fileName).Length != 0)
            {
                Configuration loadedConfig;
                if (loadBinary)
                {
                    loadedConfig = Configuration.LoadBinary(fileName);
                }
                else
                {
                    loadedConfig = Configuration.LoadFromFile(fileName);
                }
                _configuration = MergingConfiguration(loadedConfig);
                foreach (var mSection in _configuration)
                {
                    KeyValuePair<Type, object>? settingObject = null;
                    foreach (var setObj in _settingsObjects)
                    {
                        if (setObj.Key.Name.Contains(mSection.Name))
                        {
                            settingObject = setObj;
                        }
                    }
                    if (settingObject != null)
                    {
                        mSection.MapTo(settingObject.Value.Value, settingObject.Value.Key);
                    }
                }
            }
            SaveConfig(fileName, loadBinary);
        }


        #endregion

        #region Save

        /// <summary>
        /// Saves the configuration to a file.
        /// </summary>
        /// <param name="fileName">The location of the configuration file.</param>
        public void Save(string fileName)
        {
            SaveConfig(fileName, false);
        }

        /// <summary>
        /// Saves the configuration to a binary file.
        /// </summary>
        /// <param name="fileName">The location of the configuration file.</param>
        public void SaveBinary(string fileName)
        {
            SaveConfig(fileName, true);
        }

        /// <summary>
        /// Saves the configuration to an encrypted file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="key"></param>
        public void SaveSecure(string fileName, string key)
        {
            var configTempName = Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
            SaveConfig(configTempName, false);
            Secure.EncryptFile(configTempName, fileName, Environment.MachineName);
            File.Delete(configTempName);
        }

        /// <summary>
        /// Saves a configuration to a file or a binary file.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="saveBinary"></param>
        private void SaveConfig(string fileName, bool saveBinary)
        {
            if (fileName != null)
            {
                if (!Directory.Exists(Path.GetDirectoryName(fileName)))
                {
                    Directory.CreateDirectory(Path.GetDirectoryName(fileName));

                }
                foreach (var mSection in _configuration)
                {
                    KeyValuePair<Type, object>? settingObject = null;
                    foreach (var setObj in _settingsObjects)
                    {
                        if (setObj.Key.Name.Contains(mSection.Name))
                        {
                            settingObject = setObj;
                        }
                    }
                    if (settingObject != null)
                    {
                        UpdateFromObject(settingObject.Value.Value, settingObject.Value.Key);
                    }
                
                }
                if (saveBinary)
                {
                    _configuration.SaveBinary(fileName);
                }
                else
                {
                    _configuration.Save(fileName);
                }
                
            }
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Updates the configuration from added objects
        /// </summary>
        /// <param name="obj">Setting object</param>
        /// <param name="type">Type of object</param>
        private void UpdateFromObject<T>(T obj, Type type) where T : class
        {
            if (obj == null)
                throw new ArgumentNullException("obj");
            if (type == null)
                throw new ArgumentNullException("type");
            var properties = type.GetProperties();
            var section = _configuration[type.Name];
            foreach (var prop in properties)
            {
                if (!prop.CanRead)
                    continue;

                if (section != null)
                {
                    var setting = section[prop.Name];

                    if (setting != null)
                    {
                        if (prop.PropertyType.IsArray)
                        {
                            setting.SetValue((string[])prop.GetValue(obj, null));
                        }
                        else
                        {
                            setting.SetValue(prop.GetValue(obj, null));
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Merging the loaded configuration and current configuration
        /// </summary>
        /// <param name="loadedConfiguration">The loaded configuration</param>
        /// <returns>New configuration</returns>
        private Configuration MergingConfiguration(Configuration loadedConfiguration)
        {
            foreach (var section in _configuration)
            {
                if (!loadedConfiguration.Contains(section.Name))
                {
                    loadedConfiguration.Add(section);
                }
                else
                {
                    var loadedSection = loadedConfiguration[section.Name];
                    foreach (var setting in section)
                    {
                        if (!loadedSection.Contains(setting.Name))
                        {
                            loadedSection.Add(setting);
                        }
                    }
                }
            }
            var newConfig = new Configuration();
            foreach (var section in loadedConfiguration)
            {
                if (_configuration.Contains(section.Name))
                {
                    newConfig.Add(CloneSection(section));
                    var defaultSection = _configuration[section.Name];
                    var newConfigSection = newConfig[section.Name];
                    foreach (var setting in section)
                    {
                        if (defaultSection != null && !defaultSection.Contains(setting.Name))
                        {
                            newConfigSection.Remove(setting);
                        }
                    }
                }
            }
            return newConfig;
        }

        /// <summary>
        /// Creates new section with the same parameters
        /// </summary>
        /// <param name="section">Old section</param>
        /// <returns>New Section</returns>
        public static Section CloneSection(Section section)
        {
            Section sectionNew = new Section(section.Name);
            foreach (Setting setting in section)
            {
                sectionNew.Add(setting);    
            }
            return sectionNew;
        }

        #endregion

    }
}
