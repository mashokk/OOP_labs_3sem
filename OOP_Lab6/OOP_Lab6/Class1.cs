using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab6
{
    public abstract class TastyTreat : IName
    {
        public string Shape { get; set; }
        public Weight Weight;
    }

    public class Sweet : TastyTreat, ICook
    {
        public string Type { get; set; }

        public Sweet(string shape, string type, Weight weight)
        {
            this.Shape = shape;
            this.Type = type;
            this.Weight = weight;
        }

        public override string ToString()
        {
            return "Тип объекта: " + GetType().Name + "\nФорма: " + Shape + "\nТип: " + Type + "\nВес: " + Weight.Kilo + " кг " + Weight.Gramm + " г\n" + new String('-', 50);
        }

        public void Cook(ICandyAssembling candyAssembling)
        {
            candyAssembling.StartOven(new Oven());
        }
    }


    public class Cookie : TastyTreat, ICandyAssembling
    {
        public string Composition { get; set; }
        public int Gram { get; set; }
        public Cookie(string shape, string composition, Weight weight, int gram)
        {
            this.Shape = shape;
            this.Composition = composition; //состав
            this.Weight = weight;
            this.Gram = gram;
        }

        public override string ToString()
        {
            return "Тип объекта: " + GetType().Name + "\nФорма: " + Shape + "\nСостав: " + Composition + "\nВес: " + Weight.Kilo + " кг " + Weight.Gramm + " г\nГраммовка: " + Gram + "\n" + new String('-', 50);
        }
        public void StartOven(Oven oven)
        {
            if (oven.TryCooking())
                Console.WriteLine("Печеньки испеклись.");
            else Console.WriteLine("Печеньки не испеклись - сломалась духовка :(");
        }

    }


    public abstract class Pastry : ICandyAssembling, IName
    {
        public int Nuts { get; set; }
        public int Gram { get; set; }

        public virtual void StartOven(Oven oven)
        {
            if (oven.TryCooking())
                Console.WriteLine("Духовка включена!");
            else Console.WriteLine("Духовка вмэрла, сегодня без сладостей.");
        }
        public override bool Equals(object obj)
        {
            if (obj is Pastry && obj != null)
            {
                return this.GetType() == obj.GetType();
            }
            return false;
        }

        public override int GetHashCode()
        {
            return 10654;
        }
    }


    public class Candy : Pastry, IName
    {
        public string Shape { get; set; }

        public Candy(string shape, int gram)
        {
            this.Nuts = 5;
            this.Shape = shape;
            this.Gram = gram;
        }

        public override void StartOven(Oven oven) //запуск духовки
        {
            if (oven.TryCooking())
                Console.WriteLine("Духовка заработала, можно печь вкусняхи.");
            else Console.WriteLine("Духовка вмэрла, ближайшее время сидите на диете.");
        }

        public override string ToString()
        {
            return "Тип объекта: " + GetType().Name + "\nФорма: " + Shape + "\nГраммовка: " + Gram + "\nКоличество орешков: " + Nuts + "\n" + new String('-', 50);
        }
    }


    public class Caramel : Pastry, IName
    {
        public string Shape { get; set; }

        public Caramel(string shape, int gram)
        {
            this.Nuts = 2;
            this.Shape = shape;
            this.Gram = gram;
        }
        public override void StartOven(Oven oven)
        {
            if (oven.TryCooking())
                Console.WriteLine("Карамель нагрелась и скоро будет конфэта");
            else Console.WriteLine("Духовка сгорела, карамели не будет.");
        }
        public override string ToString()
        {
            return "Тип объекта: " + GetType().Name + "\nФорма карамели: " + Shape + "\nГраммовка: " + Gram + "\nКоличество орешков: " + Nuts + "\n" + new String('-', 50);
        }
    }


    public class Gummy : Candy, IName
    {
        public string Company { get; set; }
        public Gummy(string shape, int gram, string company) : base(shape, gram)
        {
            this.Nuts = 2;
            this.Company = company;
        }
    }


    public class Printer
    {
        public string IAmPrinting(Pastry obj)
        {
            if (obj is Candy)
            {
                Candy c = (Candy)obj;
                return "Тип объекта: " + c.GetType().Name + "\nФорма конфеты: " + c.Shape + "\nГраммовка: " + c.Gram + "\nКоличество орешков: " + c.Nuts + "\n" + new String('-', 50);
            }
            if (obj is Caramel)
            {
                Caramel t = (Caramel)obj;
                return "Тип объекта: " + t.GetType().Name + "\nФорма карамельки: " + t.Shape + "\nГраммовка: " + t.Gram + "\nКоличество орешков: " + t.Nuts + "\n" + new String('-', 50);
            }
            if (obj is Gummy)
            {
                Gummy b = (Gummy)obj;
                return "Тип объекта: " + b.GetType().Name + "\nФорма мармеладки: " + b.Shape + "\nГраммовка: " + b.Gram + "\nКоличество орешков: " + b.Nuts + "\n" + new String('-', 50);
            }
            return "Объект не соответствует необходимому типу объекта.";
        }
    }


    public class Oven //духовка
    {
        public bool TryCooking()
        {
            var rand = new Random();
            bool result = rand.Next(2) == 1;
            Console.WriteLine("Попытка завести двигатель: " + result);
            return result;
        }
    }
}
