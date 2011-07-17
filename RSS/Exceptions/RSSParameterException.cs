namespace RSS.Exceptions
{
    #region Using Directives

    using System;
    using System.Runtime.Serialization;

    #endregion

    public class RSSParameterException : Exception
    {
        #region Constructors and Destructors

        public RSSParameterException(string message)
            : base(string.Format("RSSParameterException {0}", message))
        {
        }

        public RSSParameterException()
        {
        }

        public RSSParameterException(string message, Exception innerException)
            : base(string.Format("RSSParameterException {0}", message), innerException)
        {
        }

        protected RSSParameterException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        #endregion
    }
}