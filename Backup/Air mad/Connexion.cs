/*
 * Crée par SharpDevelop.
 * Utilisateur: ITU
 * Date: 19/04/2017
 * Heure: 11:16
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
	/// Description of Connexion.
	/// </summary>
	public class Connexion
	{
		public SqlConnection ConnectToSql (){
	    System.Data.SqlClient.SqlConnection conn = new System.Data.SqlClient.SqlConnection ();
	    conn.ConnectionString = "Server= AMIN-PC\\DOFLAMINGO; Database=Air_mad; Integrated Security=SSPI;";
	    try
	    {
	        conn.Open();
	    }
	        catch (Exception ex)
	    {
	        MessageBox.Show("Erreur de connexion mec!!!");
	    }
	        try{
	        return conn;
	        }
	    finally
	    {
	        conn.Close();
	    }
		}
		public Connexion()
		{
		}
	}
}
