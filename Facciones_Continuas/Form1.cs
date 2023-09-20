using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Facciones_Continuas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int a, b, i = 1;
            a = int.Parse(TxtNum1.Text);
            b = int.Parse(TxtNum2.Text);

            while (b != 0)
            {
                
                int temp = b;
                b = a%b;
                if (b == 0)
                {
                    TablaDatos.Rows.Add(i, a + " divido entre " + temp + " es " + (a / temp) + " y sobran " + b, a + " / " + temp + " = " + (a / temp));
                }
                else
                {
                    TablaDatos.Rows.Add(i, a + " divido entre " + temp + " es " + (a / temp) + " y sobran " + b, a + " / " + temp + " = " + (a / temp) + " + 1 / " + temp + " / " + b);
                }
                
                a = temp;
                i++;
            }
            
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            TxtNum1.Text = "";
            TxtNum2.Text = "";
            TablaDatos.Rows.Clear();
            TxtNum1.Focus();
        }

        private void TxtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                TxtNum2.Focus();
            }
        }

    }
}
