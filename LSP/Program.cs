using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LSP
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();

            Enq e = new Enq();

            List<Iy> lll = new List<Iy>();
            lll.Add(c);
            lll.Add(e);
           
        }
    }
}
