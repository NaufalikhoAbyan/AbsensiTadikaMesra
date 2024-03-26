using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static AbsensiTadikaMesraProd.Admin.AdminMain;

namespace AbsensiTadikaMesraProd.Admin.AdminGuru
{
    public partial class EditGuru : Form
    {
        string nama, username, password;
        int level;
        private int userId;
        public EditGuru(int data)
        {
            InitializeComponent();
            userId = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nama = NamaTextBox.Text;
            username = UsernameTextBox.Text;
            password = PasswordTextBox.Text;
            level = AdminRadio.Checked ? 1 : 2;

            if (nama == "" || username == "" || password == "")
            {
                MessageBox.Show("Isi semua data", "Peringatan");
            }
            else
            {
                usersTableAdapter.UpdateRow(nama, username, password, level, userId);
                MessageBox.Show("Data berhasil diubah", "Berhasil");
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult confirmDelete = MessageBox.Show("Apakah anda ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo);
            if (confirmDelete == DialogResult.Yes)
            {
                usersTableAdapter.DeleteRow(userId);
                MessageBox.Show("Data berhasil dihapus", "Berhasil");
                this.Close();
            }
        }

        private void AdminEditGuru_Load(object sender, EventArgs e)
        {
            DataRow userData = usersTableAdapter.GetRow(userId).Rows[0];
            NamaTextBox.Text = userData["name"].ToString();
            UsernameTextBox.Text = userData["username"].ToString();
            PasswordTextBox.Text = userData["password"].ToString();
            if (Convert.ToInt32(userData["level"]) == 1)
            {
                AdminRadio.Checked = true;
            }
            else
            {
                GuruRadio.Checked = true;
            }
        }
    }
}
