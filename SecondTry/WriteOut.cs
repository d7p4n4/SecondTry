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
            System.IO.File.WriteAllText(Path.Combine(Environment.CurrentDirectory, fileName + ".cs"), text);
        }
    }
}
