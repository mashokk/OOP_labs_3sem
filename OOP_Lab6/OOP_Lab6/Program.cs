/*
Собрать Детский подарок с определением его веса. Провести
сортировку конфет в подарке на основе одного из
параметров. Найти конфету в подарке, соответствующую
заданному диапазону содержания сахара.
 */
using System;

namespace OOP_Lab6
{
    class Program
    {
        static void Main()
        {
            Gift gift = new Gift();
            Cookie Chocolate = new Cookie("Круглая", "Овсяное", new Weight(1, 800), 8700);
            Sweet Kommunarka = new Sweet("Батончик", "Сникерс", new Weight(3, 500));
            gift.Add(Chocolate);
            gift.Add(Kommunarka);
            gift.Display();
            gift.Count();
            gift.SearchWeight(new Weight(3, 500));
            gift.SearchGram(8700);
        }
    }
}
