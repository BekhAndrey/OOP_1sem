using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace _10laba
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            Student student = new Student();
            student.Name = "Andrey";

            list.Add(22);
            list.Add(55);
            list.Add(13);
            list.Add(11);
            list.Add(65);
            list.Add("Number");
            list.Add(student);

            list.RemoveAt(6);
            int count1 = 0;
            foreach(object x in list)
            {
                Console.WriteLine(x);
                count1++;
            }
            Console.WriteLine(count1);

            bool cn = list.Contains(13);
            Console.WriteLine(cn);

            List<char> chars = new List<char>();
            chars.Add('a');
            chars.Add('b');
            chars.Add('c');
            chars.Add('e');
            chars.Add('f');
            chars.Insert(3, 'd');
            int count2 = 0;
            Console.WriteLine("Обобщенный список");
            foreach (char x in chars)
            {
                Console.WriteLine(x);
                count2++;
            }
            Console.WriteLine(count2);
            Console.WriteLine("Введите количество удаляемый элементов:");
            int amount = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < amount; i++)
            {
                chars.RemoveAt(count2 - amount);
            }
            Console.WriteLine("Новый список");
            foreach (char x in chars)
            {
                Console.WriteLine(x);
            }
            Stack<char> stk = new Stack<char>();
            foreach (char x in chars)
            {
                stk.Push(x);
            }
            Console.WriteLine("Стек");
            foreach (char y in stk)
            {
                Console.WriteLine(y);
            }
            bool contains = stk.Contains('b');
            Console.WriteLine(contains);

            ObservableCollection<Student> users = new ObservableCollection<Student>
            {
                new Student { Name = "Bill" },
                new Student { Name = "Tom" },
                new Student { Name = "Alice" }
            };
            foreach (Student user in users)
            {
                Console.WriteLine(user.Name);
            }
            users.CollectionChanged += Users_CollectionChanged;
            users.Add(new Student { Name = "Bob" });
            users.RemoveAt(1);


            void Users_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
            {
                switch (e.Action)
                {
                    case NotifyCollectionChangedAction.Add:
                        Student newUser = e.NewItems[0] as Student;
                        Console.WriteLine($"Добавлен новый объект: {newUser.Name}");
                        break;
                    case NotifyCollectionChangedAction.Remove:
                        Student oldUser = e.OldItems[0] as Student;
                        Console.WriteLine($"Удален объект: {oldUser.Name}");
                        break;
                }
            }
            Console.ReadKey();
        }
    }
}
