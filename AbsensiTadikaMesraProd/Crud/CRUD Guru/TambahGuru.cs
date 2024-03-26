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
    public partial class TambahGuru : Form
    {
        public TambahGuru()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nama = NamaTextBox.Text;
            string username = UsernameTextBox.Text;
            string password = PasswordTextBox.Text;
            int level = AdminRadio.Checked ? 1 : 2;

            if (nama == "" || username == "" || password == "")
            {
                MessageBox.Show("Isi semua data", "Peringatan");
            }
            else
            {
                usersTableAdapter.InsertQuery(nama, username, password, level);
                MessageBox.Show("Data berhasil ditambahkan", "Berhasil");
                this.Close();
            }
        }
    }
}
