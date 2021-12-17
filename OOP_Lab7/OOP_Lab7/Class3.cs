using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace OOP_Lab7
{
    public class MyException : System.Exception
    {
        public string ErrorClass { get; set; }
        public MyException(string message, string errorClass) : base(message) //наследуем message от System.Exception
        {
            this.ErrorClass = errorClass;
        }
    }
    public class WeightException : MyException
    {
        public int Kilo { get; set; }
        public int Gramm { get; set; }
        public WeightException(string message, int errorKilo, int errorGramm) : base(message, "Ошибка код 1: некорректный вес!\n") //наследуем message и errorClass от MyException
        {
            this.Kilo = errorKilo;
            this.Gramm = errorGramm;
        }
    }
    public class GramException : MyException
    {
        public int Gram { get; set; }
        public GramException(string message, int errorGram) : base(message, "Ошибка код 2: неккоректная граммовка!\n")
        {
            this.Gram = errorGram;
        }
    }
    public class SearchGramException : MyException
    {
        public int Gram { get; set; }
        public SearchGramException(string message, int errorGram) : base(message, "Ошибка код 3: некорректный ввод граммовки для поиска!\n")
        {
            this.Gram = errorGram;
        }
    }
    public class ShapeException : MyException
    {
        public int Shape { get; set; }
        public ShapeException(string message, int errorShape) : base(message, "Ошибка код 4: некорректное имя!\n")
        {
            this.Shape = errorShape;
        }
    }
    public class FileLogger
    {
        public FileLogger() { }
        public void WriteLog(MyException exception)
        {
            WeightException WeightEx = exception as WeightException;
            GramException GramEx = exception as GramException;
            SearchGramException SearchEx = exception as SearchGramException;
            ShapeException ShapeEx = exception as ShapeException;

            //string filePath = ;
        }
    }
    public class ConsoleLogger
    {
        public ConsoleLogger() { }
        public void WriteLog(MyException exception)
        {
            WeightException WeightEx = exception as WeightException;
            GramException GramEx = exception as GramException;
            SearchGramException SearchEx = exception as SearchGramException;
            ShapeException ShapeEx = exception as ShapeException;
        }
    }
}
