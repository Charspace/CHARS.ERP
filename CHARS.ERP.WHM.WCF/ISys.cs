using CHARS.ERP.WHM.WCF.Cri;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace CHARS.ERP.WHM.WCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ISys" in both code and config file together.
    [ServiceContract]
    public interface ISys
    {
        [OperationContract]
        void DoWork();
        [WebInvoke(Method = "GET",
              RequestFormat = WebMessageFormat.Json,
              ResponseFormat = WebMessageFormat.Json,
              BodyStyle = WebMessageBodyStyle.Bare,
               UriTemplate = "getUserInfo")]
        UserInfo getUserInfo();
    }
}
