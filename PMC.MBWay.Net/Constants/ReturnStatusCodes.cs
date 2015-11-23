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
    public partial class ReturnStatusCodes
    {
        public const string SUCCESS = "000";

        public const string REJECTED_CREATE_ALIAS = "010";
        public const string REJECTED_FINANCIAL_OPERATION = "020";

        public const string ERROR = "100";
        public const string ERROR_TIMEOUT = "101";
        public const string ERROR_VALIDATION = "102";
        public const string ERROR_INVALID_POS = "103";
        public const string ERROR_DENIED = "104";

        public const string ALIAS_TYPE_BLOCKED = "110";
        public const string ALIAS_INVALID = "111";
        public const string ALIAS_DUPLICATED = "112";
        public const string ALIAS_UNKNOWN = "113";

        public const string FINANCIAL_OPERATION_DUPLICATED = "120";
        public const string FINANCIAL_OPERATION_TYPE_NOTFOUND = "121";
        public const string FINANCIAL_OPERATION_DENIED = "122";
        public const string FINANCIAL_OPERATION_NOTFOUND = "123";
        public const string FINANCIAL_OPERATION_ALIAS_DENIED = "124";


    }
}
