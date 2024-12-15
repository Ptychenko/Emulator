﻿using IKM724NetBasics.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IKM724NetBasics.Entities.Systems
{
    public class AerationSystem : IControllable
    {
        public bool IsOn { get; private set; }

        public void TurnOn()
        {
            IsOn = true;
            Console.WriteLine("Aeration system turned on.");
        }
        public void TurnOff()
        {
            IsOn = false;
            Console.WriteLine("Aeration system turned off.");
        }
    }
}
