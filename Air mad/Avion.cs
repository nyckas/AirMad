/*
 * Crée par SharpDevelop.
 * Utilisateur: ITU
 * Date: 19/04/2017
 * Heure: 12:00
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;

namespace Air_mad
{
	/// <summary>
	/// Description of Avion.
	/// </summary>
	public class Avion
	{
		String id;
		String nom;
		String destination;
		String avion;
		String modele;
		int capacite;
		int carburant;
		int vitesse;
		int placeLibre;
		public String getid(){
			return id;
		}
		public String getnom(){
			return nom;
		}
		public String getmodele(){
			return modele;
		}
		public String getavion(){
			return avion;
		}
		public String getdestination(){
			return destination;
		}
		public int getcapacite(){
			return capacite;
		}
		public int getcarburant(){
			return carburant;
		}
		public int getvitesse(){
			return vitesse;
		}
		public int getplaceLibre(){
			return placeLibre;
		}
		
		public Avion(String ids, String noms, String modeles, int capacites, int carburants, int vitesses)
		{
			id = ids;
			nom = noms;
			modele = modeles;
			capacite = capacites;
			carburant = carburants;
			vitesse = vitesses;
			
		}
		
	}
}
