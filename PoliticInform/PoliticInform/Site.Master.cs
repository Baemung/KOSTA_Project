﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PoliticInform
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["Login"] = Login.isLogin;
        }

        public static string ConnStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\anvo9\KOSTA_Project\PoliticInform\miniProject2.mdf;Integrated Security=True;Connect Timeout=30";

        public static Bitmap WebImageView(string URL)
        {
            try
            {
                WebClient Downloader = new WebClient();
                Stream ImageStream = Downloader.OpenRead(URL);
                Bitmap DownloadImage = Bitmap.FromStream(ImageStream) as Bitmap;
                return DownloadImage;
            }
            catch (Exception)
            {
                return null;
            }
        }
    }    
}