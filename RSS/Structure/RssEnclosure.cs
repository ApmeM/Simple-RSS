namespace RSS.Structure
{
    #region Using Directives

    using System.Xml.Serialization;

    #endregion

    public class RssEnclosure
    {
        #region Constants and Fields

        private readonly RssUrl url = new RssUrl();

        #endregion

        #region Properties

        /// <summary>
        ///   Gets or sets length says how big it is in bytes
        /// </summary>
        /// <example>
        ///   12216320
        /// </example>
        [XmlAttribute("length")]
        public int Length { get; set; }

        /// <summary>
        ///   Gets or sets type says what its type is, a standard MIME type
        /// </summary>
        /// <example>
        ///   audio/mpeg
        /// </example>
        [XmlAttribute("type")]
        public string Type { get; set; }

        /// <summary>
        ///   Gets or sets url says where the enclosure is located
        /// </summary>
        /// <example>
        ///   http://www.scripting.com/mp3s/weatherReportSuite.mp3
        /// </example>
        [XmlAttribute("url")]
        public string Url
        {
            get
            {
                return this.url.Uri;
            }

            set
            {
                this.url.Uri = value;
            }
        }

        #endregion
    }
}