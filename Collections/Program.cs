
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Console.WriteLine("Enter the Total Number of Chapter");
            // int N= Convert.ToInt32(Console.ReadLine());
            // Dictionary<int, int> dict = new Dictionary<int, int>(N);
            // dict.Add(1, 4);
            // dict.Add(5, 7);
            // dict.Add(9, 16);
            // dict.Add(17, 26);
            // Console.WriteLine("Enter current reading page");
            // int K = Convert.ToInt32(Console.ReadLine());
            // CountOfRemainingChapter remainingChapter = new CountOfRemainingChapter();
            //int result = remainingChapter.CalaculateCount(N, dict, K);
            // Console.WriteLine("Remaining Chapter count is : " + result);
            Console.WriteLine("Enter the fruits in bucket");
            int N = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter current reading page");
            int K = Convert.ToInt32(Console.ReadLine());
            List<int> A = new List<int>(N);
            List<int> B = new List<int>(N);
            A.Add(2);
            A.Add(3);
            A.Add(2);
            A.Add(4);
            B.Add(2);
            B.Add(4);
            B.Add(2);
            B.Add(3);
            MaximumSellPrice maximumSellPrice = new MaximumSellPrice();
            maximumSellPrice.FindMaxPrice(K,A,B);
        }

    }
}
