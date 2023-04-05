using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
         public struct HSL
    {
       
        
            private int h;
            private float s;
            private float l;

            public HSL(int h, float s, float l)
            {
                this.h = h;
                this.s = s;
                this.l = l;
            }

            public int H
            {
                get { return this.h; }
                set { this.h = value; }
            }

            public float S
            {
                get { return this.s; }
                set { this.s = value; }
            }

            public float L
            {
                get { return this.l; }
                set { this.l = value; }
            }

            public bool Equals(HSL hsl)
            {
                return (this.H == hsl.H) && (this.S == hsl.S) && (this.L == hsl.L);
            }
            public void Output()
        {
            Console.WriteLine( "H = " +  this.H + "  , S = "+  this.S + "  , L = "+ this.L);
        }
        }




    }

