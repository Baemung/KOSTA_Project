﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caffe_Manager
{
    static class Program
    {
        public static string db = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Baemung\Documents\KOSTA_Project\Caffe_Manager\Caffe_Manager.mdf;Integrated Security=True;Connect Timeout=30";

        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Select());
        }
    }
}
