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
            size = 4;
            pr = new Base[4];
        }

        public bool IsFull()
        {
            return (count == size);
        }
        public bool IsEmpty()
        {
            return (count == 0);
        }

        public void Add(Base el)
        {
            if (IsFull())
                throw new ArrayIsFull("Список телепередач полон");
            pr[count++] = el;
        }

        public void Del(Base el)
        {
            int? num = null;
            if (IsEmpty())
            {
                throw new ArrayIsEmpty("Список телепередач пуст");
            }
            for (int i = 0; i < count; i++)
            {
                if (pr[i].Equals(el))
                    num = i;
            }
            if(num == null)
            {
                throw new ElementDoesNotExist("Элемент не существует");
            }
                
            for (int i = (int)num; i < count; i++)
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
                Console.WriteLine($"Год выпуска - {pr[i].info.Date}");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }

}

