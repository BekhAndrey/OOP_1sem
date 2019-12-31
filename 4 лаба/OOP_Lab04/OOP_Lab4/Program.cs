using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            MyList list = new MyList(1, "BAU");
            list.AddItem("Ivan");
            list.AddItem("Andrew");
            list.AddItem("Natalia");
            list.AddItem("Victor");

            MyList list1 = new MyList(2, "ABC");
            list.AddItem("Alexander");
            list.AddItem("Uri");
            list.AddItem("Vladimir");
            list.AddItem("Sergey");

            list = list + list1;
            list--;
            list = list + "Andrey";
            bool cn = (list1 == list);
            Console.WriteLine(cn);
            if (list)
                Console.WriteLine("List is empty");

            string abc = "awdg fseol  ajes";
            Console.WriteLine($"Count of words: {abc.CountOfWords()}");
            Console.WriteLine($"Element number 4: {list.GetItemByIndex(4)}");
            Console.WriteLine($"Delete item number 4: {list.DeleteItemByIndex(4,ref list)}");
            Console.WriteLine($"Element number 4: {list.GetItemByIndex(4)}");
            Console.WriteLine($"Element number 6: {list.GetItemByIndex(6)}");


            list.GetOwner().GetInfo();


            Console.ReadKey();
        }
    }
}
