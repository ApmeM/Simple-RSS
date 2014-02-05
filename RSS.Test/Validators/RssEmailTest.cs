using X.Web.RSS.Exceptions;
using X.Web.RSS.Structure.Validators;

namespace RSS.Test.Validators
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;

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