using System;
using System.IO;
using System.Collections.Generic;


namespace SecondTry
{
    class Program
    {
        static readonly string textFile = @"D:\Server\Person.java";
        static void Main(string[] args)
        {
            var map = new Dictionary<string, string>();
            map.Add("name", "String");
            map.Add("guid", "String");

            string replaced = "";

            string[] text = File.ReadAllLines(textFile);
            int x = text.Length;

            for (int i = 0; i < x; i++)
            {
                if (text[i].Equals("#properties#"))
                {
                    foreach (var pair in map)
                    {
                        string newLine = text[i + 1].Replace("#type#", pair.Value);
                        newLine = newLine.Replace("#prop#", pair.Key);

                        replaced = replaced + "\n" + newLine;
                    }
                    i++;
                }
                else if (text[i].Equals("#getter#"))
                {
                    foreach (var pair in map)
                    {
                        string newLine = text[i + 1].Replace("#type#", pair.Value);
                        newLine = newLine.Replace("#getProp#", "get" + pair.Key);

                        replaced = replaced + "\n" + newLine;

                        newLine = text[i + 2].Replace("#prop#", pair.Key);
                        replaced = replaced + "\n" + newLine + "\n    }\n";
                    }
                    i = i + 3;
                }
                else if (text[i].Equals("#setter#"))
                {
                    foreach (var pair in map)
                    {
                        string newLine = text[i + 1].Replace("#type#", pair.Value);
                        newLine = newLine.Replace("#setProp#", "set" + pair.Key);
                        newLine = newLine.Replace("#type#", pair.Value);
                        newLine = newLine.Replace("#prop#", pair.Key);

                        replaced = replaced + "\n" + newLine;

                        newLine = text[i + 2].Replace("#prop#", pair.Key);
                        replaced = replaced + "\n" + newLine + "\n    }\n";
                    }
                    i = i + 3;
                }
                else
                {
                    replaced = replaced + "\n" + text[i];
                }
            }
            replaced = replaced.Replace("#packageName#", "com.d7p4n4");
            replaced = replaced.Replace("#className#", "Person");

            Console.WriteLine(replaced);
            
        }
    }
}
