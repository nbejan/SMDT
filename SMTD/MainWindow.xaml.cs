﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SMTD
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int[] arr_h = { 30, 50, 70, 100, 150, 200, 300 };
        double[] arr_B = new double[7];
        double[] arr_b = new double[7];
        double V_rn;
        double V_h2;
        double[] E_yaxshi = new double[7];
        double[] E_yomon = new double[7];


        double dh1;
        double dh2;
        
        //global uzgaruvchilar

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double E_s = Convert.ToDouble(AS_talab_kuchlanganlik.Text);
            double Vf = Convert.ToDouble(ajratkich_sunish.Text);
            string a_str = fider_sunish.Text;
            string P_str = nominal_quvvat.Text;
            string h2_str = Qabullash_antenasi_balandligi.Text;
            string dh1_str = xizmat_relefi_1.Text;
            string dh2_str = xizmat_relefi_2.Text;
            Antenna obj = new Antenna();
            obj.TypeAntenna(Comb.SelectedIndex);


            a_str = Replace_str(a_str);
            P_str = Replace_str(P_str);
            h2_str = Replace_str(h2_str);
            dh1_str = Replace_str(dh1_str);
            dh2_str = Replace_str(dh2_str);
            RelefTuzatish V_rel = new RelefTuzatish(dh1_str, dh2_str);


            if(InputArea_IsEmpty(dh1_str,dh2_str))
            {
                MessageBox.Show(V_rel.getVrelGood().ToString()+" "+V_rel.getVrelBad().ToString());//v_relni chaqirish mumkin
            }



            if (InputArea_IsEmpty(a_str))
            {
                 arr_b = Fider_sunish(a_str);
            }

            

            if (InputArea_IsEmpty(P_str))
            {
                V_rn = Vrn_Tuzatish(P_str);
            }


            if (InputArea_IsEmpty(h2_str))
            {
                V_h2 = V_h2_Tuzatish(h2_str);
            }

            for(int i=0; i<7; i++)
            {
                E_yaxshi[i] = E_s + V_rn + Vf + V_h2 + V_rel.getVrelGood() + Convert.ToDouble(a_str) * arr_h[i] - obj.val;
            }

            for (int i = 0; i < 7; i++)
            {
                E_yomon[i] = E_s + V_rn + Vf + V_h2 + V_rel.getVrelBad() + Convert.ToDouble(a_str) * arr_h[i] - obj.val;
            }



            MessageBox.Show(V_rn.ToString()+" va "+V_h2.ToString());
            
            MessageBox.Show(obj.val.ToString());


        }//Button


       


        private string Replace_str(string str)
        {
            for (int j = 0; j < str.Length; j++)
            {
                if (str[j] == '.')
                {
                    str = str.Replace('.', ',');
                }
            }

            return str;
        }





            //Vrn-ni tuzatish funksiyasi
        private double Vrn_Tuzatish(string str)
        {
            double p = Convert.ToDouble(str);
            return Math.Log10(1000 / p);
        }

        private double V_h2_Tuzatish(string str)
        {
            double h = Convert.ToDouble(str);
            return 10*Math.Log10(1.5 / h);
        }



        //finder subishini topuvchi funk
        private double[]  Fider_sunish(string str)
        {          
            
                double a = Convert.ToDouble(str);
                int i = 0;

                foreach (double el in arr_h)
                {
                    arr_B[i] = el * a;
                    i++;
                }

            return arr_B;
        }


        //textboxlar bushligini tekshiradi
        private bool InputArea_IsEmpty(string str)
        {
            if (str != "")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Katakchalar tuldirilmagan\n Sonlarni kiriting", "Diqat", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
        }

        /*private double All_Sumary()
        {
            double E_s = Convert.ToDouble(AS_talab_kuchlanganlik.Text);
            return E_s;
        }*/

        private bool InputArea_IsEmpty(string str, string str2)
        {
            if (str != "" && str2 !="")
            {
                return true;
            }
            else
            {
                MessageBox.Show("Katakchalar tuldirilmagan\n Sonlarni kiriting", "Diqat", MessageBoxButton.OK, MessageBoxImage.Warning);
                //MessageBox.Show();
                return false;
                
            }
        }

    }
}
