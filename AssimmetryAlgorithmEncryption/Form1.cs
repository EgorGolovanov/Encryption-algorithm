using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.IO;
using System.Windows.Forms;


namespace AssimmetryAlgorithmEncryption
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void EncryptionButton_Click(object sender, EventArgs e)
        {
            EducationButton.Visible = false;
            EncryptionButton.Visible = false;
            AlgorithmsGB.Visible = true;
            InputTextRB.Visible = true;
            OutputTextRB.Visible = true;
            AlgoRSAGroupBox.Visible = true;
        }

        private void EncryptRSAButton_Click(object sender, EventArgs e)
        {
            AlgorithmRSA RSA = new AlgorithmRSA();
            KeyValuePair<long, long> openKeys = RSA.GenerationOpenKey();
            string s = InputTextRB.Text;
            s = s.ToUpper();

            long n = openKeys.Key * openKeys.Value;
            long m = (openKeys.Key - 1) * (openKeys.Value - 1);
            long d = RSA.Calculate_d(m);
            long e_ = RSA.Calculate_e(d, m);

            MessageBox.Show("Ключ для шифрования:\np = " + openKeys.Key.ToString() + " q = " + openKeys.Value.ToString()
                + "\nКод для расшифровки:\nd = " + d + " n = " + n);

            List<string> result = RSA.RSA_Endoce(s, e_, n);

            OutputTextRB.Clear(); // очистка поля для вывода
            foreach (string item in result)
                OutputTextRB.Text += (item + "\n");
            Clipboard.SetText(OutputTextRB.Text);
            InputTextRB.Clear();

        }

        private void DecipherRSAButton_Click(object sender, EventArgs e)
        {
            AlgorithmRSA RSA = new AlgorithmRSA();
            if ((KeyDTextBox.Text.Length > 0) && (KeyNTextBox.Text.Length > 0))
            {

                    long d = Convert.ToInt64(KeyDTextBox.Text);
                    long n = Convert.ToInt64(KeyNTextBox.Text);

                List<string> input = new List<string>();

                string[] lalal = Clipboard.GetText().Split('\n');
                input = lalal.ToList<string>();

                string result = RSA.RSA_Dedoce(input, d, n);

                InputTextRB.Clear();
                InputTextRB.Text = result;
                OutputTextRB.Clear();
                KeyDTextBox.Clear();
                KeyNTextBox.Clear();
            }
            else
                MessageBox.Show("Введите секретный ключ!");
        }
    }
}
