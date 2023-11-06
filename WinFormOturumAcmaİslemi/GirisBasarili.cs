using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormOturumAcmaIslemi;
using WinFormOturumAcmaİslemi.Models;

namespace WinFormOturumAcmaİslemi
{
    public partial class GirisBasarili : Form
    {
        WinFormOturumAcmaİslemiEntitiesConnectionDb db = new WinFormOturumAcmaİslemiEntitiesConnectionDb();

        public GirisBasarili()
        {
            InitializeComponent();
        }

        private void GirisBasarili_Load(object sender, EventArgs e)
        {
            int id = Form1.Id;
            label1.Text = $@"Hoş Geldiniz. Sayın {db.Kullanici_Giris_Tablosu.FirstOrDefault(x => x.Id == Form1.Id).FirstName} {db.Kullanici_Giris_Tablosu.FirstOrDefault(x => x.Id == Form1.Id).LastName}";
        }
    }
}
