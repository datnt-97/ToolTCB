namespace Transaction_Statistical
{
    partial class UC_CfgTemplate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CfgTemplate));
            this.spc_Main = new System.Windows.Forms.SplitContainer();
            this.grp_Keyword = new System.Windows.Forms.GroupBox();
            this.spc_Keyword_Main = new System.Windows.Forms.SplitContainer();
            this.btn_Keyword_Resfresh = new System.Windows.Forms.Button();
            this.cbo_Keyword_LstKeyword = new System.Windows.Forms.ComboBox();
            this.spc_Keyword_Level = new System.Windows.Forms.SplitContainer();
            this.spc_Keyword_Pattern = new System.Windows.Forms.SplitContainer();
            this.fctxt_Pattern = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chk_Keywork_Pattern = new System.Windows.Forms.CheckBox();
            this.btn_Keyword_Add = new System.Windows.Forms.Button();
            this.btn_Keyword_Remove = new System.Windows.Forms.Button();
            this.btn_Keyword_Save = new System.Windows.Forms.Button();
            this.btn_Keyword_Help = new System.Windows.Forms.Button();
            this.spc_Keyword_Test = new System.Windows.Forms.SplitContainer();
            this.fctxt_Test = new FastColoredTextBoxNS.FastColoredTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_Keywork_Test = new System.Windows.Forms.CheckBox();
            this.btn_Keyword_Import = new System.Windows.Forms.Button();
            this.btn_Keyword_Run = new System.Windows.Forms.Button();
            this.grp_Transaction = new System.Windows.Forms.GroupBox();
            this.fctxt_Unsuccessful = new FastColoredTextBoxNS.FastColoredTextBox();
            this.cbo_Transactions = new System.Windows.Forms.ComboBox();
            this.fctxt_Successful = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btn_Transaction_Add = new System.Windows.Forms.Button();
            this.fctxt_Identification = new FastColoredTextBoxNS.FastColoredTextBox();
            this.btn_Transaction_Save = new System.Windows.Forms.Button();
            this.btn_Transaction_Remove = new System.Windows.Forms.Button();
            this.btn_Transaction_Refresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Main)).BeginInit();
            this.spc_Main.Panel1.SuspendLayout();
            this.spc_Main.Panel2.SuspendLayout();
            this.spc_Main.SuspendLayout();
            this.grp_Keyword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Keyword_Main)).BeginInit();
            this.spc_Keyword_Main.Panel1.SuspendLayout();
            this.spc_Keyword_Main.Panel2.SuspendLayout();
            this.spc_Keyword_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Keyword_Level)).BeginInit();
            this.spc_Keyword_Level.Panel1.SuspendLayout();
            this.spc_Keyword_Level.Panel2.SuspendLayout();
            this.spc_Keyword_Level.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Keyword_Pattern)).BeginInit();
            this.spc_Keyword_Pattern.Panel1.SuspendLayout();
            this.spc_Keyword_Pattern.Panel2.SuspendLayout();
            this.spc_Keyword_Pattern.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_Pattern)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Keyword_Test)).BeginInit();
            this.spc_Keyword_Test.Panel1.SuspendLayout();
            this.spc_Keyword_Test.Panel2.SuspendLayout();
            this.spc_Keyword_Test.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_Test)).BeginInit();
            this.grp_Transaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_Unsuccessful)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_Successful)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_Identification)).BeginInit();
            this.SuspendLayout();
            // 
            // spc_Main
            // 
            this.spc_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Main.Location = new System.Drawing.Point(0, 0);
            this.spc_Main.Name = "spc_Main";
            // 
            // spc_Main.Panel1
            // 
            this.spc_Main.Panel1.Controls.Add(this.grp_Keyword);
            // 
            // spc_Main.Panel2
            // 
            this.spc_Main.Panel2.Controls.Add(this.grp_Transaction);
            this.spc_Main.Size = new System.Drawing.Size(1500, 779);
            this.spc_Main.SplitterDistance = 809;
            this.spc_Main.TabIndex = 0;
            this.spc_Main.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.spc_Main_SplitterMoved);
            // 
            // grp_Keyword
            // 
            this.grp_Keyword.Controls.Add(this.spc_Keyword_Main);
            this.grp_Keyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Keyword.ForeColor = System.Drawing.Color.White;
            this.grp_Keyword.Location = new System.Drawing.Point(0, 0);
            this.grp_Keyword.Name = "grp_Keyword";
            this.grp_Keyword.Size = new System.Drawing.Size(809, 779);
            this.grp_Keyword.TabIndex = 0;
            this.grp_Keyword.TabStop = false;
            this.grp_Keyword.Text = "Key works";
            this.grp_Keyword.Enter += new System.EventHandler(this.grp_Keyword_Enter);
            // 
            // spc_Keyword_Main
            // 
            this.spc_Keyword_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Keyword_Main.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spc_Keyword_Main.IsSplitterFixed = true;
            this.spc_Keyword_Main.Location = new System.Drawing.Point(3, 18);
            this.spc_Keyword_Main.Name = "spc_Keyword_Main";
            this.spc_Keyword_Main.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_Keyword_Main.Panel1
            // 
            this.spc_Keyword_Main.Panel1.Controls.Add(this.btn_Keyword_Resfresh);
            this.spc_Keyword_Main.Panel1.Controls.Add(this.cbo_Keyword_LstKeyword);
            // 
            // spc_Keyword_Main.Panel2
            // 
            this.spc_Keyword_Main.Panel2.Controls.Add(this.spc_Keyword_Level);
            this.spc_Keyword_Main.Size = new System.Drawing.Size(803, 758);
            this.spc_Keyword_Main.SplitterDistance = 53;
            this.spc_Keyword_Main.TabIndex = 0;
            this.spc_Keyword_Main.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.spc_Keyword_Main_SplitterMoved);
            // 
            // btn_Keyword_Resfresh
            // 
            this.btn_Keyword_Resfresh.AutoSize = true;
            this.btn_Keyword_Resfresh.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Keyword_Resfresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Keyword_Resfresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Keyword_Resfresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Keyword_Resfresh.Location = new System.Drawing.Point(645, 9);
            this.btn_Keyword_Resfresh.Name = "btn_Keyword_Resfresh";
            this.btn_Keyword_Resfresh.Size = new System.Drawing.Size(105, 34);
            this.btn_Keyword_Resfresh.TabIndex = 14;
            this.btn_Keyword_Resfresh.Text = "Resfresh";
            this.btn_Keyword_Resfresh.UseVisualStyleBackColor = true;
            this.btn_Keyword_Resfresh.Click += new System.EventHandler(this.btn_Keyword_Resfresh_Click);
            // 
            // cbo_Keyword_LstKeyword
            // 
            this.cbo_Keyword_LstKeyword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbo_Keyword_LstKeyword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_Keyword_LstKeyword.ForeColor = System.Drawing.Color.White;
            this.cbo_Keyword_LstKeyword.FormattingEnabled = true;
            this.cbo_Keyword_LstKeyword.Location = new System.Drawing.Point(25, 15);
            this.cbo_Keyword_LstKeyword.Name = "cbo_Keyword_LstKeyword";
            this.cbo_Keyword_LstKeyword.Size = new System.Drawing.Size(587, 24);
            this.cbo_Keyword_LstKeyword.TabIndex = 13;
            this.cbo_Keyword_LstKeyword.SelectedIndexChanged += new System.EventHandler(this.cbo_Keyword_LstKeyword_SelectedIndexChanged);
            this.cbo_Keyword_LstKeyword.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbo_Keyword_LstKeyword_MouseDown);
            // 
            // spc_Keyword_Level
            // 
            this.spc_Keyword_Level.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Keyword_Level.Location = new System.Drawing.Point(0, 0);
            this.spc_Keyword_Level.Name = "spc_Keyword_Level";
            this.spc_Keyword_Level.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spc_Keyword_Level.Panel1
            // 
            this.spc_Keyword_Level.Panel1.Controls.Add(this.spc_Keyword_Pattern);
            // 
            // spc_Keyword_Level.Panel2
            // 
            this.spc_Keyword_Level.Panel2.Controls.Add(this.spc_Keyword_Test);
            this.spc_Keyword_Level.Size = new System.Drawing.Size(803, 701);
            this.spc_Keyword_Level.SplitterDistance = 332;
            this.spc_Keyword_Level.TabIndex = 0;
            this.spc_Keyword_Level.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.spc_Keyword_Level_SplitterMoved);
            // 
            // spc_Keyword_Pattern
            // 
            this.spc_Keyword_Pattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Keyword_Pattern.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spc_Keyword_Pattern.IsSplitterFixed = true;
            this.spc_Keyword_Pattern.Location = new System.Drawing.Point(0, 0);
            this.spc_Keyword_Pattern.Name = "spc_Keyword_Pattern";
            // 
            // spc_Keyword_Pattern.Panel1
            // 
            this.spc_Keyword_Pattern.Panel1.Controls.Add(this.fctxt_Pattern);
            // 
            // spc_Keyword_Pattern.Panel2
            // 
            this.spc_Keyword_Pattern.Panel2.Controls.Add(this.label1);
            this.spc_Keyword_Pattern.Panel2.Controls.Add(this.chk_Keywork_Pattern);
            this.spc_Keyword_Pattern.Panel2.Controls.Add(this.btn_Keyword_Add);
            this.spc_Keyword_Pattern.Panel2.Controls.Add(this.btn_Keyword_Remove);
            this.spc_Keyword_Pattern.Panel2.Controls.Add(this.btn_Keyword_Save);
            this.spc_Keyword_Pattern.Panel2.Controls.Add(this.btn_Keyword_Help);
            this.spc_Keyword_Pattern.Size = new System.Drawing.Size(803, 332);
            this.spc_Keyword_Pattern.SplitterDistance = 641;
            this.spc_Keyword_Pattern.TabIndex = 0;
            this.spc_Keyword_Pattern.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.spc_Keyword_Pattern_SplitterMoved);
            // 
            // fctxt_Pattern
            // 
            this.fctxt_Pattern.AllowSeveralTextStyleDrawing = true;
            this.fctxt_Pattern.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctxt_Pattern.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.fctxt_Pattern.BackBrush = null;
            this.fctxt_Pattern.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.fctxt_Pattern.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctxt_Pattern.CharHeight = 18;
            this.fctxt_Pattern.CharWidth = 10;
            this.fctxt_Pattern.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctxt_Pattern.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctxt_Pattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctxt_Pattern.IndentBackColor = System.Drawing.Color.DimGray;
            this.fctxt_Pattern.IsReplaceMode = false;
            this.fctxt_Pattern.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fctxt_Pattern.Location = new System.Drawing.Point(0, 0);
            this.fctxt_Pattern.Name = "fctxt_Pattern";
            this.fctxt_Pattern.Paddings = new System.Windows.Forms.Padding(0);
            this.fctxt_Pattern.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctxt_Pattern.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctxt_Pattern.ServiceColors")));
            this.fctxt_Pattern.ServiceLinesColor = System.Drawing.Color.DimGray;
            this.fctxt_Pattern.Size = new System.Drawing.Size(641, 332);
            this.fctxt_Pattern.TabIndex = 1;
            this.fctxt_Pattern.WordWrap = true;
            this.fctxt_Pattern.Zoom = 100;
            this.fctxt_Pattern.Load += new System.EventHandler(this.fctxt_Pattern_Load);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Pattern String";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // chk_Keywork_Pattern
            // 
            this.chk_Keywork_Pattern.AutoSize = true;
            this.chk_Keywork_Pattern.Checked = true;
            this.chk_Keywork_Pattern.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Keywork_Pattern.Location = new System.Drawing.Point(28, 224);
            this.chk_Keywork_Pattern.Name = "chk_Keywork_Pattern";
            this.chk_Keywork_Pattern.Size = new System.Drawing.Size(102, 21);
            this.chk_Keywork_Pattern.TabIndex = 17;
            this.chk_Keywork_Pattern.Text = "Word Wrap";
            this.chk_Keywork_Pattern.UseVisualStyleBackColor = true;
            this.chk_Keywork_Pattern.CheckedChanged += new System.EventHandler(this.chk_Keywork_Pattern_CheckedChanged);
            // 
            // btn_Keyword_Add
            // 
            this.btn_Keyword_Add.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Keyword_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Keyword_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Keyword_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Keyword_Add.Location = new System.Drawing.Point(29, 80);
            this.btn_Keyword_Add.Name = "btn_Keyword_Add";
            this.btn_Keyword_Add.Size = new System.Drawing.Size(105, 42);
            this.btn_Keyword_Add.TabIndex = 15;
            this.btn_Keyword_Add.Text = "Add";
            this.btn_Keyword_Add.UseVisualStyleBackColor = true;
            this.btn_Keyword_Add.Click += new System.EventHandler(this.btn_Keyword_Add_Click);
            // 
            // btn_Keyword_Remove
            // 
            this.btn_Keyword_Remove.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Keyword_Remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Keyword_Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Keyword_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Keyword_Remove.Location = new System.Drawing.Point(28, 128);
            this.btn_Keyword_Remove.Name = "btn_Keyword_Remove";
            this.btn_Keyword_Remove.Size = new System.Drawing.Size(105, 42);
            this.btn_Keyword_Remove.TabIndex = 16;
            this.btn_Keyword_Remove.Text = "Remove";
            this.btn_Keyword_Remove.UseVisualStyleBackColor = true;
            this.btn_Keyword_Remove.Click += new System.EventHandler(this.btn_Keyword_Remove_Click);
            // 
            // btn_Keyword_Save
            // 
            this.btn_Keyword_Save.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Keyword_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Keyword_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Keyword_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Keyword_Save.Location = new System.Drawing.Point(29, 32);
            this.btn_Keyword_Save.Name = "btn_Keyword_Save";
            this.btn_Keyword_Save.Size = new System.Drawing.Size(105, 42);
            this.btn_Keyword_Save.TabIndex = 14;
            this.btn_Keyword_Save.Text = "Save";
            this.btn_Keyword_Save.UseVisualStyleBackColor = true;
            this.btn_Keyword_Save.Click += new System.EventHandler(this.btn_Keyword_Save_Click);
            // 
            // btn_Keyword_Help
            // 
            this.btn_Keyword_Help.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Keyword_Help.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Keyword_Help.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Keyword_Help.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Keyword_Help.Location = new System.Drawing.Point(28, 176);
            this.btn_Keyword_Help.Name = "btn_Keyword_Help";
            this.btn_Keyword_Help.Size = new System.Drawing.Size(105, 42);
            this.btn_Keyword_Help.TabIndex = 12;
            this.btn_Keyword_Help.Text = "Help";
            this.btn_Keyword_Help.UseVisualStyleBackColor = true;
            this.btn_Keyword_Help.Click += new System.EventHandler(this.btn_Keyword_Help_Click);
            // 
            // spc_Keyword_Test
            // 
            this.spc_Keyword_Test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spc_Keyword_Test.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.spc_Keyword_Test.Location = new System.Drawing.Point(0, 0);
            this.spc_Keyword_Test.Name = "spc_Keyword_Test";
            // 
            // spc_Keyword_Test.Panel1
            // 
            this.spc_Keyword_Test.Panel1.Controls.Add(this.fctxt_Test);
            // 
            // spc_Keyword_Test.Panel2
            // 
            this.spc_Keyword_Test.Panel2.Controls.Add(this.label2);
            this.spc_Keyword_Test.Panel2.Controls.Add(this.chk_Keywork_Test);
            this.spc_Keyword_Test.Panel2.Controls.Add(this.btn_Keyword_Import);
            this.spc_Keyword_Test.Panel2.Controls.Add(this.btn_Keyword_Run);
            this.spc_Keyword_Test.Size = new System.Drawing.Size(803, 365);
            this.spc_Keyword_Test.SplitterDistance = 641;
            this.spc_Keyword_Test.TabIndex = 0;
            this.spc_Keyword_Test.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.spc_Keyword_Test_SplitterMoved);
            // 
            // fctxt_Test
            // 
            this.fctxt_Test.AllowSeveralTextStyleDrawing = true;
            this.fctxt_Test.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctxt_Test.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.fctxt_Test.BackBrush = null;
            this.fctxt_Test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.fctxt_Test.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctxt_Test.CharHeight = 18;
            this.fctxt_Test.CharWidth = 10;
            this.fctxt_Test.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctxt_Test.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctxt_Test.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fctxt_Test.IndentBackColor = System.Drawing.Color.DimGray;
            this.fctxt_Test.IsReplaceMode = false;
            this.fctxt_Test.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fctxt_Test.Location = new System.Drawing.Point(0, 0);
            this.fctxt_Test.Name = "fctxt_Test";
            this.fctxt_Test.Paddings = new System.Windows.Forms.Padding(0);
            this.fctxt_Test.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctxt_Test.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctxt_Test.ServiceColors")));
            this.fctxt_Test.ServiceLinesColor = System.Drawing.Color.DimGray;
            this.fctxt_Test.Size = new System.Drawing.Size(641, 365);
            this.fctxt_Test.TabIndex = 2;
            this.fctxt_Test.WordWrap = true;
            this.fctxt_Test.Zoom = 100;
            this.fctxt_Test.Load += new System.EventHandler(this.fctxt_Test_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Test String";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chk_Keywork_Test
            // 
            this.chk_Keywork_Test.AutoSize = true;
            this.chk_Keywork_Test.Checked = true;
            this.chk_Keywork_Test.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Keywork_Test.Location = new System.Drawing.Point(28, 137);
            this.chk_Keywork_Test.Name = "chk_Keywork_Test";
            this.chk_Keywork_Test.Size = new System.Drawing.Size(102, 21);
            this.chk_Keywork_Test.TabIndex = 16;
            this.chk_Keywork_Test.Text = "Word Wrap";
            this.chk_Keywork_Test.UseVisualStyleBackColor = true;
            this.chk_Keywork_Test.CheckedChanged += new System.EventHandler(this.chk_Keywork_Test_CheckedChanged);
            // 
            // btn_Keyword_Import
            // 
            this.btn_Keyword_Import.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Keyword_Import.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Keyword_Import.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Keyword_Import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Keyword_Import.Location = new System.Drawing.Point(29, 89);
            this.btn_Keyword_Import.Name = "btn_Keyword_Import";
            this.btn_Keyword_Import.Size = new System.Drawing.Size(105, 42);
            this.btn_Keyword_Import.TabIndex = 15;
            this.btn_Keyword_Import.Text = "Import";
            this.btn_Keyword_Import.UseVisualStyleBackColor = true;
            this.btn_Keyword_Import.Click += new System.EventHandler(this.btn_Keyword_Import_Click);
            // 
            // btn_Keyword_Run
            // 
            this.btn_Keyword_Run.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Keyword_Run.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Keyword_Run.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Keyword_Run.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Keyword_Run.Location = new System.Drawing.Point(29, 41);
            this.btn_Keyword_Run.Name = "btn_Keyword_Run";
            this.btn_Keyword_Run.Size = new System.Drawing.Size(105, 42);
            this.btn_Keyword_Run.TabIndex = 14;
            this.btn_Keyword_Run.Text = "Run";
            this.btn_Keyword_Run.UseVisualStyleBackColor = true;
            this.btn_Keyword_Run.Click += new System.EventHandler(this.btn_Keyword_Run_Click);
            // 
            // grp_Transaction
            // 
            this.grp_Transaction.Controls.Add(this.btn_Transaction_Refresh);
            this.grp_Transaction.Controls.Add(this.fctxt_Unsuccessful);
            this.grp_Transaction.Controls.Add(this.cbo_Transactions);
            this.grp_Transaction.Controls.Add(this.fctxt_Successful);
            this.grp_Transaction.Controls.Add(this.btn_Transaction_Add);
            this.grp_Transaction.Controls.Add(this.fctxt_Identification);
            this.grp_Transaction.Controls.Add(this.btn_Transaction_Save);
            this.grp_Transaction.Controls.Add(this.btn_Transaction_Remove);
            this.grp_Transaction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grp_Transaction.ForeColor = System.Drawing.Color.White;
            this.grp_Transaction.Location = new System.Drawing.Point(0, 0);
            this.grp_Transaction.Name = "grp_Transaction";
            this.grp_Transaction.Size = new System.Drawing.Size(687, 779);
            this.grp_Transaction.TabIndex = 1;
            this.grp_Transaction.TabStop = false;
            this.grp_Transaction.Text = "Transaction defind";
            this.grp_Transaction.Enter += new System.EventHandler(this.grp_Transaction_Enter);
            // 
            // fctxt_Unsuccessful
            // 
            this.fctxt_Unsuccessful.AllowSeveralTextStyleDrawing = true;
            this.fctxt_Unsuccessful.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctxt_Unsuccessful.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.fctxt_Unsuccessful.BackBrush = null;
            this.fctxt_Unsuccessful.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.fctxt_Unsuccessful.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctxt_Unsuccessful.CharHeight = 18;
            this.fctxt_Unsuccessful.CharWidth = 10;
            this.fctxt_Unsuccessful.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctxt_Unsuccessful.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctxt_Unsuccessful.IndentBackColor = System.Drawing.Color.DimGray;
            this.fctxt_Unsuccessful.IsReplaceMode = false;
            this.fctxt_Unsuccessful.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fctxt_Unsuccessful.Location = new System.Drawing.Point(24, 335);
            this.fctxt_Unsuccessful.Name = "fctxt_Unsuccessful";
            this.fctxt_Unsuccessful.Paddings = new System.Windows.Forms.Padding(0);
            this.fctxt_Unsuccessful.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctxt_Unsuccessful.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctxt_Unsuccessful.ServiceColors")));
            this.fctxt_Unsuccessful.ServiceLinesColor = System.Drawing.Color.DimGray;
            this.fctxt_Unsuccessful.Size = new System.Drawing.Size(569, 127);
            this.fctxt_Unsuccessful.TabIndex = 24;
            this.fctxt_Unsuccessful.WordWrap = true;
            this.fctxt_Unsuccessful.Zoom = 100;
            this.fctxt_Unsuccessful.Load += new System.EventHandler(this.fctxt_Unsuccessful_Load);
            // 
            // cbo_Transactions
            // 
            this.cbo_Transactions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.cbo_Transactions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_Transactions.ForeColor = System.Drawing.Color.White;
            this.cbo_Transactions.FormattingEnabled = true;
            this.cbo_Transactions.Location = new System.Drawing.Point(24, 34);
            this.cbo_Transactions.Name = "cbo_Transactions";
            this.cbo_Transactions.Size = new System.Drawing.Size(447, 24);
            this.cbo_Transactions.TabIndex = 18;
            this.cbo_Transactions.SelectedIndexChanged += new System.EventHandler(this.cbo_Transactions_SelectedIndexChanged);
            this.cbo_Transactions.TextChanged += new System.EventHandler(this.cbo_Transactions_TextChanged);
            this.cbo_Transactions.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cbo_Transactions_MouseDown);
            // 
            // fctxt_Successful
            // 
            this.fctxt_Successful.AllowSeveralTextStyleDrawing = true;
            this.fctxt_Successful.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctxt_Successful.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.fctxt_Successful.BackBrush = null;
            this.fctxt_Successful.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.fctxt_Successful.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctxt_Successful.CharHeight = 18;
            this.fctxt_Successful.CharWidth = 10;
            this.fctxt_Successful.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctxt_Successful.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctxt_Successful.IndentBackColor = System.Drawing.Color.DimGray;
            this.fctxt_Successful.IsReplaceMode = false;
            this.fctxt_Successful.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fctxt_Successful.Location = new System.Drawing.Point(24, 202);
            this.fctxt_Successful.Name = "fctxt_Successful";
            this.fctxt_Successful.Paddings = new System.Windows.Forms.Padding(0);
            this.fctxt_Successful.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctxt_Successful.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctxt_Successful.ServiceColors")));
            this.fctxt_Successful.ServiceLinesColor = System.Drawing.Color.DimGray;
            this.fctxt_Successful.Size = new System.Drawing.Size(569, 127);
            this.fctxt_Successful.TabIndex = 23;
            this.fctxt_Successful.WordWrap = true;
            this.fctxt_Successful.Zoom = 100;
            this.fctxt_Successful.Load += new System.EventHandler(this.fctxt_Successful_Load);
            // 
            // btn_Transaction_Add
            // 
            this.btn_Transaction_Add.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Transaction_Add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Transaction_Add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Transaction_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transaction_Add.Location = new System.Drawing.Point(178, 492);
            this.btn_Transaction_Add.Name = "btn_Transaction_Add";
            this.btn_Transaction_Add.Size = new System.Drawing.Size(105, 42);
            this.btn_Transaction_Add.TabIndex = 19;
            this.btn_Transaction_Add.Text = "Add";
            this.btn_Transaction_Add.UseVisualStyleBackColor = true;
            this.btn_Transaction_Add.Click += new System.EventHandler(this.btn_Transaction_Add_Click);
            // 
            // fctxt_Identification
            // 
            this.fctxt_Identification.AllowSeveralTextStyleDrawing = true;
            this.fctxt_Identification.AutoCompleteBracketsList = new char[] {
        '(',
        ')',
        '{',
        '}',
        '[',
        ']',
        '\"',
        '\"',
        '\'',
        '\''};
            this.fctxt_Identification.AutoScrollMinSize = new System.Drawing.Size(0, 18);
            this.fctxt_Identification.BackBrush = null;
            this.fctxt_Identification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.fctxt_Identification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.fctxt_Identification.CharHeight = 18;
            this.fctxt_Identification.CharWidth = 10;
            this.fctxt_Identification.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fctxt_Identification.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.fctxt_Identification.IndentBackColor = System.Drawing.Color.DimGray;
            this.fctxt_Identification.IsReplaceMode = false;
            this.fctxt_Identification.Language = FastColoredTextBoxNS.Language.CSharp;
            this.fctxt_Identification.Location = new System.Drawing.Point(24, 69);
            this.fctxt_Identification.Name = "fctxt_Identification";
            this.fctxt_Identification.Paddings = new System.Windows.Forms.Padding(0);
            this.fctxt_Identification.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(255)))));
            this.fctxt_Identification.ServiceColors = ((FastColoredTextBoxNS.ServiceColors)(resources.GetObject("fctxt_Identification.ServiceColors")));
            this.fctxt_Identification.ServiceLinesColor = System.Drawing.Color.DimGray;
            this.fctxt_Identification.Size = new System.Drawing.Size(569, 127);
            this.fctxt_Identification.TabIndex = 22;
            this.fctxt_Identification.WordWrap = true;
            this.fctxt_Identification.Zoom = 100;
            this.fctxt_Identification.Load += new System.EventHandler(this.fctxt_Identification_Load);
            // 
            // btn_Transaction_Save
            // 
            this.btn_Transaction_Save.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Transaction_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Transaction_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Transaction_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transaction_Save.Location = new System.Drawing.Point(289, 492);
            this.btn_Transaction_Save.Name = "btn_Transaction_Save";
            this.btn_Transaction_Save.Size = new System.Drawing.Size(105, 42);
            this.btn_Transaction_Save.TabIndex = 20;
            this.btn_Transaction_Save.Text = "Save";
            this.btn_Transaction_Save.UseVisualStyleBackColor = true;
            this.btn_Transaction_Save.Click += new System.EventHandler(this.btn_Transaction_Save_Click);
            // 
            // btn_Transaction_Remove
            // 
            this.btn_Transaction_Remove.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Transaction_Remove.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Transaction_Remove.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Transaction_Remove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transaction_Remove.Location = new System.Drawing.Point(400, 492);
            this.btn_Transaction_Remove.Name = "btn_Transaction_Remove";
            this.btn_Transaction_Remove.Size = new System.Drawing.Size(105, 42);
            this.btn_Transaction_Remove.TabIndex = 21;
            this.btn_Transaction_Remove.Text = "Remove";
            this.btn_Transaction_Remove.UseVisualStyleBackColor = true;
            this.btn_Transaction_Remove.Click += new System.EventHandler(this.btn_Transaction_Remove_Click);
            // 
            // btn_Transaction_Refresh
            // 
            this.btn_Transaction_Refresh.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btn_Transaction_Refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btn_Transaction_Refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.btn_Transaction_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Transaction_Refresh.Location = new System.Drawing.Point(488, 33);
            this.btn_Transaction_Refresh.Name = "btn_Transaction_Refresh";
            this.btn_Transaction_Refresh.Size = new System.Drawing.Size(105, 28);
            this.btn_Transaction_Refresh.TabIndex = 25;
            this.btn_Transaction_Refresh.Text = "Add";
            this.btn_Transaction_Refresh.UseVisualStyleBackColor = true;
            this.btn_Transaction_Refresh.Click += new System.EventHandler(this.btn_Transaction_Refresh_Click);
            // 
            // UC_CfgTemplate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.spc_Main);
            this.Name = "UC_CfgTemplate";
            this.Size = new System.Drawing.Size(1500, 779);
            this.spc_Main.Panel1.ResumeLayout(false);
            this.spc_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_Main)).EndInit();
            this.spc_Main.ResumeLayout(false);
            this.grp_Keyword.ResumeLayout(false);
            this.spc_Keyword_Main.Panel1.ResumeLayout(false);
            this.spc_Keyword_Main.Panel1.PerformLayout();
            this.spc_Keyword_Main.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_Keyword_Main)).EndInit();
            this.spc_Keyword_Main.ResumeLayout(false);
            this.spc_Keyword_Level.Panel1.ResumeLayout(false);
            this.spc_Keyword_Level.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spc_Keyword_Level)).EndInit();
            this.spc_Keyword_Level.ResumeLayout(false);
            this.spc_Keyword_Pattern.Panel1.ResumeLayout(false);
            this.spc_Keyword_Pattern.Panel2.ResumeLayout(false);
            this.spc_Keyword_Pattern.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Keyword_Pattern)).EndInit();
            this.spc_Keyword_Pattern.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_Pattern)).EndInit();
            this.spc_Keyword_Test.Panel1.ResumeLayout(false);
            this.spc_Keyword_Test.Panel2.ResumeLayout(false);
            this.spc_Keyword_Test.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spc_Keyword_Test)).EndInit();
            this.spc_Keyword_Test.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_Test)).EndInit();
            this.grp_Transaction.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_Unsuccessful)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_Successful)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fctxt_Identification)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spc_Main;
        private System.Windows.Forms.SplitContainer spc_Keyword_Main;
        private FastColoredTextBoxNS.FastColoredTextBox fctxt_Unsuccessful;
        private FastColoredTextBoxNS.FastColoredTextBox fctxt_Successful;
        private FastColoredTextBoxNS.FastColoredTextBox fctxt_Identification;
        private System.Windows.Forms.Button btn_Transaction_Remove;
        private System.Windows.Forms.Button btn_Transaction_Save;
        private System.Windows.Forms.Button btn_Transaction_Add;
        private System.Windows.Forms.ComboBox cbo_Transactions;
        private System.Windows.Forms.GroupBox grp_Keyword;
        private System.Windows.Forms.GroupBox grp_Transaction;
        private System.Windows.Forms.SplitContainer spc_Keyword_Level;
        private System.Windows.Forms.SplitContainer spc_Keyword_Pattern;
        private System.Windows.Forms.SplitContainer spc_Keyword_Test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chk_Keywork_Pattern;
        private System.Windows.Forms.Button btn_Keyword_Add;
        private System.Windows.Forms.Button btn_Keyword_Remove;
        private System.Windows.Forms.Button btn_Keyword_Save;
        private System.Windows.Forms.Button btn_Keyword_Help;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chk_Keywork_Test;
        private System.Windows.Forms.Button btn_Keyword_Import;
        private System.Windows.Forms.Button btn_Keyword_Run;
        private FastColoredTextBoxNS.FastColoredTextBox fctxt_Pattern;
        private FastColoredTextBoxNS.FastColoredTextBox fctxt_Test;
        private System.Windows.Forms.Button btn_Keyword_Resfresh;
        private System.Windows.Forms.ComboBox cbo_Keyword_LstKeyword;
        private System.Windows.Forms.Button btn_Transaction_Refresh;
    }
}
