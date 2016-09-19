using HairCare.Web.Models;
using LIB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HairCare.Web.App_Manager
{
    public class SessionManager
    {
        #region Structure
        private System.Web.SessionState.HttpSessionState S;
        private Serialize _serializer;

        private SessionManager() { this.S = HttpContext.Current.Session; }

        public static SessionManager GetInstance()
        {
            return new SessionManager();
        }

        private void SET(SessionType SessionName, object Value) { S[SessionName.ToString()] = Value; }
        private object GET(SessionType SessionName) { return S[SessionName.ToString()]; }
        #endregion

        public enum SessionType
        {
            IsFbLogin,
            UserData,
            FbAccessToken
        }

        public UserModel User
        {
            get { return (UserModel)(GET(SessionType.UserData)); }
            set { SET(SessionType.UserData, value); }
        }

        public string FbAccessToken
        {
            get { return (GET(SessionType.FbAccessToken).ToString()); }
            set { SET(SessionType.FbAccessToken, value); }
        }


        public bool IsFbLogin { get { return User != null; } }


        public void Destroy()
        {
            S.Clear();
            S.Abandon();
        }
        

    }
}