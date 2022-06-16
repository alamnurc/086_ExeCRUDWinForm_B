namespace CRUD_Prodi_TI
{
    partial class Form_PA
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_PA));
            this.button_Back = new System.Windows.Forms.Button();
            this.label_PembimbingAkademik = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNIP = new System.Windows.Forms.TextBox();
            this.txtNP = new System.Windows.Forms.TextBox();
            this.txtMP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sMADataSet = new CRUD_Prodi_TI.SMADataSet();
            this.rEADPABindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEAD_PATableAdapter = new CRUD_Prodi_TI.SMADataSetTableAdapters.READ_PATableAdapter();
            this.nIPDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaPembimbingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mataPelajaranDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEADPABindingSource)).BeginInit();
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
            this.button_Back.TabIndex = 14;
            this.button_Back.UseVisualStyleBackColor = true;
            this.button_Back.Click += new System.EventHandler(this.button_Back_Click);
            // 
            // label_PembimbingAkademik
            // 
            this.label_PembimbingAkademik.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_PembimbingAkademik.Font = new System.Drawing.Font("HelveticaNowDisplay Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PembimbingAkademik.Location = new System.Drawing.Point(0, 0);
            this.label_PembimbingAkademik.Name = "label_PembimbingAkademik";
            this.label_PembimbingAkademik.Size = new System.Drawing.Size(800, 88);
            this.label_PembimbingAkademik.TabIndex = 13;
            this.label_PembimbingAkademik.Text = "Pembimbing Akademik";
            this.label_PembimbingAkademik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmdDelete
            // 
            this.cmdDelete.AutoSize = true;
            this.cmdDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdDelete.FlatAppearance.BorderSize = 0;
            this.cmdDelete.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdDelete.Location = new System.Drawing.Point(427, 203);
            this.cmdDelete.Name = "cmdDelete";
            this.cmdDelete.Size = new System.Drawing.Size(108, 36);
            this.cmdDelete.TabIndex = 32;
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
            this.cmdSave.Location = new System.Drawing.Point(427, 145);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(108, 36);
            this.cmdSave.TabIndex = 31;
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
            this.cmdAdd.Location = new System.Drawing.Point(427, 87);
            this.cmdAdd.Name = "cmdAdd";
            this.cmdAdd.Size = new System.Drawing.Size(108, 36);
            this.cmdAdd.TabIndex = 30;
            this.cmdAdd.Text = "Insert";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtNIP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtMP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 133);
            this.tableLayoutPanel1.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(139, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Nama Pembimbing";
            // 
            // txtNIP
            // 
            this.txtNIP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNIP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rEADPABindingSource, "NIP", true));
            this.txtNIP.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtNIP.Location = new System.Drawing.Point(161, 8);
            this.txtNIP.Name = "txtNIP";
            this.txtNIP.Size = new System.Drawing.Size(233, 27);
            this.txtNIP.TabIndex = 2;
            // 
            // txtNP
            // 
            this.txtNP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtNP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rEADPABindingSource, "Nama_Pembimbing", true));
            this.txtNP.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtNP.Location = new System.Drawing.Point(161, 52);
            this.txtNP.Name = "txtNP";
            this.txtNP.Size = new System.Drawing.Size(233, 27);
            this.txtNP.TabIndex = 3;
            // 
            // txtMP
            // 
            this.txtMP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtMP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rEADPABindingSource, "Mata_Pelajaran", true));
            this.txtMP.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtMP.Location = new System.Drawing.Point(161, 97);
            this.txtMP.Name = "txtMP";
            this.txtMP.Size = new System.Drawing.Size(233, 27);
            this.txtMP.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label6.Location = new System.Drawing.Point(3, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Mata Pelajaran";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label11.Location = new System.Drawing.Point(3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "NIP";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nIPDataGridViewTextBoxColumn,
            this.namaPembimbingDataGridViewTextBoxColumn,
            this.mataPelajaranDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEADPABindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(780, 193);
            this.dataGridView1.TabIndex = 33;
            // 
            // sMADataSet
            // 
            this.sMADataSet.DataSetName = "SMADataSet";
            this.sMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEADPABindingSource
            // 
            this.rEADPABindingSource.DataMember = "READ_PA";
            this.rEADPABindingSource.DataSource = this.sMADataSet;
            // 
            // rEAD_PATableAdapter
            // 
            this.rEAD_PATableAdapter.ClearBeforeFill = true;
            // 
            // nIPDataGridViewTextBoxColumn
            // 
            this.nIPDataGridViewTextBoxColumn.DataPropertyName = "NIP";
            this.nIPDataGridViewTextBoxColumn.HeaderText = "NIP";
            this.nIPDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nIPDataGridViewTextBoxColumn.Name = "nIPDataGridViewTextBoxColumn";
            this.nIPDataGridViewTextBoxColumn.Width = 150;
            // 
            // namaPembimbingDataGridViewTextBoxColumn
            // 
            this.namaPembimbingDataGridViewTextBoxColumn.DataPropertyName = "Nama_Pembimbing";
            this.namaPembimbingDataGridViewTextBoxColumn.HeaderText = "Nama_Pembimbing";
            this.namaPembimbingDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.namaPembimbingDataGridViewTextBoxColumn.Name = "namaPembimbingDataGridViewTextBoxColumn";
            this.namaPembimbingDataGridViewTextBoxColumn.Width = 150;
            // 
            // mataPelajaranDataGridViewTextBoxColumn
            // 
            this.mataPelajaranDataGridViewTextBoxColumn.DataPropertyName = "Mata_Pelajaran";
            this.mataPelajaranDataGridViewTextBoxColumn.HeaderText = "Mata_Pelajaran";
            this.mataPelajaranDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mataPelajaranDataGridViewTextBoxColumn.Name = "mataPelajaranDataGridViewTextBoxColumn";
            this.mataPelajaranDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form_PA
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
            this.Controls.Add(this.label_PembimbingAkademik);
            this.Name = "Form_PA";
            this.Text = "Form_PA";
            this.Load += new System.EventHandler(this.Form_PA_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEADPABindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label label_PembimbingAkademik;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNIP;
        private System.Windows.Forms.TextBox txtNP;
        private System.Windows.Forms.TextBox txtMP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SMADataSet sMADataSet;
        private System.Windows.Forms.BindingSource rEADPABindingSource;
        private SMADataSetTableAdapters.READ_PATableAdapter rEAD_PATableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIPDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaPembimbingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mataPelajaranDataGridViewTextBoxColumn;
    }
}