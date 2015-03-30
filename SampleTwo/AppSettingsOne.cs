using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpConfig;

namespace SampleTwo
{
    public class AppSettingsOne
    {
        [DefaultSettingValueAttribute("hello")]
        [DescriptionSetting("Value for textBox1")]
        public string TextBox1Value { get; set; }

        [DefaultSettingValueAttribute("")]
        [DescriptionSetting("Value for textBox2")]
        public string TextBox2Value { get; set; }

        [DefaultSettingValueAttribute(false)]
        public bool checkBox1Value { get; set; }

        [DefaultSettingValueAttribute(true)]
        public bool checkBox2Value { get; set; }

        [DefaultSettingValueAttribute(new[] {"cool", "config"})]
        public string[] listBoxValues { get; set; }
    }
}
