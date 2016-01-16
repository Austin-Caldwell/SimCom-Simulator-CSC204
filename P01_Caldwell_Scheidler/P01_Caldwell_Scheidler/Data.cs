using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly
{
    class Data
    {
        public string Name { get; set; }
        public int Value { get; set; }

        public Data (string name, int val)
        {
            Name = name;
            Value = val;
        }
    }
}
