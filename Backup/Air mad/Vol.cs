/*
 * Crée par SharpDevelop.
 * Utilisateur: ITU
 * Date: 19/04/2017
 * Heure: 12:17
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
	/// Description of Vol.
	/// </summary>
	public class Vol
	{
		String id;
		String avion;
		String avionid;
		String nom;
		String compagnie;
		String depart;
		String destination;
		DateTime heureDepart;
		DateTime heureArrivee;
		int placeAffaire;
		int placePremium;
		int placeEco;
		int placeTotal;
		double prix;
		String aller;
		String retour;
		int heureVol;
		public int getheureVol(){
			return heureVol;
		}
		public String getid(){
			return id;
		}
		public String getavion(){
			return avion;
		}
		public String getavionid(){
			return avionid;
		}
		public String getnom(){
			return nom;
		}
		public String getcompagnie(){
			return compagnie;
		}
		public String getdepart(){
			return depart;
		}
		public String getdestination(){
			return destination;
		}
		public String getheureDepart(){
			return String.Format("{0}-{1}-{2} {3}:{4}:{5}.{6}",heureDepart.Year, heureDepart.Month, heureDepart.Day, heureDepart.Hour, heureDepart.Minute, heureDepart.Second, heureDepart.Millisecond);
		}
		public String getheureArrivee(){
			return String.Format("{0}-{1}-{2} {3}:{4}:{5}.{6}",heureArrivee.Year, heureArrivee.Month, heureArrivee.Day, heureArrivee.Hour, heureArrivee.Minute, heureArrivee.Second, heureArrivee.Millisecond);
		}
		public int getplaceAffaire(){
			return placeAffaire;
		}
		public int getplacePremium(){
			return placePremium;
		}
		public int getplaceEco(){
			return placeEco;
		}
		public int getplaceTotal(){
			if(placeTotal<=0){
				MessageBox.Show("Vol complet");
				throw new Exception("Vol complet");
			}
			return placeTotal;
		}
		public double getprix(){
			if(prix<=0){
				MessageBox.Show("Vol invalide, le prix du billet est negatif");
				throw new Exception("Vol invalide, le prix du billet est negatif");
			}
			return prix;
		}
		public String getaller(){
			return aller;
		}
		public String getretour(){
			return retour;
		}
		
		public Vol(String ids, String avions, String departs, String destinations, DateTime heureDeparts, DateTime heureArrivees, int placeAffaires, int placePremiums, int placeEcos, int placeTotals, double prixs,String allers, String retours)
		{
			id = ids;
			avion = avions;
			depart = departs;
			destination = destinations;
			heureDepart = heureDeparts;
			heureArrivee = heureArrivees;
			placeAffaire = placeAffaires;
			placePremium = placePremiums;
			placeEco = placeEcos;
			placeTotal = placeTotals;
			prix = prixs;
			aller = allers;
			retour = retours;
		}
		public Vol(String ids, String avions, String departs, String destinations, DateTime heureDeparts, DateTime heureArrivees, int placeTotals, double prixs)
		{
			id = ids;
			nom = avions;
			depart = departs;
			destination = destinations;
			heureDepart = heureDeparts;
			heureArrivee = heureArrivees;
			placeTotal = placeTotals;
			prix = prixs;
		}
		public Vol(String ids, String avionids, String noms, String departs, String destinations, DateTime heureDeparts, DateTime heureArrivees,int heureVols, double prixx)
		{
			id = ids;
			avionid = avionids;
			nom = noms;
			depart = departs;
			destination = destinations;
			heureDepart = heureDeparts;
			heureArrivee = heureArrivees;
			heureVol = heureVols;
			prix = prixx;
		}
		public Vol(String ids, String avionids, String noms,String compagnies, String departs, String destinations, DateTime heureDeparts, DateTime heureArrivees, double prixx)
		{
			id = ids;
			avionid = avionids;
			nom = noms;
			compagnie = compagnies;
			depart = departs;
			destination = destinations;
			heureDepart = heureDeparts;
			heureArrivee = heureArrivees;
			prix = prixx;
		}
		public Vol(DateTime heureDeparts,String destinations){
			heureDepart = heureDeparts;
			destination = destinations;
		}
		public Vol( String destinations, String avions, int placeTotals)
		{
			destination = destinations;
			avion = avions;
			placeTotal = placeTotals;
		}
	}
}
