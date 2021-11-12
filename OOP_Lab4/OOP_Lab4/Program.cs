/*1) Создать заданный в варианте класс. Определить в классе необходимые
методы, конструкторы, индексаторы и заданные перегруженные
операции. Написать программу тестирования, в которой проверяется
использование перегруженных операций.

2) Добавьте в свой класс вложенный объект Owner, который содержит Id,
имя и организацию создателя. Проинициализируйте его

3) Добавьте в свой класс вложенный класс Date (дата создания).
Проинициализируйте

4) Создайте статический класс StatisticOperation, содержащий 3 метода для
работы с вашим классом (по варианту п.1): сумма, разница между
максимальным и минимальным, подсчет количества элементов.

5) Добавьте к классу StatisticOperation методы расширения для типа string
и вашего типа из задания№1. См. задание по вариантам. */

/*Вариант 4

Класс - множество Set. Дополнительно перегрузить
следующие операции: - - удалить элемент из множества
(типа set-item); * - пересечение множеств; < - сравнение
множеств; > - проверка на подмножество; & - придумайте
использование.

    Методы расширения:
1) Добавление точки в конце строки
2) Удаление нулевых элементов из множества*/



//1 вариант
using System;

namespace OOP_Lab4
{
    class Array
    {
        public int[] a = new int[100];
        public string str;
        public Owner owner;
        public Array() { }
        public Array(int ownerId, string ownerName, string ownerCompany)
        {
            this.owner = new Owner(ownerId, ownerName, ownerCompany);
        }


        //ОПРЕДЕЛЕНИЕ МЕТОДОВ 
        public void enterData(params int[] ArrayData)
        {
            this.a = ArrayData;
        }
        public void printInfo()
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != 0)
                    Console.Write(a[i] + "\t");
            }
            Console.WriteLine();
        }




        // Перегрузка операторов * true int() == <
        public static Array operator *(Array arr1, Array arr2)
        {
            Array arrP = new Array();
            for (int i = 0; i < arr2.a.Length; i++)
            {
                arrP.a[i] = arr1.a[i] * arr2.a[i];
            }
            return arrP;
        }
        public static bool operator true(Array arr) //умножение массивов
        {
            for (short i = 0; i < arr.a.Length; i++)
            {
                if (arr.a[i] < 0)
                    return false;
            }
            return true;
        }
        public static bool operator false(Array arr) //истина, если массив не содержит отрицательных элементов
        {
            for (short i = 0; i < arr.a.Length; i++)
            {
                if (arr.a[i] < 0)
                    return true;
            }
            return false;
        }
        public static explicit operator int(Array arr) //операция приведения - возвращает размер (длину) массива
        {
            return arr.a.Length;
        }
        public static bool operator ==(Array arr1, Array arr2) //проверка на равенство
        {
            for (int i = 0; i < arr1.a.Length; i++)
            {
                if (arr1.a[i] != arr2.a[i])
                    return false;
            }
            return true;
        }
        public static bool operator !=(Array arr1, Array arr2) //проверка на неравенство
        {
            for (int i = 0; i < arr1.a.Length; i++)
            {
                if (arr1.a[i] != arr2.a[i])
                    return true;
            }
            return false;
        }
        public static bool operator <(Array arr1, Array arr2) //сравнение
        {
            if (StatisticOperations.sum(arr1) < StatisticOperations.sum(arr2))
                return true;
            else return false;
        }
        public static bool operator >(Array arr1, Array arr2) //тоже сравнение
        {
            if (StatisticOperations.sum(arr1) > StatisticOperations.sum(arr2))
                return true;
            else return false;
        }




        
        public class Date ///////// вложенный класс Date (дата создания)
        {
            public DateTime time;
            public Date()
            {
                this.time = new DateTime(2002, 12, 28, 7, 30, 0);
            }
            public void showDate()
            {
                Console.WriteLine("Дата создания: " + time);
            }
        }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Array arr1 = new Array();
            Array arr2 = new Array();
            Array arr3 = new Array();
            Array arr4 = new Array();

            Console.WriteLine("Два массива:");

            arr1.enterData(1, 2, 3, 4, 5, 6, 7);
            arr1.printInfo();

            arr2.enterData(1, -2, -3, 4, 5, 6, 7);
            arr2.printInfo();



            Console.WriteLine("\n\n---Перегрузка оператора * - умножение массивов---");
            Array arrP = arr1 * arr2;
            arrP.printInfo();

            Console.WriteLine("\n---Перегрузка оператора true - истина, если массив не сдержит отрицательных элементов---");
            if (arr1)
                Console.WriteLine("arr1 вернул значение true");
            else Console.WriteLine("arr1 вернул значение false");

            Console.WriteLine("\n---Перегрузка оператора int() - операция приведения – возвращает размер массива---");
            Console.WriteLine((int)arr2);

            Console.WriteLine("\n---Перегрузка оператора == - проверка на равенство---");
            if (arr1 == arr2)
                Console.WriteLine("arr1 == arr2");
            else Console.WriteLine("arr1 != arr2");

            Console.WriteLine("\n---Перегрузка оператора > - сравнение---");
            Console.WriteLine("\nМассив arr3:");
            arr3.enterData(1, 3, 32, 6, -17, 22);
            arr3.printInfo();
            Console.WriteLine("Сумма всех элементов arr3.sum() = " + arr3.sum());

            Console.WriteLine("\nМассив arr4:");
            arr4.enterData(9, 11, 32, 54, -21, 12);
            arr4.printInfo();
            Console.WriteLine("Сумма всех элементов arr4.sum() = " + arr4.sum() + "\n");

            if (arr3 > arr4)
                Console.WriteLine("arr3 > arr4");
            else Console.WriteLine("arr3 < arr4");



            Console.WriteLine("\n\n\nOwner");
            Array ownerArr = new Array(1, "Masha", "mash_ok");
            ownerArr.owner.printInfo();
            Console.WriteLine("\nDate");
            Array.Date date = new Array.Date();
            date.showDate();

            Console.WriteLine("\n\nStatistic Operations");
            Console.WriteLine("Максимальный элемент в arrP: " + arrP.max());
            Console.WriteLine("Минимальный элемент в arr4: " + arr4.min());
            Console.WriteLine("Разница (максимальный минус минимальный элемент) в arr3: " + arr3.delta());
            Console.WriteLine("Количество элементов в arr2: " + arr2.size());





            /////// ЗАДАНИЯ В ПУНКТАХ 1 ВАРИАНТ
            //1
            Array arrStr = new Array();
            arrStr.str = "qwertyuiopasdfghjkl13579";
            Console.WriteLine("\n\n\n\n1)Проверка на содержание определённого символа в строке");
            Console.WriteLine("Строка:" + arrStr.str);
            Console.WriteLine("Введите символ, который хотите найти в строке:");
            string symbol = Console.ReadLine();
            arrStr.hasSymbol(symbol);

            //2
            Array arrNega = new Array();
            arrNega.enterData(1, 2, 3, 4, 5, -6, 7, 8, -9, 10);
            Array arrOut = arrNega.nega();
            Console.WriteLine("\n\n2) Удаление отрицательных элементов");
            arrNega.printInfo();
            Console.WriteLine("Результат после удаления:");
            arrOut.printInfo();
        }
    }
}
