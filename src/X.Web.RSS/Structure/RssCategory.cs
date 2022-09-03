using System.Xml.Serialization;

namespace X.Web.RSS.Structure;

public class RssCategory
{
    #region Properties

    [XmlAttribute("domain")]
    public string Domain { get; set; }

    [XmlText]
    public string Text { get; set; }

    #endregion
}