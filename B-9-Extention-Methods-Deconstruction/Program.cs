using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Base_Lesson_9.Practice;

namespace Base_Lesson_9
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentTime = new DateTime();
            currentTime = DateTime.Now;
            var(sec,min,hour,day,_,_) = currentTime;
            Console.WriteLine($"секунд {sec}   минут {min}  часов {hour}   дней {day}   Деконструктор работает");
            //Practice.Practice.L9_P_EX_1_from_2();
            //Practice.Practice.L9_P_EX_2_from_2();
            // Lesson.Lesson.DeconstructExample();
            Console.ReadLine();

        }
    }
}
