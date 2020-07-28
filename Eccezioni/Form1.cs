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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Method1(textBox1.Text, textBox2.Text);
                MessageBox.Show("nessun errore nell'evento click");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} + {Environment.NewLine} + {ex.StackTrace}");
            }
        }

        private void Method1(string tb1, string tb2)
        {
            var strWriter = new StreamWriter(@"c:\Corso c#\esempio.csv");
            try
            {
                var int1 = int.Parse(tb1);
                var int2 = int.Parse(tb2);
                var result = int1 / int2;
                strWriter.WriteLine($"operazione con risultato {result}");
                label1.Text = result.ToString();
            }
            catch (FormatException ex)
            {
                //Logger.Log(ex);
                throw ex;
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("non è possibile dividere per 0");
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Message:{ex.Message}");
                textBox3.Text = $"StackTrace:{ex.StackTrace}";
                MessageBox.Show($"InnerException:{ex.InnerException}");
                throw;
            }
            finally
            {
                strWriter.Dispose();
                textBox4.Text = "siamo entrati nel blocco finally";
            }
        }

    }
}
