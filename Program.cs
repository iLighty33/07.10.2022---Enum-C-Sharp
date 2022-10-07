using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._10._2022___Enum_C_Sharp
{
    class Program
    {
        
        static void detectDay(string _day)
        {
            if (_day != "saturday" & _day != "sunday")
            {
                Console.WriteLine($"This {_day} is working day");
            }
            else
            {
                Console.WriteLine($"This {_day} is holiday");
            }
        }
        static void detectDay(DayOfWeek _day)
        {
            if(_day.ToString() != "saturday" & _day != DayOfWeek.Sunday)
            {
                Console.WriteLine($"This {_day} is working day");
            }
            else
            {
                Console.WriteLine($"This {_day} is holiday");
            }
        }
        static void Main(string[] args)
        {
            
            //string[] daysOfWeek = new string[] { "monday", "tuesday", "wednesday", "thursday", "friday", "saturday", "sunday" };
            //foreach (var item in daysOfWeek)
            int a = 10;
            float b = 12;
            var c = a + b;

            // Позволяет работать с индексом. 
            for (var i = DayOfWeekEnum.monday; i <= DayOfWeekEnum.sunday; i++)
            {
                Console.WriteLine(i);
               // Console.Write(Enum.GetValues(typeof(DayOfWeekEnum)));
            }


            // Когда мы хотим, чтобы у нас значение не менялось. При работе с константами.
            foreach (var item in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine("Перечисление через Enum.GetValues {0}", item);
            }

            foreach(var item in Enum.GetValues(typeof(DayOfWeek)))
            {
                detectDay((DayOfWeek)item);
            }
            foreach (var item in Enum.GetValues(typeof(dayOfMonthRus)))
            {
                Console.WriteLine("В месяце {0} {1}", item.ToString(), DayOfMonthArr.month[(int)item]);
            }
            //{
            //    detectDay(item);
            //}
            //for (int i = 0; i < daysOfWeek.Length; i++)
            //{
            //    detectDay(daysOfWeek[i]);
            //}
            Console.WriteLine("{0} = {1} ", dayOfMonthRus.август, (int)dayOfMonthRus.август);
            Console.WriteLine(DayOfWeek.Friday.ToString());
            Console.ReadKey();
        }
    }
}
