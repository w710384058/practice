using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kimmy
{
    internal class Person
    {
        private string _name;
        private int _age;

        public string Name
        {
            get { return _name; }
        }

        public int Age
        {
            get { return _age; }
        }

        public Person(string name, int age)
        {
            _name = name ?? ""; //A ?? B =「A 有值就用 A，沒有就用 B」
            _age = age;
        }
    }
}
