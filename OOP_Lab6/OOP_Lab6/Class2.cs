using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab6
{
    enum Operations 
    {
        Add,
        Delete,
        Display = 6,
        SearchWeight,
        SearchGram,
        Count
    }
    public struct Weight //структура
    {
        public int Kilo;
        public int Gramm;
        public Weight(int day, int month)
        {
            this.Kilo = day;
            this.Gramm = month;
        }
    }
    public class GiftContainer //класс-контейнер для хранения разных типов объектов в виде списка или массива (использовать абстрактный тип данных)
    {
        public List<TastyTreat> Podarok;
        public GiftContainer()
        {
            Podarok = new List<TastyTreat>();
        }
        public void Delete(int index) 
        {
            Podarok.RemoveAt(index);
        }
        public void Add(TastyTreat item)
        {
            Podarok.Add(item);
        }
        public void Display()
        {
            foreach (TastyTreat item in Podarok)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    public class Gift : GiftContainer //класс-контроллер, который управляет объектом-контейнером
    {
        public void SearchWeight(Weight weight)
        {
            int flagSearch = 0;
            Console.WriteLine("\nПоиск веса {0} кг {1} г", weight.Kilo, weight.Gramm);
            foreach (TastyTreat item in Podarok)
            {
                if (item.Weight.Equals(weight))
                {
                    Console.WriteLine("Вес {0} кг {1} г имеет {2}", weight.Kilo, weight.Gramm, item.Shape);
                    flagSearch++;
                }
                else if (flagSearch != 0)
                    Console.WriteLine("Вес не найден.");
            }
        }
        public int Count()
        {
            Console.WriteLine("\nКоличество вкуснях в подарке составляет: " + Podarok.Count);
            return Podarok.Count;
        }
        public void SearchGram(int gram)
        {
            for (int i = 0; i < Podarok.Count; i++)
            {
                if (Podarok[i] is Cookie)
                {
                    Console.WriteLine("\nГраммовку " + gram + " имеет " + Podarok[i].Shape);
                }
            }
        }
    }
}
