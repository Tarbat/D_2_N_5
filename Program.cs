using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

class HelloWorld
{
    static void Main()
    {
        Random rnd = new Random();

        long n = 1000*1000, m, q;
        m = n;
        q = n;
        long Kv = n / 1000;

        long[] Matrix1 = new long[n];
        long[] Matrix2 = new long[n];
        long[] Matrix3 = new long[n];

        for (int i = 0; i != Kv; i++)
        {
            for (int j = 0; j != Kv; j++)
            {
                long mj = j + (Kv * i);
                Matrix1[mj] = rnd.Next(0, 3);
             //   Console.Write(Matrix1[mj] + " ");
            } 
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int i = 0; i != Kv; i++)
        {
            for (int j = 0; j != Kv; j++)
            {
                long mj = j + (Kv * i);
                Matrix2[mj] = rnd.Next(0, 3);
             //   Console.Write(Matrix2[mj] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int i = 0; i != Kv; i++)
        {
            for (int j = 0; j != Kv; j++)
            {
                for (int k = 0; k != Kv; k++)
                {
                    long mj = j + (Kv * i);
                    long qk = k + (Kv * i);
                    long kq = j + (Kv * k);
                    Matrix3[mj] = Matrix3[mj] + (Matrix1[qk] * Matrix2[kq]);
                }
                //Console.Write(Matrix3[i, j] + " ");
            }
            Console.WriteLine();
        }

        for (int i = 0; i != 3; i++)
        {
            for (int j = 0; j != 3; j++)
            {
                long mj = j + (Kv * i);
                Console.Write(Matrix3[mj] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}
