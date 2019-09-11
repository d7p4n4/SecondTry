using System;
using System.IO;
using System.Collections.Generic;


namespace SecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new Dictionary<string, string>();
            map.Add("name", "String");
            map.Add("guid", "String");

            string[] text = ReadIn.readIn("Template");
            int x = text.Length;

            WriteOut.writeOut(Generate.generateClass(text, "com.d7p4n4", "Person", map, x), "Person3");

            
            
        }
    }
}
