/*
 * This file is part of the PMC.MBWay.Net package.
 *
 * (c) Pedro Costa <http://pmc.digital>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PMC.MBWay.Net.API.FinancialOperations;
using System.Threading;

namespace PMC.MBWay.Net.UnitTests
{
    [TestClass]
    public class FinancialOperationsTests : BaseIntegrationTests
    {
        protected requestFinancialOperationResult currentResult;

        [TestMethod]
        public void TestPurchase()
        {
            var request = GetRequest();

            var amount = 70; //0.70€
            var operationId = MBWayClient.GetUniqID();
            var currencyCode = CurrencyCodes.EURO_TWO_DECIMALS;

            request.financialOperation = new financialOperation
            {
                amount = amount,
                currencyCode = currencyCode,
                merchantOprId = operationId,
                operationTypeCode = FinancialOperationTypes.PURCHASE
            };

            var result = this.GetClient().RequestFinancialOperation(request);

            Assert.IsTrue(result.IsValid);
            Assert.AreEqual(amount, result.amount);
            Assert.AreEqual(operationId, result.merchantOperationID);
            Assert.AreEqual(currencyCode, result.currencyCode);
            Assert.IsTrue(!string.IsNullOrEmpty(result.token));
            Assert.IsNotNull(result.timestamp);

            currentResult = result;
        }

        [TestMethod]
        public void TestPurchaseAuthorization()
        {
            var request = GetRequest();

            var amount = 70; //0.70€
            var operationId = MBWayClient.GetUniqID();
            var currencyCode = CurrencyCodes.EURO_TWO_DECIMALS;

            request.financialOperation = new financialOperation
            {
                amount = amount,
                currencyCode = currencyCode,
                merchantOprId = operationId,
                operationTypeCode = FinancialOperationTypes.PURCHASE_AUTHORIZATION
            };

            var result = this.GetClient().RequestFinancialOperation(request);

            Assert.IsTrue(result.IsValid);
            Assert.AreEqual(amount, result.amount);
            Assert.AreEqual(operationId, result.merchantOperationID);
            Assert.AreEqual(currencyCode, result.currencyCode);
            Assert.IsTrue(!string.IsNullOrEmpty(result.token));
            Assert.IsNotNull(result.timestamp);

            currentResult = result;
        }
        [TestMethod]
        public void TestPurchaseAuthorizationAnnulment()
        {
            TestPurchaseAuthorization();

            Assert.IsNotNull(currentResult);
            Assert.IsTrue(currentResult.IsValid);

            var request = GetRequest();
            request.referencedFinancialOperation = new financialOperation
            {
                amount = currentResult.amount,
                currencyCode = currentResult.currencyCode,
                merchantOprId = currentResult.merchantOperationID,
                operationTypeCode = FinancialOperationTypes.PURCHASE_AUTHORIZATION
            };


            var newOperationId = MBWayClient.GetUniqID();
            request.financialOperation = new financialOperation
            {
                amount = currentResult.amount,
                currencyCode = currentResult.currencyCode,
                merchantOprId = newOperationId,
                operationTypeCode = FinancialOperationTypes.ANNULMENT
            };

            var result = this.GetClient().RequestFinancialOperation(request);

            Assert.IsTrue(result.IsValid);
            Assert.AreEqual(currentResult.amount, result.amount);
            Assert.AreEqual(newOperationId, result.merchantOperationID);
            Assert.AreEqual(currentResult.currencyCode, result.currencyCode);
            Assert.IsNotNull(result.timestamp);
        }

        [TestMethod]
        public void TestPurchaseAuthorizationCancellation()
        {
            TestPurchaseAuthorization();

            ApprovalSleep(); // allow for aproval in app and async callback

            Assert.IsNotNull(currentResult);
            Assert.IsTrue(currentResult.IsValid);

            var request = GetRequest();
            request.referencedFinancialOperation = new financialOperation
            {
                amount = currentResult.amount,
                currencyCode = currentResult.currencyCode,
                merchantOprId = currentResult.merchantOperationID,
                operationTypeCode = FinancialOperationTypes.PURCHASE_AUTHORIZATION
            };


            var newOperationId = MBWayClient.GetUniqID();
            request.financialOperation = new financialOperation
            {
                amount = currentResult.amount,
                currencyCode = currentResult.currencyCode,
                merchantOprId = newOperationId,
                operationTypeCode = FinancialOperationTypes.AUTHORIZATION_CANCEL
            };

            var result = this.GetClient().RequestFinancialOperation(request);

            Assert.IsTrue(result.IsValid);
            Assert.AreEqual(currentResult.amount, result.amount);
            Assert.AreEqual(newOperationId, result.merchantOperationID);
            Assert.AreEqual(currentResult.currencyCode, result.currencyCode);
            Assert.IsNotNull(result.timestamp);
        }


        [TestMethod]
        public void TestPurchaseAfterAuthorization()
        {
            TestPurchaseAuthorization();

            Assert.IsNotNull(currentResult);
            Assert.IsTrue(currentResult.IsValid);

            ApprovalSleep(); // allow for aproval in app and async callback

            var request = GetRequest();
            request.referencedFinancialOperation = new financialOperation
            {
                amount = currentResult.amount,
                currencyCode = currentResult.currencyCode,
                merchantOprId = currentResult.merchantOperationID,
                operationTypeCode = FinancialOperationTypes.PURCHASE_AUTHORIZATION
            };


            var newOperationId = MBWayClient.GetUniqID();
            request.financialOperation = new financialOperation
            {
                amount = currentResult.amount,
                currencyCode = currentResult.currencyCode,
                merchantOprId = newOperationId,
                operationTypeCode = FinancialOperationTypes.PURCHASE_AFTER_AUTHORIZATION
            };

            var result = this.GetClient().RequestFinancialOperation(request);

            Assert.IsTrue(result.IsValid);
            Assert.AreEqual(currentResult.amount, result.amount);
            Assert.AreEqual(newOperationId, result.merchantOperationID);
            Assert.AreEqual(currentResult.currencyCode, result.currencyCode);
            Assert.IsNotNull(result.timestamp);

            currentResult = result;
        }

        [TestMethod]
        public void TestPurchaseAnnulment()
        {
            TestPurchase();

            Assert.IsNotNull(currentResult);
            Assert.IsTrue(currentResult.IsValid);

            var request = GetRequest();
            request.referencedFinancialOperation = new financialOperation
            {
                amount = currentResult.amount,
                currencyCode = currentResult.currencyCode,
                merchantOprId = currentResult.merchantOperationID,
                operationTypeCode = FinancialOperationTypes.PURCHASE
            };


            var newOperationId = MBWayClient.GetUniqID();
            request.financialOperation = new financialOperation
            {
                amount = currentResult.amount,
                currencyCode = currentResult.currencyCode,
                merchantOprId = newOperationId,
                operationTypeCode = FinancialOperationTypes.ANNULMENT
            };

            var result = this.GetClient().RequestFinancialOperation(request);

            Assert.IsTrue(result.IsValid);
            Assert.AreEqual(currentResult.amount, result.amount);
            Assert.AreEqual(newOperationId, result.merchantOperationID);
            Assert.AreEqual(currentResult.currencyCode, result.currencyCode);
            Assert.IsNotNull(result.timestamp);
        }

        [TestMethod]
        public void TestPurchaseReturn()
        {
            TestPurchase();

            Assert.IsNotNull(currentResult);
            Assert.IsTrue(currentResult.IsValid);

            ApprovalSleep(); // allow for aproval in app and async callback

            var request = GetRequest();
            request.referencedFinancialOperation = new financialOperation
            {
                amount = currentResult.amount,
                currencyCode = currentResult.currencyCode,
                merchantOprId = currentResult.merchantOperationID,
                operationTypeCode = FinancialOperationTypes.PURCHASE
            };


            var newOperationId = MBWayClient.GetUniqID();
            request.financialOperation = new financialOperation
            {
                amount = currentResult.amount,
                currencyCode = currentResult.currencyCode,
                merchantOprId = newOperationId,
                operationTypeCode = FinancialOperationTypes.PURCHASE_RETURN
            };


            var result = this.GetClient().RequestFinancialOperation(request);

            Assert.IsTrue(result.IsValid);
            Assert.AreEqual(currentResult.amount, result.amount);
            Assert.AreEqual(newOperationId, result.merchantOperationID);
            Assert.AreEqual(currentResult.currencyCode, result.currencyCode);
            Assert.IsNotNull(result.timestamp);
        }

        [TestMethod]
        public void TestPurchaseAfterAuthorizationReturn()
        {
            TestPurchaseAfterAuthorization();

            Assert.IsNotNull(currentResult);
            Assert.IsTrue(currentResult.IsValid);

            var request = GetRequest();
            request.referencedFinancialOperation = new financialOperation
            {
                amount = currentResult.amount,
                currencyCode = currentResult.currencyCode,
                merchantOprId = currentResult.merchantOperationID,
                operationTypeCode = FinancialOperationTypes.PURCHASE_AFTER_AUTHORIZATION
            };


            var newOperationId = MBWayClient.GetUniqID();
            request.financialOperation = new financialOperation
            {
                amount = currentResult.amount,
                currencyCode = currentResult.currencyCode,
                merchantOprId = newOperationId,
                operationTypeCode = FinancialOperationTypes.PURCHASE_RETURN
            };


            var result = this.GetClient().RequestFinancialOperation(request);

            Assert.IsTrue(result.IsValid);
            Assert.AreEqual(currentResult.amount, result.amount);
            Assert.AreEqual(newOperationId, result.merchantOperationID);
            Assert.AreEqual(currentResult.currencyCode, result.currencyCode);
            Assert.IsNotNull(result.timestamp);
        }
        public requestFinancialOperationRequest GetRequest()
        {
            return new requestFinancialOperationRequest
            {
                alias = new alias
                {
                    aliasName = this.TestAlias,
                    aliasTypeCde = AliasTypes.CELLPHONE
                },

                merchant = new merchant
                {
                    iPAddress = this.GetConfig().MerchantIP,
                    posId = this.GetConfig().MerchantPOSID
                },

                messageProperties = new messageProperties
                {
                    apiVersion = "1",
                    channel = MessageChannelTypes.WEB,
                    channelTypeCode = "VPOS",
                    networkCode = "MULTIB",
                    serviceType = "01",
                },

                aditionalData = this.TestContext.TestName
            };
        }
    }
}
