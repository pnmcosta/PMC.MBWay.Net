using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Configuration;

namespace PMC.MBWay.Net.UnitTests
{
    [TestClass]
    public class ConfigurationTests
    {
        [TestMethod]
        public void Config_WithCertificatePath()
        {
            var config = new MBWayConfig
            {
                CertificatePass = ConfigurationManager.AppSettings["CERTIFICATE_PASS"],
                CertificatePath = ConfigurationManager.AppSettings["CERTIFICATE_PATH"],
                MerchantIP = ConfigurationManager.AppSettings["MERCHANT_IP"],
                MerchantPOSID = ConfigurationManager.AppSettings["MERCHANT_POSID"],
                AsyncServiceEndpoint = ConfigurationManager.AppSettings["ASYNC_SERVICE_ENDPOINT"]
            };

            Assert.IsNotNull(config);

            var client = new MBWayClient(config);
            Assert.IsNotNull(client);

        }
        [TestMethod]
        public void Config_WithCertificatePathFail()
        {
            var config = new MBWayConfig
            {
                CertificatePass = @"c:\path\to\nowhere.pfx",
                CertificatePath = "NotThePassword!",
                MerchantIP = ConfigurationManager.AppSettings["MERCHANT_IP"],
                MerchantPOSID = ConfigurationManager.AppSettings["MERCHANT_POSID"],
                AsyncServiceEndpoint = ConfigurationManager.AppSettings["ASYNC_SERVICE_ENDPOINT"]
            };

            Assert.IsNotNull(config);

            MBWayClient client = null;
            AssertThrows<ApplicationException>(() =>
            {
                client = new MBWayClient(config);
            });
            Assert.IsNull(client);
        }


        [TestMethod]
        public void Config_WithCertificateThumbprint()
        {
            var config = new MBWayConfig
            {
                CertificateThumbprint = ConfigurationManager.AppSettings["CERTIFICATE_THUMBPRINT"],
                MerchantIP = ConfigurationManager.AppSettings["MERCHANT_IP"],
                MerchantPOSID = ConfigurationManager.AppSettings["MERCHANT_POSID"],
                AsyncServiceEndpoint = ConfigurationManager.AppSettings["ASYNC_SERVICE_ENDPOINT"]
            };
            Assert.IsNotNull(config);

            var client = new MBWayClient(config);
            Assert.IsNotNull(client);
        }
        [TestMethod]
        public void Config_WithCertificateThumbprintFail()
        {
            var config = new MBWayConfig
            {
                CertificateThumbprint = "123123123123",
                MerchantIP = ConfigurationManager.AppSettings["MERCHANT_IP"],
                MerchantPOSID = ConfigurationManager.AppSettings["MERCHANT_POSID"],
                AsyncServiceEndpoint = ConfigurationManager.AppSettings["ASYNC_SERVICE_ENDPOINT"]
            };
            Assert.IsNotNull(config);

            MBWayClient client = null;
            AssertThrows<ApplicationException>(() =>
            {
                client = new MBWayClient(config);
            });
            Assert.IsNull(client);
        }


        public static void AssertThrows<T>(Action func) where T : Exception
        {
            // http://stackoverflow.com/a/5634337/271433
            var exceptionThrown = false;
            try
            {
                func.Invoke();
            }
            catch (T)
            {
                exceptionThrown = true;
            }

            if (!exceptionThrown)
            {
                throw new AssertFailedException(
                    String.Format("An exception of type {0} was expected, but not thrown", typeof(T))
                    );
            }
        }
    }
}
