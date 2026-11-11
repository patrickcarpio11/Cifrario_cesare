using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cifrario_cesare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_n1_Click(object sender, EventArgs e)
        {
            string parola;
            int parola2=0;
           
            parola = txt_n1.Text;
           
            for (int i = 0; i < parola.Length; i++)
            {

                parola2 = int.Parse(parola);


                parola2 = parola2 + 3;

                parola = parola.ToString();

                MessageBox.Show(parola);



            }

            
        }

       
    }
}
