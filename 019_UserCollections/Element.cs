using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _019_UserCollections
{
    class Element
    {
        public string Name { get; set; }
        public int Field1 { get; set; }
        public int Field2 { get; set; }

        public Element(string name, int field1, int field2)
        {
            this.Name = name;
            this.Field1 = field1;
            this.Field2 = field2;
        }

        public override string ToString()
        {
            return $"Element(Name: {Name}, Field1: {Field1}, Field2: {Field2})";
        }
    }

}