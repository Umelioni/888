using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime;

namespace Tasks.First
{
    public class Book : Object
    {

    }
    public class Object
    {
        readonly static Dictionary<Type, ConsoleColor> colors = new Dictionary<Type, ConsoleColor>();
        Random random = new Random();
        public void DebugValues(params object[] objs)
        {
            Debug.Indent();
            foreach (var obj in objs)
            {
                Debug.WriteLine(obj);
                if (this.GetType().IsSubclassOf(typeof(Object)))
                {
                    Type thisType = obj.GetType();
                    ConsoleColor consoleColor;
                    int typecode = (int)Type.GetTypeCode(thisType);
                    var enum_ConsoleColors = (ConsoleColor[])Enum.GetValues(typeof(ConsoleColor));
                    if (typecode != 1)
                    {
                       
                        int lastcolorIndex = (int)enum_ConsoleColors[enum_ConsoleColors.Length - 1];
                        if (typecode > lastcolorIndex) typecode -= lastcolorIndex;
                        consoleColor = (ConsoleColor)typecode;
                    } else {
                        if (!colors.ContainsKey(thisType))
                            colors[thisType] = enum_ConsoleColors[random.Next(2, enum_ConsoleColors.Length - 1)];
                        consoleColor = colors[thisType];
                    }
                     Console.ForegroundColor = consoleColor;
                    Console.Write($"({thisType.FullName}) ");
                    Console.ResetColor();
                    Console.WriteLine($"{obj.ToString()}");
                }
            }
            
            Debug.Unindent();
        }
    }
}
