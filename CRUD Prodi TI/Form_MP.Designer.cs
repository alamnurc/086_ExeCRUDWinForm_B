namespace CRUD_Prodi_TI
{
    partial class Form_MP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MP));
            this.button_Back = new System.Windows.Forms.Button();
            this.label_MataPelajaran = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdMP = new System.Windows.Forms.TextBox();
            this.txtNMP = new System.Windows.Forms.TextBox();
            this.txtJ = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sMADataSet = new CRUD_Prodi_TI.SMADataSet();
            this.rEADMPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEAD_MPTableAdapter = new CRUD_Prodi_TI.SMADataSetTableAdapters.READ_MPTableAdapter();
            this.idMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaMPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEADMPBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Back
            // 
            this.button_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_Back.FlatAppearance.BorderSize = 0;
            this.button_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Back.Image = ((System.Drawing.Image)(resources.GetObject("button_Back.Image")));
            this.button_Back.Location = new System.Drawing.Point(12, 12);
            this.button_Back.Name = "button_Back";
            this.button_Back.Size = new System.Drawing.Size(64, 64);
            this.button_Back.TabIndex = 16;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // label_MataPelajaran
            // 
            this.label_MataPelajaran.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_MataPelajaran.Font = new System.Drawing.Font("HelveticaNowDisplay Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MataPelajaran.Location = new System.Drawing.Point(0, 0);
            this.label_MataPelajaran.Name = "label_MataPelajaran";
            this.label_MataPelajaran.Size = new System.Drawing.Size(800, 88);
            this.label_MataPelajaran.TabIndex = 15;
            this.label_MataPelajaran.Text = "Mata Pelajaran";
            this.label_MataPelajaran.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIdMP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNMP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtJ, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtS, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 82);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 47F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 178);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label5.Location = new System.Drawing.Point(3, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nama Mata Pelajaran";
            // 
            // txtIdMP
            // 
            this.txtIdMP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIdMP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rEADMPBindingSource, "Id_MP", true));
            this.txtIdMP.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtIdMP.Location = new System.Drawing.Point(161, 7);
            this.txtIdMP.Name = "txtIdMP";
            this.txtIdMP.Size = new System.Drawing.Size(233, 27);
            this.txtIdMP.TabIndex = 2;
            // 
            // txtNMP
            // 
            this.txtNMP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNMP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rEADMPBindingSource, "Nama_MP", true));
            this.txtNMP.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtNMP.Location = new System.Drawing.Point(161, 50);
            this.txtNMP.Name = "txtNMP";
            this.txtNMP.Size = new System.Drawing.Size(233, 27);
            this.txtNMP.TabIndex = 3;
            // 
            // txtJ
            // 
            this.txtJ.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtJ.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rEADMPBindingSource, "Jam", true));
            this.txtJ.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtJ.Location = new System.Drawing.Point(161, 95);
            this.txtJ.Name = "txtJ";
            this.txtJ.Size = new System.Drawing.Size(233, 27);
            this.txtJ.TabIndex = 4;
            // 
            // txtS
            // 
            this.txtS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rEADMPBindingSource, "Semester", true));
            this.txtS.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtS.Location = new System.Drawing.Point(161, 141);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(233, 27);
            this.txtS.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label6.Location = new System.Drawing.Point(3, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Jam";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label7.Location = new System.Drawing.Point(3, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 24);
            this.label7.TabIndex = 10;
            this.label7.Text = "Semester";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label11.Location = new System.Drawing.Point(3, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(124, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Id Mata Pelajaran";
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoSize = true;
            this.cmdDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDelete.FlatAppearance.BorderSize = 0;
            this.cmdDelete.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Location = new System.Drawing.Point(428, 204);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(108, 36);
            this.cmdDelete.TabIndex = 25;
            this.cmdDelete.Text = "Delete";
            this.cmdDelete.UseVisualStyleBackColor = true;
            this.cmdDelete.Click += new System.EventHandler(this.cmdDelete_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.AutoSize = true;
            this.cmdSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdSave.FlatAppearance.BorderSize = 0;
            this.cmdSave.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdSave.Location = new System.Drawing.Point(428, 146);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(108, 36);
            this.cmdSave.TabIndex = 24;
            this.cmdSave.Text = "Update";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdAdd
            // 
            this.cmdAdd.AutoSize = true;
            this.cmdAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdAdd.FlatAppearance.BorderSize = 0;
            this.cmdAdd.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdAdd.Location = new System.Drawing.Point(428, 88);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(108, 36);
            this.cmdAdd.TabIndex = 23;
            this.cmdAdd.Text = "Insert";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMPDataGridViewTextBoxColumn,
            this.namaMPDataGridViewTextBoxColumn,
            this.jamDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEADMPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 267);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(780, 171);
            this.dataGridView1.TabIndex = 26;
            // 
            // sMADataSet
            // 
            this.sMADataSet.DataSetName = "SMADataSet";
            this.sMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEADMPBindingSource
            // 
            this.rEADMPBindingSource.DataMember = "READ_MP";
            this.rEADMPBindingSource.DataSource = this.sMADataSet;
            // 
            // rEAD_MPTableAdapter
            // 
            this.rEAD_MPTableAdapter.ClearBeforeFill = true;
            // 
            // idMPDataGridViewTextBoxColumn
            // 
            this.idMPDataGridViewTextBoxColumn.DataPropertyName = "Id_MP";
            this.idMPDataGridViewTextBoxColumn.HeaderText = "Id_MP";
            this.idMPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idMPDataGridViewTextBoxColumn.Name = "idMPDataGridViewTextBoxColumn";
            this.idMPDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaMPDataGridViewTextBoxColumn
            // 
            this.namaMPDataGridViewTextBoxColumn.DataPropertyName = "Nama_MP";
            this.namaMPDataGridViewTextBoxColumn.HeaderText = "Nama_MP";
            this.namaMPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaMPDataGridViewTextBoxColumn.Name = "namaMPDataGridViewTextBoxColumn";
            this.namaMPDataGridViewTextBoxColumn.Width = 150;
            // 
            // jamDataGridViewTextBoxColumn
            // 
            this.jamDataGridViewTextBoxColumn.DataPropertyName = "Jam";
            this.jamDataGridViewTextBoxColumn.HeaderText = "Jam";
            this.jamDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.jamDataGridViewTextBoxColumn.Name = "jamDataGridViewTextBoxColumn";
            this.jamDataGridViewTextBoxColumn.Width = 150;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form_MP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmdDelete);
            this.Controls.Add(this.cmdSave);
            this.Controls.Add(this.cmdAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button_Back);
            this.Controls.Add(this.label_MataPelajaran);
            this.Name = "Form_MP";
            this.Text = "Form_MP";
            this.Load += new System.EventHandler(this.Form_MP_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEADMPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label label_MataPelajaran;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdMP;
        private System.Windows.Forms.TextBox txtNMP;
        private System.Windows.Forms.TextBox txtJ;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SMADataSet sMADataSet;
        private System.Windows.Forms.BindingSource rEADMPBindingSource;
        private SMADataSetTableAdapters.READ_MPTableAdapter rEAD_MPTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaMPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
    }
}