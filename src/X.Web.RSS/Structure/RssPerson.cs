using System.Xml.Serialization;
using X.Web.RSS.Enumerators;
using X.Web.RSS.Structure.Validators;

namespace X.Web.RSS.Structure
{
    public class RssPerson
    {
        public RssPerson()
        {
        }

        public RssPerson(string name, string email)
        {
            Name = name;
            Email = email;
        }

        [XmlIgnore]
        public string Email { get; set; }

        [XmlIgnore]
        public string Name { get; set; }

        [XmlText]
        public string Value
        {
            get => $"{Email} ({Name})";
            set => throw new System.NotSupportedException("Setting this property is not supported");
        }
    }
}