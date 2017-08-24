using X.Web.RSS.Exceptions;
using System.Xml.Serialization;

namespace X.Web.RSS.Enumerators
{
    public class Hour
    {
        private byte _value;
        
        public Hour()
        {
        }

        public Hour(byte newValue)
        {
            _value = newValue;
        }

        [XmlText]
        public byte Value
        {
            get
            {
                return _value;
            }
            set
            {
                if (_value < 0 || _value > 23)
                {
                    throw new RSSParameterException("hour", value);
                }

                _value = value;
            }
        }
    }
}