/*
 * Created by SharpDevelop.
 * User: kille
 * Date: 25/11/2023
 * Time: 12:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using MySql.Data;
using MySql.Data.MySqlClient;

namespace BTSexemple
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private MySqlConnection maConnexion = connexion.Connexion();
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		Classe_Commun commun = new Classe_Commun();
		
		void Bt_CreerClick(object sender, EventArgs e)
		{

			commun.setA(int.Parse(tb_IdA.Text));
			commun.setB(tb_B.Text);
			commun.setC(tb_C.Text);
			commun.setD(tb_D.Text);
			
			commun.create();
			ChargerDonneesDansDataGridView();
			MessageBox.Show("bien créer");
	
		}
		void Bt_chercherClick(object sender, EventArgs e)
		{
			commun.setB(tb_U_B.Text);
			commun.setC(tb_U_C.Text);
			commun.setD(tb_U_D.Text);
			ChargerDonneesDansDataGridView();
			commun.Update(int.Parse(tb_U_Ida.Text));

		}

		void MainFormLoad(object sender, EventArgs e)
		{
			ChargerDonneesDansDataGridView();
		}
		void Bt_suppClick(object sender, EventArgs e)
		{
			commun.Delete(int.Parse(tb_D_Ida.Text));
			ChargerDonneesDansDataGridView();
		}
		void Button1Click(object sender, EventArgs e)
		{
			Classe_Commun comm = new Classe_Commun().Find(int.Parse(tb_R_Ida.Text));

			if (comm != null)
            {
                // Afficher les données dans les contrôles appropriés
                lb_R_A.Text = comm.getA().ToString();
                lb_R_B.Text = comm.getB();
                lb_R_C.Text = comm.getC();
                lb_R_D.Text = comm.getD();
            }
		}
		
		void ChargerDonneesDansDataGridView()
		{
		    // Connexion à la base de données
		   connexion.Connexion();
		
		    // Requête SQL pour sélectionner toutes les lignes de la table commun
		    string req = "SELECT * FROM commun";
		    MySqlCommand cmd = new MySqlCommand(req, maConnexion);
		    MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
		
		    // Remplir un DataSet avec les données de la base de données
		    System.Data.DataSet dataSet = new System.Data.DataSet();
		    adapter.Fill(dataSet, "commun");
		
		    // Afficher les données dans le DataGridView
		    dataGridView1.DataSource = dataSet.Tables["commun"];
		}

		
		

	}
}
