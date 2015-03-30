using System;
using System.Collections.Generic;
using System.Text;

namespace SharpConfig
{
    [AttributeUsage(AttributeTargets.Property)]
    public sealed class DefaultSettingValueAttribute : Attribute
    {
        private readonly object _value;

        public DefaultSettingValueAttribute(object value)
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
