using System;
using System.Collections.Generic;
using System.Linq;

namespace Pandell
{
    class Program
    {
        static void Main(string[] args)
        {

            IEnumerable<int> numList = Enumerable.Range(1, 10000);

            Random rnd = new Random();

            List<int> randList = numList.Select(x => new {val = x, order = rnd.Next()}).OrderBy(x => x.order).Select(x=> x.val).ToList();

            foreach (var i in randList)
            {
                Console.WriteLine(i);
            }


        }
    }
}
