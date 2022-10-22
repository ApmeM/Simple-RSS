namespace RSS.Test.Validators
{
     using Xunit;

    using RSS.Exceptions;
    using RSS.Structure.Validators;

    public class RssEmailTest
    {
        [Fact]
        public void Ctor_ValidEmailParameter_Ok()
        {
            // Arrange
            const string Email = "valid@mail.ru";

            // Action
            RssEmail rssEmail = new RssEmail(Email);

            // Assert
            Assert.Equal(Email, rssEmail.Email);
        }

        [Fact]
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
            Assert.NotNull(e);
        }

        [Fact]
        public void SetEmail_ValidDateParameter_Ok()
        {
            // Arrange
            RssEmail rssEmail = new RssEmail();
            const string Email = "valid@mail.ru";

            // Action
            rssEmail.Email = Email;

            // Assert
            Assert.Equal(Email, rssEmail.Email);
        }

        [Fact]
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
            Assert.NotNull(e);
        }

        [Fact]
        public void SetString_Null_StringNull()
        {
            // Arrange
            RssEmail rssEmail = new RssEmail();

            // Action
            rssEmail.Email = null;

            // Assert
            Assert.Null(rssEmail.Email);
        }
    }
}