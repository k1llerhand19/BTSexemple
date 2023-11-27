/*
 * Created by SharpDevelop.
 * User: kille
 * Date: 25/11/2023
 * Time: 12:10
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace BTSexemple
{
	/// <summary>
	/// Description of Classe_Commun.
	/// </summary>
	public class Classe_Commun
	{
		private int A;
        private string B;
        private string C;
        private string D;
        private MySqlConnection maConnexion = connexion.Connexion();
        
        public Classe_Commun(int a, string b, string c, string d)
        {
            this.A = a;
            this.B = b;
            this.C = c;
            this.D = d;
        }
        
		public Classe_Commun()
		{
			
		}
		
		public int getA() {  return this.A; }
        public string getB() { return this.B;}
        public string getC() { return this.C;}
        public string getD() { return this.D;}

        //set

        public void setA(int a) {  this.A = a; }
        public void setB(string b) { this.B = b; } 
        public void setC(string c) { this.C = c; }
        public void setD(string d) {  this.D = d; }

        //crud

        public void create()
        {
            // Connexion à la base de données
            connexion.Connexion();
            string req = "INSERT INTO commun(ida, b, c, d) VALUES('" + A + "'" + "," + "'" + B + "'" + "," + "'" + C + "'" + "," + "'" + D + "'" + ")";
            MySqlCommand cmd = new MySqlCommand(req, maConnexion);
            cmd.ExecuteNonQuery();

        }
        
       
		 public Classe_Commun Find(int id)
		    {
		        // Connexion à la base de données
		        connexion.Connexion();
		
		        // Assuming that the primary key of your table is 'ida'
		        string req = "SELECT * FROM commun WHERE ida = " + id;
		        
		        MySqlCommand cmd = new MySqlCommand(req, maConnexion);
		        MySqlDataReader reader = cmd.ExecuteReader();
		
		        if (reader.Read())
		        {
		            // Create a new instance of Classe_Commun with the retrieved data
		            Classe_Commun result = new Classe_Commun();
		            result.setA(reader.GetInt32("ida"));
		            result.setB(reader.GetString("b"));
		            result.setC(reader.GetString("c"));
		            result.setD(reader.GetString("d"));
		
		            reader.Close();
		            return result;
		        }
		        else
		        {

		            reader.Close();
		            return null;
		        }
		    }
        	
	
		public string Update(int idG)
		{
			connexion.Connexion();
			string req = "update commun set b = '" + B + "', c = '" + C + "', d = '" + D + "' where ida = " + idG;
			MySqlCommand cmd = new MySqlCommand(req, maConnexion);
			cmd.ExecuteNonQuery();
			return req;
		}
		
		
		public void Delete(int id)
		{
		    // Connexion à la base de données
		    connexion.Connexion();
		    
		    // Assuming that the primary key of your table is 'ida'
		    string req = "DELETE FROM commun WHERE ida = " + id;
		    
		    MySqlCommand cmd = new MySqlCommand(req, maConnexion);
		    cmd.ExecuteNonQuery();
		}
		
		
	}
}
