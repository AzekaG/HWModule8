using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWModule9
{
    internal class Program
    {
        /*Создайте структуру «Трёхмерный вектор». Определите внутри неё необходимые поля и методы. Реализуйте
следующую функциональность:
■ Умножение вектора на число;
■ Сложение векторов;
■ Вычитание векторов.*/



        struct MyVector
        {
           public  MyVector(int x, int y, int z) { X = x; Y = y; Z = z; }
            public int X { get; set; }
            public int Y { get; set; }
            public int Z { get; set; }
            public void Output()
            {
                Console.WriteLine("X = " + X + ", Y = " + Y + ", Z = " + Z);
            }


            static public MyVector operator +(MyVector a, MyVector b)
            {
                return new MyVector { X = a.X + b.X, Y = a.Y + b.Y, Z = a.Z + b.Z };
            }
            static public MyVector operator -(MyVector a, MyVector b)
            {
                return new MyVector { X = a.X - b.X, Y = a.Y - b.Y, Z = a.Z - b.Z };
            }
            static public MyVector operator *(MyVector a, int value)
            {
                return new MyVector { X = a.X * value, Y = a.Y * value, Z = a.Z * value };
            }
        }


        static void Main(string[] args)
        {


            MyVector v = new MyVector(5, 2, 3);
            MyVector v2 = v * 2;
            Console.Write($"Vectot1 : ");
            v.Output();
            Console.Write($"Vectot2 : ");
            v2.Output();

            Console.Write("vector1 * 3  :  ");
            v = v * 3;
            v.Output();
            Console.Write("vector1 + vector2  :  ");
            MyVector v3 = v+v2;
            v3.Output();

            Console.WriteLine();
            Console.Write("vector2 - vector1 : ");
            v3 = v2 - v;
            v3.Output();
        }
    }
}
