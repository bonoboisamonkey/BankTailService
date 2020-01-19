using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankService
{
    class generateCheck
    {
        private static Dictionary<string, int> check;
        private static Queue<string> tail;

        static generateCheck()
        {
            check = new Dictionary<string, int>();
            tail = new Queue<string>();
        }

        public string createCheck(string key)
        {
            if (check.ContainsKey(key))
            {
                int num = check[key];
                num++;
                check[key] = num;
            }
            else
            {
                check.Add(key, 1);
            }
            string result=$"{key}{check[key]}";
            tail.Enqueue(result);
            return result;
        }

        public string deleteCheck()
        {
            if (tail.Count == 0)
                return "No other customer";
            string result = tail.Peek();
            tail.Dequeue();

            return result;
        }
    }
    
}
