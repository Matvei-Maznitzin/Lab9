using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalLib
{
    public class Register
    {
        private Memory[] data;
        private bool[,] inputs;
        private bool set;
        private bool reset;
        public Register()
        {
            data = new Memory[12];
            inputs = new bool[12, 3];
        }
    }
}
