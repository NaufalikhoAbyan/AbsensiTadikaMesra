namespace AbsensiTadikaMesraProd.Admin
{
    partial class DashboardAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kelasCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.siswaCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.guruCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.absensiTadikaMesraDataSet = new AbsensiTadikaMesraProd.AbsensiTadikaMesraDataSet();
            this.usersTableAdapter = new AbsensiTadikaMesraProd.AbsensiTadikaMesraDataSetTableAdapters.usersTableAdapter();
            this.studentsTableAdapter = new AbsensiTadikaMesraProd.AbsensiTadikaMesraDataSetTableAdapters.studentsTableAdapter();
            this.classesTableAdapter = new AbsensiTadikaMesraProd.AbsensiTadikaMesraDataSetTableAdapters.classesTableAdapter();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absensiTadikaMesraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(783, 167);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.kelasCount);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(552, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(201, 107);
            this.panel3.TabIndex = 2;
            // 
            // kelasCount
            // 
            this.kelasCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kelasCount.AutoSize = true;
            this.kelasCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.kelasCount.Location = new System.Drawing.Point(74, 62);
            this.kelasCount.Name = "kelasCount";
            this.kelasCount.Size = new System.Drawing.Size(53, 38);
            this.kelasCount.TabIndex = 1;
            this.kelasCount.Text = "10";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.label6.Location = new System.Drawing.Point(55, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kelas";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.siswaCount);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(291, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(201, 107);
            this.panel2.TabIndex = 1;
            // 
            // siswaCount
            // 
            this.siswaCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siswaCount.AutoSize = true;
            this.siswaCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.siswaCount.Location = new System.Drawing.Point(74, 62);
            this.siswaCount.Name = "siswaCount";
            this.siswaCount.Size = new System.Drawing.Size(53, 38);
            this.siswaCount.TabIndex = 1;
            this.siswaCount.Text = "10";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.label4.Location = new System.Drawing.Point(55, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Siswa";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.guruCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(30, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(201, 107);
            this.panel1.TabIndex = 0;
            // 
            // guruCount
            // 
            this.guruCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guruCount.AutoSize = true;
            this.guruCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.guruCount.Location = new System.Drawing.Point(74, 62);
            this.guruCount.Name = "guruCount";
            this.guruCount.Size = new System.Drawing.Size(53, 38);
            this.guruCount.TabIndex = 1;
            this.guruCount.Text = "10";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.label1.Location = new System.Drawing.Point(55, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Guru";
            // 
            // absensiTadikaMesraDataSet
            // 
            this.absensiTadikaMesraDataSet.DataSetName = "AbsensiTadikaMesraDataSet";
            this.absensiTadikaMesraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.absensiTadikaMesraDataSet;
            // 
            // DashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 449);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DashboardAdmin";
            this.Text = "GuruDashboardAdmin";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absensiTadikaMesraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label guruCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label kelasCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label siswaCount;
        private System.Windows.Forms.Label label4;
        private AbsensiTadikaMesraDataSet absensiTadikaMesraDataSet;
        private AbsensiTadikaMesraDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private AbsensiTadikaMesraDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private AbsensiTadikaMesraDataSetTableAdapters.classesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource usersBindingSource;
    }
}