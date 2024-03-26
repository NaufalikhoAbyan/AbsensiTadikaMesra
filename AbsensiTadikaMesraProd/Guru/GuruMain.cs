using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbsensiTadikaMesraProd.Admin.AdminSiswa;
using AbsensiTadikaMesraProd.Pengaturan;

namespace AbsensiTadikaMesraProd.Guru
{
    public partial class GuruMain : Form
    {
        public int guruId;
        public GuruMain(int guruId)
        {
            InitializeComponent();
            this.guruId = guruId;
        }

        private void GuruMain_Load(object sender, EventArgs e)
        {
            DashboardGuru dg = new DashboardGuru
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            GuruContentPanel.Controls.Add(dg);
            dg.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            GuruContentPanel.Controls.Clear();
            DashboardGuru dg = new DashboardGuru
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            GuruContentPanel.Controls.Add(dg);
            dg.Show();
        }

        private void ManagemenSiswa_Click(object sender, EventArgs e)
        {
            GuruContentPanel.Controls.Clear();
            SiswaManagemen sm = new SiswaManagemen
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            GuruContentPanel.Controls.Add(sm);
            sm.Show();
        }

        private void Pengaturan_Click(object sender, EventArgs e)
        {
            GuruContentPanel.Controls.Clear();
            ResetPassword rpg = new ResetPassword(guruId)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                FormBorderStyle = FormBorderStyle.None
            };
            GuruContentPanel.Controls.Add(rpg);
            rpg.Show();
        }

        private void Logout_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
