using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMTD
{
    class RelefTuzatish
    {
        private string h1;
        private string h2;

        public RelefTuzatish()
        {
          
        }
        public RelefTuzatish(string h1, string h2)
        {
            this.h1 = h1;
            this.h2 = h2;
        }

        public double getVrelGood()
        {
            //MessageBox.Show(Relef_tezatish_qishloq_good(h1).ToString());
            return (Relef_tezatish_qishloq_good(h1) + Relef_tezatish_shahar_good(h1))/2;
        }

        public double getVrelBad()
        {
            //MessageBox.Show(Relef_tezatish_qishloq_bad(h2).ToString());
            return (Relef_tezatish_qishloq_bad(h2) + Relef_tezatish_shahar_bad(h2)) / 2;
        }

        //1-chi grafikdan

        private double Relef_tezatish_qishloq_good(string str)
        {
            double a = Convert.ToDouble(str);

            if (a >= 10 && a < 20)
            {
                return -10 + 0.4 * (a - 10);
            }
            else if (a >= 20 && a < 50)
            {
                return -10 + 0.2 * (a - 20);
            }
            else if (a >= 50 && a < 100)
            {
                return -10 + 0.1 * (a - 50);
            }
            else if (a >= 100 && a < 200)
            {
                return -10 + 0.06 * (a - 100);
            }
            else
            {
                return 0;
            }
        }

        //2-chi grafikdan

        private double Relef_tezatish_shahar_good(string str)
        {
            double a = Convert.ToDouble(str);

            if (a >= 10 && a < 20)
            {
                return -10 + 0.5 * (a - 10);
            }
            else if (a >= 20 && a < 50)
            {
                return -10 + 0.2 * (a - 20);
            }
            else if (a >= 50 && a < 100)
            {
                return -10 + 0.12 * (a - 50);
            }
            else if (a >= 100 && a < 200)
            {
                return -10 + 0.08 * (a - 100);
            }
            else
            {
                return 0;
            }
        }


        //1-qishloq
        private double Relef_tezatish_qishloq_bad(string str)
        {
            double a = Convert.ToDouble(str);

            if (a >= 10 && a < 20)
            {
                return -10 + 0.1 * (a - 10);
            }
            else if (a >= 20 && a < 50)
            {
                return -10 + 0.06 * (a - 20);
            }
            else if (a >= 50 && a < 100)
            {
                return -10 + 0.06 * (a - 50);
            }
            else if (a >= 100 && a < 200)
            {
                return -10 + 0.03 * (a - 100);
            }
            else
            {
                return 0;
            }
        }


        //2-shahar

        private double Relef_tezatish_shahar_bad(string str)
        {
            double a = Convert.ToDouble(str);

            if (a >= 10 && a < 20)
            {
                return -10 + 0.1 * (a - 10);
            }
            else if (a >= 20 && a < 50)
            {
                return -10 + 0.13 * (a - 20);
            }
            else if (a >= 50 && a < 100)
            {
                return -10 + 0.08 * (a - 50);
            }
            else if (a >= 100 && a < 200)
            {
                return -10 + 0.03 * (a - 100);
            }
            else
            {
                return 0;
            }
        }

    }
}
