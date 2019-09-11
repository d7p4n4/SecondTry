using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace SecondTry
{
    class ReadIn
    {
        public static string[] readIn(string fileName)
        {

            string textFile = Path.Combine(Environment.CurrentDirectory, fileName + ".java");

            string[] text = File.ReadAllLines(textFile);

            return text;
        }
    }
}
