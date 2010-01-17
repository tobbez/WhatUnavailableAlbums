using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace WhatUnavailableAlbums
{
    static class WhatHelper
    {
        static CookieContainer mCookies;

        public static void Login(string username, string password)
        {
            mCookies = new CookieContainer();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("https://ssl.what.cd/login.php");
            request.CookieContainer = mCookies;
            request.UserAgent = "WhatUnavailableAlbums";

            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";

            string postData = "username=" + System.Web.HttpUtility.UrlEncode(username)
                + "&password=" + System.Web.HttpUtility.UrlEncode(password)
                + "&keeplogged=0";
            request.ContentLength = postData.Length;
            StreamWriter sw = new StreamWriter(request.GetRequestStream());
            sw.Write(postData);
            sw.Close();
            

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader sr = new StreamReader(response.GetResponseStream());

            if (sr.ReadToEnd().Contains("id=\"loginform\""))
            {
                throw new Exception("WhatHelper: Login failed");
            }
        }

        public static bool AlbumIsAvailable(Album album)
        {
            string page = "torrents.php?searchstr=" + System.Web.HttpUtility.UrlEncode(album.ArtistName + " " + album.AlbumName);
            string result = FetchPage(page);

            // This check is kind of ugly, but it works
            return result.Contains("group_torrent");
        }

        public static string FetchPage(string page)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://ssl.what.cd/" + page);
            request.UserAgent = "WhatUnavailableAlbums";
            request.CookieContainer = mCookies;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            return new StreamReader(response.GetResponseStream()).ReadToEnd();
        }
    }
}
