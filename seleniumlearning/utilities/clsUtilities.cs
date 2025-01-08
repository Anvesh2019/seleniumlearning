﻿
using IronXL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumlearning.utilities
{
    public class clsUtilities
    {
        public string GetColumnValuefromExcel()
        {

            return "Anand";
        }
        /// <summary>
        /// this method will read the excel file and copy its data into a datatable
        /// </summary>
        /// <param name="fileName">name of the file</param>
        /// <returns>DataTable</returns>
        //public DataTable ReadExcel(string fileName)
        //{
        //    WorkBook workbook = WorkBook.Load(fileName);
        //    //// Work with a single WorkSheet.
        //    ////you can pass static sheet name like Sheet1 to get that sheet
        //    ////WorkSheet sheet = workbook.GetWorkSheet("Sheet1");
        //    //You can also use workbook.DefaultWorkSheet to get default in case you want to get first sheet only
        //    WorkSheet sheet = workbook.DefaultWorkSheet;
        //    //WorkSheet sheet = workbook.GetWorkSheet("Students");
        //    //Convert the worksheet to System.Data.DataTable
        //    //Boolean parameter sets the first row as column names of your table.
        //    return sheet.ToDataTable(true);
        //}

        public DataTable ReadExcel(string fileName, string sheetName)
        {
            WorkBook workbook = WorkBook.Load(fileName);
            //// Work with a single WorkSheet.
            ////you can pass static sheet name like Sheet1 to get that sheet
            ////WorkSheet sheet = workbook.GetWorkSheet("Sheet1");
            WorkSheet sheet = null;
            //You can also use workbook.DefaultWorkSheet to get default in case you want to get first sheet only
            if (sheetName =="Sheet1") 
            {
                sheet = workbook.DefaultWorkSheet;
            }
            else
            {
                sheet = workbook.GetWorkSheet(sheetName);
            }

            //Convert the worksheet to System.Data.DataTable
            //Boolean parameter sets the first row as column names of your table.
            return sheet.ToDataTable(true);
        }
    }
}