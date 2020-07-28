using Eccezioni.Code;
using System;
using System.IO;
using System.Windows.Forms;

namespace Eccezioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_stampa_Click(object sender, EventArgs e)
        {
            var p = GetPersona();
            try
            {
                Helpers.StampaPersona(p);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }           
        }

        private Persona GetPersona()
        {
            if (textBox2.Text == string.Empty) return null;
            return new Persona()
            {
                Cognome = textBox2.Text,
                Nome = textBox1.Text
            };

        }
    }
}
