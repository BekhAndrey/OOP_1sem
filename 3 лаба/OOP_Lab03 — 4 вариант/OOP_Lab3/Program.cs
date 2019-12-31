using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer one = new Customer(3);
            Customer two = new Customer(4, Andrey,);
            Customer three = new Customer(17);
            Customer four = new Customer(surname: Andrey, );
            Customer five = new Customer(17);
            Time two = new Time();
            Time three = new Time(10,40,50);
            Time four = new Time(hour: 21,second: 38);
            Time five = new Time(second: 36);

            Console.WriteLine(four);

            Time[] timeArray = { one, two, three, four, five};

            Time.GetInfo();

            var myView = new { hour = 1, minute = 40, second = 59 };


            for (int i = 0; i < 5; i++)
            {
                if (timeArray[i].Hour <= 12)
                {
                    Console.Write("Утро - ");
                    Console.WriteLine(timeArray[i]);
                }
                else if (timeArray[i].Hour <= 18)
                {
                    Console.Write("День - ");
                    Console.WriteLine(timeArray[i]);
                }
                else if (timeArray[i].Hour <= 22)
                {
                    Console.Write("Вечер - ");
                    Console.WriteLine(timeArray[i]);
                }
                else if (timeArray[i].Hour <= 24)
                {
                    Console.Write("Ночь - ");
                    Console.WriteLine(timeArray[i]);
                }
            }

            Console.WriteLine("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            foreach (Time item in timeArray)
            {
                if (item.Hour == number)
                    Console.WriteLine(item);
            }
            one.Equals(two);



            Console.ReadKey();
        }
    }
}
