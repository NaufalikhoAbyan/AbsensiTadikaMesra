using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AbsensiTadikaMesraProd.AbsensiTadikaMesraDataSetTableAdapters;

namespace AbsensiTadikaMesraProd.Guru
{
    public partial class DashboardGuru : Form
    {
        public DashboardGuru()
        {
            InitializeComponent();
            siswaCount.Text = studentsTableAdapter.GetData().Rows.Count.ToString();
            kelasCount.Text = classesTableAdapter.GetData().Rows.Count.ToString();
        }
    }
}
