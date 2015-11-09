/*
 * This file is part of the PMC.MBWay.Net package.
 *
 * (c) Pedro Costa <http://pmc.digital>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

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
        protected MBWayClient client;

        protected MBWayClient GetClient()
        {
            if (client != null)
                return client;

            client = new MBWayClient(this.GetConfig(), true);

            return client;
        }
        protected void ApprovalSleep()
        {
            Thread.Sleep(int.Parse(ConfigurationManager.AppSettings["APPROVAL_SLEEP"]));
        }
        protected MBWayConfig GetConfig()
        {
            return new MBWayConfig
            {
                CertificatePass = ConfigurationManager.AppSettings["CERTIFICATE_PASS"],
                CertificatePath = ConfigurationManager.AppSettings["CERTIFICATE_PATH"],
                MerchantIP = ConfigurationManager.AppSettings["MERCHANT_IP"],
                MerchantPOSID = ConfigurationManager.AppSettings["MERCHANT_POSID"],
                AsyncServiceEndpoint = ConfigurationManager.AppSettings["ASYNC_SERVICE_ENDPOINT"]
            };
        }
    }
}
