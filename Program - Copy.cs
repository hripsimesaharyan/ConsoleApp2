using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello Matrix");
            //Matrix M = new Matrix();

            //Console.WriteLine("First Values ");
            //M.SetMatrix();
            //M.PrintMatrix();
            //Console.WriteLine("-------------------------");


            //Console.Write("Enter sizeof matrix:");
            //int n = int.Parse(Console.ReadLine());
            //int m = n;

            Matrix T = new Matrix(5,2);
            //T.mheith = n;
            //T.mlength = m;
            T.SetMatrix();
            T.PrintMatrix();
            Console.WriteLine("-------------------------");

            Console.WriteLine("Transposematrix");

            T.Transposematrix();
            
            Console.WriteLine("-------------------------");

            Console.WriteLine("Matrix 1");
            Matrix M1 = new Matrix(2);
            M1.SetMatrix();
            M1.PrintMatrix();
            Console.WriteLine("-------------------------");

            int max=M1.Maxvalue();
            int min = M1.Minvalue();
            Console.WriteLine($"Max value:\t{max}");
            Console.WriteLine($"Min value:\t{min}");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Matrix 2");
            Matrix M2 = new Matrix(2);
            M2.SetMatrix();
            M2.PrintMatrix();
            Console.WriteLine("-------------------------");
            //Console.WriteLine("Matrix 1+ Matrix2");
            //Matrix  M3 = M1 + M2;
            
            //M3.PrintMatrix();
            //Console.WriteLine("-------------------------");
            Console.WriteLine("Matrix 1*Matrix2");
            Matrix M4 = new Matrix();
            M4 = M2 * M1;
            M4.PrintMatrix();
            Console.WriteLine("-------------------------");

            Console.WriteLine($" ScalarMultiplication-2");
            Matrix M5 = new Matrix(3);
            M5.SetMatrix();
            M5.PrintMatrix();
            Console.WriteLine("-------------------------");
            M5.ScalarMultiplication(2);
            M5.PrintMatrix();


            Console.ReadLine();

        }
    }
}
