using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApplication11
{
	class Board : Panel
	{
		public Field[,] pb = null;
		private byte playerturn = 1;
		private byte amountOfTurns = 0;
		public void Generate()
		{
			int Columns = 7;
			int Rows = 6;

			this.pb = new Field[Rows, Columns];
            
			int y = 10;
			for (int i = 0; i < Rows; i++)
			{
				int x = 100;


				for (int j = 0; j < Columns; j++)
				{

					Field f = new Field();


					f.MouseClick += Form1PB_MouseClick;

					f.Col = j;
					f.Row = i;

					f.XLoc = x;
					f.YLoc = y;

					pb[i, j] = f;
					x += 100;
				}
				y += 100;
			}
		}

		public void BeginInit()
		{
			for (int i = 0, length = this.pb.GetLength(0); i < length; i++)
			{
				for (int j = 0, jlength = this.pb.GetLength(1); j < jlength; j++)
				{
					((System.ComponentModel.ISupportInitialize)(this.pb[i, j])).BeginInit();
				}
			}
		}

		public void EndInit()
		{
			for (int i = 0, length = this.pb.GetLength(0); i < length; i++)
			{
				for (int j = 0, jlength = this.pb.GetLength(1); j < jlength; j++)
				{
					((System.ComponentModel.ISupportInitialize)(this.pb[i, j])).EndInit();
				}
			}

		}

		public void BuildBoard()
		{
			for (int i = 0, length = this.pb.GetLength(0); i < length; i++)
			{
				for (int j = 0, jlength = this.pb.GetLength(1); j < jlength; j++)
				{
					this.Controls.Add(pb[i, j]);

					pb[i, j].Col = j;
					pb[i, j].Filled = false;
					pb[i, j].ImageLocation = "C:/Users/quinten/Desktop/original/Resources/4inaRowEmpty.png";
					pb[i, j].Image = global::WindowsFormsApplication11.Properties.Resources._4inaRowEmpty;
					pb[i, j].Location = new System.Drawing.Point(pb[i, j].XLoc, pb[i, j].YLoc);
					pb[i, j].Name = "Field " + j.ToString() + i.ToString();
					pb[i, j].Playernumber = ((byte)(0));
					pb[i, j].Row = i;
					pb[i, j].Size = new System.Drawing.Size(100, 100);
					pb[i, j].TabIndex = 0;
					pb[i, j].TabStop = false;
					pb[i, j].Visible = true;

				}
			}
		}

		private void InitializeComponent()
		{
			this.SuspendLayout();
			this.ResumeLayout(false);

		}
		void Form1PB_MouseClick(object sender, MouseEventArgs e)
		{

			Field pbox = (Field)sender;
			int Col = pbox.Col;
			int Row = pbox.Row;
			int maximumZetten = pb.Length;



			//int target = 3;
			//int count = 0;
			//int check = 0;
			//bool win = false;

			////check vertical
			//do
			//{
			//	count++;
			//}
			//while (Row + count < pb.GetLength(0));

			//if (count > target)
			//{
			//	win = true;
			//}

			//count = 0;
			//check = 0;

			//if (win == true)
			//{
			//	MessageBox.Show("GOE GEDAAN");
			//}

			for (int i = pb.GetLength(0) - 1; i >= 0; i--)
			{
				if (pb[i, Col].Filled == false && maximumZetten > amountOfTurns)
				{
					if (playerturn == 1)
					{
						pb[i, Col].Image = Properties.Resources._4inaRowFilled;
						playerturn = 2;
						pb[i, Col].Filled = true;
						pb[i, Col].Playernumber = 1;
					}

					else
					{
						pb[i, Col].Image = Properties.Resources._4inaRowFilledYellow;
						playerturn = 1;
						pb[i, Col].Filled = true;
						pb[i, Col].Playernumber = 2;
					}
					amountOfTurns++;
					break;
				}


			}
		}
	}
}
