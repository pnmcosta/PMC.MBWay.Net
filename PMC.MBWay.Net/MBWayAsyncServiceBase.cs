/*
 * This file is part of the PMC.MBWay.Net package.
 *
 * (c) Pedro Costa <http://pmc.digital>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 */

using PMC.MBWay.Net.API.FinancialOperations;
using PMC.MBWay.Net.API.MerchantAlias;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Text;

namespace PMC.MBWay.Net
{
    [AspNetCompatibilityRequirements(
        RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public abstract class MBWayAsyncServiceBase : FinancialOperationAsyncResult, CreateMerchantAliasAsyncResult
    {
        public createAliasResultResponse createAliasResult(createAliasResultRequest request)
        {
            ProcessCreateAliasResult(request.arg0);

            return new createAliasResultResponse();
        }
        public abstract void ProcessCreateAliasResult(createMerchantAliasResult result);



        public financialOperationResultResponse financialOperationResult(financialOperationResultRequest request)
        {
            ProcessFinancialOperationResult(request.arg0);

            return new financialOperationResultResponse();
        }
        public abstract void ProcessFinancialOperationResult(requestFinancialOperationResult result);
    }

}
