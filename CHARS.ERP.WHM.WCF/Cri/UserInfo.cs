using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CHARS.ERP.WHM.WCF.Cri
{
    public class UserInfo
    {
        public UserInfo()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mUser;
        private string mPWD;

        #endregion
        #region "public member"
        [DataMember]
        public string User
        {
            get { return mUser; }
            set { mUser = value; }
        }
        [DataMember]
        public string PWD
        {
            get { return mPWD; }
            set { mPWD = value; }
        }


        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mUser = "";
            mPWD = "";

        }
        #endregion
    }
}
