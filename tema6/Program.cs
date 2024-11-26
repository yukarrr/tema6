using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string data1 = "2024-11-11";
            try
            {
                DateTime date1 = DateTime.Parse(data1);
                Console.WriteLine($"Parse: {date1}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Неверный формат даты: {data1}");
            }

            string data2 = "10-10-2024";
            string format = "dd-MM-yyyy";
            try
            {
                DateTime date2 = DateTime.ParseExact(data2, format, CultureInfo.InvariantCulture);
                Console.WriteLine($"ParseExact: {date2}");
            }
            catch (FormatException)
            {
                Console.WriteLine($"Неверный формат даты: {data2}");
            }

            string data3 = "2024/11/11";
            if (DateTime.TryParse(data3, out DateTime date3))
            {
                Console.WriteLine($"TryParse: {date3}");
            }
            else
            {
                Console.WriteLine($"TryParse: {data3}");
            }

            string data4 = "2024-10-10";
            string exactFormat = "yyyy-MM-dd";
            if (DateTime.TryParseExact(data4, exactFormat, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime date4))
            {
                Console.WriteLine($"TryParseExact: {date4}");
            }
            else
            {
                Console.WriteLine($"Неверный формат даты: {data4}");
            }

            Console.ReadLine();
        }
    }
}
