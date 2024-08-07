using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTask
{
    internal class ClsCalculator
    {
        static public bool AreEqual<T>(T x , T y)
        {
            return EqualityComparer<T>.Default.Equals(x, y); 
        }
    }
}
