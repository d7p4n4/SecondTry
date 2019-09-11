using System;
using System.Collections.Generic;
using System.Text;

namespace SecondTry
{
    class Generate
    {
        public static string generateClass(string[] text, string package, string className, Dictionary<string, string> map, int x)
        {
            string replaced = "";

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
            replaced = replaced.Replace("#packageName#", package);
            replaced = replaced.Replace("#className#", className);

            return replaced;
        }
    }
}
