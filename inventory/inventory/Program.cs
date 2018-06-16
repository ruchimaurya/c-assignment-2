using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory
{
    class Program
    {
        static void Main(string[] args)
        {
            int tot = 0, cnt = 0;
            List<string> veglist = new List<string>();
            veglist.Add("Tomato");
            veglist.Add("Potato");
            veglist.Add("ToMato");
            veglist.Add("Potato");
            veglist.Add("Red Tomato");
            veglist.Add("Tomato  Catchup");
            veglist.Add("Grapes");
            veglist.Add("grapes");
            veglist.Add("potato");

            foreach (string str in veglist)
            {
                int ind = str.IndexOf("tomato", StringComparison.InvariantCultureIgnoreCase);

                if (ind >= 0)
                    tot = tot + 1;

                if (str.Equals("tomato", StringComparison.CurrentCultureIgnoreCase))
                {
                    cnt += 1;
                }
            }

            Console.WriteLine("total string contains tomato : " + tot);
            Console.WriteLine("types of string tomato : " + cnt);

            foreach (var j in veglist)
            {
                if (j.Contains("Potato"))
                {
                    Console.WriteLine("index of Potato : {0} ", veglist.IndexOf(j));
                }

            }

            Console.Read();
        }
    }
}
