using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace OOP_Lab5
{
        public abstract class Pastry //АБСТРАКТНЫЙ КЛАСС
        {
            public int Consignment; //партия товара
            public int Month; //месяц выпуска 1-12

            protected Pastry() { }

            protected Pastry (int consignment, int month)
            {
                Consignment = consignment;
                Month = month;
            }
        /*
        При наследовании нередко возникает необходимость изменить в классе-наследнике
        функционал метода, который был унаследован от базового класса. В этом случае
        класс-наследник может переопределять методы и свойства базового класса.
        
        Те методы и свойства, которые мы хотим сделать доступными для переопределения,
        в базовом классе помечается модификатором virtual. Такие методы и свойства называют виртуальными.

        А чтобы переопределить метод в классе-наследнике, этот метод определяется с модификатором override.
        Переопределенный метод в классе-наследнике должен иметь тот же набор параметров, что и виртуальный
        метод в базовом классе.
        */
        public override string ToString() //ИСПОЛЬЗОВАНИЕ ВИРТУАЛЬНЫХ МЕТОДОВ
            {
                return "Партия сладостей номер " + Consignment + ", выпущенная в " + Month + " месяце 2021 года.";
            }
            public abstract bool DoClone(); //ОДНОИМЕННЫЙ МЕТОД!!
        }

        /*class UserClass : BaseClone, ICloneable //ЧЕ ОТ МЕНЯ ХОТЯТ
        {
            ....
        }*/
    class Sweet : Pastry
    {
        public override bool DoClone()
        {
            return true;
        }
        public int Gram;
        public Sweet() { }
        public Sweet(int Gram, int Consignment, int Month)
        {
            this.Gram = Gram;
            this.Consignment = Consignment;
            this.Month = Month;
        }
        public override string ToString() //Во всех классах (иерархии) переопределить метод ToString(), который выводит информацию о типе объекта и его текущих значениях.
        {
            return "Партия конфет номер " + Consignment + ", выпущенная в " + Month + " месяце содержит " + Gram + " грамм.";
        }
    }

    class Cookie : Pastry
    {
        public override bool DoClone()
        {
            return true;
        }
        public int Diameter;
        public Cookie() { }
        public Cookie(int Diameter, int Consignment, int Month)
        {
            this.Diameter = Diameter;
            this.Consignment = Consignment;
            this.Month = Month;
        }
        public override string ToString()
        {
            return "Партия печенюшек диаметром " + Diameter + " см номер " + Consignment + ", выпущена в " + Month + " месяце.";
        }
    }
    class Caramel : Sweet
    {
        public override bool DoClone()
        {
            return true;
        }
        public string Color;
        public Caramel() { }
        public Caramel(int Gram, int Consignment, int Month, string Color)
        {
            this.Gram = Gram;
            this.Consignment = Consignment;
            this.Month = Month;
            this.Color = Color; //красного, синего...
        }
        public override string ToString()
        {
            return "Партия конфет " + Color + " цвета номер " + Consignment + ", выпущенная в " + Month + " месяце содержит " + Gram + " грамм.";
        }
    }
    class ChocoSweet : Sweet
    {
        public void Eat()
        {
            Console.WriteLine("Вы съели конфету");
        }
        public override bool DoClone()
        {
            return true;
        }
        public string Chocolat;
        public ChocoSweet() { }
        public ChocoSweet(int Gram, int Consignment, int Month, string Chocolat)
        {
            this.Gram = Gram;
            this.Consignment = Consignment;
            this.Month = Month;
            this.Chocolat = Chocolat; //горького, молочного...
        }
        public override string ToString()
        {
            return "Партия конфет из " + Chocolat + " шоколада номер " + Consignment + ", выпущенная в " + Month + " месяце содержит " + Gram + " грамм.";
        }
    }
    // partial
    sealed class Box : ChocoSweet //Сделайте один из классов sealed; ТРЕТЬЕ ЗАДАНИЕ
    {
        public override bool DoClone()
        {
            return false;
        }
        public int Number;
        public Box() { }
        public Box(int Number, int Gram, int Consignment, int Month, string Chocolat)
        {
            this.Number = Number;
            this.Gram = Gram;
            this.Consignment = Consignment;
            this.Month = Month;
            this.Chocolat = Chocolat;
        }
        public override string ToString()
        {
            return "Партия конфет из " + Chocolat + " шоколада номер " + Consignment + ", выпущенная в " + Month + " месяце содержит " + Gram + " грамм и упаковывается в коробки по " + Number + " конфет.";
        }
    }
    interface IClonable //ИНТЕРФЕЙС 
    {
        bool DoClone(); //ОДНОИМЕННЫЙ МЕТОД??
    }

    /*Формальным параметром метода должна быть ссылка на абстрактный класс или наиболее
    общий интерфейс в вашей иерархии классов.В методе iIAmPrinting
    определите тип объекта и вызовите ToString(). В демонстрационной
    программе создайте массив, содержащий ссылки на разнотипные объекты
    ваших классов по иерархии, а также объект класса Printer и последовательно
    вызовите его метод IAmPrinting со всеми ссылками в качестве аргументов.*/
    class Printer //дополнительный класс Printer c полиморфным методом IAmPrinting(SomeAbstractClassorInterface someobj).
    {
        public string IAmPrinting(Pastry someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Sweet someobj)
        {
            return someobj.ToString();
        }
        public string IAmPrinting(Cookie someobj)
        {
            return someobj.ToString();
        }
    }
}
