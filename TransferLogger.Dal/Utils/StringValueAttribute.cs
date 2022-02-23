using System;

namespace TransferLogger.Dal.Utils
{
    public class StringValueAttribute : Attribute
    {
        private readonly string _value;
        public string Value => _value;

        public StringValueAttribute(string value)
        {
            _value = value;
        }
    }
}
