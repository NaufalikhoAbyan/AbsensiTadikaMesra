using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsensiTadikaMesraProd.Pengaturan
{
    public partial class ResetPassword : Form
    {
        private int userId;
        public ResetPassword(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string passwordlama = passwordLamaTextBox.Text;
            string passwordbaru = passwordBaruTextBox.Text;
            string ulangPaswword = ulangPasswordTextBox.Text;

            DataRow adminData = usersTableAdapter.GetRow(userId).Rows[0];

            if (passwordlama == "" || passwordbaru == "" || ulangPaswword == "")
            {
                MessageBox.Show("Semua kolom harus diisi");
                passwordLamaTextBox.Text = "";
                passwordBaruTextBox.Text = "";
                ulangPasswordTextBox.Text = "";
                return;
            }
            else
            {
                if (passwordlama != adminData["password"].ToString())
                {
                    MessageBox.Show("Password lama salah");
                    passwordLamaTextBox.Text = "";
                    passwordBaruTextBox.Text = "";
                    ulangPasswordTextBox.Text = "";
                    return;
                }
                else if (passwordbaru != ulangPaswword)
                {
                    MessageBox.Show("Password baru dan ulangi password tidak sama");
                    passwordLamaTextBox.Text = "";
                    passwordBaruTextBox.Text = "";
                    ulangPasswordTextBox.Text = "";
                    return;
                }
                else
                {
                    usersTableAdapter.UpdatePassword(passwordbaru, userId);
                    MessageBox.Show("Password berhasil diubah");
                    passwordLamaTextBox.Text = "";
                    passwordBaruTextBox.Text = "";
                    ulangPasswordTextBox.Text = "";
                }
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            passwordLamaTextBox.Text = "";
            passwordBaruTextBox.Text = "";
            ulangPasswordTextBox.Text = "";
        }
    }
}
