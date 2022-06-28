using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTD
{
    class Data
    {
        public double E = new double();
        public int[] h = { 30, 50, 70, 100, 150, 200, 300 };
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
        public double[] r = new double[7];

        public Data(double E)
        {
            this.E = E;
            int hv = 0;
            for(int i=0; i<h.Length; i++)
            {
                hv = h[i];
                r[i] = Dots(E, hv);
            }
        }  

        public double[] DotsValue(double[] rr)
        {
            return rr;
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
            else if (h1 == 50)
            {
                i = FindIndex(arr, E1, 2);
                c = 2;

            }
            else if (h1 == 70)
            {
                i = FindIndex(arr, E1, 3);
                c = 3;

            }
            else if (h1 == 100)
            {
                i = FindIndex(arr, E1, 4);
                c = 4;

            }
            else if (h1 == 150)
            {
                i = FindIndex(arr, E1, 5);
                c = 5;

            }
            else if (h1 == 200)
            {
                i = FindIndex(arr, E1, 6);
                c = 6;

            }
            else if (h1 == 300)
            {
                i = FindIndex(arr, E1, 7);
                c = 7;

            }


            return DotFunc(arr[0, i], arr[0, i+1], arr[c,i], arr[c,i+1], E1);
        }




        private double DotFunc(double x1, double x2, double y1, double y2, double E2)
        {
            return (x2-x1)*(E2-y1)/(y2-y1);
        }




        private int FindIndex( double[,] arr1, double E3 ,int j)
        {
            int b = 0;
            int i = 0;
            while (i < 3)
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
