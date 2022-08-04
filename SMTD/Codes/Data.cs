using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Threading.Tasks;

namespace SMTD
{
    class Data
    {
        private double[] E = new double[7];
        private int[] h = new int[7];
        private double[] r = new double[7];
        private double[,] arr = {
            { 1, 76, 77, 80, 82, 84, 85, 87 },
            { 2, 64, 66, 68, 69, 71, 73, 75 },
            { 5, 49, 51, 53, 55, 57, 60, 64 },
            {10, 41, 43, 44, 47, 49, 52, 56 },
            {20, 29, 31, 33, 37, 40, 42, 44 },
            {30, 22, 24, 26, 28, 31, 34, 39 },
            {50, 11, 13, 14, 17, 19, 22, 25 },
            {70, 3,  5,  7,  8,  11, 14, 19 },
            {90, -3, -1, 1,  3,  6,  10, 14 }
        };
        //public double[] r = new double[7];
        public Data()
        {

        }

        public void DotsData(double[] E, int[] h)
        {
            this.E = E;
            this.h = h;
            
            //int hv = 0;
            for (int i=0; i<7; i++)
            {
                
                r[i] = Dots(E[i], h[i]);
            }
            DotsValue();
        }  

        public double[] DotsValue()
        {
            return r;
        }
        public double Dots(double E1, int h1)
        {
            int i = 0;
            int c = 0;
            
            if (h1 == 30)
            {
                i = FindIndex(arr, E1, 1);
                c = 1;

            }
            if (h1 == 50)
            {
                i = FindIndex(arr, E1, 2);
                c = 2;

            }
            if (h1 == 70)
            {
                i = FindIndex(arr, E1, 3);
                c = 3;

            }
            if (h1 == 100)
            {
                i = FindIndex(arr, E1, 4);
                c = 4;

            }
            if (h1 == 150)
            {
                i = FindIndex(arr, E1, 5);
                c = 5;

            }
            if (h1 == 200)
            {
                i = FindIndex(arr, E1, 6);
                c = 6;

            }
            if (h1 == 300)
            {
                i = FindIndex(arr, E1, 7);
                c = 7;

            }

            //MessageBox.Show("E1 " + E1);
            //MessageBox.Show(FindIndex(arr, 60, 6).ToString() + "   its");
            //MessageBox.Show("h1 " + h1);
            //MessageBox.Show("c " + c);
            //MessageBox.Show("i " + i);
            //MessageBox.Show("arr[0, i] " + arr[0, i]);

            return DotFunc(arr[i, 0], arr[i+1, 0], arr[i, c], arr[i+1, c], E1);
        }




        private double DotFunc(double x1, double x2, double y1, double y2, double E2)
        {
            //MessageBox.Show("X1 " + x1);
            //MessageBox.Show("X2 " + x2);
            //MessageBox.Show("Y1 " + y1);
            //MessageBox.Show("Y2 " + y2);
            //MessageBox.Show("E2 " + E2);
            return (x2-x1)*(E2-y1)/(y2-y1)+x1;
        }




        private int FindIndex( double[,] arr1, double E3 ,int j)
        {
            int b = 0;
            int i = 0;
            while (i < 7)
            {

                if (E3 <= arr1[i, j] && E3 != arr1[i, 7])
                {
                    b = i;
                }
                
                i++;

            }
            return b;
        }
    }
}
