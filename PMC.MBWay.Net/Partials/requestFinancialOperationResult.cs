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

namespace PMC.MBWay.Net.API.FinancialOperations
{
    public partial class requestFinancialOperationResult
    {
        public bool IsValid
        {
            get
            {
                return this.statusCode == ReturnStatusCodes.SUCCESS || this.statusCode == ReturnStatusCodes.REJECTED_FINANCIAL_OPERATION;
            }
        }
    }
}
