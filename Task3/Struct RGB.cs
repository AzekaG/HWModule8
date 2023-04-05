using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    public struct RGB
    {
        private byte r;
        private byte g;
        private byte b;

        public RGB(byte r, byte g, byte b)
        {
            this.r = r;
            this.g = g;
            this.b = b;
        }

        public byte R
        {
            get { return this.r; }
            set { this.r = value; }
        }

        public byte G
        {
            get { return this.g; }
            set { this.g = value; }
        }

        public byte B
        {
            get { return this.b; }
            set { this.b = value; }
        }

        public bool Equals(RGB rgb)
        {
            return (this.R == rgb.R) && (this.G == rgb.G) && (this.B == rgb.B);
        }
    }
}
