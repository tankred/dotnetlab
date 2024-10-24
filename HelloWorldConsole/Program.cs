using ClosedXML.Excel; // REF closedXML package ! 
using var workbook = new XLWorkbook();
var worksheet = workbook.AddWorksheet("TABBLAD-891");
worksheet.Cell("A1").Value = "Hello World!";
worksheet.Cell("A2").FormulaA1 = "MID(A1, 7, 5)";
workbook.SaveAs("../report/HelloWorld.xlsx");
//
// Console.WriteLine("Hello, World!");
// 
