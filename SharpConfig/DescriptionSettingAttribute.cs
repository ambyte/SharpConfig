using System;
using System.Collections.Generic;
using System.Text;

namespace SharpConfig
{
    public sealed class DescriptionSettingAttribute : Attribute
    {
        private readonly string _description;

        public DescriptionSettingAttribute(string description)
        {
            _description = description;
        }

        public string Description
        {
            get
            {
                return _description;
            }
        }
    }
}
