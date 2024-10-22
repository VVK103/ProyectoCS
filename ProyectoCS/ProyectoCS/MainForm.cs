/*
 * Created by SharpDevelop.
 * User: CC2_PC34
 * Date: 22/10/2024
 * Time: 07:47 a. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoCS
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
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
		

		
		void BtnCrearClick(object sender, EventArgs e)
		{
			
			char nombre= char.Parse(Txtnombre.Text);
			char apellidop= char.Parse(Txtapellido1.Text);
			char apellidom= char.Parse(Txtapellido2.Text);
			LblRFC2.Text += apellidop(2).ToString() + apellidom(1).ToString() + nombre(1).ToString();
		}
	}
}
