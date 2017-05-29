/*
 * Crée par SharpDevelop.
 * Utilisateur: ITU
 * Date: 27/04/2017
 * Heure: 13:02
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Air_mad
{
	/// <summary>
	/// Description of Form1.
	/// </summary>
	public partial class Form1 : Form
	{
		public Form1()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			VolDao medoc=new VolDao();
			medoc.updatetarif(textBox1.Text, double.Parse(textBox2.Text));
		}
		
		void TextBox1TextChanged(object sender, EventArgs e)
		{
			
		}
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			VolDao medoc=new VolDao();
			Vol me = new Vol(textBox4.Text, textBox9.Text, textBox3.Text, textBox7.Text, Convert.ToDateTime(textBox8.Text), Convert.ToDateTime(textBox11.Text), int.Parse(textBox14.Text),int.Parse(textBox12.Text),int.Parse(textBox15.Text),int.Parse(textBox6.Text), Double.Parse(textBox10.Text),textBox13.Text,textBox16.Text);
			medoc.insert(me);
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			VolDao medoc=new VolDao();
			medoc.delete(textBox5.Text);
		}
		
		void TabPage1Click(object sender, EventArgs e)
		{
			
		}
	}
}
