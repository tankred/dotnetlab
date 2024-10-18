using ClosedXML.Excel; // REF closedXML package ! 
using var workbook = new XLWorkbook();
// See https://aka.ms/new-console-template for more information
var worksheet = workbook.AddWorksheet("Sample Sheet");
worksheet.Cell("A1").Value = "Hello World!";
worksheet.Cell("A2").FormulaA1 = "MID(A1, 7, 5)";
workbook.SaveAs("HelloWorld.xlsx");
Console.WriteLine("Hello, World!");

