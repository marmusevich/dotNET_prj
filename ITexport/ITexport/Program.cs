using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ITexport
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {


            if(args.Length == 0)
                //return;
                ITexport.dbConnect.conStringFromIT = "DRIVER={SQLServer};SERVER={192.168.10.8};UID={sa};PWD={291263};DATABASE={IOT};Network={DBMSSOCN};APP={IT.%DATABASE%};WSID={%WSID%}";
            else
                foreach (string str in args)
                    ITexport.dbConnect.conStringFromIT += str;

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}

