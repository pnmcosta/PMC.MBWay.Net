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
    public static class FinancialOperationTypes
    {
        public const string PURCHASE = "022";
        public const string PURCHASE_RETURN = "023";
        public const string PURCHASE_AUTHORIZATION = "024";
        public const string PURCHASE_AFTER_AUTHORIZATION = "025";
        public const string AUTHORIZATION_CANCEL = "026";
        public const string ANNULMENT = "048";
    }
}
