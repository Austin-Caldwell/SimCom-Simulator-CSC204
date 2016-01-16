using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly
{
    public class Assembly
    {

        public string Label { get; set; }
        public string Opcode { get; set; }
        public string Variable { get; set; }

        public Assembly(string lbl, string opc, string var)
        {
            Label = lbl;
            Opcode = opc;
            Variable = var;
        }
        
    }
}
