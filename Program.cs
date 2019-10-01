using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthlyWIPReport
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var rDb = new thas01ReportEntities())
            {
                rDb.Database.CommandTimeout = 10000;
                var wipReport = rDb.THAS_ExcelExport_WIPEvaluationReport().ToList();

                FileInfo fileInfo;
                string theDate = DateTime.Now.ToString("yyyyMMdd");
                string theDateHours = DateTime.Now.ToString("yyyyMMdd HH.mm.ss");
                if (CreateDirectoryStructure(out fileInfo, theDate, theDateHours, @"WIPEvaluation_", "Finance Reports", true))
                    {
                        using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
                        {
                            var workSheet = excelPackage.Workbook.Worksheets.Add("WIPEvaluation");

                            workSheet.Cells["A1"].LoadFromCollection(wipReport, true, OfficeOpenXml.Table.TableStyles.Medium2);
                            int rowCount = workSheet.Dimension.Rows;
                            workSheet.Cells["P2:P" + rowCount].Style.Numberformat.Format = "dd/MM/yyyy";
                            workSheet.Cells["Q2:Q" + rowCount].Style.Numberformat.Format = "dd/MM/yyyy";
                            workSheet.Cells["S2:S" + rowCount].Style.Numberformat.Format = "dd/MM/yyyy";
                            workSheet.Cells[workSheet.Dimension.Address].AutoFitColumns();
                            workSheet.View.ZoomScale = 75;
                            excelPackage.Save();
                        }
                    }
               
            }
        }
        private static bool CreateDirectoryStructure(out FileInfo fileInfo, string date, string dateHours, string filename, string folderPath, bool costed)
        {
            string path = @"\\tas\reports$\{0}\{1}\";
            if (costed)
            {
                path = @"\\tas\reports$\{0}\With Costing Info\{1}\";
            }
            else
            {
                path = @"\\tas\reports$\{0}\Without Costing Info\{1}\";
            }

            fileInfo = new FileInfo(string.Format(path + filename + "_{2}.xlsx", folderPath, date, dateHours));
            try
            {
                var fullpath = string.Format(path + filename + "_{2}.xlsx", folderPath, date, dateHours);
                if (!File.Exists(fullpath))
                {
                    fileInfo = new FileInfo(fullpath);
                    fileInfo.Directory.Create();
                    return true;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Issue : " + ex.Message);
                return false;
            }
        }


    }
}
