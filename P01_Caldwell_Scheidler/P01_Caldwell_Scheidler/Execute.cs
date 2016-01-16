using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assembly
{
    public class Execute
    {

        public void Main(ref int[] mem, int x, ref int instruct_val, ref int r, ref bool gt, ref bool lt, ref bool eq)
        {
            switch (instruct_val)
            {
                case 0:
                    Load(mem, x, ref r);
                    break;
                case 1:
                    Store(ref mem, x, r);
                    break;
                case 2:
                    Clear(ref mem, x);
                    break;
                case 3:
                    Add(mem, x, ref r);
                    break;
                case 4:
                    Increment(ref mem, x);
                    break;
                case 5:
                    Subtract(mem, x, ref r);
                    break;
                case 6:
                    Decrement(ref mem, x);
                    break;
                case 7:
                    Compare(mem, x, r, ref gt, ref lt, ref eq)
                    break;
                case 8:
                    Jump(x, ref instruct_val);
                    break;
                case 9:
                    JumpGT(x, ref instruct_val, gt);
                    break;
                case 10:
                    JumpEQ(x, ref instruct_val, eq);
                    break;
                case 11:
                    JumpLT(x, ref instruct_val, lt);
                    break;
                case 12:
                    JumpNEQ(x, ref instruct_val, eq);
                    break;
                case 13:
                    In(ref mem, x);
                    break;
                case 14:
                    Out(mem, x);
                    break;
                case 15:
                    Halt();
                    break;
            }
        }

        //move value at memory location x into r
        private void Load(int[] mem, int x, ref int r)
        {
            r = mem[x];
            return;
        }

        //store the value r in memory location x
        private void Store(ref int[] mem, int x, int r)
        {
            mem[x] = r;
            return; 
        }

        //set memory location x to 0
        private void Clear(ref int[] mem, int x)
        {
            mem[x] = 0;
            return;
        }

        //add r to value at memory location x and save in r
        private void Add(int[] mem, int x, ref int r)
        {
            r += mem[x];
            return;
        }

        //increment the value at memory location x
        private void Increment(ref int[] mem, int x)
        {
            mem[x]++;
            return;
        }

        //subtract the value at memory location x from r and store in r
        private void Subtract(int[] mem, int x, ref int r)
        {
            r -= mem[x];
            return;
        }

        //decrement the value at memory location x
        private void Decrement(ref int[] mem, int x)
        {
            mem[x]--;
            return;
        }

        //compare the value ant memory location x to r and set appropriet flags
        private void Compare(int[] mem, int x, int r, ref bool gt, ref bool lt, ref bool eq)
        {
            gt = false; //greater than
            lt = false; //less than
            eq = false; //equal to

            if (mem[x] > r)
                gt = true;
            else if (mem[x] < r)
                lt = true;
            else
                eq = true;

            return;
        }

        //jump to instruction x
        private void Jump(int x, ref int instrut_val)
        {
            instrut_val = x;
            return;
        }

        //jump to instruction x if gt == 1
        private void JumpGT(int x, ref int instruct_val, bool gt)
        {
            if (gt)
                instruct_val = x;

            return;
        }

        //jump to instruction x if eq == 1
        private void JumpEQ(int x, ref int instruct_val, bool eq)
        {
            if (eq)
                instruct_val = x;

            return;
        }

        //jump to instruction x if lt == 1
        private void JumpLT(int x, ref int instruct_val, bool lt)
        {
            if (lt)
                instruct_val = x;

            return;
        }

        //jump to instruction x if eq != 1
        private void JumpNEQ(int x, ref int instruct_val, bool eq)
        {
            if (!eq)
                instruct_val = x;

            return;
        }

        //take input from user and store in memory location x
        private void In(ref int[] mem, int x)
        {
            string fall = "123";
            if (Int32.TryParse(fall, out mem[x]))
                return;
            else
            {
                return;
            }
        }

        //output a value from memory location x to user
        private void Out(int[] mem, int x)
        {
            outputbox.Value = mem[x].ToString;
        }

        //end program
        private void Halt()
        {
        }
    }
}
