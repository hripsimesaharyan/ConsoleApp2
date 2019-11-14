using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Matrix
    {
        
        private int colnum;
        private int rownum;
        public static Random rnd=new Random ();


        private int[,] array = new int[10,10];

        public Matrix()
        {
            colnum = 1;
            rownum = 1;
        }
        public Matrix(int colsnum, int rowsnum)
        {
            this.colnum = colsnum;
            this.rownum = rowsnum;

        }
        public Matrix(int n)
        {
            this.mheith = n;
            this.mlength = n;
            this.array = new int[mlength, mheith];
        }
        public int this[int i, int j]
        {
            get { return array[i, j]; }
            set { array[i, j] = value; }
        }
        public int mlength
        {
            set { if (rownum != value) rownum = value; }
            get { return rownum; }
        }
        public int mheith
        {
            set { if (colnum != value) colnum = value; }
            get { return colnum; }
        }
        public void SetMatrix()
        {
            //rnd = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < rownum; i++)
            {
                for (int j = 0; j < colnum; j++)
                {
                    array[i, j] = rnd.Next(10);

                }
            }

        }
        public void PrintMatrix()
        {
            for (int i = 0; i < rownum; i++)
            {
                for (int j = 0; j < colnum; j++)
                {

                    Console.Write(array[i, j] + "\t");

                }
                Console.WriteLine("\n");
            }

        }

        public int Maxvalue()
        {
            int maxvalue = array[0,0];

            for (int i = 0; i < rownum; i++)
            {
                for (int j = 0; j < colnum; j++)
                {
                    if (maxvalue <= array[i, j])
                    {
                        maxvalue = array[i, j];
                    }
                   
                 }
                
            }
            return maxvalue;
        }
        public int Minvalue()
        {
            int minvalue = array[0, 0];

            for (int i = 0; i < rownum; i++)
            {
                for (int j = 0; j < colnum; j++)
                {
                    if (minvalue >= array[i, j])
                    {
                        minvalue = array[i, j];
                    }

                }

            }
            return minvalue;
        }

        public static Matrix operator+(Matrix arr1,Matrix arr2)
        {
                int rw = arr1.mheith;
                int col = arr1.mlength;
                Matrix arradd= new Matrix(rw,col);

            for(int i = 0; i < rw; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    arradd[i,j] = arr1[i,j] + arr2[i,j];
                }
            }
            return (arradd);
        }
     
        public static Matrix operator*(Matrix arr1,Matrix arr2)
        {
            int rw = arr1.mheith;
            int col = arr1.mlength;
           
            Matrix arradd = new Matrix(rw, col);
                      
                for (int i = 0; i < rw; i++)
                { 
                    for (int j = 0; j < col; j++)
                    {
                        for (int k = 0; k < col; k++) 
                        {
                                arradd[i,j] += arr1[i, k] * arr2[k, j];
                        }
                       
                    }
                    
                   
                }
               
                 return (arradd);

        }
        public void ScalarMultiplication(int number)
        {
            for (int i = 0; i < rownum; i++)

                for (int j = 0; j < colnum; j++)
                {
                    array[i, j] = array[i, j] * number;

                }


        }
        public Matrix Transposematrix
        {
            get
            {

                Matrix tarr = new Matrix(colnum, rownum);

                for (int j = 0; j < colnum; j++)
                {
                    for (int i = 0; i < rownum; i++)
                    {
                        tarr[j, i] = array[i, j];
                        Console.Write(tarr[j, i] + "\t");

                        //Console.Write($"tar:\t{tarr[j, i]}");
                    }
                    Console.WriteLine("\n");
                }
                return (tarr);
            }
        }
    }
}
