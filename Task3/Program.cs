using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Task3
{
    /*Создайте структуру «RGB цвет». Определите внутри
неё необходимые поля и методы. Реализуйте следующую
функциональность:
■ Перевод в HEX формат;
■ Перевод в HSL;
■ Перевод в CMYK.*/
    internal class Program
    {



        static void Main(string[] args)
        {
            RGB data = new RGB(255, 255, 255);
            CMYK value = RGBToCMYK(data);
            value.Output();
            HSL val = RGBToHSL(data);
            val.Output();
            string RGBinHex = RGBToHEx(data);
            Console.WriteLine(RGBinHex);
            Console.WriteLine();

            
            Console.WriteLine("Enter a new RGB color : ");
            Console.WriteLine("Enter R (diapason from 0 to 255)");
            Byte r = Byte.Parse( Console.ReadLine() );
            Console.WriteLine("Enter G (diapason from 0 to 255)");
            Byte g = Byte.Parse( Console.ReadLine() ) ;
            Console.WriteLine("Enter B (diapason from 0 to 255");
            Byte b = Byte.Parse(Console.ReadLine());
            data = new RGB(r,g,b);
            value = RGBToCMYK(data);
            Console.WriteLine("RGB to CMYK : ");
            value.Output();
            Console.WriteLine();
            Console.WriteLine("RGB to HSL : ");
            val = RGBToHSL(data);
            val.Output() ;
            RGBinHex = RGBToHEx(data);
            Console.WriteLine() ;
            Console.WriteLine("RGB to Hex  ");
            Console.WriteLine(RGBinHex);

        }



      

        public static string RGBToHEx(RGB rgb)
        {
            string res = ToHexValue(rgb.R);
            res += ToHexValue(rgb.G);
            res += ToHexValue(rgb.B);
            return res;

         
        }

         static  public string ToHexValue(int Value)
        {

            {
                int temp = Value;
                string res = "";

                do
                {
                    if (temp % 16 < 10) { res += (temp % 16).ToString(); temp /= 16; }

                    if (temp % 16 == 10) { res += "A"; temp /= 16; }
                    if (temp % 16 == 11) { res += "B"; temp /= 16; }

                    if (temp % 16 == 12) { res += "C"; temp /= 16; }

                    if (temp % 16 == 13) { res += "D"; temp /= 16; }
                    if (temp % 16 == 14) { res += "E"; temp /= 16; }
                    if (temp % 16 == 15) { res += "F"; temp /= 16; }
                   
                } while (temp > 0);

                char[] sReverse = res.ToCharArray();
                Array.Reverse(sReverse);
                res = new string(sReverse);

                return res;

            }
        }



        public static CMYK RGBToCMYK(RGB rGB)
        {

            double dr = (double)rGB.R / 255;
            double dg = (double)rGB.G / 255;
            double db = (double)rGB.B / 255;
            double k = (1 - Math.Max(Math.Max(dr, dg), db));
            double c = (1 - dr - k) / (1 - k);
            double m = (1 - dg - k) / (1 - k);
            double y = (1 - db - k) / (1 - k);
            return new CMYK(c, m, y, k);
        }
        public static HSL RGBToHSL(RGB rGB)
        {
            HSL hsl = new HSL();
            float r = (rGB.R / 255.0f);
            float g = (rGB.G / 255.0f);
            float b = (rGB.B / 255.0f);
            float min = Math.Min(Math.Min(r, g), b);
            float max = Math.Max(Math.Max(r, g), b);
            float dif = max - min;
            hsl.L = (max + min) / 2;
            if (dif == 0)
            {
                hsl.H = 0;
                hsl.S = 0.0f;
            }
            else
            {
                hsl.S = (hsl.L <= 0.5) ? (dif / (max + min)) : (dif / (2 - max - min));


                float hue;
                if (r == max)
                {
                    hue = ((g - b) / 6) / dif;
                }
                else if (g == max)
                {
                    hue = (1.0f / 3) + ((b - r) / 6) / dif;
                }
                else
                {
                    hue = (2.0f / 3) + ((r - g) / 6) / dif;
                }
                if (hue < 0) hue += 1;
                if (hue > 1) hue -= 1;
                hsl.H = (int)(hue * 360);
            }
            return hsl;



        }
    }
}