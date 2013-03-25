using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace X.Web.RSS.Structure.Validators
{
    public class RssEmail
    {
        #region Constants and Fields

        private readonly Regex r =
            new Regex(
                "[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?",
                RegexOptions.IgnoreCase);

        private string _email;

        #endregion

        #region Constructors and Destructors

        public RssEmail()
        {
        }

        public RssEmail(string email)
        {
            this.Email = email;
        }

        #endregion

        #region Properties

        [XmlText]
        public string Email
        {
            get
            {
                return this._email;
            }

            set
            {
                //if (value != null && !this.r.IsMatch(value))
                //{
                //    throw new RSSParameterException("email", value);
                //}

                this._email = value;
            }
        }

        #endregion
    }
}