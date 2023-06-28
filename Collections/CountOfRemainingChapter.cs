using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class CountOfRemainingChapter
    {
        public int CalaculateCount(int N,Dictionary<int,int> dict,int K)
        {
            int count = 0;
            foreach(var item in dict)
            {
                if (item.Value>=K)
                {
                    count++;
                }
          
            }
            return count;
           
        }
    }
}
