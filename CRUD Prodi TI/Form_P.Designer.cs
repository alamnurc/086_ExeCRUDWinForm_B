namespace CRUD_Prodi_TI
{
    partial class Form_P
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_P));
            this.button_Back = new System.Windows.Forms.Button();
            this.label_Periode = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIdP = new System.Windows.Forms.TextBox();
            this.txtTA = new System.Windows.Forms.TextBox();
            this.txtS = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.cmdDelete = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdAdd = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sMADataSet = new CRUD_Prodi_TI.SMADataSet();
            this.rEADPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rEAD_PTableAdapter = new CRUD_Prodi_TI.SMADataSetTableAdapters.READ_PTableAdapter();
            this.idPeriodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tahunAjarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.semesterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEADPBindingSource)).BeginInit();
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
            // label_Periode
            // 
            this.label_Periode.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_Periode.Font = new System.Drawing.Font("HelveticaNowDisplay Black", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Periode.Location = new System.Drawing.Point(0, 0);
            this.label_Periode.Name = "label_Periode";
            this.label_Periode.Size = new System.Drawing.Size(800, 88);
            this.label_Periode.TabIndex = 15;
            this.label_Periode.Text = "Periode";
            this.label_Periode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_Periode.Click += new System.EventHandler(this.label_PembimbingAkademik_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 240F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtIdP, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTA, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtS, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label11, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(398, 133);
            this.tableLayoutPanel1.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Tahun Ajar";
            // 
            // txtIdP
            // 
            this.txtIdP.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtIdP.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rEADPBindingSource, "Id_Periode", true));
            this.txtIdP.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtIdP.Location = new System.Drawing.Point(161, 8);
            this.txtIdP.Name = "txtIdP";
            this.txtIdP.Size = new System.Drawing.Size(233, 27);
            this.txtIdP.TabIndex = 2;
            // 
            // txtTA
            // 
            this.txtTA.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtTA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rEADPBindingSource, "Tahun_Ajar", true));
            this.txtTA.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtTA.Location = new System.Drawing.Point(161, 52);
            this.txtTA.Name = "txtTA";
            this.txtTA.Size = new System.Drawing.Size(233, 27);
            this.txtTA.TabIndex = 3;
            // 
            // txtS
            // 
            this.txtS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rEADPBindingSource, "Semester", true));
            this.txtS.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.txtS.Location = new System.Drawing.Point(161, 97);
            this.txtS.Name = "txtS";
            this.txtS.Size = new System.Drawing.Size(233, 27);
            this.txtS.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label6.Location = new System.Drawing.Point(3, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Semester";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("HelveticaNowDisplay Regular", 8F);
            this.label11.Location = new System.Drawing.Point(3, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 24);
            this.label11.TabIndex = 0;
            this.label11.Text = "Id Periode";
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
            this.cmdDelete.TabIndex = 28;
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
            this.cmdSave.TabIndex = 27;
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
            this.cmdAdd.TabIndex = 26;
            this.cmdAdd.Text = "Insert";
            this.cmdAdd.UseVisualStyleBackColor = true;
            this.cmdAdd.Click += new System.EventHandler(this.cmdAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPeriodeDataGridViewTextBoxColumn,
            this.tahunAjarDataGridViewTextBoxColumn,
            this.semesterDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.rEADPBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 245);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(776, 193);
            this.dataGridView1.TabIndex = 29;
            // 
            // sMADataSet
            // 
            this.sMADataSet.DataSetName = "SMADataSet";
            this.sMADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rEADPBindingSource
            // 
            this.rEADPBindingSource.DataMember = "READ_P";
            this.rEADPBindingSource.DataSource = this.sMADataSet;
            // 
            // rEAD_PTableAdapter
            // 
            this.rEAD_PTableAdapter.ClearBeforeFill = true;
            // 
            // idPeriodeDataGridViewTextBoxColumn
            // 
            this.idPeriodeDataGridViewTextBoxColumn.DataPropertyName = "Id_Periode";
            this.idPeriodeDataGridViewTextBoxColumn.HeaderText = "Id_Periode";
            this.idPeriodeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idPeriodeDataGridViewTextBoxColumn.Name = "idPeriodeDataGridViewTextBoxColumn";
            this.idPeriodeDataGridViewTextBoxColumn.Width = 150;
            // 
            // tahunAjarDataGridViewTextBoxColumn
            // 
            this.tahunAjarDataGridViewTextBoxColumn.DataPropertyName = "Tahun_Ajar";
            this.tahunAjarDataGridViewTextBoxColumn.HeaderText = "Tahun_Ajar";
            this.tahunAjarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tahunAjarDataGridViewTextBoxColumn.Name = "tahunAjarDataGridViewTextBoxColumn";
            this.tahunAjarDataGridViewTextBoxColumn.Width = 150;
            // 
            // semesterDataGridViewTextBoxColumn
            // 
            this.semesterDataGridViewTextBoxColumn.DataPropertyName = "Semester";
            this.semesterDataGridViewTextBoxColumn.HeaderText = "Semester";
            this.semesterDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.semesterDataGridViewTextBoxColumn.Name = "semesterDataGridViewTextBoxColumn";
            this.semesterDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form_P
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
            this.Controls.Add(this.label_Periode);
            this.Name = "Form_P";
            this.Text = "Form_P";
            this.Load += new System.EventHandler(this.Form_P_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sMADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rEADPBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Back;
        private System.Windows.Forms.Label label_Periode;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIdP;
        private System.Windows.Forms.TextBox txtTA;
        private System.Windows.Forms.TextBox txtS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button cmdDelete;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdAdd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SMADataSet sMADataSet;
        private System.Windows.Forms.BindingSource rEADPBindingSource;
        private SMADataSetTableAdapters.READ_PTableAdapter rEAD_PTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPeriodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tahunAjarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn semesterDataGridViewTextBoxColumn;
    }
}