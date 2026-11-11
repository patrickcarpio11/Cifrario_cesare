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
            

                if (parola2>=65&&parola2 <= 90)
                {
                    parola2 = 65 + (parola2 - 65 + chiave) % 26;
                }
                if (parola2 >= 97 && parola2 <= 122)
                {
                    parola2 = 97 + (parola2 - 97 + chiave) % 26;
                }
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
               
                if (parola2 >= 65 && parola2 <= 90)
                {
                    parola2 = 65 + (parola2 - 65 - chiave % 26 + 26) % 26;
                }
                if (parola2 >= 97 && parola2 <= 122)
                {
                    parola2 = 97 + (parola2 - 97 - chiave % 26 + 26) % 26;
                }
                parolaF = parolaF + Convert.ToChar(parola2);
            }

            lbl_risultato2.Text = parolaF.ToLower();

        }
        private void btn_invio5_Click(object sender, EventArgs e)
        {
            string parola, parolaF = " ";
            int parola2 = 0;

            parola = txt_parola5.Text;
            parola = parola.ToUpper();
          
            for (int i = 0; i < parola.Length; i++)
            {

                parola2 = Convert.ToInt32(parola[i]);
                parola2 = parola2 + 3;
                parolaF = parolaF + Convert.ToChar(parola2);
            }

            lbl_risultato5.Text = parolaF.ToLower();
        }
        private void btn_invio6_Click(object sender, EventArgs e)
        {
            string parola, parolaF = " ";
            int parola2 = 0;

            parola = txt_parola6.Text;
            parola = parola.ToUpper();
           
            for (int i = 0; i < parola.Length; i++)
            {

                parola2 = Convert.ToInt32(parola[i]);
                parola2 = parola2 - 3; 
                parolaF = parolaF + Convert.ToChar(parola2);
            }

            lbl_risultato6.Text = parolaF.ToLower();

        }
    }
}
