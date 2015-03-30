using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SharpConfig;

namespace SampleTwo
{
    public class AppSettingsTwo
    {
        [DefaultSettingValueAttribute("bye")]
        public string TextBox1Value { get; set; }

        [DefaultSettingValueAttribute("day")]
        public string TextBox2Value { get; set; }

        [DescriptionSetting("Value for checkBox1")]
        [DefaultSettingValueAttribute(true)]
        public bool checkBox1Value { get; set; }

        [DescriptionSetting("Value for checkBox2")]
        [DefaultSettingValueAttribute(false)]
        public bool checkBox2Value { get; set; }

        [DefaultSettingValueAttribute(new[] { "super", "config" })]
        public string[] listBoxValues { get; set; }
    }
}
