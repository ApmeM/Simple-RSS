using X.Web.RSS.Exceptions;
using X.Web.RSS.Structure.Validators;

namespace RSS.Test.Validators
{
    using System;
    using System.Globalization;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RssUrlTest
    {
        [TestMethod]
        public void Ctor_ValidUriParameter_Ok()
        {
            // Arrange
            Uri uri = new Uri("http://test.url.com");

            // Action
            RssUrl rssUrl = new RssUrl(uri);

            // Assert
            Assert.AreEqual(uri, rssUrl.Url);
        }
        
        [TestMethod]
        public void SetUri_ValidUriParameter_Ok()
        {
            // Arrange
            RssUrl rssUrl = new RssUrl();
            Uri uri = new Uri("http://test.url.com");

            // Action
            rssUrl.Url = uri;

            // Assert
            Assert.AreEqual(uri, rssUrl.Url);
        }
        
        [TestMethod]
        public void Ctor_ValidStringParameter_Ok()
        {
            // Arrange
            String uri = new Uri("http://test.url.com").ToString();

            // Action
            RssUrl rssUrl = new RssUrl(uri);

            // Assert
            Assert.AreEqual(uri, rssUrl.UrlString);
        }

        [TestMethod]
        public void SetString_ValidStringParameter_Ok()
        {
            // Arrange
            RssUrl rssUrl = new RssUrl();
            String uri = new Uri("http://test.url.com").ToString();

            // Action
            rssUrl.UrlString = uri;

            // Assert
            Assert.AreEqual(uri, rssUrl.UrlString);
        }

        [TestMethod]
        public void SetUri_ConvertToString_String()
        {
            // Arrange
            RssUrl rssUrl = new RssUrl();
            Uri uri = new Uri("http://test.url.com");

            // Action
            rssUrl.UrlString = uri.AbsoluteUri;

            // Assert
            Assert.AreEqual(uri, rssUrl.Url);
        }

        [TestMethod]
        public void SetString_ConvertToUri_Uri()
        {
            // Arrange
            RssUrl rssUrl = new RssUrl();
            Uri uri = new Uri("http://test.url.com");

            // Action
            rssUrl.Url = uri;

            // Assert
            Assert.AreEqual(uri.AbsoluteUri, rssUrl.UrlString);
        }

        [TestMethod]
        public void SetString_Null_UriNull()
        {
            // Arrange
            RssUrl rssUrl = new RssUrl();

            // Action
            rssUrl.UrlString = null;

            // Assert
            Assert.AreEqual(null, rssUrl.Url);
        }

        [TestMethod]
        public void SetUri_Null_StringNull()
        {
            // Arrange
            RssUrl rssUrl = new RssUrl();

            // Action
            rssUrl.Url = null;

            // Assert
            Assert.AreEqual(null, rssUrl.UrlString);
        }

        [TestMethod]
        public void SetString_InvalidUriFormat_Error()
        {
            // Arrange
            RssUrl rssUrl = new RssUrl();
            const string InvalidUri = "adsfsadf";

            // Action
            RSSParameterException e = null;
            try
            {
                rssUrl.UrlString = InvalidUri;
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void Ctor_InvalidUriFormat_Error()
        {
            // Arrange
            const string InvalidUri = "adsfsadf";

            // Action
            RSSParameterException e = null;
            try
            {
                new RssUrl(InvalidUri);
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }
    }
}