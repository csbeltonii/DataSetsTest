using System;
using System.Data;
using System.Net;
using System.Net.Mail;
using static System.Console;

namespace DataSetsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            // small program to test datasets in C#
            
            // create a data table
            var data = new DataTable();

            // add columns to the table
            data.Columns.Add("FirstName", typeof(string));
            data.Columns.Add("LastName", typeof(string));
            data.Columns.Add("Age", typeof(int));

            foreach (DataColumn col in data.Columns)
            {
                WriteLine(col.ColumnName);
            }

            ReadKey();
            WriteLine("");

            // create a row for some data
            var _row = data.NewRow();
            var i = int.MaxValue;
            i++;

            _row["FirstName"] = "Craig";
            _row["LastName"] = "Belton";
            _row["Age"] = i;
            data.Rows.Add(_row);

            foreach(DataRow r in data.Rows)
            {
                WriteLine($"First name is: {r["FirstName"]}");
                WriteLine($"Last name is: {r["LastName"]}");
                WriteLine($"Age is: {r["Age"]}");
            }

        }
    }
}
