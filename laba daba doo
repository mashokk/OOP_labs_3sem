using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            
            //#1
            string name = "Masha";
            int age = 18;
            bool isEmployed = false;
            double high = 169.86;
            byte bit1 = 102;
            Console.WriteLine($"Имя: {name}");
            Console.WriteLine($"Возраст: {age}");
            Console.WriteLine($"Работает: {isEmployed}");
            Console.WriteLine($"Рост: {high}");
            Console.WriteLine($"Просто тип байт: {bit1}");


            
            int value1int = 10; //неявное преобразование
            long value1long;
            value1long = value1int;

            int x1 = 4;
            int? x2 = x1;
            Console.WriteLine(x2);


            long value2long = 15; //явное преобразование
            int value2int;
            value2int = (int)value2long;

            int? xx = null;
            if (xx.HasValue)
            {
                int yy = (int)xx;
                Console.WriteLine(yy);
            }



            int AAA = 1; //упаковка и распаковка значимых типов
            object BBB = AAA;
            int CCC = (int)BBB;



            var mycatsname = "Nosok"; //работа с неявно типизированными переменными
            var mycatsage = "12";
            var mycatiscat = true;
            Type mycatsnameType = mycatsname.GetType();
            Type mycatsageType = mycatsage.GetType();
            Type mycatiscatType = mycatiscat.GetType();
            Console.WriteLine("Тип mycatsname: {0}", mycatsnameType);
            Console.WriteLine("Тип mycatsage: {0}", mycatsageType);
            Console.WriteLine("Тип mycatiscat: {0}", mycatiscatType);
            Console.ReadLine();



/*            int? nnn = null; //пример работы с nullable переменной
            Console.WriteLine(nnn == null);
            Console.WriteLine(nnn.HasValue);
            Console.WriteLine(nnn.GetValueOrDefault());
            Console.WriteLine(nnn.GetValueOrDefault(5));
            Console.WriteLine(nnn ?? 55);*/

            //ctrl shift /
            
            object a = "hello"; //объявление и сравнение строковых литералов
            object b = "hello";
            object c = "Hello";
            object d = "hell";
            System.Console.WriteLine(a == b);
            System.Console.WriteLine(a == c);
            System.Console.WriteLine(a != d);



            string word1 = "Солнце светит. "; //сцепление строк
            string word2 = "Птички поют. ";
            string word3 = "Я лежу дома и болею. ";
            string phrase;
            phrase = String.Concat(word1, word2, word3);
            Console.WriteLine(phrase);

            //копирование подстроки ??

            //выделение подстроки ??

            string[] words = word3.Split(new Char[] { ' ',' ' }); //разделение строки на слова
            foreach (string s in words)
            {
                if (s.Trim() != "")
                    Console.WriteLine(s);
            }

            string word4 = " КВА КВА КВА"; //вставка подстроки в заданную позицию
            int insertPosition = 6;
            word2 = word2.Substring(0, insertPosition) + word4 + word2.Remove(0, insertPosition);
            Console.WriteLine(word2);

            int index = word2.IndexOf(word4); //удаление заданной подстроки
            if (index != -1)
            {
                word2 = word2.Remove(index, word4.Length);
                index = word2.LastIndexOf(word4);
                if (index != -1)
                    word2 = word2.Remove(index, word4.Length);
            }
            word2 = word2.Trim();
            Console.WriteLine(word2);



            //null строка



            //stringbuilder
            
            
            //двум массив и вывод его в виде матрицы
            int[,] jj = { { 1, 2, 3 }, { 1, 2, 3 }, { 3, 2, 1 } };

            int rows = jj.GetUpperBound(0) + 1;
            int columns = jj.Length / rows;

            for (int pop = 0; pop < rows; pop++)
            {
                for (int kek = 0; kek < columns; kek++)
                {
                    Console.Write($"{jj[pop, kek]} \t");
                }
                Console.WriteLine();
            }



            //одномерный массив строк
            string[] kk = { "qwerty", "asdfgh", "zxcvbn" };

            Console.WriteLine(kk.Length);

            foreach (string oop in kk)
            {
                Console.WriteLine(oop);
            }

            kk[1] = "popopop"; //изменение произвольного элемента



            //ступенчатый массив вещественных чисел с 3 строками
            int[][] ll = new int[3][];
            ll[0] = new int[] { 1, 3 };
            ll[1] = new int[] { 1, 3, 5 };
            ll[2] = new int[] { 1, 3, 4, 7 };

            foreach (int[] row in ll)
            {
                foreach (int number in row)
                {
                    Console.Write($"{number} \t");
                }
                Console.WriteLine();
            }



            //неявно типизированные переменные
            var zz = new object[0];
        }
    }
}
