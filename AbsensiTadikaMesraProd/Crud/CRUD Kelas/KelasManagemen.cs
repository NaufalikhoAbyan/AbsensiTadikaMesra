using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AbsensiTadikaMesraProd.Admin.AdminKelas
{
    public partial class KelasManagemen : Form
    {
        public KelasManagemen()
        {
            InitializeComponent();
        }

        private void classesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.absensiTadikaMesraDataSet);

        }

        private void KelasManagemenAdmin_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'absensiTadikaMesraDataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.absensiTadikaMesraDataSet.classes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TambahKelas tambahKelas = new TambahKelas();
            tambahKelas.ShowDialog();
            classesTableAdapter.Fill(absensiTadikaMesraDataSet.classes);
        }

        private void classesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            EditKelas editKelas = new EditKelas(Convert.ToInt32(classesDataGridView.CurrentRow.Cells[0].Value));
            editKelas.ShowDialog();
            classesTableAdapter.Fill(absensiTadikaMesraDataSet.classes);
        }
    }
}
