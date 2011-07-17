namespace RSS.Structure
{
    #region Using Directives

    using System.Xml.Serialization;

    #endregion

    public class RssCategory
    {
        #region Properties

        [XmlAttribute("domain")]
        public string Domain { get; set; }

        [XmlText]
        public string Text { get; set; }

        #endregion
    }
}