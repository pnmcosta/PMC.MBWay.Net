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
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using PMC.MBWay.Net.API.FinancialOperations;
using PMC.MBWay.Net.API.MerchantAlias;

namespace PMC.MBWay.Net.TestSite
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MBWayAsyncService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MBWayAsyncService.svc or MBWayAsyncService.svc.cs at the Solution Explorer and start debugging.
    public class MBWayAsyncService : MBWayAsyncServiceBase
    {
        public override void ProcessCreateAliasResult(createMerchantAliasResult result)
        {
            throw new NotImplementedException();
        }

        public override void ProcessFinancialOperationResult(requestFinancialOperationResult result)
        {
            throw new NotImplementedException();
        }
    }
}
