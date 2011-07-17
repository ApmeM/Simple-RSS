namespace RSS.Test
{
    #region Using Directives

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    #endregion

    [TestClass]
    public class ValidatorsTest
    {
        #region Public Methods

        [TestMethod]
        public void UrlValidator_ValidUrl_True()
        {
            var result = Validators.UrlValidator("http://valid.absolute.url/");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UrlValidator_NullUrl_True()
        {
            var result = Validators.UrlValidator(null);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UrlValidator_InvalidUrl_True()
        {
            var result = Validators.UrlValidator(string.Empty);

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void UrlValidator_ValidEmail_True()
        {
            var result = Validators.Emailvalidator("valid@email.com");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UrlValidator_NullEmail_True()
        {
            var result = Validators.Emailvalidator(null);

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void UrlValidator_InvalidEmail_True()
        {
            var result = Validators.Emailvalidator(string.Empty);

            Assert.IsFalse(result);
        }

        #endregion
    }
}