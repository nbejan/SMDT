using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTD
{
    class Antenna:MainWindow
    {
        private int index;
        public double val;
        

        public Antenna()
        {
            
        }
        public void TypeAntenna(int index)
        {
            double[] val = { 0, 1.6, 0, 0, 8, 7.3, 3.6 };
            this.index = index;
            this.val = val[index];
        }
    }
}
