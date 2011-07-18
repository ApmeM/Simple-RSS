namespace RSS.Structure.Validators
{
    #region Using Directives

    using System;

    using RSS.Exceptions;

    #endregion

    public class RssDate
    {
        #region Constants and Fields

        private string dateString;
        private DateTime? date;

        #endregion

        #region Constructors and Destructors

        public RssDate(string date)
        {
            DateTime? newDate = null;
            if (date != null)
            {
                try
                {
                    newDate = DateTime.Parse(date);
                }
                catch (Exception ex)
                {
                    throw new RSSParameterException("date", date, ex);
                }
            }
         
            this.SetDate(newDate);
        }

        public RssDate(DateTime? date)
        {
            this.SetDate(date);
        }

        #endregion

        #region Properties

        public string DateString
        {
            get
            {
                return this.dateString;
            }
        }

        public DateTime? Date
        {
            get
            {
                return this.date;
            }
        }

        #endregion

        private void SetDate(DateTime? newDate)
        {
            if (newDate != null)
            {
                if (newDate > DateTime.Now)
                {
                    throw new RSSParameterException("newDate", newDate);
                }

                this.date = newDate;
                this.dateString = this.date.Value.ToString("R");
            }
            else
            {
                this.date = null;
                this.dateString = null;
            }
        }
    }
}