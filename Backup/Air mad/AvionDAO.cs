/*
 * Crée par SharpDevelop.
 * Utilisateur: ITU
 * Date: 19/04/2017
 * Heure: 12:56
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
	/// Description of AvionDAO.
	/// </summary>
	public class AvionDAO
	{
		public Avion[] findAvion() {
		Avion[]valiny=new Avion[100];
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		conn.Open();
		SqlCommand cmd;
		SqlDataReader reader;
	   	string requete = ("Select * from avion order by id ASC");
	   	cmd = new SqlCommand(requete, conn);
	   	reader = cmd.ExecuteReader();
	   	//MessageBox.Show("Affichage reussit");
		
		for(int i=0; reader.Read(); i++)
		{
			String id = reader["id"].ToString();
			String nom = reader["nom"].ToString();
			String modele = reader["modele"].ToString();
			int capacite = int.Parse(reader["capacite"].ToString());
			int carburant = int.Parse(reader["carburant"].ToString());
			int vitesse = int.Parse(reader["vitesse"].ToString());
			Console.Out.WriteLine("{0} {1} {2} {3} {4} {5}",id,nom,modele,capacite,carburant,vitesse);
			valiny[i] = new Avion(id,nom,modele,capacite,carburant,vitesse);
		}
		reader.Close();
		cmd.Dispose();
        conn.Close(); 
		return valiny;
    }
		public Avion[] findAvionVol() {
		Avion[]valiny=new Avion[100];
		Connexion con=new Connexion();
		SqlConnection conn = con.ConnectToSql();
		conn.Open();
		SqlCommand cmd;
		SqlDataReader reader;
	   	string requete = ("Select * from avion,vol where avion.id = vol.avion order by avion.id ASC");
	   	cmd = new SqlCommand(requete, conn);
	   	reader = cmd.ExecuteReader();
	   	//MessageBox.Show("Affichage reussit");
		
		for(int i=0; reader.Read(); i++)
		{
			String id = reader["id"].ToString();
			String nom = reader["nom"].ToString();
			String modele = reader["modele"].ToString();
			int capacite = int.Parse(reader["capacite"].ToString());
			int carburant = int.Parse(reader["carburant"].ToString());
			int vitesse = int.Parse(reader["vitesse"].ToString());
			//int placeLibre = int.Parse(reader["placeLibre"].ToString());
			Console.Out.WriteLine("{0} {1} {2} {3} {4} {5}",id,nom,modele,capacite,carburant,vitesse);
			valiny[i] = new Avion(id,nom,modele,capacite,carburant,vitesse);
		}
		reader.Close();
		cmd.Dispose();
        conn.Close(); 
		return valiny;
    }
		//,(select a.capacite from avion a, reservation r, Vol v where r.destination = v.destination and v.avion = a.id) as placeLibre
		
		public AvionDAO()
		{
		}
	}
}
