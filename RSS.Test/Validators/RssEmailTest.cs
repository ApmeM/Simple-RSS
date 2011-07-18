namespace RSS.Test.Validators
{
    using System;
    using System.Globalization;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using RSS.Exceptions;
    using RSS.Structure.Validators;

    [TestClass]
    public class RssEmailTest
    {
        [TestMethod]
        public void Ctor_ValidEmailParameter_Ok()
        {
            // Arrange
            const string Email = "valid@mail.ru";

            // Action
            RssEmail rssEmail = new RssEmail(Email);

            // Assert
            Assert.AreEqual(Email, rssEmail.Email);
        }

        [TestMethod]
        public void Ctor_InvalidEmail_Error()
        {
            // Arrange
            const string Email = "invalidmail.ru";

            // Action
            RSSParameterException e = null;
            try
            {
                new RssEmail(Email);
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void SetEmail_ValidDateParameter_Ok()
        {
            // Arrange
            RssEmail rssEmail = new RssEmail();
            const string Email = "valid@mail.ru";

            // Action
            rssEmail.Email = Email;

            // Assert
            Assert.AreEqual(Email, rssEmail.Email);
        }

        [TestMethod]
        public void SetEmail_InvalidEmail_Error()
        {
            // Arrange
            const string Email = "invalidmail.ru";
            RssEmail rssEmail = new RssEmail();

            // Action
            RSSParameterException e = null;
            try
            {
                rssEmail.Email = Email;
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void SetString_Null_StringNull()
        {
            // Arrange
            RssEmail rssEmail = new RssEmail();

            // Action
            rssEmail.Email = null;

            // Assert
            Assert.AreEqual(null, rssEmail.Email);
        }
    }
}