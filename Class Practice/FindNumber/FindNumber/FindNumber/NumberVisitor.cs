using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumber
{
    class NumberVisitor : INumberVisitor
    {
        public void onMyInt(MyInt i)
        {
            Console.WriteLine("Found a int");
        }

        public void onMyFloat(MyFloat f)
        {
            Console.WriteLine("Found a float");
        }
    }
}
