using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        List<int> caja = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Comenzar_Click(object sender, EventArgs e)
        {
            if ( !string.IsNullOrEmpty(TX_1.Text) && !string.IsNullOrEmpty(TX_2.Text))
            {
                if( Int32.TryParse(TX_1.Text , out int num) && Int32.TryParse(TX_2.Text, out int expo))
                {
                    potencia(num, expo, caja);

                    foreach ( int n in caja)
                    {
                        LT_1.Items.Add(n.ToString());
                    }
                    
                }
            }
        }

        private int potencia ( int num , int expo, List<int> Lista)
        {
            if( expo > 0)
            {
                Lista.Add(num);
                return potencia( num*2 , expo-1 , Lista);
            }
            else
            {
                return 0;
            }
        }
    }
}
