namespace RSS.Structure
{
    #region Using Directives

    using System;
    using System.Xml.Serialization;

    #endregion

    public class RssUrl
    {
        #region Constants and Fields

        private Uri url;

        #endregion

        #region Constructors and Destructors

        public RssUrl()
        {
        }

        public RssUrl(string newUri)
        {
            this.Uri = newUri;
        }

        public RssUrl(Uri newUri)
        {
            this.url = newUri;
        }

        #endregion

        #region Properties

        [XmlText]
        public string Uri
        {
            get
            {
                return this.url.AbsoluteUri;
            }

            set
            {
                this.url = new Uri(value, UriKind.Absolute);
            }
        }

        #endregion
    }
}