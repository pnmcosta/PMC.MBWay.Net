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
using PMC.MBWay.Net.API.FinancialOperations;
using PMC.MBWay.Net.API.MerchantAlias;
using System.ServiceModel;
using System.Security.Cryptography.X509Certificates;
using System.Collections;
using System.ServiceModel.Channels;

namespace PMC.MBWay.Net
{
    public class MBWayClient
    {
        private ChannelFactory<MerchantAliasWSCreate> _createMerchantAliasFactory;
        private ChannelFactory<MerchantAliasWSRemove> _removeMerchantAliasFactory;
        private ChannelFactory<MerchantFinancialOperationWS> _financialOperationFactory;

        private MBWayConfig _config;
        private bool _sandbox;

        private Dictionary<bool, string> _endPoints = new Dictionary<bool, string>
        {
            { false, "https://mbway.pt/" }, // production
            { true, "https://qly.mbway.pt/" } // sandbox
        };

        private Dictionary<Type, string> _aliasLocations = new Dictionary<Type, string>
        {
            { typeof(MerchantAliasWSCreate), "Merchant/createMerchantAliasWS" },
            { typeof(MerchantAliasWSRemove), "Merchant/removeMerchantAliasWS" },
            { typeof(MerchantFinancialOperationWS), "Merchant/requestFinancialOperationWS" }
        };

        X509Certificate2 _certificate;

        public MBWayClient(MBWayConfig config)
            : this(config, false)
        {

        }
        public MBWayClient(MBWayConfig config, bool sandbox)
        {
            _config = config;
            _sandbox = sandbox;
            _certificate = new X509Certificate2(_config.CertificatePath, _config.CertificatePass,
                                                        X509KeyStorageFlags.Exportable | X509KeyStorageFlags.MachineKeySet |
                                                        X509KeyStorageFlags.PersistKeySet);

            InitFactory(ref _financialOperationFactory);
            InitFactory(ref _removeMerchantAliasFactory);
            InitFactory(ref _createMerchantAliasFactory);
        }


        public requestFinancialOperationResult RequestFinancialOperation(requestFinancialOperationRequest request)
        {
            IClientChannel channel = (IClientChannel)_financialOperationFactory.CreateChannel();

            bool success = false;
            requestFinancialOperationResult result = null;
            try
            {
                requestFinancialOperationResponse response = null;
                using (OperationContextScope scope = new OperationContextScope(channel))
                {
                    OperationContext.Current.OutgoingMessageHeaders.ReplyTo = new EndpointAddress(_config.AsyncServiceEndpoint);
                    response = ((MerchantFinancialOperationWS)channel).requestFinancialOperation(new requestFinancialOperationRequest1(request));
                    channel.Close();
                }

                result = response.@return;

                success = true;
            }
            finally
            {
                if (!success)
                    channel.Abort();
            }
            return result;
        }
        public createMerchantAliasResult CreateMerchantAlias(createMerchantAliasRequest request)
        {
            IClientChannel channel = (IClientChannel)_createMerchantAliasFactory.CreateChannel();

            bool success = false;
            createMerchantAliasResult result = null;
            try
            {
                createMerchantAliasResponse response = null;
                using (OperationContextScope scope = new OperationContextScope(channel))
                {
                    OperationContext.Current.OutgoingMessageHeaders.ReplyTo = new EndpointAddress(_config.AsyncServiceEndpoint);
                    response = ((MerchantAliasWSCreate)channel).createMerchantAlias(new createMerchantAliasRequest1(request));
                    channel.Close();
                }

                result = response.@return;

                success = true;
            }
            finally
            {
                if (!success)
                    channel.Abort();
            }
            return result;
        }
        public removeMerchantAliasResult RemoveMerchantAlias(removeMerchantAliasRequest request)
        {
            IClientChannel channel = (IClientChannel)_createMerchantAliasFactory.CreateChannel();

            bool success = false;
            removeMerchantAliasResult result = null;
            try
            {
                removeMerchantAliasResponse response = ((MerchantAliasWSRemove)channel).removeMerchantAlias(new removeMerchantAliasRequest1(request));
                channel.Close();

                result = response.@return;

                success = true;
            }
            finally
            {
                if (!success)
                    channel.Abort();
            }
            return result;
        }
        private void InitFactory<TChannel>(ref ChannelFactory<TChannel> channelFactory)
        {
            channelFactory = new ChannelFactory<TChannel>(this.GetBinding<TChannel>(), this.GetEndpoint<TChannel>());
            channelFactory.Credentials.ClientCertificate.Certificate = _certificate;
        }
        private string GetEndpoint<TChannelType>()
        {
            return _endPoints[_sandbox] + _aliasLocations[typeof(TChannelType)];
        }
        private Binding GetBinding<TChannelType>()
        {
            Binding binding = null;

            var cb = new CustomBinding();
            cb.Elements.Add(new TextMessageEncodingBindingElement() { MessageVersion = MessageVersion.Soap11WSAddressing10 });
            cb.Elements.Add(new HttpsTransportBindingElement() { RequireClientCertificate = true });
            binding = cb;

            //if (typeof(TChannelType) is MerchantFinancialOperationWS)
            //{

            //}
            //else
            //{
            //    binding = new BasicHttpBinding()
            //    {
            //        Security = new BasicHttpSecurity
            //        {
            //            Mode = BasicHttpSecurityMode.Transport,
            //            Transport = new HttpTransportSecurity
            //            {
            //                ClientCredentialType = HttpClientCredentialType.Certificate
            //            }
            //        }
            //    };
            //}
            return binding;
        }


        public static string GetUniqID()
        {
            var ts = (DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0));
            double t = ts.TotalMilliseconds / 1000;

            int a = (int)Math.Floor(t);
            int b = (int)((t - Math.Floor(t)) * 1000000);

            return a.ToString("x8") + b.ToString("x5");
        }
    }
}
