using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormOturumAcmaİslemi;
using WinFormOturumAcmaİslemi.Models;

namespace WinFormOturumAcmaIslemi
{
    public partial class Form1 : Form
    {

        WinFormOturumAcmaİslemiEntitiesConnectionDb db = new WinFormOturumAcmaİslemiEntitiesConnectionDb();


        public Form1()
        {
            InitializeComponent();
        }

        public static int Id;
        private void button1_Click(object sender, EventArgs e)
        {
            var Durum = db.Kullanici_Giris_Tablosu.FirstOrDefault(x => x.Mail == textBox1.Text && x.Password == textBox2.Text);
            if (Durum != null)
            {
                Id = Durum.Id;
                GirisBasarili gb = new GirisBasarili(); 
                gb.ShowDialog();
            }
            else
            {
                MessageBox.Show("Girilen bilgiler hatalı veya yanlış", "Durum", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SifreYenileme sy = new SifreYenileme();
            sy.ShowDialog();
           
        }
    }
}
