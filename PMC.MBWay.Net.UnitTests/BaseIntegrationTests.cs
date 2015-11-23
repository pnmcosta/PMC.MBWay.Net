/*
 * This file is part of the PMC.MBWay.Net package.
 *
 * (c) Pedro Costa <http://pmc.digital>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMC.MBWay.Net.API.FinancialOperations;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading;

namespace PMC.MBWay.Net.UnitTests
{
    public class BaseIntegrationTests
    {
        private MBWayClient client;
        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        protected MBWayClient GetClient()
        {
            if (client != null)
                return client;

            client = new MBWayClient(this.GetConfig(), true);

            return client;
        }
        protected void ApprovalSleep()
        {
            Thread.Sleep(int.Parse(ConfigurationManager.AppSettings["TEST_APPROVAL_SLEEP"]));
        }
        protected string TestAlias
        {
            get
            {
               return ConfigurationManager.AppSettings["TEST_ALIAS"];
            }
        }
        protected MBWayConfig GetConfig()
        {

            return new MBWayConfig
            {
                CertificateThumbprint = ConfigurationManager.AppSettings["CERTIFICATE_THUMBPRINT"],
                MerchantIP = ConfigurationManager.AppSettings["MERCHANT_IP"],
                MerchantPOSID = ConfigurationManager.AppSettings["MERCHANT_POSID"],
                AsyncServiceEndpoint = ConfigurationManager.AppSettings["ASYNC_SERVICE_ENDPOINT"]
            };

            //return new MBWayConfig
            //{
            //    CertificatePass = ConfigurationManager.AppSettings["CERTIFICATE_PASS"],
            //    CertificatePath = ConfigurationManager.AppSettings["CERTIFICATE_PATH"],
            //    MerchantIP = ConfigurationManager.AppSettings["MERCHANT_IP"],
            //    MerchantPOSID = ConfigurationManager.AppSettings["MERCHANT_POSID"],
            //    AsyncServiceEndpoint = ConfigurationManager.AppSettings["ASYNC_SERVICE_ENDPOINT"]
            //};
        }
    }
}
