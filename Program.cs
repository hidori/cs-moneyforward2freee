using System;
using System.Text;
using Microsoft.VisualBasic.FileIO;

namespace mf2freee
{
    class Program
    {
        static Program()
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Date,Amount,Description");
            foreach (var arg in args)
            {
                using (var parser = CreateParser(arg))
                {
                    parser.ReadFields();
                    while (!parser.EndOfData)
                    {
                        var fields = parser.ReadFields();
                        var row = CreateRow(fields);
                        Console.WriteLine($"{row.Date},{row.Amount},{row.Description}");
                    }
                }
            }
        }

        static TextFieldParser CreateParser(string filePath)
        {
            var parser = new TextFieldParser(filePath, Encoding.GetEncoding("Shift_JIS"));
            parser.SetDelimiters(new[] { "," });
            parser.HasFieldsEnclosedInQuotes = true;
            return parser;
        }

        static Row CreateRow(string[] fields)
        {
            return new Row
            {
                Date = fields[1],
                Amount = -1 * int.Parse(fields[3]),
                Description = fields[2].Replace(",", "，"),
            };
        }
    }

    class Row
    {
        public string Date { get; set; }
        public string Description { get; set; }
        public int Amount { get; set; }
    }
}