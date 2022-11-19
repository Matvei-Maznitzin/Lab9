using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalLib
{
    public class Memory : Element
    {
        private bool[] inputs;
        private bool outValue;
        private bool notOutValue;

        public Memory()
        {
            inputs = new bool[3];
            outValue = false;
            notOutValue = false;
        }

        public Memory(Memory memory) : base("Memory", 3, 1)
        {
            memory.outValue = outValue;
            memory.inputs.CopyTo(inputs, 0);
            memory.notOutValue = notOutValue;
        }

        public void SetInputs(bool[] inputs)
        {
            this.inputs.CopyTo(inputs, 0);
        }

        public bool GetInput(int inputIndex)
        {
            return inputs[inputIndex];
        }

        public bool GetValue()
        {
            // TODO: Переделать
            bool result = inputs[0];
            for (int i = 1; i < base.InCount; i++)
                result = (result && inputs[i]);
            return !result;
        }

        public bool GetOut()
        {
            return this.outValue;
        }

        public bool GetNotOut()
        {
            return this.notOutValue;
        }

        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;
            Memory other = obj as Memory;
            return other != null && outValue == other.outValue && notOutValue == other.notOutValue && inputs.Equals(other.inputs);
        }

        public static bool operator ==(Memory m1, Memory m2)
        {
            return m1.Equals(m2);
        }

        public static bool operator !=(Memory m1, Memory m2)
        {
            return !(m1 == m2);
        }
    }
}
