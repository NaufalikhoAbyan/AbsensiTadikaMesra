using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AbsensiTadikaMesraProd.Siswa
{
    public partial class SiswaAbsen : Form
    {
        private int countdown = 9;
        public SiswaAbsen(int siswaId)
        {
            InitializeComponent();
            DataRow SiswaData = studentsTableAdapter.GetRow(siswaId).Rows[0];
            label2.Text = "Hai, " + SiswaData["name"] + " Selamat Pagi";
            label3.Text = "Halaman ini akan hilang dalam (" + 10 + ")";
            Timer timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            label3.Text = "Halaman ini akan hilang dalam (" + countdown + ")";
            countdown--;
            if (countdown == 0)
            {
                Application.Restart();
            }
        }   
    }
}
