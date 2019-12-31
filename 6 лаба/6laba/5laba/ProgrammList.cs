using System;
using System.Collections.Generic;
using System.Text;

namespace _5laba
{
    public class ProgrammList
    {
        public Base[] pr;
        public int count = 0;
        public int size;

        public ProgrammList()
        {
            size = 3;
            pr = new Base[4];
        }



        public void Add(Base el)
        {
            pr[count++] = el;
        }

        public void Del(Base el)
        {
            int num = 0;
            for (int i = 0; i < count; i++)
            {
                if (pr[i].Equals(el))
                    num = i;
            }
            for (int i = num; i < count; i++)
            {
                pr[i] = pr[i + 1];
            }
            count--;
        }

        public void show()
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Автор - { pr[i].ToString()}");
                Console.WriteLine($"Продолжительность - {pr[i].info.Duration} минут");
                Console.WriteLine($"Рейтинг - {pr[i].info.Rating}");
                Console.WriteLine($"Год выпуска - {pr[i].info.Date}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}

