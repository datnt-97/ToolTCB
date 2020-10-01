namespace Transaction_Statistical.UControl
{
	partial class UC_ExportOptionSelect
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_ExportOptionSelect));
			this.lstViewTables = new System.Windows.Forms.ListView();
			this.btnOk = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lstViewTables
			// 
			this.lstViewTables.HideSelection = false;
			this.lstViewTables.Location = new System.Drawing.Point(0, 0);
			this.lstViewTables.Margin = new System.Windows.Forms.Padding(4);
			this.lstViewTables.Name = "lstViewTables";
			this.lstViewTables.Size = new System.Drawing.Size(297, 376);
			this.lstViewTables.TabIndex = 2;
			this.lstViewTables.UseCompatibleStateImageBehavior = false;
			this.lstViewTables.View = System.Windows.Forms.View.List;
			this.lstViewTables.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.lstViewTables_ItemSelectionChanged);
			// 
			// btnOk
			// 
			this.btnOk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnOk.BackgroundImage")));
			this.btnOk.Location = new System.Drawing.Point(211, 378);
			this.btnOk.Margin = new System.Windows.Forms.Padding(4);
			this.btnOk.Name = "btnOk";
			this.btnOk.Size = new System.Drawing.Size(91, 41);
			this.btnOk.TabIndex = 3;
			this.btnOk.UseVisualStyleBackColor = true;
			this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
			// 
			// UC_ExportOptionSelect
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.Controls.Add(this.btnOk);
			this.Controls.Add(this.lstViewTables);
			this.Name = "UC_ExportOptionSelect";
			this.Size = new System.Drawing.Size(298, 423);
			this.Load += new System.EventHandler(this.Select_Tables_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnOk;
		private System.Windows.Forms.ListView lstViewTables;
	}
}
