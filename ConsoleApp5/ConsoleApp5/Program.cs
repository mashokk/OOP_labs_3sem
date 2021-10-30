using System;
using System.Linq;

namespace ConsoleApp5
{



    //Класс - некая абстракция, логическая структура, описывающая поведение и характеристики. Например, машина. Она может ехать, сигналить и т.п.
    //Объект - конкретный экземпляр класса.Например, конкретная ваша машина.
    //Экземпляр класса - это одно и тоже, что и объект класса.
    //Класс: фрукт, Объект: киви, банан, манго.
    class Customer
    {
        public Customer(string name) { Name = name; } //конструкторы
        public Customer(string n, string m) { Name = n; LastName = m; MiddleName = "Петрович"; Address = m; CardNumber = 5896341; Balance = 31; }
        public Customer(string n, string m, int c) { Name = n; Address = m; CardNumber = c; Balance = 1; }

        public string Name //публичный, общедоступный класс или член класса
        {
            get; private set;
        }

        public string LastName
        {
            get; set;
        }

        public string MiddleName
        {
            get; set;
        }

        public string Address
        {
            get; set;
        }

        public int CardNumber
        {
            get; set;
        }

        public int Balance
        {
            get; set;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} Адрес: {3} Номер карты:{4} Баланс: {5}", Name, LastName, MiddleName, Address, CardNumber, Balance);
        }
    }

    class Balancesum
    { 
        
        
        
        /////////////////// минимальная допустимая сумма для всех счетов
        private static decimal minSum = 1;
        public static decimal MinSum
        {
            get { return minSum; }
            set { if (value > 0) minSum = value; }
        }

        public decimal Sum { get; private set; }    // сумма на счете

        ////////////////// подсчет суммы на счете через определенный период по определенной ставке
        public static decimal GetSum(decimal sum, int period)
        {
            decimal result = sum;
            const decimal q = 0.3M;
            for (int i = 1; i <= period; i++)
                result = result + (result * q);
            return result;
        }
        public static decimal GetMin(decimal min, int n)
        {
            decimal res = min;
            const decimal q = 0.3M;
            for (int i = 1; i <= 1000; i++)
                res = min - (n * q);
            return res;
        }
    }
    public partial class Cust
    {
        partial void Read();
        public void DoSomething()
        {
            Read();
        }
    }
    public partial class Cust
    {
        partial void Read()
        {
            Console.WriteLine("3 Пользователь получил зачисление на счет");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Customer[] customers = new Customer[3]; //вызов массива конструкторов

            customers[0] = new Customer("Иван", "Иванов") { MiddleName = "Иванович", Address = "ул. Иванова 2", CardNumber = 5896341, Balance = 42 };
            customers[1] = new Customer("Петр", "Петров", 1289) { LastName = "Петров", MiddleName = "Петрович", Address = "ул. Петровская 4",/* CardNumber =1289,*/ Balance = 1 };
            customers[2] = new Customer("Олег") { LastName = "Олегов", MiddleName = "Олегович", Address = "ул. Олеговича 66", CardNumber = 5896341, Balance = 567 };

            Console.WriteLine("База данных покупателей: ");
            foreach (Customer customer in customers)
            {
                Console.WriteLine(customer.ToString());
            }

            decimal result = Balancesum.GetSum(567, 1);
            Console.WriteLine("Обновленный баланс 3 покупателя:" + result);
            decimal res = Balancesum.GetMin(42, 30);
            Console.WriteLine("Обновленный баланс 1 покупателя:" + res);
            Console.WriteLine();
            Console.WriteLine("Покупатели у кот. кредитная карта до 50000: ");
            var intNumber = customers.Where(x => x.CardNumber < 50000);
            foreach (Customer customer in intNumber)
            {
                Console.WriteLine(customer.ToString());
            }



            //ToString служит для получения строкового представления данного объекта. Для базовых типов просто будет выводиться их строковое значение:
            //GetHashCode позволяет возвратить некоторое числовое значение, которое будет соответствовать данному объекту или его хэш-код.
            //Метод GetType позволяет получить тип данного объекта:
            //Метод Equals позволяет сравнить два объекта на равенство:
        }
    }
}