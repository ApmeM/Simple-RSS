using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Globalization;
using X.Web.RSS.Exceptions;
using X.Web.RSS.Structure.Validators;

namespace RSS.Test.Validators
{
    [TestClass]
    public class RssDateTest
    {
        [TestMethod]
        public void Ctor_ValidDateParameter_Ok()
        {
            // Arrange
            DateTime date = DateTime.Now.Date;

            // Action
            RssDate rssDate = new RssDate(date);

            // Assert
            Assert.AreEqual(date, rssDate.Date);
        }

        [TestMethod]
        public void Ctor_DateInFuture_Error()
        {
            // Arrange
            DateTime date = DateTime.Now.AddDays(1);

            // Action
            RSSParameterException e = null;
            try
            {
                new RssDate(date);
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void SetDate_ValidDateParameter_Ok()
        {
            // Arrange
            RssDate rssDate = new RssDate();
            DateTime date = DateTime.Now;

            // Action
            rssDate.Date = date;

            // Assert
            Assert.AreEqual(date, rssDate.Date);
        }

        [TestMethod]
        public void SetDate_DateInFuture_Error()
        {
            // Arrange
            RssDate rssDate = new RssDate();
            DateTime date = DateTime.Now.AddDays(1);

            // Action
            RSSParameterException e = null;
            try
            {
                rssDate.Date = date;
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void Ctor_ValidStringParameter_Ok()
        {
            // Arrange
            String date = DateTime.Now.Date.ToString();

            // Action
            RssDate rssDate = new RssDate(date);

            // Assert
            Assert.AreEqual(date, rssDate.DateString);
        }

        [TestMethod]
        public void Ctor_StringInFuture_Error()
        {
            // Arrange
            String date = DateTime.Now.AddDays(1).ToString("R");

            // Action
            RSSParameterException e = null;
            try
            {
                new RssDate(date);
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void SetString_ValidStringParameter_Ok()
        {
            // Arrange
            RssDate rssDate = new RssDate();
            String date = DateTime.Now.Date.ToString();

            // Action
            rssDate.DateString = date;

            // Assert
            Assert.AreEqual(date, rssDate.DateString);
        }

        [TestMethod]
        public void SetString_StringInFuture_Error()
        {
            // Arrange
            RssDate rssDate = new RssDate();
            String date = DateTime.Now.AddDays(1).ToString("R");

            // Action
            RSSParameterException e = null;
            try
            {
                rssDate.DateString = date;
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void SetDate_ConvertToString_String()
        {
            DateTime date = DateTime.Now.Date;

            RssDate rssDate = new RssDate();
            rssDate.DateString = date.ToString();

            // Assert
            Assert.AreEqual(date, rssDate.Date);
        }

        [TestMethod]
        public void SetString_ConvertToDate_Date()
        {
            // Arrange
            RssDate rssDate = new RssDate();
            DateTime date = DateTime.Now;

            // Action
            rssDate.Date = date;

            // Assert
            Assert.AreEqual(date.ToString(), rssDate.DateString);
        }

        [TestMethod]
        public void SetString_Null_DateNull()
        {
            // Arrange
            RssDate rssDate = new RssDate();

            // Action
            rssDate.DateString = null;

            // Assert
            Assert.AreEqual(null, rssDate.Date);
        }

        [TestMethod]
        public void SetDate_Null_StringNull()
        {
            // Arrange
            RssDate rssDate = new RssDate();

            // Action
            rssDate.Date = null;

            // Assert
            Assert.IsTrue(String.IsNullOrEmpty(rssDate.DateString));
        }

        [TestMethod]
        public void SetString_InvalidDateFormat_Error()
        {
            // Arrange
            RssDate rssDate = new RssDate();
            const string InvalidDate = "adsfsadf";

            // Action
            RSSParameterException e = null;
            try
            {
                rssDate.DateString = InvalidDate;
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void Ctor_InvalidDateFormat_Error()
        {
            // Arrange
            const string InvalidDate = "adsfsadf";

            // Action
            RSSParameterException e = null;
            try
            {
                new RssDate(InvalidDate);
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