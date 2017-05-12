using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNumber
{
    interface INumberVisitor
    {
        void onMyInt(MyInt i);
        void onMyFloat(MyFloat f);
    }
}
