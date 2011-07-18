namespace RSS.Structure.Validators
{
    #region Using Directives

    using System.Text.RegularExpressions;

    using RSS.Exceptions;

    #endregion

    public class RssEmail
    {
        #region Constants and Fields

        private readonly string email;

        private readonly Regex r =
            new Regex(
                "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", 
                RegexOptions.IgnoreCase);

        #endregion

        #region Constructors and Destructors

        public RssEmail(string email)
        {
            if (email != null && !this.r.IsMatch(email))
            {
                throw new RSSParameterException("email", email);
            }

            this.email = email;
        }

        #endregion

        #region Properties

        public string Email
        {
            get
            {
                return this.email;
            }
        }

        #endregion
    }
}