/*
 * Created by SharpDevelop.
 * User: CC2_PC34
 * Date: 22/10/2024
 * Time: 07:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoCS
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
			this.Lblnombre = new System.Windows.Forms.Label();
			this.Lblapellido1 = new System.Windows.Forms.Label();
			this.Lblapellido2 = new System.Windows.Forms.Label();
			this.Lbltelefono = new System.Windows.Forms.Label();
			this.Lbldireccion = new System.Windows.Forms.Label();
			this.LblFNac = new System.Windows.Forms.Label();
			this.LblRFC = new System.Windows.Forms.Label();
			this.LblRFC2 = new System.Windows.Forms.Label();
			this.Txtnombre = new System.Windows.Forms.TextBox();
			this.Txtapellido1 = new System.Windows.Forms.TextBox();
			this.Txttelefono = new System.Windows.Forms.TextBox();
			this.Txtdireccion = new System.Windows.Forms.TextBox();
			this.Txtapellido2 = new System.Windows.Forms.TextBox();
			this.Lblsemestre = new System.Windows.Forms.Label();
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnCrear = new System.Windows.Forms.Button();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.SuspendLayout();
			// 
			// Lblnombre
			// 
			this.Lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lblnombre.Location = new System.Drawing.Point(38, 64);
			this.Lblnombre.Name = "Lblnombre";
			this.Lblnombre.Size = new System.Drawing.Size(121, 23);
			this.Lblnombre.TabIndex = 0;
			this.Lblnombre.Text = "Nombre:";
			// 
			// Lblapellido1
			// 
			this.Lblapellido1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lblapellido1.Location = new System.Drawing.Point(38, 99);
			this.Lblapellido1.Name = "Lblapellido1";
			this.Lblapellido1.Size = new System.Drawing.Size(121, 23);
			this.Lblapellido1.TabIndex = 1;
			this.Lblapellido1.Text = "Apellido Paterno:";
			// 
			// Lblapellido2
			// 
			this.Lblapellido2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lblapellido2.Location = new System.Drawing.Point(38, 134);
			this.Lblapellido2.Name = "Lblapellido2";
			this.Lblapellido2.Size = new System.Drawing.Size(121, 23);
			this.Lblapellido2.TabIndex = 2;
			this.Lblapellido2.Text = "Apellido Materno:";
			// 
			// Lbltelefono
			// 
			this.Lbltelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbltelefono.Location = new System.Drawing.Point(38, 170);
			this.Lbltelefono.Name = "Lbltelefono";
			this.Lbltelefono.Size = new System.Drawing.Size(121, 23);
			this.Lbltelefono.TabIndex = 3;
			this.Lbltelefono.Text = "Telefono:";
			// 
			// Lbldireccion
			// 
			this.Lbldireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lbldireccion.Location = new System.Drawing.Point(38, 205);
			this.Lbldireccion.Name = "Lbldireccion";
			this.Lbldireccion.Size = new System.Drawing.Size(121, 23);
			this.Lbldireccion.TabIndex = 4;
			this.Lbldireccion.Text = "Direccion:";
			// 
			// LblFNac
			// 
			this.LblFNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblFNac.Location = new System.Drawing.Point(38, 282);
			this.LblFNac.Name = "LblFNac";
			this.LblFNac.Size = new System.Drawing.Size(121, 23);
			this.LblFNac.TabIndex = 5;
			this.LblFNac.Text = "F. Nacimiento:";
			// 
			// LblRFC
			// 
			this.LblRFC.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblRFC.Location = new System.Drawing.Point(38, 316);
			this.LblRFC.Name = "LblRFC";
			this.LblRFC.Size = new System.Drawing.Size(236, 28);
			this.LblRFC.TabIndex = 6;
			this.LblRFC.Text = "Registro Federal de Contribuyentes(RFC)";
			// 
			// LblRFC2
			// 
			this.LblRFC2.Font = new System.Drawing.Font("Microsoft Uighur", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblRFC2.Location = new System.Drawing.Point(38, 344);
			this.LblRFC2.Name = "LblRFC2";
			this.LblRFC2.Size = new System.Drawing.Size(236, 23);
			this.LblRFC2.TabIndex = 7;
			// 
			// Txtnombre
			// 
			this.Txtnombre.Location = new System.Drawing.Point(183, 61);
			this.Txtnombre.Name = "Txtnombre";
			this.Txtnombre.Size = new System.Drawing.Size(200, 20);
			this.Txtnombre.TabIndex = 8;
			// 
			// Txtapellido1
			// 
			this.Txtapellido1.Location = new System.Drawing.Point(183, 96);
			this.Txtapellido1.Name = "Txtapellido1";
			this.Txtapellido1.Size = new System.Drawing.Size(200, 20);
			this.Txtapellido1.TabIndex = 9;
			// 
			// Txttelefono
			// 
			this.Txttelefono.Location = new System.Drawing.Point(183, 167);
			this.Txttelefono.Name = "Txttelefono";
			this.Txttelefono.Size = new System.Drawing.Size(200, 20);
			this.Txttelefono.TabIndex = 10;
			// 
			// Txtdireccion
			// 
			this.Txtdireccion.Location = new System.Drawing.Point(183, 202);
			this.Txtdireccion.Name = "Txtdireccion";
			this.Txtdireccion.Size = new System.Drawing.Size(200, 20);
			this.Txtdireccion.TabIndex = 11;
			// 
			// Txtapellido2
			// 
			this.Txtapellido2.Location = new System.Drawing.Point(183, 131);
			this.Txtapellido2.Name = "Txtapellido2";
			this.Txtapellido2.Size = new System.Drawing.Size(200, 20);
			this.Txtapellido2.TabIndex = 12;
			// 
			// Lblsemestre
			// 
			this.Lblsemestre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lblsemestre.Location = new System.Drawing.Point(38, 241);
			this.Lblsemestre.Name = "Lblsemestre";
			this.Lblsemestre.Size = new System.Drawing.Size(121, 23);
			this.Lblsemestre.TabIndex = 13;
			this.Lblsemestre.Text = "Semestre:";
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[] {
									"1er Semestre",
									"2do Semestre",
									"3er Semestre",
									"4to Semestre",
									"5to Semestre",
									"6to Semestre"});
			this.comboBox1.Location = new System.Drawing.Point(183, 238);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(200, 21);
			this.comboBox1.TabIndex = 19;
			this.comboBox1.Tag = "";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(3, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(429, 41);
			this.label1.TabIndex = 21;
			this.label1.Text = "Registro Federal de Contribuyentes(RFC)";
			// 
			// BtnCrear
			// 
			this.BtnCrear.Location = new System.Drawing.Point(298, 316);
			this.BtnCrear.Name = "BtnCrear";
			this.BtnCrear.Size = new System.Drawing.Size(85, 51);
			this.BtnCrear.TabIndex = 22;
			this.BtnCrear.Text = "Crear";
			this.BtnCrear.UseVisualStyleBackColor = true;
			this.BtnCrear.Click += new System.EventHandler(this.BtnCrearClick);
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(183, 278);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
			this.dateTimePicker1.TabIndex = 23;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 407);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.BtnCrear);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.Lblsemestre);
			this.Controls.Add(this.Txtapellido2);
			this.Controls.Add(this.Txtdireccion);
			this.Controls.Add(this.Txttelefono);
			this.Controls.Add(this.Txtapellido1);
			this.Controls.Add(this.Txtnombre);
			this.Controls.Add(this.LblRFC2);
			this.Controls.Add(this.LblRFC);
			this.Controls.Add(this.LblFNac);
			this.Controls.Add(this.Lbldireccion);
			this.Controls.Add(this.Lbltelefono);
			this.Controls.Add(this.Lblapellido2);
			this.Controls.Add(this.Lblapellido1);
			this.Controls.Add(this.Lblnombre);
			this.Name = "MainForm";
			this.Text = "Registro";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Button BtnCrear;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Label Lblsemestre;
		private System.Windows.Forms.TextBox Txtapellido2;
		private System.Windows.Forms.TextBox Txtdireccion;
		private System.Windows.Forms.TextBox Txttelefono;
		private System.Windows.Forms.TextBox Txtapellido1;
		private System.Windows.Forms.TextBox Txtnombre;
		private System.Windows.Forms.Label LblRFC2;
		private System.Windows.Forms.Label LblRFC;
		private System.Windows.Forms.Label LblFNac;
		private System.Windows.Forms.Label Lbldireccion;
		private System.Windows.Forms.Label Lbltelefono;
		private System.Windows.Forms.Label Lblapellido2;
		private System.Windows.Forms.Label Lblapellido1;
		private System.Windows.Forms.Label Lblnombre;
	}
}
