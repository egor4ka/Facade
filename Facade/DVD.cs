using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class DVD
    {
        public void In()
        {
            Console.WriteLine("Диск вставлен");
        }

        public void Out()
        {
            Console.WriteLine("Диск извлечен");
        }

        public void Play()
        {
            Console.WriteLine("Диск проигрывается");
        }
    }
}
