/*
 * Crée par SharpDevelop.
 * Utilisateur: ITU
 * Date: 19/04/2017
 * Heure: 12:05
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Air_mad
{
	/// <summary>
	/// Description of VolDao.
	/// </summary>
	public class VolDao
	{
		public Vol[] findvol() {
		Vol[]valiny=new Vol[100];
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		conn.Open();
		SqlCommand cmd;
		SqlDataReader reader;
	   	string requete = ("select v.id,a.id as avion,a.nom,v.depart, v.destination, v.heureDepart, v.heureArrivee,{fn HOUR(v.heureArrivee)}-{fn HOUR(v.heureDepart)} as heureVol, v.prixBillet from vol v, Avion a where v.avion = a.id order by v.id ASC");
	   	cmd = new SqlCommand(requete, conn);
	   	reader = cmd.ExecuteReader();
	   	//MessageBox.Show("Affichage reussit");
		
		for(int i=0; reader.Read(); i++)
		{
			String id = reader["id"].ToString();
			String avionid = reader["avion"].ToString();
			String avion = reader["nom"].ToString();
			String depart = reader["depart"].ToString();
			String destination = reader["destination"].ToString();
			DateTime heureDep = DateTime.Parse(reader["heureDepart"].ToString());
			DateTime heureAr = DateTime.Parse(reader["heureArrivee"].ToString());
			int heureDepart = Convert.ToInt32(heureDep.Hour);
			int heureArrive = Convert.ToInt32(heureAr.Hour);
			int heureDevol =  heureArrive - heureDepart;
			int heuredevol = int.Parse(reader["heureVol"].ToString());
			Double prix = Double.Parse(reader["prixBillet"].ToString());
			Console.Out.WriteLine("{0} {1} {2} {3} {4} {5} {6}",id,avionid,avion,depart,destination,heureDep,heureAr,heuredevol,prix);
			valiny[i] = new Vol(id,avionid,avion,depart,destination,heureDep,heureAr,heureDevol,prix);
		}
		reader.Close();
		cmd.Dispose();
        conn.Close(); 
		return valiny;
    }
		public Vol[] AirFrance() {
		Vol[]valiny=new Vol[100];
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		conn.Open();
		SqlCommand cmd;
		SqlDataReader reader;
	   	string requete = ("select v.id,a.id as avion,a.nom,v.compagnie,v.depart, v.destination, v.heureDepart, v.heureArrivee, v.prixBillet from Compagnie v, Avion a where v.avion = a.id order by v.id ASC");
	   	cmd = new SqlCommand(requete, conn);
	   	reader = cmd.ExecuteReader();
	   	//MessageBox.Show("Affichage reussit");
		
		for(int i=0; reader.Read(); i++)
		{
			String id = reader["id"].ToString();
			String avionid = reader["avion"].ToString();
			String avion = reader["nom"].ToString();
			String compagnie = reader["compagnie"].ToString();
			String depart = reader["depart"].ToString();
			String destination = reader["destination"].ToString();
			DateTime heureDep = DateTime.Parse(reader["heureDepart"].ToString());
			DateTime heureAr = DateTime.Parse(reader["heureArrivee"].ToString());
			Double prix = Double.Parse(reader["prixBillet"].ToString());
			Console.Out.WriteLine("{0} {1} {2} {3} {4} {5} {6}",id,avionid,avion,compagnie,depart,destination,heureDep,heureAr,prix);
			valiny[i] = new Vol(id,avionid,avion,compagnie,depart,destination,heureDep,heureAr,prix);
		}
		reader.Close();
		cmd.Dispose();
        conn.Close(); 
		return valiny;
    }
		public Equipage[] Equipage() {
		Equipage[]valiny=new Equipage[100];
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		conn.Open();
		SqlCommand cmd;
		SqlDataReader reader;
	   	string requete = ("select * from Mpiasa order by id ASC");
	   	cmd = new SqlCommand(requete, conn);
	   	reader = cmd.ExecuteReader();
		
		for(int i=0; reader.Read(); i++)
		{
			String id = reader["id"].ToString();
			String nom = reader["nom"].ToString();
			String poste = reader["poste"].ToString();
			String sexe = reader["sexe"].ToString();
			float salaire = float.Parse(reader["salaire"].ToString());
			valiny[i] = new Equipage(id,nom,poste,sexe,salaire);
		}
		reader.Close();
		cmd.Dispose();
        conn.Close(); 
		return valiny;
    }
		public Vol[] finddateVol() {
		Vol[]valiny=new Vol[100];
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		conn.Open();
		SqlCommand cmd;
		SqlDataReader reader;
	   	string requete = ("select v.heureDepart,v.destination from Vol v,Reservation r where v.destination = r.destination");
	   	cmd = new SqlCommand(requete, conn);
	   	reader = cmd.ExecuteReader();
	   	//MessageBox.Show("Affichage reussit");
		
		for(int i=0; reader.Read(); i++)
		{
			DateTime heureDep = DateTime.Parse(reader["heureDepart"].ToString());
			String destination = reader["destination"].ToString();
			//Console.Out.WriteLine("{0} {1} {2} {3} {4} {5} {6}",id,avion,depart,destination,heureDep,heureAr,prix);
			valiny[i] = new Vol(heureDep,destination);
		}
		reader.Close();
		cmd.Dispose();
        conn.Close(); 
		return valiny;
    }
		public Vol[] findPlaceLibre() {
		Vol[]valiny=new Vol[100];
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		conn.Open();
		SqlCommand cmd;
		SqlDataReader reader;
	   	string requete = ("select v.destination,a.nom,v.placeTotal from avion a, reservation r, Vol v where r.destination = v.destination and v.avion = a.id group by v.destination, a.nom, v.placeTotal");
	   	cmd = new SqlCommand(requete, conn);
	   	reader = cmd.ExecuteReader();
		for(int i=0; reader.Read(); i++)
		{
			String destination = reader["destination"].ToString();
			String nom = reader["nom"].ToString();
			int capacite = int.Parse(reader["placeTotal"].ToString());
			Console.Out.WriteLine("{0} {1}",destination, nom,capacite);
			valiny[i] = new Vol(destination, nom,capacite);
		}
		reader.Close();
		cmd.Dispose();
        conn.Close(); 
		return valiny;
    }
		
	public void updatetarif(String id, double tarif){
			try{
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		SqlCommand cmd = new SqlCommand();
		cmd.Connection = conn;
		conn.Open();
		cmd.CommandText = "update vol set prixBillet='"+tarif+"' where id='"+id+"'";
	   	cmd.ExecuteNonQuery();
	 // 	MessageBox.Show("Modification reussit");
		conn.Close();
	} catch(Exception e){
			Console.Out.Write(e.Message);
		}
		}
		public void insert(Vol medoc){
		try{
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		SqlCommand cmd = new SqlCommand();
		cmd.Connection = conn;
		conn.Open();
	   	cmd.CommandText = "insert into vol values('"+medoc.getid()+"','"+medoc.getavion()+"','"+medoc.getdepart()+"','"+medoc.getdestination()+"','"+medoc.getheureDepart()+"','"+medoc.getheureArrivee()+"','"+medoc.getplaceAffaire()+"','"+medoc.getplacePremium()+"','"+medoc.getplaceEco()+"','"+medoc.getplaceTotal()+"','"+medoc.getprix()+"','"+medoc.getaller()+"','"+medoc.getretour()+"')";
	   	cmd.ExecuteNonQuery();
	   	MessageBox.Show("Insertion reussit");
		conn.Close();
	} catch(Exception e){
			Console.Out.Write(e.Message);
		}
	}
		public void insertEquipage(Equipage medoc){
		try{
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		SqlCommand cmd = new SqlCommand();
		cmd.Connection = conn;
		conn.Open();
	   	cmd.CommandText = "insert into mpiasa values('"+medoc.getid()+"','"+medoc.getnom()+"','"+medoc.getposte()+"','"+medoc.getsexe()+"','"+medoc.getsalaire()+"')";
	   	cmd.ExecuteNonQuery();
	   	MessageBox.Show("Insertion reussit");
		conn.Close();
	} catch(Exception e){
			Console.Out.Write(e.Message);
		}
	}
	public void delete(String condition){
		try{
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		SqlCommand cmd = new SqlCommand();
		cmd.Connection = conn;
		conn.Open();
	   	cmd.CommandText = "delete from vol where id = '"+condition+"'";
	   	cmd.ExecuteNonQuery();
	   	MessageBox.Show("Vol numero "+condition+"  annulé!");
		conn.Close();
	} catch(Exception e){
			Console.Out.Write(e.Message);
		}
	}
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
		
	/*

	public void update(String id, String nom, Double prix, String daty, String condition){
		try{
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		SqlCommand cmd = new SqlCommand();
		DateTime d = Convert.ToDateTime(daty);
		String dd = String.Format("{0}/{1}/{2} ",d.Year,d.Month,d.Day);
		cmd.Connection = conn;
		conn.Open();
		cmd.CommandText = "update fanafody set id = '"+id+"' ,nom = '"+nom+"' ,prix = "+prix+" ,daty = '"+dd+"'  where id = '"+condition+"'";
	   	cmd.ExecuteNonQuery();
	   	MessageBox.Show("Modification reussit");
		conn.Close();
	} catch(Exception e){
			Console.Out.Write(e.Message);
		}
	}
	*/
		public VolDao()
		{
		}
	}
}
