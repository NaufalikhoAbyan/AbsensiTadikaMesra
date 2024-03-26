namespace AbsensiTadikaMesraProd.Guru
{
    partial class DashboardGuru
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.kelasCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.siswaCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.absensiTadikaMesraDataSet = new AbsensiTadikaMesraProd.AbsensiTadikaMesraDataSet();
            this.studentsTableAdapter = new AbsensiTadikaMesraProd.AbsensiTadikaMesraDataSetTableAdapters.studentsTableAdapter();
            this.classesTableAdapter = new AbsensiTadikaMesraProd.AbsensiTadikaMesraDataSetTableAdapters.classesTableAdapter();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absensiTadikaMesraDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 167);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.kelasCount);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(430, 30);
            this.panel3.Margin = new System.Windows.Forms.Padding(30);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(340, 107);
            this.panel3.TabIndex = 2;
            // 
            // kelasCount
            // 
            this.kelasCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.kelasCount.AutoSize = true;
            this.kelasCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.kelasCount.Location = new System.Drawing.Point(144, 62);
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
            this.label6.Location = new System.Drawing.Point(125, 6);
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
            this.panel2.Location = new System.Drawing.Point(30, 30);
            this.panel2.Margin = new System.Windows.Forms.Padding(30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(340, 107);
            this.panel2.TabIndex = 1;
            // 
            // siswaCount
            // 
            this.siswaCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.siswaCount.AutoSize = true;
            this.siswaCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.5F);
            this.siswaCount.Location = new System.Drawing.Point(144, 62);
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
            this.label4.Location = new System.Drawing.Point(125, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "Siswa";
            // 
            // absensiTadikaMesraDataSet
            // 
            this.absensiTadikaMesraDataSet.DataSetName = "AbsensiTadikaMesraDataSet";
            this.absensiTadikaMesraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // studentsTableAdapter
            // 
            this.studentsTableAdapter.ClearBeforeFill = true;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // DashboardGuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "DashboardGuru";
            this.Text = "DashboardGuru";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.absensiTadikaMesraDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label kelasCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label siswaCount;
        private System.Windows.Forms.Label label4;
        private AbsensiTadikaMesraDataSet absensiTadikaMesraDataSet;
        private AbsensiTadikaMesraDataSetTableAdapters.studentsTableAdapter studentsTableAdapter;
        private AbsensiTadikaMesraDataSetTableAdapters.classesTableAdapter classesTableAdapter;
    }
}