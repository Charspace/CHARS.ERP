using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace CHARS.ERP.WHM.WCF.Cri
{
    public class LoginUser
    {
        public LoginUser()
        {
            setDefaultValue();
        }

        #region "private member"
        private string mAsk;
        private string mUserImage;
        private string mUserID;
        private string mUserDes;
        private string mUserPhone;
        private string mUserEmail;
        #endregion
        #region "public member"
        [DataMember(Order = 1)]
        public string Ask
        {
            get { return mAsk; }
            set { mAsk = value; }
        }
        [DataMember(Order = 2)]
        public string UserImage
        {
            get { return mUserImage; }
            set { mUserImage = value; }
        }
        [DataMember(Order = 3)]
        public string UserID
        {
            get { return mUserID; }
            set { mUserID = value; }
        }
        [DataMember(Order = 4)]
        public string UserDes
        {
            get { return mUserDes; }
            set { mUserDes = value; }
        }
        [DataMember(Order = 5)]
        public string UserPhone
        {
            get { return mUserPhone; }
            set { mUserPhone = value; }
        }
        [DataMember(Order = 6)]
        public string UserEmail
        {
            get { return mUserEmail; }
            set { mUserEmail = value; }
        }

        #endregion
        #region"Default Property"
        public void setDefaultValue()
        {
            mAsk = "0";
            mUserID = "";
            mUserDes = "";
            mUserImage = "";
            mUserPhone = "";
            mUserEmail = "";
        }
        #endregion

    }
}
