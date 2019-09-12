using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;


namespace SecondTry
{
    [AttributeUsage(AttributeTargets.Method)]
    class MyAttribute : Attribute
    {
        public string someProp { get; set; }
        public string elseProp { get; set; }

        public MyAttribute(string t, string d)
        {
            someProp = t;
            elseProp = d;
        }

        public static void AttributeDisplay(Type classType)
        {
            Console.WriteLine("Methods of class {0}", classType.Name);

            MethodInfo[] methods = classType.GetMethods();

            for(int i = 0; i < methods.Length; i++)
            {
                Object[] attributesArray = methods[i].GetCustomAttributes(true);

                foreach (Attribute item in attributesArray)
                {
                    if (item is MyAttribute)
                    {

                        // Display the fields of the NewAttribute 
                        MyAttribute attributeObject = (MyAttribute)item;
                        Console.WriteLine("{0} - {1}, {2} ", methods[i].Name,
                         attributeObject.someProp, attributeObject.elseProp);
                    }
                }
            }
        }
    }
}
