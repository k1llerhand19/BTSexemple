/*
 * Created by SharpDevelop.
 * User: kille
 * Date: 25/11/2023
 * Time: 12:07
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using MySql.Data.MySqlClient;


namespace BTSexemple
{
	/// <summary>
	/// Description of connexion.
	/// </summary>
	public class connexion
	{
		public connexion()
		{
		}
		
		public static MySqlConnection Connexion( ) 
		{
			//Déclaration variable pour stocker le contenue d'une ligne (enregistrement ou tuple) du fichier 
		
			String chaineConnexion;
			chaineConnexion = "server=localhost;database=btsexamexemple;user id=root;password=;";
			MySqlConnection maConnexion;
			maConnexion = new MySqlConnection(chaineConnexion);
			maConnexion.Open();
			return maConnexion;
		}
	}
}
