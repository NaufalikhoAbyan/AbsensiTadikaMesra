using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsensiTadikaMesraProd
{
    public partial class Login : Form
    {
        public DataTable LoginData = new DataTable();
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginData = usersTableAdapter.LoginCheck(UsernameTextBox.Text, PasswordTextBox.Text);
            if (LoginData.Rows.Count > 0)
            {
                MainForm mainForm = (MainForm)ParentForm;
                mainForm.LoginUser(Convert.ToInt32(LoginData.Rows[0]["level"]), Convert.ToInt32(LoginData.Rows[0]["id"]));
                LoginData = null;
            }
            else
            {
                LoginData = studentsTableAdapter.LoginCheck(UsernameTextBox.Text, PasswordTextBox.Text);
                if (LoginData.Rows.Count > 0)
                {
                    MainForm mainForm = (MainForm)ParentForm;
                    mainForm.LoginUser(Convert.ToInt32(0), Convert.ToInt32(LoginData.Rows[0]["id"]));
                    LoginData = null;
                }
                else
                {
                    MessageBox.Show("Krediensial login salah");
                    PasswordTextBox.Text = "";
                }
            }
        }
    }
}
