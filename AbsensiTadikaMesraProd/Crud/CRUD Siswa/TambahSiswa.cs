using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsensiTadikaMesraProd.Admin.AdminSiswa
{
    public partial class TambahSiswa : Form
    {
        public TambahSiswa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = namaTextBox.Text;
            string username = usernameTextBox.Text;
            string password = passwordTextBox.Text;
            DateTime tanggalLahir = dateTimePicker.Value;
            int jenisKelamin = lakiLakiRadio.Checked ? 1 : 0;
            int kelas = Convert.ToInt32(kelasComboBox.SelectedValue);

            if (nama == "" || username == "" || password == "")
            {
                MessageBox.Show("Semua field harus diisi");
                return;
            }
            else
            {
                studentsTableAdapter.InsertQuery(nama, username, password, tanggalLahir.ToString(), jenisKelamin.ToString(), kelas);
                MessageBox.Show("Siswa berhasil diubah", "berhasil");
                this.Close();
            }
        }

        private void AdminTambahSiswa_Load(object sender, EventArgs e)
        {
            List<Kelas> kelas = new List<Kelas>();
            DataTable kelasDataTable = classesTableAdapter.GetData();
            if (kelasDataTable.Rows.Count > 0)
            {
                foreach (DataRow row in kelasDataTable.Rows)
                {
                    int id = Convert.ToInt32(row["id"]);
                    string name = row["name"] + " " + row["year"];
                    kelas.Add(new Kelas(id, name));
                }
                kelasComboBox.DataSource = kelas;
                kelasComboBox.DisplayMember = "name";
                kelasComboBox.ValueMember = "id";
            }
            else
            {
                kelasComboBox.Items.Add("Tidak Ada Kelas");
            }
        }
    }
}
