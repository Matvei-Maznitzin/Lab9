using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalLib
{
    public class Combinative : Element
    {
        private bool[] inputs;

        public Combinative() : base("AndNot", 3, 1)
        {
            inputs = new bool[base.InCount];
        }
        public Combinative(bool[] inputs) : base("AndNot", 3, 1)
        {
            this.inputs = inputs;
        }
        public void SetInputs(bool[] inputs)
        {
            this.inputs = inputs;
        }
        public bool GetInput(int inputIndex)
        {
            return inputs[inputIndex];
        }
        public bool GetValue()
        {
            bool result = inputs[0];
            for (int i = 1; i < base.InCount; i++)
                result = (result && inputs[i]);
            return !result;
        }
    }
}
