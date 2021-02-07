namespace Transaction_Statistical.UControl
{
	partial class Banks
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
			this.mode_DataGridView1 = new Transaction_Statistical.Mode_DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.mode_DataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// mode_DataGridView1
			// 
			this.mode_DataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
			this.mode_DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.mode_DataGridView1.Location = new System.Drawing.Point(663, 166);
			this.mode_DataGridView1.Name = "mode_DataGridView1";
			this.mode_DataGridView1.RowHeadersWidth = 51;
			this.mode_DataGridView1.RowTemplate.Height = 24;
			this.mode_DataGridView1.Size = new System.Drawing.Size(240, 150);
			this.mode_DataGridView1.TabIndex = 0;
			// 
			// Banks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.mode_DataGridView1);
			this.Name = "Banks";
			this.Size = new System.Drawing.Size(1039, 553);
			((System.ComponentModel.ISupportInitialize)(this.mode_DataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Mode_DataGridView mode_DataGridView1;
	}
}
