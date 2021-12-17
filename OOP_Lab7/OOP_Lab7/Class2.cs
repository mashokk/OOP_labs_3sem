using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab7
{
    enum Operations //перечисление -  набор логически связанных констант
    {
        Add = 1,
        Delete,
        Display,
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
            if (this.Kilo > 30 || this.Kilo < 0 || this.Gramm > 1000 ||this.Gramm < 0)
            {
                throw new WeightException("Ошибка! Неккоректно введен вес", this.Kilo, this.Gramm);
            }
        }
    }
    public class GiftContainer //класс-контейнер для хранения разных типов объектов в виде списка или массива(использовать абстрактный тип данных)
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
        public void SearchGram(int gram) // ВОЗМОЖНО ТУТ ОШИБКА И НЕ ИЩЕТ ВЕС !!!
        {
            if (gram > 9999 || gram < 0)
                throw new SearchGramException("Ошибка! Неверно введена граммовка для поиска:", gram);
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

