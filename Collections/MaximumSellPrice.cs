using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    internal class MaximumSellPrice
    {
        public void FindMaxPrice(int K,List<int> A, List<int> B)
        {
            int temp = 0;
            A.Sort();
            B.Sort();
            int c = B.Count;
            for(int i=0;i<K;i++)
            {
                A[i] = B[c-1];
                c--;
            }

            int sum1=0,sum2=0;
             foreach(var item in A)
            {
               sum1 += item;
            }
            foreach (var item in B)
            {

                sum2 += item;
            }
            if(sum1 > sum2)
            {
                Console.WriteLine(sum1);
            }
            else
            {
                Console.WriteLine(sum2);
            }
        }

    }
}
