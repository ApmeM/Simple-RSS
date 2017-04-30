using System.Xml.Serialization;

namespace X.Web.RSS.Structure.Validators
{
    public class RssEmail
    {
        #region Constants and Fields

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
        public string Email { get; set; }

        #endregion
    }
}