using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tasks.Second
{
    public class A : Tasks.First.Object
    {
        public A(params B[] b_classes)
        {
            foreach (var b in b_classes)
            {
                Console.WriteLine($"class {b.GetType().Name}: ");
                var flag = (System.Reflection.BindingFlags)(-1);
                var methods = b.GetType().GetMethods(flag);
                var properties = b.GetType().GetProperties(flag);
                var fields = b.GetType().GetFields(flag);
                DebugValues(methods);
                DebugValues(properties);
                DebugValues(fields);
            }
        }
    }


    public class B
    {
        byte f_A;
        public virtual void Print() => Console.WriteLine("Бип");
    }
    public class C : B
    {
        byte f_A;
        byte f_B;
        public override void Print()
        {
            Console.WriteLine("Я наследующий, я Cи");
        }
    }
    public class D : B
    {
        byte f_A;
        byte f_B;
        
        byte C { get; set; }


        public override void Print()
        {
            Console.WriteLine("Я просто Ди от Би на 2");
        }
    }
    public class E : B
    {
        byte f_A;
        byte f_B;

        byte C { get; set; }

        void D() 
        {

        }


        public override void Print()
        {
            Console.WriteLine("Я И, я после Ди, похож на Би");
        }
    }
}
