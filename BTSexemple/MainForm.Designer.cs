/*
 * Created by SharpDevelop.
 * User: kille
 * Date: 25/11/2023
 * Time: 12:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BTSexemple
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button bt_Creer;
		private System.Windows.Forms.TextBox tb_D;
		private System.Windows.Forms.TextBox tb_C;
		private System.Windows.Forms.TextBox tb_B;
		private System.Windows.Forms.TextBox tb_IdA;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button bt_chercher;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tb_U_Ida;
		private System.Windows.Forms.TextBox tb_U_D;
		private System.Windows.Forms.TextBox tb_U_C;
		private System.Windows.Forms.TextBox tb_U_B;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.Button bt_supp;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox tb_D_Ida;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tb_R_Ida;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label lb_R_D;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label lb_R_C;
		private System.Windows.Forms.Label lb_R_B;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lb_R_A;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.DataGridView dataGridView1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.bt_Creer = new System.Windows.Forms.Button();
			this.tb_D = new System.Windows.Forms.TextBox();
			this.tb_C = new System.Windows.Forms.TextBox();
			this.tb_B = new System.Windows.Forms.TextBox();
			this.tb_IdA = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.tb_U_D = new System.Windows.Forms.TextBox();
			this.tb_U_C = new System.Windows.Forms.TextBox();
			this.tb_U_B = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.bt_chercher = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.tb_U_Ida = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.bt_supp = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.tb_D_Ida = new System.Windows.Forms.TextBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.tb_R_Ida = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.lb_R_D = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.lb_R_C = new System.Windows.Forms.Label();
			this.lb_R_B = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.lb_R_A = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.bt_Creer);
			this.groupBox1.Controls.Add(this.tb_D);
			this.groupBox1.Controls.Add(this.tb_C);
			this.groupBox1.Controls.Add(this.tb_B);
			this.groupBox1.Controls.Add(this.tb_IdA);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 43);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(243, 323);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Creer";
			// 
			// bt_Creer
			// 
			this.bt_Creer.Location = new System.Drawing.Point(67, 228);
			this.bt_Creer.Name = "bt_Creer";
			this.bt_Creer.Size = new System.Drawing.Size(100, 41);
			this.bt_Creer.TabIndex = 8;
			this.bt_Creer.Text = "Créer";
			this.bt_Creer.UseVisualStyleBackColor = true;
			this.bt_Creer.Click += new System.EventHandler(this.Bt_CreerClick);
			// 
			// tb_D
			// 
			this.tb_D.Location = new System.Drawing.Point(17, 200);
			this.tb_D.Name = "tb_D";
			this.tb_D.Size = new System.Drawing.Size(206, 22);
			this.tb_D.TabIndex = 7;
			// 
			// tb_C
			// 
			this.tb_C.Location = new System.Drawing.Point(17, 149);
			this.tb_C.Name = "tb_C";
			this.tb_C.Size = new System.Drawing.Size(206, 22);
			this.tb_C.TabIndex = 6;
			// 
			// tb_B
			// 
			this.tb_B.Location = new System.Drawing.Point(17, 98);
			this.tb_B.Name = "tb_B";
			this.tb_B.Size = new System.Drawing.Size(206, 22);
			this.tb_B.TabIndex = 5;
			// 
			// tb_IdA
			// 
			this.tb_IdA.Location = new System.Drawing.Point(17, 47);
			this.tb_IdA.Name = "tb_IdA";
			this.tb_IdA.Size = new System.Drawing.Size(206, 22);
			this.tb_IdA.TabIndex = 4;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(17, 174);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(206, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "D :";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(17, 123);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(206, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "C :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(17, 72);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(206, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "B :";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(17, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(206, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Id A :";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.tb_U_D);
			this.groupBox2.Controls.Add(this.tb_U_C);
			this.groupBox2.Controls.Add(this.tb_U_B);
			this.groupBox2.Controls.Add(this.label8);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Controls.Add(this.bt_chercher);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.tb_U_Ida);
			this.groupBox2.Location = new System.Drawing.Point(277, 46);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(243, 320);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Modifier";
			// 
			// tb_U_D
			// 
			this.tb_U_D.Location = new System.Drawing.Point(6, 206);
			this.tb_U_D.Name = "tb_U_D";
			this.tb_U_D.Size = new System.Drawing.Size(231, 22);
			this.tb_U_D.TabIndex = 16;
			// 
			// tb_U_C
			// 
			this.tb_U_C.Location = new System.Drawing.Point(6, 155);
			this.tb_U_C.Name = "tb_U_C";
			this.tb_U_C.Size = new System.Drawing.Size(231, 22);
			this.tb_U_C.TabIndex = 15;
			// 
			// tb_U_B
			// 
			this.tb_U_B.Location = new System.Drawing.Point(6, 104);
			this.tb_U_B.Name = "tb_U_B";
			this.tb_U_B.Size = new System.Drawing.Size(231, 22);
			this.tb_U_B.TabIndex = 14;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(6, 180);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(35, 23);
			this.label8.TabIndex = 13;
			this.label8.Text = "D :";
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 129);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(35, 23);
			this.label7.TabIndex = 12;
			this.label7.Text = "C :";
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(6, 78);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 23);
			this.label6.TabIndex = 11;
			this.label6.Text = "B :";
			// 
			// bt_chercher
			// 
			this.bt_chercher.Location = new System.Drawing.Point(63, 247);
			this.bt_chercher.Name = "bt_chercher";
			this.bt_chercher.Size = new System.Drawing.Size(100, 41);
			this.bt_chercher.TabIndex = 10;
			this.bt_chercher.Text = "Modifier";
			this.bt_chercher.UseVisualStyleBackColor = true;
			this.bt_chercher.Click += new System.EventHandler(this.Bt_chercherClick);
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(6, 27);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(206, 23);
			this.label5.TabIndex = 10;
			this.label5.Text = "Id A :";
			// 
			// tb_U_Ida
			// 
			this.tb_U_Ida.Location = new System.Drawing.Point(6, 53);
			this.tb_U_Ida.Name = "tb_U_Ida";
			this.tb_U_Ida.Size = new System.Drawing.Size(231, 22);
			this.tb_U_Ida.TabIndex = 0;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.bt_supp);
			this.groupBox3.Controls.Add(this.label12);
			this.groupBox3.Controls.Add(this.tb_D_Ida);
			this.groupBox3.Location = new System.Drawing.Point(543, 55);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(243, 143);
			this.groupBox3.TabIndex = 17;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Supprimer";
			// 
			// bt_supp
			// 
			this.bt_supp.Location = new System.Drawing.Point(67, 81);
			this.bt_supp.Name = "bt_supp";
			this.bt_supp.Size = new System.Drawing.Size(100, 41);
			this.bt_supp.TabIndex = 10;
			this.bt_supp.Text = "Supprimer";
			this.bt_supp.UseVisualStyleBackColor = true;
			this.bt_supp.Click += new System.EventHandler(this.Bt_suppClick);
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(6, 27);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(206, 23);
			this.label12.TabIndex = 10;
			this.label12.Text = "Id A :";
			// 
			// tb_D_Ida
			// 
			this.tb_D_Ida.Location = new System.Drawing.Point(6, 53);
			this.tb_D_Ida.Name = "tb_D_Ida";
			this.tb_D_Ida.Size = new System.Drawing.Size(231, 22);
			this.tb_D_Ida.TabIndex = 0;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.button1);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.tb_R_Ida);
			this.groupBox4.Location = new System.Drawing.Point(543, 217);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(243, 143);
			this.groupBox4.TabIndex = 18;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Retrouver";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(67, 81);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(100, 41);
			this.button1.TabIndex = 10;
			this.button1.Text = "Chercher";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(6, 27);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(206, 23);
			this.label9.TabIndex = 10;
			this.label9.Text = "Id A :";
			// 
			// tb_R_Ida
			// 
			this.tb_R_Ida.Location = new System.Drawing.Point(6, 53);
			this.tb_R_Ida.Name = "tb_R_Ida";
			this.tb_R_Ida.Size = new System.Drawing.Size(231, 22);
			this.tb_R_Ida.TabIndex = 0;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.lb_R_D);
			this.groupBox5.Controls.Add(this.label15);
			this.groupBox5.Controls.Add(this.lb_R_C);
			this.groupBox5.Controls.Add(this.lb_R_B);
			this.groupBox5.Controls.Add(this.label14);
			this.groupBox5.Controls.Add(this.label16);
			this.groupBox5.Controls.Add(this.lb_R_A);
			this.groupBox5.Controls.Add(this.label10);
			this.groupBox5.Location = new System.Drawing.Point(12, 405);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(891, 71);
			this.groupBox5.TabIndex = 19;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Retrouver";
			// 
			// lb_R_D
			// 
			this.lb_R_D.Location = new System.Drawing.Point(702, 27);
			this.lb_R_D.Name = "lb_R_D";
			this.lb_R_D.Size = new System.Drawing.Size(169, 23);
			this.lb_R_D.TabIndex = 21;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(661, 27);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(35, 23);
			this.label15.TabIndex = 20;
			this.label15.Text = "D :";
			// 
			// lb_R_C
			// 
			this.lb_R_C.Location = new System.Drawing.Point(486, 27);
			this.lb_R_C.Name = "lb_R_C";
			this.lb_R_C.Size = new System.Drawing.Size(169, 23);
			this.lb_R_C.TabIndex = 20;
			// 
			// lb_R_B
			// 
			this.lb_R_B.Location = new System.Drawing.Point(270, 27);
			this.lb_R_B.Name = "lb_R_B";
			this.lb_R_B.Size = new System.Drawing.Size(169, 23);
			this.lb_R_B.TabIndex = 18;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(229, 27);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(35, 23);
			this.label14.TabIndex = 17;
			this.label14.Text = "B :";
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(445, 27);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(35, 23);
			this.label16.TabIndex = 19;
			this.label16.Text = "C :";
			// 
			// lb_R_A
			// 
			this.lb_R_A.Location = new System.Drawing.Point(54, 27);
			this.lb_R_A.Name = "lb_R_A";
			this.lb_R_A.Size = new System.Drawing.Size(169, 23);
			this.lb_R_A.TabIndex = 11;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(6, 27);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(42, 23);
			this.label10.TabIndex = 10;
			this.label10.Text = "Id A :";
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(54, 482);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(849, 142);
			this.dataGridView1.TabIndex = 20;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1018, 653);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "MainForm";
			this.Text = "BTSexemple";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
