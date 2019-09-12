
using System;

namespace SecondTry
{
	class Person 
	{
    		private String name;
    		private String guid;
    		private int newProperty;

		public Person(){}
    
		public String getname() {
        		return name;
        }

		public String getguid() {
        		return guid;
        }

		public int getnewProperty() {
        		return newProperty;
        }


    		public void setname(String newValue) {
        		name = newValue;
        }

    		public void setguid(String newValue) {
        		guid = newValue;
        }

    		public void setnewProperty(int newValue) {
        		newProperty = newValue;
        }

	}
}