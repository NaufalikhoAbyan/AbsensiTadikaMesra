using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsensiTadikaMesraProd.Admin.AdminSiswa
{
    public partial class SiswaManagemen : Form
    {
        public SiswaManagemen()
        {
            InitializeComponent();
        }

        private void SiswaManagemenAdmin_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'absensiTadikaMesraDataSet.students' table. You can move, or remove it, as needed.
            this.studentsTableAdapter.Fill(this.absensiTadikaMesraDataSet.students);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TambahSiswa tambahSiswa = new TambahSiswa();
            tambahSiswa.ShowDialog();
            studentsTableAdapter.Fill(absensiTadikaMesraDataSet.students);
        }

        private void studentsDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditSiswa editSiswa = new EditSiswa(Convert.ToInt32(studentsDataGridView.CurrentRow.Cells[0].Value));
            editSiswa.ShowDialog();
            studentsTableAdapter.Fill(absensiTadikaMesraDataSet.students);
        }
    }
}
