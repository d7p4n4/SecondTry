using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SecondTry
{
    class WriteOut
    {
        public static void writeOut(string text, string fileName)
        {
            System.IO.File.WriteAllText(Path.Combine(Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName, fileName + ".cs"), text);
        }
    }
}
