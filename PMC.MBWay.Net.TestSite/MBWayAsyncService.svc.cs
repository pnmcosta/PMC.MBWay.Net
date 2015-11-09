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
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Web;

namespace PMC.MBWay.Net.TestSite
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "MBWayAsyncService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select MBWayAsyncService.svc or MBWayAsyncService.svc.cs at the Solution Explorer and start debugging.
    public class MBWayAsyncService : MBWayAsyncServiceBase
    {
        string logsPath = string.Empty;
        public MBWayAsyncService()
        {
            logsPath = HttpContext.Current.Server.MapPath("/logs/");

            if (!Directory.Exists(logsPath))
                Directory.CreateDirectory(logsPath);

        }
        public override void ProcessCreateAliasResult(createMerchantAliasResult result)
        {
            CreateLogFile(result, result.operationId);
        }

        public override void ProcessFinancialOperationResult(requestFinancialOperationResult result)
        {
            CreateLogFile(result, result.merchantOperationID);
        }

        private void CreateLogFile<T>(T result, string fileName)
        {
            var filePath = Path.Combine(logsPath, CleanFileName(fileName) + ".xml");
            if (File.Exists(filePath))
                filePath = Path.Combine(logsPath, CleanFileName(fileName) + "-" + DateTime.UtcNow.Ticks.ToString() + ".xml");

            XmlDocument xmlDocument = new XmlDocument();
            XmlSerializer serializer = new XmlSerializer(result.GetType());
            using (MemoryStream stream = new MemoryStream())
            {
                serializer.Serialize(stream, result);
                stream.Position = 0;
                xmlDocument.Load(stream);
                xmlDocument.Save(filePath);
                stream.Close();
            }
        }
        private static string CleanFileName(string fileName)
        {
            return Path.GetInvalidFileNameChars().Aggregate(fileName, (current, c) => current.Replace(c.ToString(), string.Empty));
        }
    }
}
