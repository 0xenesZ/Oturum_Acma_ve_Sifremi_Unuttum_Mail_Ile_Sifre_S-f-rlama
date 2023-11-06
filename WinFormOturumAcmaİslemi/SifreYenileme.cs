using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormOturumAcmaİslemi.Models;

namespace WinFormOturumAcmaİslemi
{
    public partial class SifreYenileme : Form
    {

        public SifreYenileme()
        {
            InitializeComponent();
        }
        MailYenilemeIstegi my = new MailYenilemeIstegi();
        private void button1_Click(object sender, EventArgs e)
        {
            my.Microsoft(textBox1.Text, textBox2.Text, textBox1.Text);
            MessageBox.Show("Bilgiler eşleşir ise şifreniz yenilenecektir ve mail olarak gelecektir", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
