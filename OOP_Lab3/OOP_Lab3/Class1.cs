using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab3
{
    class Class1
    {
        class test
        {
            static void Main2(string[] args)
            {
                int param = 10;
                testMethod(ref param); //Выйдет значение = 11
                Console.WriteLine("Значение переменной param в методе Main = {0}", param); //Выйдет значение = 11
                Console.ReadLine();
            }
            static void testMethod(ref int param)
            {
                param++;
                Console.WriteLine("Значение переменной param в методе testMethod = {0}", param);
            }
            static void testMethod2(out int param)
            {
                param = 10;
                param++;
                Console.WriteLine("Значение переменной param в методе testMethod2 = {0}", param);
            }
        }
    }
}
