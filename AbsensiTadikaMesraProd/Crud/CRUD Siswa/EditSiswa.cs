using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsensiTadikaMesraProd.Admin.AdminSiswa
{
    public partial class EditSiswa : Form
    {
        int siswaId;
        public EditSiswa(int siswaId)
        {
            InitializeComponent();
            this.siswaId = siswaId;
        }

        private void AdminEditSiswa_Load(object sender, EventArgs e)
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

            DataRow dataSiswa = studentsTableAdapter.GetRow(siswaId).Rows[0];
            namaTextBox.Text = dataSiswa["name"].ToString();
            usernameTextBox.Text = dataSiswa["username"].ToString();
            passwordTextBox.Text = dataSiswa["password"].ToString();
            if (dataSiswa["gender"].ToString() == "1")
            {
                lakiLakiRadio.Checked = true;
            }
            else
            {
                perempuanRadio.Checked = true;
            }
            kelasComboBox.SelectedValue = dataSiswa["class_id"];
            dateTimePicker.Value = Convert.ToDateTime(dataSiswa["born"]);
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
                studentsTableAdapter.UpdateQuery(nama, username, password, tanggalLahir, jenisKelamin, kelas, siswaId);
                MessageBox.Show("Siswa berhasil ditambahkan", "berhasil");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Apakah anda yakin ingin menghapus siswa ini?", "Hapus Siswa", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                studentsTableAdapter.DeleteRow(siswaId);
                MessageBox.Show("Siswa berhasil dihapus", "berhasil");
                this.Close();
            }
        }
    }
}
