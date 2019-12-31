using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    public static class Controller
    {
        public static void FindFilm(ProgrammList prgrm)
        {
            int i;
            int year;
            Console.WriteLine("Введите год выпуска фильма");
            year = int.Parse(Console.ReadLine());
            for (i = 0; i < prgrm.count; i++)
            {
                if (prgrm.pr[i].info.Date == year)
                {
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine($"Автор - { prgrm.pr[i].ToString()}");
                    Console.WriteLine($"Продолжительность - {prgrm.pr[i].info.Duration} минут");
                    Console.WriteLine($"Рейтинг - {prgrm.pr[i].info.Rating}");
                    Console.WriteLine($"Год выпуска - {prgrm.pr[i].info.Date}");
                }
            }
        }
        public static void Time(ProgrammList prgrm)
        {
            int i;
            int time;
            int total = 0;
            for (i = 0; i < prgrm.count; i++)
            {
                time = prgrm.pr[i].info.Duration;
                total += time;
            }
            Console.WriteLine("----------------------");
            Console.WriteLine($"Общее время телепередачи - {total} минут");
        }
    }
}

