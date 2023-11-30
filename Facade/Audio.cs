﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Audio
    {
        public void On()
        {
            Console.WriteLine("Аудио включено");
        }

        public void Off()
        {
            Console.WriteLine("Аудио выключено");
        }
    }
}
