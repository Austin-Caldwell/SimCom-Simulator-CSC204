// CSC 204 P01 - Austin Caldwell and Joshua Scheidler - 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Caldwell_Scheidler
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
