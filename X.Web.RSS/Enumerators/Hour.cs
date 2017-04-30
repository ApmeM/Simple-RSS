using X.Web.RSS.Exceptions;
using System.Xml.Serialization;

namespace X.Web.RSS.Enumerators
{
    public class Hour
    {
        #region Constants and Fields

        private byte value;

        #endregion

        #region Constructors and Destructors

        public Hour()
        {
        }

        public Hour(byte newValue)
        {
            this.value = newValue;
        }

        #endregion

        #region Properties

        [XmlText]
        public byte Value
        {
            get
            {
                return this.value;
            }

            set
            {
                if (value < 0 || value > 23)
                {
                    throw new RSSParameterException("hour", value);
                }

                this.value = value;
            }
        }

        #endregion
    }
}