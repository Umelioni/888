using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tasks.First;
using Tasks.Second;
using Tasks.Third;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
            Debug.AutoFlush = true;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[-- 1th task --]");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-- class Object --");
            Console.ResetColor();
            var obj = new Tasks.First.Object();
            obj.DebugValues("Я обьект", obj);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-- class Book : Object --");
            Console.ResetColor();
            var book = new Book();
            book.DebugValues("Цветы жизни", 4, 435.0f, book);


            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[-- 2th task --]");
            Console.ResetColor();
            new A(new B(), new C(), new D(), new E());

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[-- 3th task --]");
            Console.ResetColor();

            new Chichen("Chicka");
            new Duck("Mac");


            Console.ReadKey();
        }
    }
}
