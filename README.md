# PMC.MBWay.Net
.NET implementation of the MBWay API by [PMC-Digital](http://pmc.digital)

## Installation
Build the solution in Release mode and reference the main PMC.MBWay.Net.dll in your ASP.net project.

## Configuring the Async service
There is a base abstract class for the service that exposes a ProcessCreateAliasResult and ProcessFinancialOperationResult method that allows you to handle the requests from MBWay in your implementation's particular way.

Create a service file (.svc) in your ASP.net project, that inherits from the class MBWayAsyncServiceBase and implement the methods mentioned above.

Configure the service's bindings and settings as per the TestSite web.config that can be found [here](https://github.com/pnmcosta/PMC.MBWay.Net/blob/master/PMC.MBWay.Net.TestSite/Web.config).

## Using the API's Client
Ensure you have the certificate and your MBWay developer/merchant account configured and use the MBWayClient class supplied as such:
```
    MBWayClient client = new MBWayClient(new MBWayConfig
    {
        CertificatePass = "Your!CertificatePassword123!",
        CertificatePath = "c:\\path\\to\\cerficiate.pfx",
        MerchantIP = "Your.Ip.Address",
        MerchantPOSID = "YourPOSId",
        AsyncServiceEndpoint = "https://path/to/asyncservice.svc"
    });
```
You have full examples of operation types in the unit tests supplied [here](https://github.com/pnmcosta/PMC.MBWay.Net/tree/master/PMC.MBWay.Net.UnitTests).
## License
For the full copyright and license information, please view the LICENSE file that was distributed with this source code.
