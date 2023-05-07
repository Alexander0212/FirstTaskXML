using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace XML_перше_знайомство
{
    internal class Employee
    {
        public string Name { get; private set; }
        public int Age { get; private set; }
        public bool Programmer { get; private set; }
        public Employee(string name, int age, bool programmer)
        {
        Name = name;
        Age = age;
        Programmer = programmer;
        }
        public override string ToString()
        {
            return Name;
        }
    }
  


}
