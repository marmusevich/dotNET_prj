using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITexport
{
    static class dbConnect
    {
        //признаки в договорах
        //KDO2 = 'К' - казначейство
        //KDO3 = 'Т' - тендерный


        //типы процессов поле KDMT
        //    U02   - приходы
        //    1УПУ  - акты


        //---------------------------------------------------------------------------------------------------------------------------------------------
        #region  consts and values
        //---------------------------------------------------------------------------------------------------------------------------------------------
        //
        public static string conStringFromIT = null;
        //
        public static string connectionString = null;


        ////
        //public static const string queriStr_doc = "";
        ////
        //public static const string queriStr_contracts = "";
        ////
        //public static const string queriStr_1 = "";
        ////
        //public static const string queriStr_2 = "";

        #endregion



        ////tbConn.Text = ITexport.dbConnect.conStringIT;

        //string connetionString = null;
        //;

        //// to do: вырезать параметры из строки
        ////connetionString = "DRIVER={SQLServer};SERVER={192.168.10.8};UID={sa};PWD={291263};DATABASE={IOT};Network={DBMSSOCN};APP={IT.%DATABASE%};WSID={%WSID%}";
        ////connetionString="Data Source=IP_ADDRESS,PORT;Network Library=DBMSSOCN;Initial Catalog=DatabaseName;User ID=UserName;Password=Password"
        //connetionString = "Data Source=192.168.10.8;Network Library=DBMSSOCN;Initial Catalog=iot;User ID=sa;Password=291263";

        //try
        //{
        //    using (SqlConnection cnn = new SqlConnection(connetionString))
        //    {
        //        cnn.Open();

        //        //cnn.CreateCommand();

        //        MessageBox.Show("Connection Open ! ");

        //        cnn.Close();
        //    }
        //}
        //catch (Exception ex)
        //{
        //    MessageBox.Show("Can not open connection ! ");
        //}




        //---------------------------------------------------------------------------------------------------------------------------------------------
        #region  --2
        //---------------------------------------------------------------------------------------------------------------------------------------------

        #endregion

        //---------------------------------------------------------------------------------------------------------------------------------------------
        #region  --3
        //---------------------------------------------------------------------------------------------------------------------------------------------

        #endregion

        //---------------------------------------------------------------------------------------------------------------------------------------------
        #region  --4
        //---------------------------------------------------------------------------------------------------------------------------------------------

        #endregion



    }
}
