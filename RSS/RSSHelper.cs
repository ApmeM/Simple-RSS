namespace RSS
{
    #region Using Directives

    using System.IO;
    using System.Xml.Serialization;

    using RSS.Structure;

    #endregion

    public class RSSHelper
    {
        #region Public Methods

        public static void GetRSS(Rss value, Stream destination)
        {
            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
            xsn.Add("atom", "http://www.w3.org/2005/Atom");

            XmlSerializer ser = new XmlSerializer(value.GetType());
            ser.Serialize(destination, value, xsn);
        }

        public static Rss ReadRSS(Stream source)
        {
            XmlSerializerNamespaces xsn = new XmlSerializerNamespaces();
            xsn.Add("atom", "http://www.w3.org/2005/Atom");

            XmlSerializer ser = new XmlSerializer(typeof(Rss));
            return (Rss)ser.Deserialize(source);
        }

        #endregion
    }
}