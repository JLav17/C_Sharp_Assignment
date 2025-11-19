using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributesTrial
{
    internal class UsingCustomAttribute
    {

        [Custom("Ritik","1.1")]
        public void product(int a , int b)
        {
            Console.WriteLine(a * b);
        }
    }
}
