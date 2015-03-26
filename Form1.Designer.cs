namespace WindowsFormsApplication11
{
	partial class Form1
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
			this.connect41 = new WindowsFormsApplication11.Connect4();
			this.board1 = new WindowsFormsApplication11.Board();
			
			this.board1.Generate();

			this.board1.BeginInit();
			
			this.connect41.SuspendLayout();
			this.board1.SuspendLayout();
			
			this.SuspendLayout();
			// 
			// connect41
			// 
			this.connect41.Controls.Add(this.board1);
			this.connect41.Location = new System.Drawing.Point(12, 3);
			this.connect41.Name = "connect41";
			this.connect41.Size = new System.Drawing.Size(990, 1000);
			this.connect41.TabIndex = 0;
			// 
			// board1
			// 
			this.board1.BuildBoard();
			this.board1.Location = new System.Drawing.Point(3, 3);
			this.board1.Name = "board1";
			this.board1.Size = new System.Drawing.Size(984, 1000);
			this.board1.TabIndex = 0;
			
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1014, 1000);
			this.Controls.Add(this.connect41);
			this.Name = "Form1";
			this.Text = "FORM";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.connect41.ResumeLayout(false);
			this.board1.ResumeLayout(false);

			this.board1.EndInit();		
			this.ResumeLayout(false);

		}

		#endregion

		private Connect4 connect41;
		private Board board1;


	}
}

