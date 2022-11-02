using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6.Classes
{
    public static class MyClass<T>
    {
        public static T FacrotyMethod()
        {
            return Activator.CreateInstance<T>();
        }
    }
}
