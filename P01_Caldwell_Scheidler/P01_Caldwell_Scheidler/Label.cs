using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly
{
    class Label
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Label(string name, int val)
        {
            Name = name;
            Value = val;
        }
    }
}
