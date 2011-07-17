namespace RSS.Test
{
    #region Using Directives

    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Text;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RSS.Enumerators;
    using RSS.Structure;

    #endregion

    [TestClass]
    public class RSSHelperTest
    {
        #region Public Methods

        [TestMethod]
        public void GetRSS_AllData_ValidRssXml()
        {
            MemoryStream ms = new MemoryStream();
            Rss rss = new Rss
                {
                    Channel =
                        new RssChannel
                            {
                                AtomLink = new RssLink { Href = "http://atomlink.com", Rel = "self", Type = "text/plain" },
                                Category = "category",
                                Cloud =
                                    new RssCloud
                                        {
                                            Domain = "domain",
                                            Path = "path",
                                            Port = 1234,
                                            Protocol = Protocol.xmlrpc,
                                            RegisterProcedure = "registerProcedure"
                                        },
                                Copyright = "copyrignt (c)",
                                Description = "long description",
                                Image =
                                    new RssImage
                                        {
                                            Description = "Image Description",
                                            Height = 100,
                                            Width = 100,
                                            Link = new RssUrl("http://image.link.url.com"),
                                            Title = "title",
                                            Url = new RssUrl("http://image.url.com")
                                        },
                                Language = new CultureInfo("en"),
                                LastBuildDate = DateTime.Now.AddDays(-1),
                                Link = new RssUrl("http://channel.url.com"),
                                ManagingEditor = "managingEditor@mail.com (manager)",
                                PubDate = DateTime.Now.AddDays(-1),
                                Rating = "rating",
                                SkipDays = new List<Day> { Day.Thursday, Day.Wednesday },
                                SkipHours = new List<Hour> { new Hour(22), new Hour(15), new Hour(4) },
                                TextInput =
                                    new RssTextInput
                                        {
                                            Description = "text input desctiption",
                                            Link = "http://text.input.link.com",
                                            Name = "text input name",
                                            Title = "text input title"
                                        },
                                Title = "channel title",
                                TTL = 10,
                                WebMaster = "webmaster@mail.ru (webmaster)",
                                Item =
                                    new List<RssItem>
                                        {
                                            new RssItem
                                                {
                                                    Author = "item.author@mail.ru (author)",
                                                    Category =
                                                        new RssCategory
                                                            {
                                                                Domain = "category domain value", 
                                                                Text = "category text value"
                                                            },
                                                    Comments = new RssUrl("http://rss.item.comment.url.com"),
                                                    Description = "item description",
                                                    Enclosure =
                                                        new RssEnclosure
                                                            {
                                                                Length = 1234,
                                                                Type = "text/plain",
                                                                Url = "http://rss.item.enclosure.type.url.com"
                                                            },
                                                    Link = "http://rss.item.link.url.com",
                                                    PubDate = "Sat, 07 Sep 2002 09:42:31 GMT",
                                                    Title = "item title",
                                                    Guid = new RssGuid { IsPermaLink = false, Value = "guid value" },
                                                    Source = new RssSource { Url = "http://rss.item.source.url.com" }
                                                }
                                        }
                            }
                };

            RSSHelper.GetRSS(rss, ms);

            var result = Encoding.UTF8.GetString(ms.GetBuffer());
            Console.WriteLine(result);
        }

        #endregion
    }
}