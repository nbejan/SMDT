using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTD
{
    class getValues
    {
        public int[] h1 = { 30, 50, 70, 100, 150, 200, 300 };
        public double[] r_dh1 = new double[7];
        public double[] r_dh2 = new double[7];
        public double[] r1 = new double[7];
        public double[] E_yaxshi = new double[7];
        public double[] E_yomon = new double[7];
        


        public getValues(double[] E_yaxshi, double[] E_yomon)
        {
            this.E_yaxshi = E_yaxshi;
            this.E_yomon = E_yomon;
        }

        public Data g = new Data();
        public Data b = new Data();
        public double[] GetR()
        {
            g.DotsData(E_yaxshi, h1);
            b.DotsData(E_yomon, h1);

            r_dh1 = g.DotsValue();
            r_dh2 = b.DotsValue();

            for (int i=0; i<7; i++)
            {
                r1[i] = Math.Min(r_dh1[i], r_dh2[i]);
            }

            return r1;
        }
    }
}
