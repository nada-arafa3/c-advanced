using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__advanced
{
    public class BubbleSort <t> where t : IComparable
    {
        public static void Sort(t[] Arr) {
            for (int i = 0; i < Arr.Length; i++)
            {
                bool flag=false;
                for (int j = 0; j < Arr.Length-i-1; j++) {
                    
                    if (Arr[j].CompareTo(Arr[j+1])==1)
                    {
                         t temp = Arr[j];
                        Arr[j + 1] = temp;
                        flag = true;

                    }
                
                }
                if (!flag) {
                    break;

                }

            }
        
        }
    }
}
