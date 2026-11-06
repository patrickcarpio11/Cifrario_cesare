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
            string parola, parolaF = " ";
            int parola2 = 0,chiave=0;
            
            parola =txt_parola1.Text;
            parola = parola.ToUpper();
            chiave = int.Parse(txt_chiave1.Text);
            for (int i = 0; i <parola.Length; i++) 
            {

                parola2 = Convert.ToInt32(parola[i]);
                parola2 = parola2 + chiave;

                if (parola2 > 90)
                {
                    parola2 = parola2 - 26;
                }
                parola2=Convert.ToChar(parola2);
                parolaF = parolaF + Convert.ToChar(parola2);
            }
            
            lbl_risultato.Text =parolaF.ToLower();
          

        }

        private void btn_n2_Click(object sender, EventArgs e)
        {
            string parola, parolaF = " ";
            int parola2 = 0, chiave = 0;

            parola = txt_parola2.Text;
            parola = parola.ToUpper();
            chiave = int.Parse(txt_chiave2.Text);
            for (int i = 0; i < parola.Length; i++)
            {

                parola2 = Convert.ToInt32(parola[i]);
                parola2 = parola2 - chiave;

                if (parola2 < 65 )
                {
                    parola2 = parola2 + 26;
                }
                parola2 = Convert.ToChar(parola2);
                parolaF = parolaF + Convert.ToChar(parola2);
            }

            lbl_risultato2.Text = parolaF.ToLower();

        }

        private void btn_invio3_Click(object sender, EventArgs e)
        {
            string parola, parolaF = " ",chiave;
            int parola2 = 0,chiaveN;

            parola = txt_parola3.Text;
            parola = parola.ToUpper();
            chiave = txt_chiave3.Text;
            chiave=chiave.ToUpper();
            chiaveN = Convert.ToInt32(chiave);
            for (int i = 0; i < parola.Length; i++)
            {

                parola2 = Convert.ToInt32(parola[i]);
              
                parola2 = parola2 + chiaveN;

                if (parola2 > 90)
                {
                    parola2 = parola2 - 26;
                }
                parola2 = Convert.ToChar(parola2);
                parolaF = parolaF + Convert.ToChar(parola2);
            }

            lbl_risultato.Text = parolaF.ToLower();

        }

        private void btn_invio4_Click(object sender, EventArgs e)
        {

        }
    }
}
