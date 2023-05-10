using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3HW4
{
    internal class Task1
    {
        public Task1()
        {
            this.Sum1 += Sum;
            this.Sum1 += Sum;
        }

        public delegate int GetSum(int x, int y);
        public event GetSum Sum1;

        public int Sum(int x, int y)
        {
            return x + y;
        }

        public void Summing()
        {
            var invocationlist = Sum1.GetInvocationList();
            var sum = 0;
            foreach (var item in invocationlist)
            {
                var temp = item.DynamicInvoke(10, 20);
                sum += Convert.ToInt32(temp);
            }

            Console.WriteLine(sum);
        }

        public void CoverSumming(Action act)
        {
            try
            {
                act.Invoke();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
