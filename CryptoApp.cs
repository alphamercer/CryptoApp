using System;
using System.Windows.Forms;

namespace CryptoApp
{
    public partial class CryptoApp : Form
    {
        public CryptoApp()
        {
            InitializeComponent();
        }

        private void ButtonGronsfeld_Click(object sender, EventArgs e)
        {
            output_GF.Text = Gronsfeld.CryptGF(input_GF.Text, key_GF.Text, checkBox_GF.Checked);
        }
        private void ButtonPolybius_Click(object sender, EventArgs e)
        {
            output_PS.Text = Polybius.CryptPS(input_PS.Text.ToUpper(), key_PS.Text.ToUpper(), checkBox_PS.Checked);

        }
        private void ButtonSkitala_Click(object sender, EventArgs e)
        {
            output_S.Text = Skitala.CryptS(input_S.Text.ToUpper(), ((int)key_S.Value), checkBox_S.Checked);

        }
    }
}