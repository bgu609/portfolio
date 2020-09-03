using System;
using System.Globalization;
using static System.Console;

namespace StringSearchApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string g = "Good Morning, Good Morning";
            WriteLine(g);

            WriteLine($"IndexOf 'Good' : {g.IndexOf("Good")}");
            WriteLine($"IndexOf 'Hood' : {g.IndexOf("Hood")}");
            WriteLine($"LastIndexOf 'Good' : {g.LastIndexOf("Good")}");
            WriteLine($"IndexOf 'n' : {g.IndexOf('n')}");
            WriteLine($"LastIndexOf 'n' : {g.LastIndexOf('n')}");

            WriteLine($"StartsWith 'Good' {g.StartsWith("Good")}");
            WriteLine($"StartsWith 'Morning' {g.StartsWith("Morning")}");

            WriteLine($"Contains 'Good' {g.Contains("Good")}");

            if(g.Contains("Morning"))
            {
                WriteLine($"Replace 'Morning' to 'Evening' : {g.Replace("Morning", "Evening")}");
            }

            WriteLine($"ToLower : {g.ToLower()}");
            WriteLine($"ToUpper : {g.ToUpper()}");
            WriteLine($"Insert : {g.Insert(g.IndexOf("Morning") - 1, " Very")}");
            WriteLine($"Insert : {g.Insert(g.IndexOf("Morning"), "Very ")}");

            WriteLine($"Remove : '{"I don't Love you".Remove(2, 6)}'");
            WriteLine($"Trim : '{" No Space ".Trim()}'");
            WriteLine($"Trim : '{" No Space ".TrimStart()}'");
            WriteLine($"Trim : '{" No Space ".TrimEnd()}'");

            string codes = "WSFT, GOOG, AMZN, AAPL, RHT";
            var result = codes.Split(',');
            foreach (var item in result)
            {
                WriteLine($"each item '{item.Trim()}'");
            }

            WriteLine($"substring : {g.Substring(0, 4)}");
            WriteLine($"substring : {g.Substring(5)}");

            WriteLine(string.Format("{0}DEF", "ABC"));
            WriteLine(string.Format("{0,-10}DEF", "ABC"));
            WriteLine(string.Format("{0, 10}DEF", "ABC"));

            DateTime dt = DateTime.Now;
            WriteLine(string.Format($"{dt:yyyy-MM-dd HH:mm:ss}"));
            WriteLine(string.Format($"{dt:d/M/yyyy HH:mm:ss}"));
            WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss", new CultureInfo("ko-KR")));
            WriteLine(dt.ToString("d/M/yyyy HH:mm:ss", new CultureInfo("en-US")));

            WriteLine(string.Format("{0:y yy yyy yyyy}", dt));
            WriteLine(string.Format("{0:M MM MMM MMMM}", dt));
            WriteLine(string.Format("{0:d dd ddd dddd}", dt));

            decimal mvalue = 2700_0000m;
            WriteLine(string.Format($"price {mvalue:C}"));
            WriteLine(mvalue.ToString("C"));
            WriteLine(mvalue.ToString("C", new CultureInfo("en-US")));
            WriteLine(mvalue.ToString("C", new CultureInfo("fr-FR")));
            WriteLine(mvalue.ToString("C", new CultureInfo("ja-JP")));
        }
    }
}