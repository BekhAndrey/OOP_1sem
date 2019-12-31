using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;
using System.Reflection;

namespace _15laba
{
    class Program
    {
        static void Main(string[] args)
        {
            var allProcesses = Process.GetProcesses();
            foreach (var proc in allProcesses)
            {
                try
                {
                    Console.WriteLine($"id:{proc.Id}; name: {proc.ProcessName}; start time: {proc.StartTime}; priority: {proc.PriorityClass}");
                }
                catch (Exception e)
                {

                }
            }


            AppDomain cur = AppDomain.CurrentDomain;  
            Console.WriteLine($" name: {cur.FriendlyName} ");
            Console.WriteLine($" directory base: {cur.BaseDirectory} ");
            Console.WriteLine($" id: {cur.Id}");

            Console.WriteLine("\nassemblies:\n");

            Assembly[] asss = cur.GetAssemblies();
            foreach (Assembly assembly in asss)
            {
                Console.WriteLine(assembly.GetName().Name);
            }
            AppDomain anydomain = AppDomain.CreateDomain("anydomain");

            Console.WriteLine();
            Console.WriteLine(anydomain.FriendlyName);
            AppDomain.Unload(anydomain);








            Thread myThread = new Thread(new ThreadStart(FirstThread));
            myThread.Name = "MyThread1";
            Thread mainthr = Thread.CurrentThread;

            myThread.Start();

            for (int i = 0; i < 10; i++)
            {
                if (myThread.IsAlive)
                {
                    Console.WriteLine($"{i} Приоритет основного {mainthr.Priority}'Имя ({myThread.Name}): Статус:{myThread.ThreadState}, Приоритет:{myThread.Priority}, ");
                    if (i == 3)

                    {
                        myThread.Suspend();
                    }
                    Thread.Sleep(300);
                    if (i == 6)
                    {
                        myThread.Resume();
                    }
                }
                else
                {
                    Console.WriteLine($"{i} Приор осн. {mainthr.Priority}'Основной поток'; {myThread.Name} - завершен");
                }
                Thread.Sleep(300);
            }



            object locker = new object();
            int n = 10;
            Thread Even = new Thread(new ParameterizedThreadStart(EvenNumber));
            Thread UnEven = new Thread(new ParameterizedThreadStart(UnEvenNumber));

            Even.Priority = ThreadPriority.Highest;

            Even.Start(n);
            UnEven.Start(n);

            //TimerCallback meth = new TimerCallback(PrintInt);
            //Timer timer = new Timer(meth, 0, 0, 2500);


            void FirstThread()
            {
                int x = 10;
                int.TryParse(Console.ReadLine(), out x);
                for (int i = 1; i < x; i++)
                {
                    Console.WriteLine($"{i}  'Второй поток'");
                    Thread.Sleep(200);
                }
            }
            void EvenNumber(Object parm)
            {
                //Thread.Sleep(3500);
                //Thread.Sleep(200);
                int x = (int)parm;
                for (int i = 0; i < n; i++)
                {
                    if (i % 2 == 0)
                        Console.WriteLine(i); 
                    Thread.Sleep(350);
                }
            }

            void UnEvenNumber(Object parm)
            {
                int x = (int)parm;
                for (int i = 0; i <= n; i++)
                {
                    if (i % 2 != 0)
                        Console.WriteLine(i);
                    Thread.Sleep(350);
                }
            }

            void PrintInt(Object argument)
            {
                Random rnd = new Random();
                Console.WriteLine("random " + rnd.Next());
            }











            Console.ReadLine();
        }
    }
}
