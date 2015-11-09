/*
 * This file is part of the PMC.MBWay.Net package.
 *
 * (c) Pedro Costa <http://pmc.digital>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PMC.MBWay.Net
{
    public class MBWayConfig
    {
        private string _certificatePath;
        private string _certificatePass;
        private string _merchantPOSID;
        private string _merchantIP;
        private string _asyncServiceEndpoint;

        public string CertificatePath
        {
            get { return _certificatePath; }
            set { _certificatePath = value; }
        }
        public string CertificatePass
        {
            get { return _certificatePass; }
            set { _certificatePass = value; }
        }

        public string MerchantPOSID
        {
            get { return _merchantPOSID; }
            set { _merchantPOSID = value; }
        }

        public string AsyncServiceEndpoint
        {
            get { return _asyncServiceEndpoint; }
            set { _asyncServiceEndpoint = value; }
        }
       
        public string MerchantIP
        {
            get { return _merchantIP; }
            set { _merchantIP = value; }
        }
        public MBWayConfig()
        {
            
        }
        public MBWayConfig(string certificatePath, string certificatePass, string merchantPOSID, string merchantIP, string asyncServiceEndpoint)
        {
            _certificatePath = certificatePath;
            _certificatePass = certificatePass;
            _merchantPOSID = merchantPOSID;
            _merchantIP = merchantIP;
            _asyncServiceEndpoint = asyncServiceEndpoint;
        }
    }
}
