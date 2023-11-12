using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fussballmanschaft_solution
{
    public class Result
    {
        private readonly int toreA, toreB;

        public Result(int a, int b)
        {
            this.toreA = a;
            this.toreB = b;
        }

        public string ToString()
        {
            return $"{toreA} : {toreB}";
        }
    }
}
