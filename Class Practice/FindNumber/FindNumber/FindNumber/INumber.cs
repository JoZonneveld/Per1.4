using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumber
{
    interface INumber<M>
    {
        M visit(INumberVisitor visitor);
    }
}
