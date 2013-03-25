using System;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;
using X.Web.RSS.Structure;

namespace X.Web.RSS
{
    [XmlRoot("rss")]
    public class RssDocument : X.Web.RSS.Structure.Rss
    {
        public const string MimeType = "application/rss+xml";

        public RssDocument()
        {

        }

        public RssDocument(Rss rss)
        {
            this.Channel = rss.Channel;
            this.Version = rss.Version;

        }

        /// <summary>
        /// Render RSS to XML
        /// </summary>
        /// <returns></returns>
        public string ToXml()
        {
            var ms = new MemoryStream();

            RSSHelper.WriteRSS(this, ms);

            var xml = Encoding.UTF8.GetString(ms.GetBuffer()).Trim('\0');
            return xml;
        }

        /// <summary>
        /// Loads the specified URL.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <returns>RssDocument</returns>
        public static Rss Load(Uri url)
        {

            var webClient = new WebClient();

            var data = webClient.DownloadData(url);
            var memoryStream = new MemoryStream(data);

            var rss = X.Web.RSS.RSSHelper.ReadRSS(memoryStream);
            return rss;
        }

        public static Rss Load(string xml)
        {
            var stream = new MemoryStream();
            var streamWriter = new StreamWriter(stream);
            streamWriter.Write(xml);
            streamWriter.Flush();
            stream.Position = 0;

            var instance = X.Web.RSS.RSSHelper.ReadRSS(stream);
            return instance;
        }
    }
}
