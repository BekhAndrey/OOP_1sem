using System;

namespace OOP_Lab3
{
    partial class Customer
    {
        // ПОЛЯ ====================================================
        private static int size;
        private readonly int objHash = size + 1;
        private const string month = "September";

        private int id;
        private string name;
        private string surname;
        private int number;
        private int balance;

        // СВОЙСТВА ================================================
        public int Id
        {
            get => id;
            set
            {
                if (value >= 1 && value < 100)
                    id = value;
                else
                    throw new Exception("Неверный формат id");
            }
        }
        public string Name
        {
            get => name;
            set
            {
                name = value;
            }
        }
        public string Surname
        {
            get => surname;
            set
            {
                surname = value;
            }
        }
        public int Number
        {
            get => number;
            set 
            {
                if(value >= 0)
                    number = value;
                else
                    throw new Exception("Неверный формат номера.");
            }
        }

        public int Balance
        {
            get => balance;
            set
            {
                if (value >= 0 )
                    balance = value;
                else
                    throw new Exception("Неверный формат балланса.");
            }
        }

        public string Month { get; }

        // КОНСТРУКТОРЫ ============================================
        static Customer()
        {
            Console.WriteLine("Начата работа с классом \"Customer_Class\"");
        }

        public Customer()
        {
            Id = 0;
            Name = " ";
            Surname = " ";
            Number = 0;
            Balance = 0;

            Customer.size++;
        }

        public Customer(int id = 0, string name = "Andrey",string surname = "Bekh", int number = 0, int balance = 0)
        {
            this.Id = id;
            this.Name = name;
            this.Surname = surname;
            this.Number = number;
            this.Balance = balance;

            Customer.size++;
        }

        private Customer(int number, int balance)
        {
            Id = 0;
            Name = " ";
            Surname = " ";
            this.Number = number;
            this.Balance = balance;

            Customer.size++;
        }

        // МЕТОДЫ ===================================================
        public override bool Equals(object obj)
        {
            Customer tmp = obj as Customer;
            if (tmp != null)
            {
                if (this.Id == tmp.Id && this.Name == tmp.Name && this.Surname == tmp.Surname && this.Number == tmp.Number && this.Balance == tmp.Balance)
                    return true;
                else    
                    return false;
            }
            throw new Exception("Невозможно преобразовать объект к типу Time_Class.");
        }

        public override int GetHashCode() => objHash;

        public override string ToString() => $"Id: {Id}, Name: {Name}, Surname: {Surname} , Number: {Number}, Balance: {Balance}";
    }
}


