using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Person
    {
        private string name;
        private string address;

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        public Person()
        {
        }

        public string GetName()
        {
            return name;
        }
        public string GetAddress()
        {
            return address;
        }
        public void setAddress(string address)
        {
            this.address = address;
        }
        public string toStrin()
        {
            return name +" "+ address;
        }
    }
}
