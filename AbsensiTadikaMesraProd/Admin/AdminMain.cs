using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbsensiTadikaMesraProd.Admin.AdminGuru;
using AbsensiTadikaMesraProd.Admin.AdminKelas;
using AbsensiTadikaMesraProd.Admin.AdminSiswa;
using AbsensiTadikaMesraProd.Pengaturan;

namespace AbsensiTadikaMesraProd.Admin
{
    public partial class AdminMain : Form
    {
        public int adminId;
        public AdminMain(int adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
        }

        private void AdminMain_Load(object sender, EventArgs e)
        {
            DashboardAdmin gda = new DashboardAdmin
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            AdminContentPanel.Controls.Add(gda);
            gda.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AdminContentPanel.Controls.Clear();
            DashboardAdmin gda = new DashboardAdmin
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            AdminContentPanel.Controls.Add(gda);
            gda.Show();
        }

        private void ManagemenGuru_Click(object sender, EventArgs e)
        {
            AdminContentPanel.Controls.Clear();
            GuruManagemen gma = new GuruManagemen
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            AdminContentPanel.Controls.Add(gma);
            gma.Show();
        }

        private void ManagemenSiswa_Click(object sender, EventArgs e)
        {
            AdminContentPanel.Controls.Clear();
            SiswaManagemen sma = new SiswaManagemen
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            AdminContentPanel.Controls.Add(sma);
            sma.Show();
        }

        private void ManagemenKelas_Click(object sender, EventArgs e)
        {
            AdminContentPanel.Controls.Clear();
            KelasManagemen kma = new KelasManagemen
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            AdminContentPanel.Controls.Add(kma);
            kma.Show();
        }

        private void Pengaturan_Click(object sender, EventArgs e)
        {
            AdminContentPanel.Controls.Clear();
            ResetPassword rpa = new ResetPassword(adminId)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            AdminContentPanel.Controls.Add(rpa);
            rpa.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
