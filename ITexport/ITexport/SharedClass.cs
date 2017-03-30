using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITexport
{
    static class SharedClass
    {
        //---------------------------------------------------------------------------------------------------------------------------------------------
        #region  -
        //---------------------------------------------------------------------------------------------------------------------------------------------
        //получить дату первого дня месяца
        public static DateTime GetFirstMonthDayDate(DateTime date)
        {
            return new DateTime(date.Year, date.Month, 1);
        }
        //получить дату последнего дня месяца
        public static DateTime GetLastMonthDayDate(DateTime date)
        {
            return new DateTime(date.Year, date.Month, DateTime.DaysInMonth(date.Year, date.Month));
        }

        #endregion

        //---------------------------------------------------------------------------------------------------------------------------------------------
        #region  --
        //---------------------------------------------------------------------------------------------------------------------------------------------

        #endregion




    }
}
