
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace LineRepeater
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			textBox2.Clear();
			foreach (string line in textBox1.Lines) {
				for (int i = 0; i < numericUpDown1.Value; i++) {
					string lineout = line;
					if (textBox2.TextLength != 0) { lineout = Environment.NewLine + line; }
					textBox2.AppendText(lineout);
				}
			}
		}
	}
}
