using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Task2
{
    internal class Program
    {

        struct DecValue
        {
            int value;
            public int Value
            {
                get { return value; }
                set { this.value = value; }
            }
            public string ToHexValue()
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
                        if (temp % 16 >= 16) { temp /= 16; res += ToHexValue(); }
                    } while (temp > 0);

                    char[] sReverse = res.ToCharArray();
                    Array.Reverse(sReverse);
                    res = new string(sReverse);

                    return res;

                } 
            }
            public int ToOxtoValue()
            {

                int temp = Value;
                int res = 0;
                int count = 0;
                char[] ch = new char[10];
                do
                {
                    ch[count++] = char.Parse((temp%8).ToString());
                    temp /= 8;
                } while (temp != 0);

                char[] sReverse = new char[count]; //без него невозможно пропарсить чар в стринг в инт , остаются \0 после реверса
                for(int i = 0; i < count;i++)
                {
                    sReverse[i] = ch[i];
                }
                sReverse = sReverse.ToArray();
                Array.Reverse(sReverse);

                string str = new string(sReverse);
               
                return Convert.ToInt32(str);
            }
            public int ToBinValue()
            {

                return Value;
            }
        
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value in Dec : ");
            int value = int.Parse(Console.ReadLine());
            DecValue decValue = new DecValue() { Value = value };
            Console.WriteLine("in 8 system :   " + decValue.ToOxtoValue());
            Console.WriteLine("in 16 system :   " + decValue.ToHexValue());


        }
    }
}
