// CSC 204 P01 - Austin Caldwell and Joshua Scheidler - 2016
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_Caldwell_Scheidler
{
    class Convert
    {
        public int Label(int line_num)
        {
            return line_num;
        }

        public int Opcode(string opc)
        {
            opc = opc.ToUpper();

            if (opc == "LOAD")
            { return 0; }
            else if (opc == "STORE")
            { return 1; }
            else if (opc == "CLEAR")
            { return 2; }
            else if (opc == "ADD")
            { return 3; }
            else if (opc == "INCREMENT")
            { return 4; }
            else if (opc == "SUBTRACT")
            { return 5; }
            else if (opc == "DECREMENT")
            { return 6; }
            else if (opc == "COMPARE")
            { return 7; }
            else if (opc == "JUMP")
            { return 8; }
            else if (opc == "JUMPGT")
            { return 9; }
            else if (opc == "JUMPEQ")
            { return 10; }
            else if (opc == "JUMPLT")
            { return 11; }
            else if (opc == "JUMPNEQ")
            { return 12; }
            else if (opc == "IN")
            { return 13; }
            else if (opc == "OUT")
            { return 14; }
            else if (opc == "HALT")
            { return 15; }
            else
            { return 16; }
        }

        public int Variable(List<Data> data_list, List<Label> label_list, Assembly assem)
        {
            foreach(Data d in data_list)
            {
                if (assem.Variable.ToUpper() == d.Name.ToUpper())
                { return d.Value; }
            }
            foreach (Label l in label_list)
            {
                if (assem.Variable.ToUpper() == l.Name.ToUpper())
                { return l.Value; }
            }

            return -1;
        }
    }
}
