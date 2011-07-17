namespace RSS.Enumerators
{
    #region Using Directives

    using System.Xml.Serialization;

    using RSS.Exceptions;

    #endregion

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
                    throw new RSSParameterException(string.Format("{0}.value", this.GetType()));
                }

                this.value = value;
            }
        }

        #endregion
    }
}