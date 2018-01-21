using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Time_conversion
{
    class Program
    {
        static string timeConversion(string s)
        {
            DateTime time = Convert.ToDateTime(s);
            return time.ToString("HH:mm:ss");
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = timeConversion(s);
            Console.WriteLine(result);
        }
    }
}
