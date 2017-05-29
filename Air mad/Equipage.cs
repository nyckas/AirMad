/*
 * Crée par SharpDevelop.
 * Utilisateur: ITU
 * Date: 10/05/2017
 * Heure: 14:58
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;

namespace Air_mad
{
	/// <summary>
	/// Description of Equipage.
	/// </summary>
	public class Equipage
	{
		String id;
		String nom;
		String poste;
		String sexe;
		float salaire;
		public String getid(){
			return id;
		}
		public String getnom(){
			return nom;
		}
		public String getposte(){
			return poste;
		}
		public String getsexe(){
			return sexe;
		}
		public float getsalaire(){
			return salaire;
		}
		public Equipage(String ids, String noms, String postes, String sexes, float salaires)
		{
			id = ids;
			nom = noms;
			poste = postes;
			sexe = sexes;
			salaire = salaires;
		}
		
		public Equipage()
		{
		}
	}
}
