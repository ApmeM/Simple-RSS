namespace RSS.Structure.Validators
{
    #region Using Directives

    using System;

    using RSS.Exceptions;

    #endregion

    public class RssTtl
    {
        #region Constants and Fields

        private int ttl;

        private string ttlString;

        #endregion

        #region Constructors and Destructors

        public RssTtl(string ttl)
        {
            int newTtl = 0;
            if (ttl != null)
            {
                try
                {
                    newTtl = int.Parse(ttl);
                }
                catch (Exception ex)
                {
                    throw new RSSParameterException("ttl", ttl, ex);
                }
            }

            this.SetTTL(newTtl);
        }

        public RssTtl(int ttl)
        {
            this.SetTTL(ttl);
        }

        #endregion

        #region Properties

        public int TTL
        {
            get
            {
                return this.ttl;
            }
        }

        public string TTLString
        {
            get
            {
                return this.ttlString;
            }
        }

        #endregion

        #region Methods

        private void SetTTL(int newTtl)
        {
            if (newTtl < 0)
            {
                throw new RSSParameterException(string.Format("{0}.ttl", this.GetType()), newTtl);
            }

            if (newTtl != 0)
            {
                this.ttl = newTtl;
                this.ttlString = this.ttl.ToString();
            }
            else
            {
                this.ttl = 0;
                this.ttlString = null;
            }
        }

        #endregion
    }
}