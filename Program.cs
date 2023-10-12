using System;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

class HelloWorld
{
    static void Main()
    {
        Random rnd = new Random();

        long n = 10, m, q;
        m = n;
        q = n;

        long[,] Matrix1 = new long[n, m];
        long[,] Matrix2 = new long[n, m];
        long[,] Matrix3 = new long[n, m];

        for (int i = 0; i != n; i++)
        {
            for (int j = 0; j != m; j++)
            {
                Matrix1[i, j] = rnd.Next(0, 3);
                Console.Write(Matrix1[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int i = 0; i != n; i++)
        {
            for (int j = 0; j != m; j++)
            {
                Matrix2[i, j] = rnd.Next(0, 3);
                Console.Write(Matrix2[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();

        for (int i = 0; i != n; i++)
        {
            for (int j = 0; j != m; j++)
            {
                for (int k = 0; k != q; k++)
                { 
                    Matrix3[i, j] = Matrix3[i, j] + (Matrix1[i, k] * Matrix2[k, j]);
                }
                Console.Write(Matrix3[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
