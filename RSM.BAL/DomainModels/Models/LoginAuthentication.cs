using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace RsecBOL.LoginAuthentication
{

    [DataContract]
    public class LoginResponse
    {
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string ErrorMsg { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string Token { get; set; }
        [DataMember]
        public string AccId { get; set; }
        [DataMember]
        public string Broker { get; set; }
        [DataMember]
        public string BrokerBranchId { get; set; }
    }

    [DataContract]
    public class LoginImages
    {
        [DataMember]
        public string Img1 { get; set; }
        [DataMember]
        public string ImgIndex1 { get; set; }
        [DataMember]
        public string Img2 { get; set; }
        [DataMember]
        public string ImgIndex2 { get; set; }
        [DataMember]
        public string Img3 { get; set; }
        [DataMember]
        public string ImgIndex3 { get; set; }
        [DataMember]
        public string Img4 { get; set; }
        [DataMember]
        public string ImgIndex4 { get; set; }
        [DataMember]
        public string Img5 { get; set; }
        [DataMember]
        public string ImgIndex5 { get; set; }
        [DataMember]
        public string LoginStatus { get; set; }
        [DataMember]
        public string IsSuspended { get; set; }
        [DataMember]
        public string ErrorMsg { get; set; }

        [DataMember]
        public string tomcat { get; set; } // Added by Poonam 20201128 For New tick web added TomcatCount

    }

    [DataContract]
    public class UserQuestions
    {
        [DataMember]
        public string Question1 { get; set; }
        [DataMember]
        public string QuestionIndex1 { get; set; }
        [DataMember]
        public string Question2 { get; set; }
        [DataMember]
        public string QuestionIndex2 { get; set; }
        [DataMember]
        public string Question3 { get; set; }
        [DataMember]
        public string QuestionIndex3 { get; set; }
        [DataMember]
        public string Question4 { get; set; }
        [DataMember]
        public string QuestionIndex4 { get; set; }
        [DataMember]
        public string Question5 { get; set; }
        [DataMember]
        public string QuestionIndex5 { get; set; }
        [DataMember]
        public string Question6 { get; set; }
        [DataMember]
        public string QuestionIndex6 { get; set; }
        [DataMember]
        public string Question7 { get; set; }
        [DataMember]
        public string QuestionIndex7 { get; set; }
        [DataMember]
        public string Question8 { get; set; }
        [DataMember]
        public string QuestionIndex8 { get; set; }
        [DataMember]
        public string Question9 { get; set; }
        [DataMember]
        public string QuestionIndex9 { get; set; }
        [DataMember]
        public string Question10 { get; set; }
        [DataMember]
        public string QuestionIndex10 { get; set; }
        [DataMember]
        public string Question11 { get; set; }
        [DataMember]
        public string QuestionIndex11 { get; set; }
        [DataMember]
        public string Question12 { get; set; }
        [DataMember]
        public string QuestionIndex12 { get; set; }
        [DataMember]
        public string Question13 { get; set; }
        [DataMember]
        public string QuestionIndex13 { get; set; }
        [DataMember]
        public string Question14 { get; set; }
        [DataMember]
        public string QuestionIndex14 { get; set; }
        [DataMember]
        public string Question15 { get; set; }
        [DataMember]
        public string QuestionIndex15 { get; set; }
        [DataMember]
        public string Question16 { get; set; }
        [DataMember]
        public string QuestionIndex16 { get; set; }
        [DataMember]
        public string Question17 { get; set; }
        [DataMember]
        public string QuestionIndex17 { get; set; }
        [DataMember]
        public string Question18 { get; set; }
        [DataMember]
        public string QuestionIndex18 { get; set; }
        [DataMember]
        public string Question19 { get; set; }
        [DataMember]
        public string QuestionIndex19 { get; set; }
        [DataMember]
        public string Question20 { get; set; }
        [DataMember]
        public string QuestionIndex20 { get; set; }
        [DataMember]
        public string UserId { get; set; }
        [DataMember]
        public string Token { get; set; }
        [DataMember]
        public string AccId { get; set; }
        [DataMember]
        public string UserName { get; set; }
        [DataMember]
        public string LoginTime { get; set; }
        [DataMember]
        public string ClientType { get; set; }
        [DataMember]
        public string Broker { get; set; }
        [DataMember]
        public string BrokerBranchId { get; set; }
        [DataMember]
        public string LoginType { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string ErrorMsg { get; set; }

        [DataMember]
        public string IsPasswordReset { get; set; }
        [DataMember]
        public string UserSessionId { get; set; }

        [DataMember]
        public string UserSessionKey { get; set; }

        [DataMember]
        public string[] Segment { get; set; }

    }

    [DataContract]
    public class FirstTimeLogin
    {
        [DataMember]
        public string uid { get; set; }
        [DataMember]
        public string accid { get; set; }
        [DataMember]
        public string token { get; set; }
        [DataMember]
        public string broker { get; set; }
        [DataMember]
        public string brokerbranchid { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public string ErrorMsg { get; set; }
    }

    [DataContract]
    public class SecurityQuetions
    {
        [DataMember]
        public string QuestId = "";
        [DataMember]
        public string QuestAns = "";
    }

}
