# PMC.MBWay.Net
.NET implementation of the MBWay API by [PMC-Digital](http://pmc.digital)

## Installation
Build the solution in Release mode and reference the main PMC.MBWay.Net.dll in your ASP.net project.

Or download the DLL from the [latest release](https://github.com/pnmcosta/PMC.MBWay.Net/releases) package and include in your .NET package

## Configuring the Async service
Create a WCF service (.svc) in your ASP.net project, that inherits from the base class [PMC.MBWay.Net.MBWayAsyncServiceBase](https://github.com/pnmcosta/PMC.MBWay.Net/blob/master/PMC.MBWay.Net/MBWayAsyncServiceBase.cs) and implement the methods ProcessCreateAliasResult and ProcessFinancialOperationResult so you can handle the MBWAY responses with your custom code, like in [this example](https://github.com/pnmcosta/PMC.MBWay.Net/blob/master/PMC.MBWay.Net.TestSite/MBWayAsyncService.svc.cs) where a log file is created with the serialized result.

Configure the service's bindings and settings as per the TestSite web.config that can be found [here](https://github.com/pnmcosta/PMC.MBWay.Net/blob/master/PMC.MBWay.Net.TestSite/Web.config).

## Using the API's Client
Ensure you have the certificate and your MBWay developer/merchant account configured and use the MBWayClient class supplied as such:
```
    using PMC.MBWay.Net;
    
    // Create client with prefered certificate method
    MBWayClient client = new MBWayClient(new MBWayConfig
    {
        // certificate's SHA1 thumbprint from the Local Computer\Personal\Certificates store
        CertificateThumbprint = "f4eaa0362ccec7a03f76786052037483c50fde36",

        // or use a password protected pfx file
        //CertificatePass = "Your!CertificatePassword123!",
        //CertificatePath = "c:\\path\\to\\cerficiate.pfx",

        MerchantIP = "Your.Ip.Address",
        MerchantPOSID = "YourPOSId",
        AsyncServiceEndpoint = "https://path/to/asyncservice.svc"
    });

    var request = new requestFinancialOperationRequest
    {
        alias = new alias
        {
            aliasName = "351#911231231",
            aliasTypeCde = AliasTypes.CELLPHONE
        },

        merchant = new merchant
        {
            iPAddress = client.CurrentConfig.MerchantIP,
            posId = client.CurrentConfig.MerchantPOSID
        },

        messageProperties = new messageProperties
        {
            apiVersion = "1",
            channel = MessageChannelTypes.WEB,
            channelTypeCode = "VPOS",
            networkCode = "MULTIB",
            serviceType = "01",
        },

        aditionalData = "TEST CLIENT",

        financialOperation = new financialOperation
        {
            amount = 70, //0.70€
            currencyCode = CurrencyCodes.EURO_TWO_DECIMALS,
            merchantOprId = MBWayClient.GetUniqID(),
            operationTypeCode = FinancialOperationTypes.PURCHASE
        }
    };

    var result = client.RequestFinancialOperation(request);
```
You have full examples of financial operation in the unit tests supplied [here](https://github.com/pnmcosta/PMC.MBWay.Net/blob/master/PMC.MBWay.Net.UnitTests/FinancialOperationsTests.cs).

## License
For the full copyright and license information, please view the LICENSE file that was distributed with this source code.
