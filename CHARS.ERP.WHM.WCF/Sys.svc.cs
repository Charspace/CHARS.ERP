using CHARS.ERP.WHM.WCF.Cri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;

namespace CHARS.ERP.WHM.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Sys" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Sys.svc or Sys.svc.cs at the Solution Explorer and start debugging.
    public class Sys : ISys
    {
        public UserInfo getUserInfo()
        {
            return new UserInfo();
        }
        public void DoWork()
        {
            //// Add behavior for Services - enable WSDL access
            //ServiceMetadataBehavior serviceABehavior = new ServiceMetadataBehavior();
            //serviceABehavior.HttpGetEnabled = true;
            //serviceABehavior.HttpGetUrl = new Uri("http://localhost:8080/ServiceA");
            //serviceAHost.Description.Behaviors.Add(serviceABehavior);

            //ServiceMetadataBehavior serviceBBehavior = new ServiceMetadataBehavior();
            //serviceBBehavior.HttpGetEnabled = true;
            //serviceBBehavior.HttpGetUrl = new Uri("http://localhost:8080/ServiceB");
            //serviceBHost.Description.Behaviors.Add(serviceBBehavior);

            //// Create basicHttpBinding endpoint at http://localhost:8080/ServiceA/  
            //serviceAHost.AddServiceEndpoint(serviceAContractType, new BasicHttpBinding(),
            //"http://localhost:8080/ServiceA");
            //// Create basicHttpBinding endpoint at http://localhost:8080/ServiceB/  
            //serviceBHost.AddServiceEndpoint(serviceBContractType, new BasicHttpBinding(),
            //"http://localhost:8080/ServiceB");
        }
    }
}
