using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
	class Field : PictureBox
	{
		private int col;
		private int row;

		private bool filled = false;
		private byte playernumber = 0;

		private int x;
		private int y;

		public int XLoc
		{
			get { return x; }
			set { x = value; }
		}

		public int YLoc
		{
			get { return y; }
			set { y = value; }
		}

		public byte Playernumber
		{
			get { return playernumber; }
			set { playernumber = value; }
		}
		public bool Filled
		{
			get { return filled; }
			set { filled = value; }
		}

		public int Col
		{
			get { return col; }
			set { col = value; }
		}

		public int Row
		{
			get { return row; }
			set { row = value; }
		}

		private void InitializeComponent()
		{
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			this.SuspendLayout();
			// 
			// Field
			// 
			this.InitialImage = global::WindowsFormsApplication11.Properties.Resources._4inaRowEmpty;
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();
			this.ResumeLayout(false);

		}


	}
}
