using FbManager.Models;
using HairCare.DB;
using HairCare.Web.App_Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HairCare.Web.Models
{
    public class UserFbFriendModel : FacebookUserFriend
    {
        public static FbNominee FillNomineeModel(UserFbFriendModel friend)
        {
            SessionManager session = SessionManager.GetInstance();
            FbNominee n = new FbNominee();
            n.Birthday = friend.Birthday;
            n.Email = "";
            n.FbId = friend.FbId;
            n.FirstName = friend.FirstName;
            n.Gender = "";
            n.LastName = friend.LastName;
            n.Link = friend.Link;
            n.Locale = friend.location == null ? "" : friend.location.name;
            n.PictureUrl = friend.PictureUrl;
            n.UserId = session.User.Data.Id;
            n.Name = friend.Name;
            n.UserName = "";
            return n;
        }
    }
}