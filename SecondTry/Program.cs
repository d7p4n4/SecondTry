using System;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;

namespace SecondTry
{
    class Program
    {
        static void Main(string[] args)
        {
            var map = new Dictionary<string, string>();
            map.Add("name", "String");
            map.Add("guid", "String");
            map.Add("newProperty", "int");

            string[] text = ReadIn.readIn("Template");
            int x = text.Length;

            WriteOut.writeOut(Generate.generateClass(text, "com.d7p4n4", "Person", map, x), "Person3");
            
            Type g = typeof(Generate);

            PropertyInfo[] props = g.GetProperties(BindingFlags.Instance | BindingFlags.Public);

            for (int i = 0; i < props.Length; i++)
            {
                string name = props[i].Name;
                Console.WriteLine("Type: {0}", props[i].PropertyType + ", Name: " + Char.ToLower(name[0]) + name.Substring(1));
            }

            MyAttribute.AttributeDisplay(typeof(Generate));
            
        }
    }
}
