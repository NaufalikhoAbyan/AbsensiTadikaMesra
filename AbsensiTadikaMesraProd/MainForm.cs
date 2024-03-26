using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbsensiTadikaMesraProd.Admin;
using AbsensiTadikaMesraProd.Guru;
using AbsensiTadikaMesraProd.Siswa;

namespace AbsensiTadikaMesraProd
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void LoginUser(int level, int userId)
        {
            if (level == 1)
            {
                MainPanel.Controls.Clear();
                AdminMain adminMain = new AdminMain(userId)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                    FormBorderStyle = FormBorderStyle.None
                };
                MainPanel.Controls.Add(adminMain);
                adminMain.Show();
            }
            else if (level == 2)
            {
                MainPanel.Controls.Clear();
                GuruMain guruMain = new GuruMain(userId)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                    FormBorderStyle = FormBorderStyle.None
                };
                MainPanel.Controls.Add(guruMain);
                guruMain.Show();
            }
            else
            {
                MainPanel.Controls.Clear();
                SiswaAbsen siswaAbsen = new SiswaAbsen(userId)
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                    FormBorderStyle = FormBorderStyle.None
                };
                MainPanel.Controls.Add(siswaAbsen);
                siswaAbsen.Show();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Login login = new Login
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            MainPanel.Controls.Add(login);
            login.Show();
        }
    }
}
