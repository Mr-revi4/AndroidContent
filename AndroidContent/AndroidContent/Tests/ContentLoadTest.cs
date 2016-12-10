using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AllContent_Client;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System.IO;
using Android.Util;

namespace AndroidContent.Tests
{
    public class ContentLoadTest
    {
        static public User user;
        const string ContentLoadMark = "ContentLoad_Test_Logs";



        public List<ContentUnit> cu_list;
        public ContentLoadTest()
        {
            cu_list = new List<ContentUnit>();
            user = new User();
            Log.Info(ContentLoadMark, "Authoriz res: " + user.Authorization("TestLogin", "TestLogin").ToString());
            user.LoadFavoritSources();
            foreach (var fav in user.favoritSources)
                FavoritList.Favorits.Add(fav);
            FavoritList.Favorits.RefreshAll();
        }

    }
}