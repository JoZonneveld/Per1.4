using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReusablePatterns
{
    public interface Iterator<T>
    {
        Option<T> getNext();
    }

}
