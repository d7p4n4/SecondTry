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
            using (StreamWriter writer = new StreamWriter(Path.Combine(Environment.CurrentDirectory, fileName + ".java"), true))
            {
                writer.Write(text);
            }
        }
    }
}
