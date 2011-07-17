namespace RSS.Structure
{
    #region Using Directives

    using System.Xml.Serialization;

    #endregion

    /// <summary>
    ///   &lt;atom:link href = "http://bash.org.ru/rss/" rel = "self" type = "application/rss+xml" /&gt;
    /// </summary>
    public class RssLink
    {
        #region Constants and Fields

        private readonly RssUrl href = new RssUrl();

        #endregion

        #region Constructors and Destructors

        public RssLink()
        {
            this.Type = "application/rss+xml";
            this.Rel = "self";
        }

        #endregion

        #region Properties

        [XmlAttribute("href")]
        public string Href
        {
            get
            {
                return this.href.Uri;
            }

            set
            {
                this.href.Uri = value;
            }
        }

        // ToDo: validator
        [XmlAttribute("rel")]
        public string Rel { get; set; }

        [XmlAttribute("type")]
        public string Type { get; set; }

        #endregion
    }
}