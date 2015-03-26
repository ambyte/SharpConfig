using System;
using System.Collections.Generic;
using System.Text;

namespace SharpConfig
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class DefaultSettingAttribute : Attribute
    {
        private readonly object _value;

        public DefaultSettingAttribute(object value)
        {
            _value = value;
        }

        public DefaultSettingAttribute(object value, string comment)
        {
            _value = value;
        }

        public object Value
        {
            get
            {
                return _value;
            }
        }
    }
}
