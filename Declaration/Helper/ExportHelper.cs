using OfficeOpenXml;
using OfficeOpenXml.Style;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;

namespace Declaration.Helper
{
    public static class ExportHelper
    {
        public static void ExportToExcel<T>(List<T> model, string filename = "Exported Data", int[] deleteColumn = null)
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Exported Data");
            workSheet.DefaultRowHeight = 12;
            //Header of table  
            // 

            var header = typeof(T).GetProperties()
                        .Select(property => property.Name)
                        .ToArray();

            for (int i = 0; i <= header.Count() - 1; i++)
            {
                var rowColumn = i + 1;
                workSheet.Cells[1, rowColumn].Value = header[i];
                workSheet.Cells[1, rowColumn].Style.Font.Bold = true;
                workSheet.Cells[1, rowColumn].Style.Fill.PatternType = ExcelFillStyle.Solid;                      //Set Pattern for the background to Solid
                workSheet.Cells[1, rowColumn].Style.Fill.BackgroundColor.SetColor(Color.FromArgb(79, 129, 189));  //Set color to dark blue
                workSheet.Cells[1, rowColumn].Style.Font.Color.SetColor(Color.White);
            }

            int recordIndex = 2;
            foreach (var gmds in model)
            {
                var valueOfEntity = gmds.GetType().GetProperties().Select(x => x.GetValue(gmds, null)).ToArray();

                for (int i = 0; i <= valueOfEntity.Count() - 1; i++)
                {
                    var rowColumn = i + 1;

                    if (valueOfEntity[i] != null)
                    {
                        DateTime dateTime;
                        string value = "";

                        value = valueOfEntity[i].ToString();

                        if (DateTime.TryParse(value, out dateTime))
                        {
                            workSheet.Cells[recordIndex, rowColumn].Style.Numberformat.Format = "dd-mm-yyy";
                            workSheet.Cells[recordIndex, rowColumn].Value = value;
                        }
                        else
                        {
                            workSheet.Cells[recordIndex, rowColumn].Value = value;
                        }
                    }
                }
                recordIndex++;
            }

            if (deleteColumn != null)
            {
                for (int i = 0; i < deleteColumn.Length; i++)
                {
                    workSheet.DeleteColumn(deleteColumn[i]);
                }
            }

            string excelName = filename + "_" + DateTime.Now.ToShortDateString();


            using (var memoryStream = new MemoryStream())
            {
                HttpContext.Current.Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                HttpContext.Current.Response.AddHeader("content-disposition", "attachment; filename=" + excelName + ".xlsx");
                excel.SaveAs(memoryStream);
                memoryStream.WriteTo(HttpContext.Current.Response.OutputStream);
                HttpContext.Current.Response.Flush();
                HttpContext.Current.Response.End();
            }
        }
    }
}