/*
 * Crée par SharpDevelop.
 * Utilisateur: ITU
 * Date: 19/04/2017
 * Heure: 11:15
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Air_mad
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			AvionDAO av=new AvionDAO();
			Avion[]avion = new Avion[100];
			Avion[]avion1 = new Avion[100];
			try{
			avion = av.findAvion();
			//avion1 = av.findPlaceLibre();
            
            
			for(int i=0; i<avion.Length; i++){
				this.dataGridView2.Rows.Add(avion[i].getnom().ToString(),avion[i].getmodele().ToString(),avion[i].getcapacite().ToString(),avion[i].getcarburant().ToString(),avion[i].getvitesse().ToString());
			
				 
			}
           
			}catch(Exception ex){
				
			}
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void PictureBox1Click(object sender, EventArgs e)
		{
			
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			VolDao vol=new VolDao();
			Vol[]volavo = new Vol[100];
			try{
			volavo = vol.findvol();
			this.dataGridView1.Rows.Clear();
			for(int i=0; i<volavo.Length; i++){
				this.dataGridView1.Rows.Add(volavo[i].getnom().ToString(),volavo[i].getdepart().ToString(),volavo[i].getdestination().ToString(),volavo[i].getheureDepart().ToString(),volavo[i].getheureArrivee().ToString(),volavo[i].getheureVol().ToString()+" h",volavo[i].getprix().ToString("#,##0")+" €");
				
            	
			}
			}catch(Exception ex){
				
			}
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			ReservationDAO medoc=new ReservationDAO();
			Reservation me = new Reservation(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, Convert.ToDateTime(dateTimePicker1.Text), comboBox1.Text, textBox7.Text, comboBox2.Text, textBox6.Text,textBox8.Text);
			medoc.insert(me);
		}
		/**/
		
		void Button3Click(object sender, EventArgs e)
		{
			ReservationDAO av=new ReservationDAO();
			Reservation[]avion = new Reservation[100];
			try{
			avion = av.findReserv();
			//MessageBox.Show("Affichage reussit 2");
			this.dataGridView5.Rows.Clear();
            for(int i=0; i<avion.Length; i++){
				this.dataGridView5.Rows.Add(avion[i].getPassager().ToString(),avion[i].getdestination().ToString(),avion[i].getclasse().ToString(),avion[i].getvol().ToString(),avion[i].getvolretour().ToString(),avion[i].gettype().ToString(),avion[i].getprix().ToString("#,##0")+" €");
			
			}
			}catch(Exception ex){
				
			}
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			
			VolDao av=new VolDao();
			Vol[]avion = new Vol[100];
			//Avion[]avion1 = new Avion[100];
			try{
			avion = av.findPlaceLibre();
            this.dataGridView3.Rows.Clear();
			for(int i=0; i<avion.Length; i++){
            	this.dataGridView3.Rows.Add(avion[i].getdestination().ToString(),avion[i].getavion().ToString(),(avion[i].getplaceTotal()).ToString());
			
				 
			}
           
			}catch(Exception ex){
				
			}
		}
		
		void Button5Click(object sender, EventArgs e)
		{
			Form1 f = new Form1();
			f.Show();
		}
		
		void Button6Click(object sender, EventArgs e)
		{
			VolDao vol=new VolDao();
			Vol[]volavo = new Vol[100];
			try{
			volavo = vol.AirFrance();
			this.dataGridView4.Rows.Clear();
			for(int i=0; i<volavo.Length; i++){
				this.dataGridView4.Rows.Add(volavo[i].getnom().ToString(),volavo[i].getcompagnie().ToString(),volavo[i].getdepart().ToString(),volavo[i].getdestination().ToString(),volavo[i].getheureDepart().ToString(),volavo[i].getheureArrivee().ToString(),volavo[i].getprix().ToString("#,##0")+" €");
				
            	
			}
			}catch(Exception ex){
				
			}
		}
		
		void Button7Click(object sender, EventArgs e)
		{
			ReservationDAO av=new ReservationDAO();
			Reservation[]avion = new Reservation[100];
			try{
			avion = av.volCompose();
			this.dataGridView6.Rows.Clear();
			for(int i=0; i<avion.Length; i++){
				this.dataGridView6.Rows.Add(avion[i].getvol1().ToString(),avion[i].getvol2().ToString(),avion[i].getPassager().ToString(),avion[i].getavion1().ToString(),avion[i].getavion2().ToString(),avion[i].getclasse().ToString(),avion[i].getdepart().ToString(),avion[i].getescale().ToString(),avion[i].getdestination().ToString(),avion[i].getprix().ToString("#,##0")+" €");
				
			}
			}catch(Exception ex){
				
			}
		}
		/*
			*/
		void Button8Click(object sender, EventArgs e)
		{
			ReservationDAO av=new ReservationDAO();
			Reservation[]avion = new Reservation[100];
			try{
			avion = av.volComposeII();
			this.dataGridView8.Rows.Clear();
			for(int i=0; i<avion.Length; i++){
				this.dataGridView8.Rows.Add(avion[i].getPassager().ToString(),avion[i].getavion().ToString(),avion[i].getclasse().ToString(),avion[i].getdepart().ToString(),avion[i].getdestination().ToString(),avion[i].getprix().ToString("#,##0")+" €");
			
			}
			}catch(Exception ex){
				
			}
		}
		
		void Button9Click(object sender, EventArgs e)
		{
			ReservationDAO vol=new ReservationDAO();
			SousTraitance[]volavo = new SousTraitance[100];
			try{
				/*DateTime dt1 = DateTime.Parse(textBox9.Text);
				String dd = String.Format("{0}/{1}/{2} ",dt1.Year,dt1.Month,dt1.Day);
				DateTime dt2 = DateTime.Parse(textBox10.Text);
				String dd2 = String.Format("{0}/{1}/{2} ",dt2.Year,dt2.Month,dt2.Day);
				//MessageBox.Show(dd.ToString());*/
				volavo = vol.sousTraitance();
				this.dataGridView7.Rows.Clear();
			for(int i=0; i<volavo.Length; i++){
            	this.dataGridView7.Rows.Add(volavo[i].getcompagnie().ToString(),volavo[i].getclasse().ToString(),volavo[i].getnombre().ToString(),volavo[i].getmontantDu().ToString("#,##0")+" €",volavo[i].getmontantVente().ToString("#,##0")+" €",volavo[i].gettypee().ToString());  //MessageBox.Show(volavo[i].getcompagnie().ToString());
			
			}
			}catch(Exception ex){
				
			}
		}
		
		void DataGridView1CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			
		}
		
		void Button10Click(object sender, EventArgs e)
		{
			VolDao vol=new VolDao();
			Equipage[]volavo = new Equipage[100];
			try{
				volavo = vol.Equipage();
				this.dataGridView9.Rows.Clear();
			for(int i=0; i<volavo.Length; i++){
            	this.dataGridView9.Rows.Add(volavo[i].getnom().ToString(),volavo[i].getposte().ToString(),volavo[i].getsexe().ToString(),volavo[i].getsalaire().ToString("#,##0")+" €");  
			
			}
			}catch(Exception ex){
				
			}
		}
		
		void Button11Click(object sender, EventArgs e)
		{
			ReservationDAO vol=new ReservationDAO();
			SousTraitance[]volavo = new SousTraitance[100];
			try{
				volavo = vol.benefice();
				listBox1.Items.Clear();
				listBox2.Items.Clear();
				listBox3.Items.Clear();
				listBox4.Items.Clear();
				listBox5.Items.Clear();
				listBox6.Items.Clear();
			for(int i=0; i<volavo.Length; i++){
				listBox1.Items.Add(volavo[i].getavion().ToString("#,##0")+" €");
				listBox2.Items.Add(volavo[i].getsalaire().ToString("#,##0")+" €");
				listBox3.Items.Add(volavo[i].getconsommation().ToString("#,##0")+" €");
				listBox4.Items.Add(volavo[i].getreservation().ToString("#,##0")+" €");
				listBox5.Items.Add(volavo[i].getsousTraitance().ToString("#,##0")+" €");
				listBox6.Items.Add(volavo[i].getbenefice().ToString("#,##0")+" €");
			
			}
			}catch(Exception ex){
				
			}
		}
		
		void TabPage9Click(object sender, EventArgs e)
		{
			
		}
		
		void Button12Click(object sender, EventArgs e)
		{
			VolDao medoc=new VolDao();
			Equipage me = new Equipage(textBox16.Text, textBox15.Text, textBox5.Text, textBox14.Text, float.Parse(textBox11.Text));
			medoc.insertEquipage(me);
		}
	}
}
