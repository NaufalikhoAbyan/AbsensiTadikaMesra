using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsensiTadikaMesraProd.Admin
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
            guruCount.Text = usersTableAdapter.GetData().Rows.Count.ToString();
            siswaCount.Text = studentsTableAdapter.GetData().Rows.Count.ToString();
            kelasCount.Text = classesTableAdapter.GetData().Rows.Count.ToString();
        }
    }
}
