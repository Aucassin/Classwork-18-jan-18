using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parser
{
    class Program
    {
        static void TimerCallBack(Object obj)
        {
            TimeSpan timeToNewYear = DateTime.Now - DateTime.ParseExact("31:12:2018 23:59:59", "dd:MM:yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            Console.WriteLine($"{timeToNewYear:dd\\ hh\\:mm\\:ss} days");
        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            //DateTime date = new DateTime();
            //Console.WriteLine(DateTime.Now);

            string str = "22/Jul/2017:05:38:16";
            //date = DateTime.ParseExact(str, "dd/MMM/yyyy:HH:mm:ss", CultureInfo.InvariantCulture);
            //Console.WriteLine(date);

            List<DateTime> dates = new List<DateTime>();

            using (StreamReader reader = new StreamReader(@"C:\Users\student\Desktop\Test.log"))
            {
                while ((str = reader.ReadLine()) != null)
                {
                    dates.Add(DateTime.ParseExact(str.Split('[', ']')[1], "dd/MMM/yyyy:HH:mm:ss K", CultureInfo.InvariantCulture));
                }
            }
            Timer t = new Timer(TimerCallBack, null, 0, 1000);
            Console.ReadKey();
            //foreach (var item in dates)
            //{
            //    Console.WriteLine(item);
            //}
        }
    }
}
