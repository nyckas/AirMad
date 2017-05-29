/*
 * Crée par SharpDevelop.
 * Utilisateur: ITU
 * Date: 04/05/2017
 * Heure: 11:30
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;

namespace Air_mad
{
	/// <summary>
	/// Description of SousTraitance.
	/// </summary>
	public class SousTraitance
	{
		String id;
		String compagnie;
		String classe;
		int nombre;
		float montantDu;
		float montantVente;
		float avion;
		float salaire;
		float consommation;
		float reservation;
		float sousTraitance;
		float benefice;
		String typee;
		public String getid(){
			return id;
		}
		public String getcompagnie(){
			return compagnie;
		}
		public String getclasse(){
			return classe;
		}
		public int getnombre(){
			return nombre;
		}
		public float getmontantDu(){
			return montantDu;
		}
		public float getmontantVente(){
			return montantVente;
		}
		public String gettypee(){
			return typee;
		}
		public float getavion(){
			return avion;
		}
		public float getsalaire(){
			return salaire;
		}
		public float getconsommation(){
			return consommation;
		}
		public float getreservation(){
			return reservation;
		}
		public float getsousTraitance(){
			return sousTraitance;
		}
		public float getbenefice(){
			return benefice;
		}
		public SousTraitance(String ids, String compagnies, String classes, int nombres, float montantDus, float montantVentes, String typees){
			id = ids;
			compagnie = compagnies;
			classe = classes;
			nombre = nombres;
			montantDu = montantDus;
			montantVente = montantVentes;
			typee = typees;
		}
		public SousTraitance(String compagnies, String classes, int nombres, String typees, float montantDus, float montantVentes){
			compagnie = compagnies;
			classe = classes;
			nombre = nombres;
			typee = typees;
			montantDu = montantDus;
			montantVente = montantVentes;
		}
		public SousTraitance(float avionS,float salaireS,float consommationS,float reservationS,float sousTraitanceS,float beneficeS){
			avion = avionS;
			salaire = salaireS;
			consommation = consommationS;
			reservation = reservationS;
			sousTraitance = sousTraitanceS;
			benefice = beneficeS;
		}
		public SousTraitance()
		{
		}
	}
}
