/*
 * Created by SharpDevelop.
 * User: CC2_PC34
 * Date: 24/10/2024
 * Time: 07:31 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ProyectoCS
{
	partial class RFC
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
			this.LblRFC = new System.Windows.Forms.Label();
			this.Lblname = new System.Windows.Forms.Label();
			this.LblRFC2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Lblnombre
			// 
			this.Lblnombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lblnombre.Location = new System.Drawing.Point(52, 66);
			this.Lblnombre.Name = "Lblnombre";
			this.Lblnombre.Size = new System.Drawing.Size(164, 23);
			this.Lblnombre.TabIndex = 0;
			this.Lblnombre.Text = "Nombre completo";
			// 
			// LblRFC
			// 
			this.LblRFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblRFC.Location = new System.Drawing.Point(51, 195);
			this.LblRFC.Name = "LblRFC";
			this.LblRFC.Size = new System.Drawing.Size(313, 23);
			this.LblRFC.TabIndex = 1;
			this.LblRFC.Text = "Registro Federal de Contribuyentes(RFC)";
			// 
			// Lblname
			// 
			this.Lblname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Lblname.Location = new System.Drawing.Point(51, 124);
			this.Lblname.Name = "Lblname";
			this.Lblname.Size = new System.Drawing.Size(436, 23);
			this.Lblname.TabIndex = 2;
			// 
			// LblRFC2
			// 
			this.LblRFC2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblRFC2.Location = new System.Drawing.Point(51, 262);
			this.LblRFC2.Name = "LblRFC2";
			this.LblRFC2.Size = new System.Drawing.Size(436, 23);
			this.LblRFC2.TabIndex = 3;
			// 
			// RFC
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(532, 433);
			this.Controls.Add(this.LblRFC2);
			this.Controls.Add(this.Lblname);
			this.Controls.Add(this.LblRFC);
			this.Controls.Add(this.Lblnombre);
			this.Name = "RFC";
			this.Text = "RFC";
			this.Load += new System.EventHandler(this.RFCLoad);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label LblRFC2;
		private System.Windows.Forms.Label Lblname;
		private System.Windows.Forms.Label LblRFC;
		private System.Windows.Forms.Label Lblnombre;
	}
}
