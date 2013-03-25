using System;
using System.Runtime.Serialization;

namespace X.Web.RSS.Exceptions
{
    public class RSSParameterException : Exception
    {
        #region Constants and Fields

        private readonly string field;

        private readonly object value;

        private const string MessageText = "RSSParameterException field '{0}', value '{1}'";

        #endregion

        #region Constructors and Destructors

        public RSSParameterException(string field, object value)
            : base(string.Format(MessageText, field, value))
        {
            this.field = field;
            this.value = value;
        }

        public RSSParameterException(string field, object value, Exception innerException)
            : base(string.Format(MessageText, field, value), innerException)
        {
            this.field = field;
            this.value = value;
        }

        protected RSSParameterException(SerializationInfo info, StreamingContext context, string field, object value)
            : base(info, context)
        {
            this.field = field;
            this.value = value;
        }

        #endregion

        #region Properties

        public string Field
        {
            get
            {
                return this.field;
            }
        }

        public object Value
        {
            get
            {
                return this.value;
            }
        }

        #endregion
    }
}