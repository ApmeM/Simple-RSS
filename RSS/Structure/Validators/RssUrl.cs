namespace RSS.Structure.Validators
{
    #region Using Directives

    using System;
    using System.Xml.Serialization;

    using RSS.Exceptions;

    #endregion

    public class RssUrl
    {
        #region Constants and Fields

        private Uri url;

        private string urlString;

        #endregion

        #region Constructors and Destructors

        public RssUrl()
        {
        }

        public RssUrl(string newUrl)
        {
            this.UrlString = newUrl;
        }

        public RssUrl(Uri newUrl)
        {
            this.Url = newUrl;
        }

        #endregion

        #region Properties

        [XmlIgnore]
        public Uri Url
        {
            get
            {
                return this.url;
            }

            set
            {
                this.url = value;
                this.urlString = this.url.AbsoluteUri;
            }
        }

        [XmlText]
        public string UrlString
        {
            get
            {
                return this.urlString;
            }

            set
            {
                Uri parseUrl;
                try
                {
                    parseUrl = new Uri(value, UriKind.Absolute);
                }
                catch (Exception ex)
                {
                    throw new RSSParameterException("url", value, ex);
                }

                this.Url = parseUrl;
            }
        }

        #endregion
    }
}