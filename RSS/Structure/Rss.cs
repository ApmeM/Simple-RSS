using System.IO;
using System.Xml.Serialization;

namespace X.Web.RSS.Structure
{

    /// <summary>
    /// RSS is a Web content syndication format.
    ///   Its name is an acronym for Really Simple Syndication.
    ///   RSS is a dialect of XML. All RSS files must conform to the XML 1.0 specification, 
    ///   as published on the World Wide Web Consortium (W3C) website.
    ///   http://www.w3.org/TR/REC-xml
    /// </summary>
    [XmlRoot("rss")]
    public class Rss
    {
        public Rss()
        {
            this.Channel = new RssChannel();
            this.Version = "2.0";
        }

        /// <summary>
        ///   Gets or sets subordinate to the 'rss' element is a single 'channel' element, 
        ///   which contains information about the channel (metadata) and its contents.
        /// </summary>
        [XmlElement("channel")]
        public RssChannel Channel { get; set; }

        /// <summary>
        ///   Gets or sets at the top level, a RSS document is a 'rss' element, 
        ///   with a mandatory attribute called version, that specifies 
        ///   the version of RSS that the document conforms to.
        /// </summary>
        [XmlAttribute("version")]
        public string Version { get; set; }
    }
}