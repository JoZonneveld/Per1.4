using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumber
{
    class MyFloat : INumber
    {
        public void visit(INumberVisitor visitor)
        {
            visitor.onMyFloat(this);
        }
        
    }
}
