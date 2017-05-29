/*
 * Crée par SharpDevelop.
 * Utilisateur: ITU
 * Date: 19/04/2017
 * Heure: 13:37
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
	/// Description of ReservationDAO.
	/// </summary>
	public class ReservationDAO
	{
		public Reservation[] findReserv() {
		Reservation[]valiny=new Reservation[100];
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		conn.Open();
		SqlCommand cmd;
		SqlDataReader reader;
	   	string requete = ("select r.id,r.passager,r.destination,r.nationalite,r.date,r.classe,r.vol,r.volretour,r.type,((v.prixBillet+c.tarif)*t.tarif)-t.remise as prix from destination d, reservation r, classe c, vol v, types t where r.destination = d.nom and c.nom = r.classe and v.destination = r.destination and v.depart = r.depart and t.nom = r.type and v.placeTotal>0 order by r.id ASC  ");
	   	cmd = new SqlCommand(requete, conn);
	   	reader = cmd.ExecuteReader();
		for(int i=0; reader.Read(); i++)
		{
			String id = reader["id"].ToString();
			String passager = reader["passager"].ToString();
			String destination = reader["destination"].ToString();
			String nationalite = reader["nationalite"].ToString();
			DateTime dates = DateTime.Parse(reader["date"].ToString());
			String classe = reader["classe"].ToString();
			String vol = reader["vol"].ToString();
			String retour = reader["volretour"].ToString();
			String type = reader["type"].ToString();
			double prix = Double.Parse(reader["prix"].ToString());
			Console.Out.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}",id,passager,destination,nationalite,dates,classe,vol,retour,type,prix);
			valiny[i] = new Reservation(id,passager,destination,nationalite,dates,classe,vol,retour,type,prix);
		}
		reader.Close();
		cmd.Dispose();
        conn.Close(); 
		return valiny;
    }
		public Reservation[] volCompose() {
		Reservation[]valiny=new Reservation[100];
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		conn.Open();
		SqlCommand cmd;
		SqlDataReader reader;
	   	string requete = ("select v.id as Vol1,af.id as Vol2,r.passager,v.avion as avion1,af.avion as avion2,r.classe,v.depart,v.destination as Escale,af.destination,(((v.prixBillet+c.tarif)*t.tarif)-t.remise)+(af.prixBillet+((af.prixBillet*10)/100))  as prix from Vol v, Reservation r,Compagnie af, classe c,Types t where v.id = r.vol and v.depart = r.depart and t.nom = r.type and v.destination = af.depart and r.destination = af.destination and r.classe = c.nom  ");
	   	cmd = new SqlCommand(requete, conn);
	   	reader = cmd.ExecuteReader();
	   	//MessageBox.Show("Affichage reussit");
		
		for(int i=0; reader.Read(); i++)
		{
			String id = reader["Vol1"].ToString();
			String id2 = reader["Vol2"].ToString();
			String passager = reader["passager"].ToString();
			String avion1 = reader["avion1"].ToString();
			String avion2 = reader["avion2"].ToString();
			String classe = reader["classe"].ToString();
			String depart = reader["depart"].ToString();
			String escale = reader["Escale"].ToString();
			String destination = reader["destination"].ToString();
			double prix = Double.Parse(reader["prix"].ToString());
			Console.Out.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8}",id,id2,passager,avion1,avion2,classe,depart,escale,destination,prix);
			valiny[i] = new Reservation(id,id2,passager,avion1,avion2,classe,depart,escale,destination,prix);
		}
		reader.Close();
		cmd.Dispose();
        conn.Close(); 
		return valiny;
    }
		public Reservation[] volComposeII() {
		Reservation[]valiny=new Reservation[100];
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		conn.Open();
		SqlCommand cmd;
		SqlDataReader reader;
	   	string requete = ("select af.id ,r.passager ,af.avion,r.classe,r.depart,af.destination,(((af.prixBillet+c.tarif)*t.tarif)-t.remise)+(af.prixBillet+((af.prixBillet*10)/100))  as prix from Reservation r,Compagnie af, classe c,Types t where t.nom = r.type  and r.destination = af.destination and r.classe = c.nom and af.compagnie = 'Air Mauritius'");
	   	cmd = new SqlCommand(requete, conn);
	   	reader = cmd.ExecuteReader();
		for(int i=0; reader.Read(); i++)
		{
			String id = reader["id"].ToString();
			String passager = reader["passager"].ToString();
			String avion = reader["avion"].ToString();
			String classe = reader["classe"].ToString();
			String depart = reader["depart"].ToString();
			String destination = reader["destination"].ToString();
			double prix = Double.Parse(reader["prix"].ToString());
			valiny[i] = new Reservation(id,passager,avion,classe,depart,destination,prix);
		}
		reader.Close();
		cmd.Dispose();
        conn.Close(); 
		return valiny;
    }
		public SousTraitance[] benefice() {
		SousTraitance[]valiny=new SousTraitance[100];
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		conn.Open();
		SqlCommand cmd;
		SqlDataReader reader;
	   	string requete = ("select c.CarburantTotal as avion,s.salaire,s.salaire+c.CarburantTotal as depense,r.prix as reservation,sT.benefice as sousTraitance,(r.prix-(s.salaire+c.CarburantTotal))+sT.benefice as benefice from SalaireTotal s,CarbuTotal c,ReservationTotal r,TotalSousT2 sT");
	   	cmd = new SqlCommand(requete, conn);
	   	reader = cmd.ExecuteReader();
		for(int i=0; reader.Read(); i++)
		{
			float avion = float.Parse(reader["avion"].ToString());
			float salaire = float.Parse(reader["salaire"].ToString());
			float consommation = float.Parse(reader["depense"].ToString());
			float reservation = float.Parse(reader["reservation"].ToString());
			float sousTraitance = float.Parse(reader["sousTraitance"].ToString());
			float benefice = float.Parse(reader["benefice"].ToString());
			valiny[i] = new SousTraitance(avion,salaire,consommation,reservation,sousTraitance,benefice);
		}
		reader.Close();
		cmd.Dispose();
        conn.Close(); 
		return valiny;
    }
		
	public void insert(Reservation medoc){
		try{
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		SqlCommand cmd = new SqlCommand();
		cmd.Connection = conn;
		conn.Open();
		cmd.CommandText = "insert into reservation values('"+medoc.getid()+"','"+medoc.getPassager()+"','"+medoc.getdestination()+"','"+medoc.getnationalite()+"','"+medoc.getdaty()+"','"+medoc.getclasse()+"','"+medoc.getvol()+"','"+medoc.gettype()+"','"+medoc.getvolretour()+"','"+medoc.getdepart()+"')";
		updatePlace(medoc.getvol());
		cmd.ExecuteNonQuery();
		MessageBox.Show("Mr/Mme "+medoc.getPassager()+", Vous etes dans le vol vers "+medoc.getdestination());
		conn.Close();
	} catch(Exception e){
			Console.Out.Write(e.Message);
		}
	}
		public void updatePlace(String id){
			try{
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		SqlCommand cmd = new SqlCommand();
		cmd.Connection = conn;
		conn.Open();
		cmd.CommandText = "update vol set placeTotal=placeTotal-1 where id='"+id+"'";
	   	cmd.ExecuteNonQuery();
	 // 	MessageBox.Show("Modification reussit");
		conn.Close();
	} catch(Exception e){
			Console.Out.Write(e.Message);
		}
		}
		public SousTraitance[] sousTraitance() {
		SousTraitance[]valiny=new SousTraitance[100];
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		conn.Open();
		/*DateTime dt1 = Convert.ToDateTime(date1);
		DateTime dt2 = Convert.ToDateTime(date2);
		String dd1 = String.Format("{0}/{1}/{2} ",dt1.Year,dt1.Month,dt1.Day);
		String dd2 = String.Format("{0}/{1}/{2} ",dt2.Year,dt2.Month,dt2.Day);*/
		SqlCommand cmd;
		SqlDataReader reader;
	   	string requete = ("select nbre.compagnie,nbre.classe,nbre.nombre,nbre.type,SUM(((c.prixBillet+cl.tarif)*t.tarif)-t.remise)*nbre.nombre as montantDu,SUM((((c.prixBillet+cl.tarif)*t.tarif)-t.remise)+(c.prixBillet+((c.prixBillet*5)/100)))*nbre.nombre as montantVente from nombreBillet nbre,compagnie c, classe cl, types t where cl.nom = nbre.classe and t.nom = nbre.type group by nbre.compagnie,nbre.classe,nbre.nombre,nbre.type ");
	   	cmd = new SqlCommand(requete, conn);
	   	reader = cmd.ExecuteReader();
		for(int i=0; reader.Read(); i++)
		{
			String compagnie = reader["compagnie"].ToString();
			String classe = reader["classe"].ToString();
			int nombre = int.Parse(reader["nombre"].ToString());
			String type = reader["type"].ToString();
			float montantDu = float.Parse(reader["montantDu"].ToString());
			float montantVente = float.Parse(reader["montantVente"].ToString());
			valiny[i] = new SousTraitance(compagnie,classe,nombre,type,montantDu,montantVente);
			
			
		}
		reader.Close();
		cmd.Dispose();
        conn.Close(); 
		return valiny;
    }
		/*public void updateTraitance(){
			try{
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		SqlCommand cmd = new SqlCommand();
		cmd.Connection = conn;
		conn.Open();
		cmd.CommandText = "update vol set placeTotal=placeTotal-1 where id='"+id+"'";
	   	cmd.ExecuteNonQuery();
	 // 	MessageBox.Show("Modification reussit");
		conn.Close();
	} catch(Exception e){
			Console.Out.Write(e.Message);
		}
		}*/
		public ReservationDAO()
		{
		}
	}
}
