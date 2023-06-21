using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Convertor.Delegate;

namespace Convertor
{
    public class BaseMethod
    {
        public static void ConverterService(double a, Delegate.Convert convertor) 
        {
            convertor(a);
        }
    }
}
