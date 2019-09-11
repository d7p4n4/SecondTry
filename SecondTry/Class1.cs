using System;
using System.Collections.Generic;
using System.Text;

namespace SecondTry
{
    class Class1
    {
        private String s = "dogivm";

        public String getS()
        {
            return this.s;
        }

        public String myS
        {
            get
            {
                return s;
            }
            set
            {
                s = value;
            }
        }
    }
}
