namespace Transaction_Statistical
{
    partial class UC_Menu_Startup
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Source = new System.Windows.Forms.TextBox();
            this.txt_Destination = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txt_TaskName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbl_Forms = new System.Windows.Forms.CheckedListBox();
            this.cbo_LstTemplate = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_HH = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dataGridView_lsPermissions = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn5 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewCheckBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lsPermissions)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(90, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Start at";
            // 
            // txt_Source
            // 
            this.txt_Source.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Source.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_Source.BackColor = System.Drawing.Color.DimGray;
            this.txt_Source.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Source.ForeColor = System.Drawing.Color.White;
            this.txt_Source.Location = new System.Drawing.Point(154, 95);
            this.txt_Source.Name = "txt_Source";
            this.txt_Source.Size = new System.Drawing.Size(560, 22);
            this.txt_Source.TabIndex = 6;
            this.txt_Source.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_MouseDown);
            // 
            // txt_Destination
            // 
            this.txt_Destination.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_Destination.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_Destination.BackColor = System.Drawing.Color.DimGray;
            this.txt_Destination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Destination.ForeColor = System.Drawing.Color.White;
            this.txt_Destination.Location = new System.Drawing.Point(154, 123);
            this.txt_Destination.Name = "txt_Destination";
            this.txt_Destination.Size = new System.Drawing.Size(560, 22);
            this.txt_Destination.TabIndex = 7;
            this.toolTip1.SetToolTip(this.txt_Destination, "Ex: D:\\Export\\Transaction_yyyyMMdd.xls");
            this.txt_Destination.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txt_MouseDown);
            // 
            // txt_TaskName
            // 
            this.txt_TaskName.BackColor = System.Drawing.Color.DimGray;
            this.txt_TaskName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_TaskName.ForeColor = System.Drawing.Color.White;
            this.txt_TaskName.Location = new System.Drawing.Point(154, 39);
            this.txt_TaskName.Name = "txt_TaskName";
            this.txt_TaskName.Size = new System.Drawing.Size(560, 22);
            this.txt_TaskName.TabIndex = 20;
            this.toolTip1.SetToolTip(this.txt_TaskName, "Ex: Run daily 22h00");
            this.txt_TaskName.TextChanged += new System.EventHandler(this.txt_TaskName_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ckbl_Forms);
            this.groupBox1.Controls.Add(this.cbo_LstTemplate);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_Add);
            this.groupBox1.Controls.Add(this.btn_Save);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_TaskName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_HH);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_Remove);
            this.groupBox1.Controls.Add(this.txt_Destination);
            this.groupBox1.Controls.Add(this.txt_Source);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(26, 169);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 288);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create/Modify";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(56, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Forms select";
            // 
            // ckbl_Forms
            // 
            this.ckbl_Forms.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.ckbl_Forms.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ckbl_Forms.CheckOnClick = true;
            this.ckbl_Forms.ForeColor = System.Drawing.Color.White;
            this.ckbl_Forms.FormattingEnabled = true;
            this.ckbl_Forms.Location = new System.Drawing.Point(154, 179);
            this.ckbl_Forms.Name = "ckbl_Forms";
            this.ckbl_Forms.Size = new System.Drawing.Size(560, 87);
            this.ckbl_Forms.TabIndex = 0;
            // 
            // cbo_LstTemplate
            // 
            this.cbo_LstTemplate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbo_LstTemplate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_LstTemplate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_LstTemplate.ForeColor = System.Drawing.Color.White;
            this.cbo_LstTemplate.FormattingEnabled = true;
            this.cbo_LstTemplate.Location = new System.Drawing.Point(154, 150);
            this.cbo_LstTemplate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbo_LstTemplate.Name = "cbo_LstTemplate";
            this.cbo_LstTemplate.Size = new System.Drawing.Size(560, 24);
            this.cbo_LstTemplate.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(77, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Template";
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.ForeColor = System.Drawing.Color.White;
            this.btn_Add.Location = new System.Drawing.Point(748, 75);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(105, 42);
            this.btn_Add.TabIndex = 23;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.ForeColor = System.Drawing.Color.White;
            this.btn_Save.Location = new System.Drawing.Point(748, 123);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(105, 42);
            this.btn_Save.TabIndex = 22;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(66, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Task name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(215, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "(HH:mm - 24h)";
            // 
            // txt_HH
            // 
            this.txt_HH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txt_HH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.txt_HH.BackColor = System.Drawing.Color.DimGray;
            this.txt_HH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_HH.ForeColor = System.Drawing.Color.White;
            this.txt_HH.Location = new System.Drawing.Point(154, 67);
            this.txt_HH.MaxLength = 8;
            this.txt_HH.Name = "txt_HH";
            this.txt_HH.Size = new System.Drawing.Size(55, 22);
            this.txt_HH.TabIndex = 18;
            this.txt_HH.Text = "02:00";
            this.txt_HH.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_HH.Validating += new System.ComponentModel.CancelEventHandler(this.txt_HH_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(23, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Export destination";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(48, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Import Source";
            // 
            // btn_Remove
            // 
            this.btn_Remove.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Remove.ForeColor = System.Drawing.Color.White;
            this.btn_Remove.Location = new System.Drawing.Point(748, 171);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(105, 42);
            this.btn_Remove.TabIndex = 15;
            this.btn_Remove.Text = "Remove";
            this.btn_Remove.UseVisualStyleBackColor = true;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView_lsPermissions);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(26, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 145);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Forms";
            // 
            // dataGridView_lsPermissions
            // 
            this.dataGridView_lsPermissions.AllowUserToAddRows = false;
            this.dataGridView_lsPermissions.AllowUserToDeleteRows = false;
            this.dataGridView_lsPermissions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView_lsPermissions.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_lsPermissions.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.dataGridView_lsPermissions.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView_lsPermissions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_lsPermissions.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewCheckBoxColumn5,
            this.dataGridViewCheckBoxColumn6,
            this.dataGridViewCheckBoxColumn7});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView_lsPermissions.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_lsPermissions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_lsPermissions.Location = new System.Drawing.Point(3, 18);
            this.dataGridView_lsPermissions.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_lsPermissions.MultiSelect = false;
            this.dataGridView_lsPermissions.Name = "dataGridView_lsPermissions";
            this.dataGridView_lsPermissions.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView_lsPermissions.RowHeadersVisible = false;
            this.dataGridView_lsPermissions.RowHeadersWidth = 51;
            this.dataGridView_lsPermissions.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_lsPermissions.Size = new System.Drawing.Size(872, 124);
            this.dataGridView_lsPermissions.TabIndex = 8;
            this.dataGridView_lsPermissions.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_lsPermissions_CellClick);
            this.dataGridView_lsPermissions.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_lsPermissions_CellContentClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "No.";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 59;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Name";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn5.Width = 74;
            // 
            // dataGridViewCheckBoxColumn5
            // 
            this.dataGridViewCheckBoxColumn5.FalseValue = "F";
            this.dataGridViewCheckBoxColumn5.HeaderText = "Active";
            this.dataGridViewCheckBoxColumn5.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn5.Name = "dataGridViewCheckBoxColumn5";
            this.dataGridViewCheckBoxColumn5.TrueValue = "T";
            this.dataGridViewCheckBoxColumn5.Width = 52;
            // 
            // dataGridViewCheckBoxColumn6
            // 
            this.dataGridViewCheckBoxColumn6.HeaderText = "Start at";
            this.dataGridViewCheckBoxColumn6.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn6.Name = "dataGridViewCheckBoxColumn6";
            this.dataGridViewCheckBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewCheckBoxColumn6.Width = 60;
            // 
            // dataGridViewCheckBoxColumn7
            // 
            this.dataGridViewCheckBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewCheckBoxColumn7.HeaderText = "Description";
            this.dataGridViewCheckBoxColumn7.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn7.Name = "dataGridViewCheckBoxColumn7";
            this.dataGridViewCheckBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCheckBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // UC_Menu_Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "UC_Menu_Startup";
            this.Size = new System.Drawing.Size(932, 480);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_lsPermissions)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Source;
        private System.Windows.Forms.TextBox txt_Destination;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_HH;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_TaskName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox ckbl_Forms;
        private System.Windows.Forms.ComboBox cbo_LstTemplate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView_lsPermissions;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCheckBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewCheckBoxColumn7;
    }
}
