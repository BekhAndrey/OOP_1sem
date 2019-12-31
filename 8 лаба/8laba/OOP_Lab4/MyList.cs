using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace OOP_Lab4
{
    public class MyList<T> : IInterface<T>/* where T: Person*/
    {
        // ПОЛЯ 
        private List<T> collection;
      

        // СВОЙСТВА
        public int Size { get; }

        // КОНСТРУКТОРЫ 
        public MyList()
        {
            this.collection = new List<T>();
        }



        public void Add(T item)
        {
            collection.Add(item);
        }
        public void Del(T item)
        {
            collection.Remove(item);
        }
        public void Show()
        {
            foreach (T item in collection)
            {
                Console.WriteLine(item);
            }
        }

        public int GetSize()
        {
            int size = 0;
            foreach(T item in collection)
            {
                size++;
            }
            return size;
        }
        // ПЕРЕГРУЗКИ =================================================
        public static MyList<T> operator + (MyList<T> list, T item)
        {
            list.collection.Add(item);
            return list;
        }

        public static MyList<T> operator + (MyList<T> listOne, MyList<T> listTwo)
        {
            foreach(T item in listTwo.collection)
            {
                listOne.Add(item);
            }

            return listOne;
        }

        public static MyList<T> operator -- (MyList<T> list)
        {
            list.collection.RemoveAt(0);
            return list;
        }


        public static bool operator true (MyList<T> list)
        {
            if (list.GetSize() == 0)
                return true;
            else return false;
        }

        public static bool operator false (MyList<T> list)
        {
            if (list.GetSize() != 0)
                return false;
            else return true;
        }
        public class Date
        {
            public readonly DateTime time;

            public Date()
            {
                time = DateTime.Now;
            }
        }
    }
}