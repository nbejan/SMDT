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
        public double[] r = new double[7];
        public double[] E_yaxshi = new double[7];
        public double[] E_yomon = new double[7];
        public Data d = new Data();


        public getValues(double[] E_yaxshi, double[] E_yomon)
        {
            this.E_yaxshi = E_yaxshi;
            this.E_yomon = E_yomon;
        }
        
    }
}
