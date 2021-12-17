using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_Lab7
{
    public interface IName
    {
        string Shape { get { return Shape; } set { this.Shape = value; } }
    }

    public interface ICook
    {
        public void Cook(ICandyAssembling candyAssembling); //candy assembling - сборка конфет (для подарка)
    }

    public interface ICandyAssembling
    {
        public void StartOven(Oven oven);
        public int Gram { get; set; }
    }
}
