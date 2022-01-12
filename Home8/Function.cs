using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home8
{
    class Function
    {
        public int v1;
        public int v2;
        public string l1;
        public string l2;

        public Function( int value1 , string label1 , int value2 , string label2)
            {
            v1 = value1;
            v2 = value2;
            l1 = label1;
            l2 = label2;
            }
        public void TimeAdder()
        {
            if (CheckIfIsWrite(v1, l1, v2, l2))
            {
                Console.WriteLine(Adder(v1, l1, v2, l2));
            }
            else
            {
                Console.WriteLine("Wrong input!");
            }
        }

        public String Adder(int value1, string label1, int value2, string label2)
        {
            string totalTime = (value1 + value2).ToString() + " " + label1;
            return totalTime;
        }

        public bool CheckIfIsWrite(int value1, string label1, int value2, string label2)
        {
            bool final;
            if (label1 == label2 || (label1 == (label2 + "s") && value1 == 1 && value2 != 1) || ((label1 + "s") == label2 && value2 == 1 && value1 != 1))
            {
                final = true;
            }
            else
            {
                final = false;
            }

            return final;
        }
    }
}
