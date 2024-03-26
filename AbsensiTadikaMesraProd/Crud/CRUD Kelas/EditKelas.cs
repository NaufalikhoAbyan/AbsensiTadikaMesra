using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsensiTadikaMesraProd.Admin.AdminKelas
{
    public partial class EditKelas : Form
    {
        string nama, tahun;
        int kelasId;
        public EditKelas(int kelasId)
        {
            InitializeComponent();
            this.kelasId = kelasId;
        }

        private void AdminEditKelas_Load(object sender, EventArgs e)
        {
            DataRow kelasData = classesTableAdapter.GetRow(kelasId).Rows[0];
            NamaTextBox.Text = kelasData["name"].ToString();
            TahunTextBox.Text = kelasData["year"].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus data ini?", "Peringatan", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                classesTableAdapter.DeleteRow(kelasId);
                MessageBox.Show("Data berhasil dihapus", "Berhasil");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nama = NamaTextBox.Text;
            tahun = TahunTextBox.Text;
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
                classesTableAdapter.UpdateQuery(nama, tahunInt, kelasId);
                MessageBox.Show("Data berhasil diubah", "Berhasil");
                this.Close();
            }
        }
    }
}
