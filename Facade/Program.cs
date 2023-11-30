using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class Program
    {
        public static void Main()
        {
            Facade _facade = new Facade(new DVD(), new TV(), new Audio());
            _facade.On();
            _facade.Off();
        }
    }
}
