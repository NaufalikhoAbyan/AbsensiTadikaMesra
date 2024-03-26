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
    public partial class GuruManagemen : Form
    {
        public GuruManagemen()
        {
            InitializeComponent();
        }

        public void GuruManagemenAdmin_Load(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.absensiTadikaMesraDataSet.users);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TambahGuru adminTambahGuru = new TambahGuru();
            adminTambahGuru.ShowDialog();
            usersTableAdapter.Fill(this.absensiTadikaMesraDataSet.users);
        }

        private void usersDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditGuru adminEditGuru = new EditGuru(Convert.ToInt32(usersDataGridView.CurrentRow.Cells[0].Value));
            adminEditGuru.ShowDialog();
            usersTableAdapter.Fill(this.absensiTadikaMesraDataSet.users);
        }
    }
}
