using FindNumber;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumber
{
    class MyInt : INumber
    {
        public void visit<T>(INumberVisitor visitor)
        {
            visitor.onMyInt(this);
        }
    }
}
