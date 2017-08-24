using X.Web.RSS.Exceptions;
using X.Web.RSS.Structure.Validators;

namespace RSS.Test.Validators
{
    using System;
    using System.Globalization;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class RssTtlTest
    {
        [TestMethod]
        public void Ctor_ValidTtlParameter_Ok()
        {
            // Arrange
            const int TTL = 10;

            // Action
            RssTtl rssTtl = new RssTtl(TTL);

            // Assert
            Assert.AreEqual(TTL, rssTtl.TTL);
        }

        [TestMethod]
        public void Ctor_TtlLessZero_Error()
        {
            // Arrange
            const int TTL = -1;

            // Action
            RSSParameterException e = null;
            try
            {
                new RssTtl(TTL);
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void SetTtl_ValidTtlParameter_Ok()
        {
            // Arrange
            RssTtl rssTtl = new RssTtl();
            const int TTL = 10;

            // Action
            rssTtl.TTL = TTL;

            // Assert
            Assert.AreEqual(TTL, rssTtl.TTL);
        }

        [TestMethod]
        public void SetTtl_TtlLessZero_Error()
        {
            // Arrange
            RssTtl rssTtl = new RssTtl();
            const int TTL = -1;

            // Action
            RSSParameterException e = null;
            try
            {
                rssTtl.TTL = TTL;
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void Ctor_ValidStringParameter_Ok()
        {
            // Arrange
            const string TTL = "10";

            // Action
            RssTtl rssTtl = new RssTtl(TTL);

            // Assert
            Assert.AreEqual(TTL, rssTtl.TTLString);
        }

        [TestMethod]
        public void Ctor_StringLessZero_Error()
        {
            // Arrange
            const string TTL = "-1";

            // Action
            RSSParameterException e = null;
            try
            {
                new RssTtl(TTL);
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void SetString_ValidStringParameter_Ok()
        {
            // Arrange
            RssTtl rssTtl = new RssTtl();
            const string TTL = "10";

            // Action
            rssTtl.TTLString = TTL;

            // Assert
            Assert.AreEqual(TTL, rssTtl.TTLString);
        }

        [TestMethod]
        public void SetString_StringLessZero_Error()
        {
            // Arrange
            RssTtl rssTtl = new RssTtl();
            const string TTL = "-1";

            // Action
            RSSParameterException e = null;
            try
            {
                rssTtl.TTLString = TTL;
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void SetTtl_ConvertToString_String()
        {
            // Arrange
            RssTtl rssTtl = new RssTtl();
            const int TTL = 10;

            // Action
            rssTtl.TTLString = TTL.ToString();

            // Assert
            Assert.AreEqual(TTL, rssTtl.TTL);
        }

        [TestMethod]
        public void SetString_ConvertToTtl_Ttl()
        {
            // Arrange
            RssTtl rssTtl = new RssTtl();
            const int TTL = 10;

            // Action
            rssTtl.TTL = TTL;

            // Assert
            Assert.AreEqual(TTL.ToString(), rssTtl.TTLString);
        }

        [TestMethod]
        public void SetString_Null_TtlZero()
        {
            // Arrange
            RssTtl rssTtl = new RssTtl();

            // Action
            rssTtl.TTLString = null;

            // Assert
            Assert.AreEqual(0, rssTtl.TTL);
        }

        [TestMethod]
        public void SetTtl_Zero_StringNull()
        {
            // Arrange
            RssTtl rssTtl = new RssTtl();

            // Action
            rssTtl.TTL = 0;

            // Assert
            Assert.AreEqual(null, rssTtl.TTLString);
        }

        [TestMethod]
        public void SetString_InvalidTtlFormat_Error()
        {
            // Arrange
            RssTtl rssTtl = new RssTtl();
            const string Invalidttl = "adsfsadf";

            // Action
            RSSParameterException e = null;
            try
            {
                rssTtl.TTLString = Invalidttl;
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }

        [TestMethod]
        public void Ctor_InvalidTtlFormat_Error()
        {
            // Arrange
            const string Invalidttl = "adsfsadf";

            // Action
            RSSParameterException e = null;
            try
            {
                new RssTtl(Invalidttl);
            }
            catch (RSSParameterException ex)
            {
                e = ex;
            }

            // Assert
            Assert.IsNotNull(e);
        }
    }
}