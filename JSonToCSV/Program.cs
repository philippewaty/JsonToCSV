using System;
using System.Windows.Forms;
using ChoETL;
using CsvHelper;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

namespace JSonToCSV
{
  class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run(new MainForm());
    }

    //static void Main(string[] args)
    //{
    //  if (args.Length != 2)
    //  {
    //    Console.WriteLine("usage: ");
    //    Console.WriteLine(" arg 1: input json file");
    //    Console.WriteLine(" arg 2: output csv file");
    //    Environment.Exit(-1);
    //  }

    //  string jsonFile = args[0];
    //  string csvFile = args[1];
    //  string jsonContent;
    //  //https://stackoverflow.com/questions/36274948/json-string-to-csv-and-csv-to-json-conversion-in-c-sharp/36348017#36348017
    //  jsonContent = System.IO.File.ReadAllText(jsonFile);
    //  //string jsonCSV = jsonToCSV(jsonContent, ",");
    //  //System.IO.File.WriteAllText(csvFile, jsonCSV);

    //  using (var r = new ChoJSONReader(jsonFile))
    //  {
    //    using (var w = new ChoCSVWriter(csvFile))
    //    {
    //      w.WithFirstLineHeader();
    //      //w.WithDelimiter(",");
    //      w.Write(r);
    //    }
    //  }
    // }

    //public static DataTable jsonStringToTable(string jsonContent)
    //{
    //  DataTable dt = JsonConvert.DeserializeObject<DataTable>(jsonContent);
    //  return dt;
    //}

    //public static string jsonToCSV(string jsonContent, string delimiter)
    //{
    //  StringWriter csvString = new StringWriter();
    //  using (var csv = new CsvWriter(csvString))
    //  {
    //    csv.Configuration.Delimiter = delimiter;

    //    using (var dt = jsonStringToTable(jsonContent))
    //    {
    //      foreach (DataColumn column in dt.Columns)
    //      {
    //        csv.WriteField(column.ColumnName);
    //      }
    //      csv.NextRecord();

    //      foreach (DataRow row in dt.Rows)
    //      {
    //        for (var i = 0; i < dt.Columns.Count; i++)
    //        {
    //          csv.WriteField(row[i]);
    //        }
    //        csv.NextRecord();
    //      }
    //    }
    //  }
    //  return csvString.ToString();
    //}
  }
}
