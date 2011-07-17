namespace RSS
{
    #region Using Directives

    using System;
    using System.Text.RegularExpressions;

    #endregion

    public class Validators
    {
        #region Public Methods

        public static bool Emailvalidator(string email)
        {
            if (email == null)
            {
                return true;
            }

            Regex r =
                new Regex(
                    "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?", 
                    RegexOptions.IgnoreCase);
            return r.IsMatch(email);
        }

        public static bool UrlValidator(string url)
        {
            if (url == null)
            {
                return true;
            }

            try
            {
                new Uri(url, UriKind.Absolute);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        #endregion
    }
}