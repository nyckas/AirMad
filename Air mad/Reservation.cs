/*
 * Crée par SharpDevelop.
 * Utilisateur: ITU
 * Date: 19/04/2017
 * Heure: 11:54
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
	/// Description of Reservation.
	/// </summary>
	public class Reservation
	{
		DateTime dd;
		String vol1;
		String vol2;
		String id;
		String passager;
		String depart;
		String destination;
		String nationalite;
		DateTime daty;
		String classe;
		String avion;
		String avion1;
		String avion2;
		String escale;
		String vol;
		String volretour;
		String type;
		double prix;
		public String getid(){
			return id;
		}
		public String getvol1(){
			return vol1;
		}
		public String getvol2(){
			return vol2;
		}
		public String getavion1(){
			return avion1;
		}
		public String getavion2(){
			return avion2;
		}
		public String getescale(){
			return escale;
		}
		public String getPassager(){
			return passager;
		}
		public String getdepart(){
			return depart;
		}
		public String getdestination(){
			return destination;
		}
		public String getnationalite(){
			return nationalite;
		}
		public String getdaty(){
			if(daty<DateTime.Now)
			{
				MessageBox.Show("Il n'y a pas de vol a cette date");
				throw new Exception("Il n'y a pas de vol");
			}
				return String.Format("{0}-{1}-{2} {3}:{4}:{5}.{6}",daty.Year, daty.Month, daty.Day, daty.Hour, daty.Minute, daty.Second, daty.Millisecond);
				
		}
		public String getclasse(){
			return classe;
		}
		public String getavion(){
			return avion;
		}
		public String getvol(){
			return vol;
		}
		public String gettype(){
			return type;
		}
		public String getvolretour(){
			return volretour;
		}
		public double getprix(){
			return prix;
		}		
		public Reservation(String ids, String passagers, String destinations, String nationalites, DateTime datee, String classes, String vols, String types, String volretours, String departs)
		{
			id = ids;
			passager = passagers;
			depart = departs;
			destination = destinations;
			nationalite = nationalites;
			daty = datee;
			classe = classes;
			vol = vols;
			type = types;
			volretour = volretours;
		}
		public Reservation(String ids, String passagers, String destinations, String nationalites, DateTime datee, String classes, String vols, String volretours, String types, double prixx)
		{
			id = ids;
			passager = passagers;
			destination = destinations;
			nationalite = nationalites;
			daty = datee;
			classe = classes;
			vol = vols;
			volretour = volretours;
			type = types;
			prix = prixx;
		}
		public Reservation(String vol1s, String vol2s, String passagers, String avions1, String avions2, String classes, String departs, String escales, String destinations, double prixx)
		{
			vol1 = vol1s;
			vol2 = vol2s;
			passager = passagers;
			avion1 = avions1;
			avion2 = avions2;
			classe = classes;
			depart = departs;
			escale = escales;
			destination = destinations;
			prix = prixx;
		}
		public Reservation(String ids, String passagers, String avions, String classes, String departs, String destinations, double prixx)
		{
			id = ids;
			passager = passagers;
			avion = avions;
			classe = classes;
			depart = departs;
			destination = destinations;
			prix = prixx;
		}
	}
}
