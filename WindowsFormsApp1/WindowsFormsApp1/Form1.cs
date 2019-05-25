using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnTambahNo_Click(object sender, EventArgs e)
        {
            contact obj = new contact();
            obj.NamaAwal = kolomNama1.Text;
            obj.NamaAkhir = kolomNama2.Text;
            obj.Nomor = kolomNomor.Text;

            listNomor.Items.Add(obj.ToString());
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            kolomNama1.Clear();
            kolomNama2.Clear();
            kolomNomor.Clear();

        }
    }
}
