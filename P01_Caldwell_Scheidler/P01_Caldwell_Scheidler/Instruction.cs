using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly
{
    class Instruction
    {
        public int Label { get; set; }
        public int Opcode { get; set; }
        public int Variable { get; set; }

        public Instruction(int lbl, int opc, int var)
        {
            Label = lbl;
            Opcode = opc;
            Variable = var;
        }
    }
}
