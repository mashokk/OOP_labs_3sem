//Кондитерское изделие, Конфета, Карамель, Шоколадная конфета,
//Печенюшка, Коробка конфет.
using System;
using System.Collections.Generic;

namespace OOP_Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pastry pastry = new Pastry(); //кондитерское изделие
            Sweet sweet = new Sweet(1000, 837362, 6); //int Gram, int Consignment, int Month
            Caramel caramel = new Caramel(1500, 374564, 7, "красного"); //int Gram, int Consignment, int Month, string Color
            ChocoSweet chocosweet = new ChocoSweet(2000, 792955, 8, "горького"); //int Gram, int Consignment, int Month, string Chocolat
            Cookie cookie = new Cookie(12, 385762, 9); //Diameter, int Consignment, int Month
            Box box = new Box(16, 5000, 100247, 10, "молочного"); //int Number, int Gram, int Consignment, int Month, string Chocolat

            //Console.WriteLine(pastry.ToString());
            Console.WriteLine(sweet.ToString());
            Console.WriteLine(caramel.ToString());
            Console.WriteLine(chocosweet.ToString());
            chocosweet.Eat();
            Console.WriteLine(cookie.ToString());
            Console.WriteLine(box.ToString());

            List<Pastry> list = new List<Pastry> { new Sweet(1000, 837362, 6), new Cookie(12, 385762, 9) };

            Printer printer = new Printer();
            foreach (Pastry v in list)
            {
                Console.WriteLine(printer.IAmPrinting(v));
            }

            /*Composition composition = new Composition();

            composition.cp.Add(caramel);
            composition.cp.Add(chocosweet);
            composition.cp.Add(box);
            composition.GetPastry("sweet");
            composition.GetTransport("2"); // не пашет*/
        }

        /*public partial class Composition
        {
            public List<object> cp = new System.Collections.Generic.List<object>();
            public void GetPastry(string pastr)
            {
                foreach (Pastry v in cp) { }
            }
        }
        public void GetTransport(int num)
        {
            string buf;
            for (int i = 0; i < cp.Count; i++) // ругается на cp
            {
                buf = Convert.ToString(cp[i]); // ругается на cp
                if (buf.Contains(Convert.ToString(num)))
                {
                    Console.WriteLine(buf);
                }
            }
        }*/
    }
}
