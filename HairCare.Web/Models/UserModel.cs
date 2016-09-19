using FbManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using HairCare.Web.App_Manager;
using HairCare.DB;
using HairCare.Service;

namespace HairCare.Web.Models
{
    public class UserModel
    {
        public DB.User Data { get; set; }

        public List<UserFbFriendModel> Friends { get; set; }

        public List<UserFbAlbumModel> UserAlbums { get; set; }

        public string Ip { get; set; }
    }
        
    #region StructureCoding

    public class UserDataManager
    {


        public UserModel Handler(string JsonFbData)
        {
            UserModel uModel = new UserModel();

            srvUser _userService;
            FacebookUser FbData;

            _userService = new srvUser();

            FbData = LIB.JsonHelper.ToObject<FacebookUser>(JsonFbData);

            uModel.Data = _userService.FbDataSave(FbData);

            if (ConfigManager.GetInstance().Facebook_IncludeFriends)
                uModel.Friends = FbFriendTransfer(FbData.Friends);

            uModel.Ip = LIB.ServerVars.Ip();

            return uModel;
        }

        private List<UserFbAlbumModel>  FbAlbumTransfer(IList<FacebookUserAlbum> FbAlbums)
        {
            List<UserFbAlbumModel> uFbAlbumList = new List<UserFbAlbumModel>();
            UserFbAlbumModel uFbAlbum;
            foreach (var item in FbAlbums)
            {
                uFbAlbum = new UserFbAlbumModel();
                uFbAlbum.CanUpload = item.CanUpload;
                uFbAlbum.Count = item.Count;
                uFbAlbum.CoverPhoto = item.CoverPhoto;
                uFbAlbum.CreatedTime = item.CreatedTime;
                uFbAlbum.Id = item.Id;
                uFbAlbum.Link = item.Link;
                uFbAlbum.Name = item.Name;
                uFbAlbum.Privacy = item.Privacy;
                uFbAlbum.Type = item.Type;
                uFbAlbum.UpdatedTime = item.UpdatedTime;

                uFbAlbumList.Add(uFbAlbum);
            }
            return uFbAlbumList;

        }

        private List<UserFbFriendModel> FbFriendTransfer(IList<FacebookUserFriend> Friends)
        {
            List<UserFbFriendModel> friendList = new List<UserFbFriendModel>();
            UserFbFriendModel friend;
            foreach (var item in Friends)
            {
                friend = new UserFbFriendModel();
                friend.Birthday = item.Birthday;
                friend.FbId = item.FbId;
                friend.FirstName = item.FirstName;
                friend.LastName = item.LastName;
                friend.Link = item.Link;
                friend.location = item.location;
                friend.Name = item.Name;
                friend.PictureUrl = item.PictureUrl;
                friendList.Add(friend);
            }
            return friendList;

        }

    }
    #endregion
}