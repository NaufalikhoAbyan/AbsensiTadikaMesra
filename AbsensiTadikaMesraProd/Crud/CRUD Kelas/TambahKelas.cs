using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbsensiTadikaMesraProd.AbsensiTadikaMesraDataSetTableAdapters;

namespace AbsensiTadikaMesraProd.Admin.AdminKelas
{
    public partial class TambahKelas : Form
    {
        public TambahKelas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = NamaTextBox.Text;
            string tahun = TahunTextBox.Text;

            if (nama == "" || tahun == "")
            {
                MessageBox.Show("Isi semua data", "Peringatan");
            }
            else
            {
                int tahunInt;
                try
                {
                    tahunInt = int.Parse(tahun);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tahun harus berupa angka", "Peringatan");
                    return;
                }
                classesTableAdapter.InsertQuery(nama, tahunInt);
                MessageBox.Show("Data berhasil ditambahkan", "Berhasil");
                this.Close();
            }
        }
    }
}
