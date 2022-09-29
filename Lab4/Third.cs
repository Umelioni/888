using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;


namespace Tasks.Third
{
    public class Bird
    {
        public string name = "Carl";
        public Bird(string name)
        {
            this.name = name;
            OutputInfo();
        }
        public void OutputInfo()
        {
            Debug.Indent();
            Debug.WriteLine($"[{this.GetType().FullName}] field Name, value {name}");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($"[{this.GetType().FullName}] ");
            Console.ResetColor();
            Console.WriteLine($"field Name, value {name}");
            Debug.Unindent();
        }
    }

    public class Chichen : Bird
    {
        public Chichen(string name) : base(name) { }
    }
    public class Duck : Bird
    {
        public Duck(string name) : base(name) { }
    }



}
