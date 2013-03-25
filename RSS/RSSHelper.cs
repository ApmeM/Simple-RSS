using System.IO;
using System.Xml.Serialization;
using X.Web.RSS.Structure;

namespace X.Web.RSS
{
    public static class RSSHelper
    {

        public static void WriteRSS(Rss value, Stream destination)
        {
            var xsn = new XmlSerializerNamespaces();
            xsn.Add("atom", "http://www.w3.org/2005/Atom");
            xsn.Add("dc", "http://purl.org/dc/elements/1.1/");
            xsn.Add("content", "http://purl.org/rss/1.0/modules/content/");

            var ser = new XmlSerializer(value.GetType());
            ser.Serialize(destination, value, xsn);
        }

        public static Rss ReadRSS(Stream source)
        {
            var xsn = new XmlSerializerNamespaces();
            xsn.Add("atom", "http://www.w3.org/2005/Atom");
            xsn.Add("dc", "http://purl.org/dc/elements/1.1/");
            xsn.Add("content", "http://purl.org/rss/1.0/modules/content/");

            var ser = new XmlSerializer(typeof(Rss));
            return (Rss)ser.Deserialize(source);
        }

    }
}