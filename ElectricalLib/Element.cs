using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectricalLib
{
    public abstract class Element
    {
        private string name;
        private int inCount;
        private int outCount;
        public Element()
        {

        }
        public Element(string name, int inCount, int outCount)
        {
            this.name = name;
            this.OutCount = outCount;
            this.InCount = inCount;
        }
        public Element(string name) : this(name, 1, 1) { }

        public string Name
        {
            get => name;
        }
        public int InCount { get => inCount; set => inCount = value; }
        public int OutCount { get => outCount; set => outCount = value; }
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
                return false;
            Element other = obj as Element;
            return other != null && this.Name == other.Name &&
                this.InCount == other.inCount && this.OutCount == other.outCount;
        }
    }
}
