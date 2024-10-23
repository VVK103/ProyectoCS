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
			
			string Snombre = Txtnombre.Text;
			string Sapellidop = Txtapellido1.Text;
			string Sapellidom = Txtapellido2.Text;
			var nombre = Snombre[0];
			var apellidop1 = Sapellidop[0];
			var apellidop2 = Sapellidop[1];
			var apellidom = Sapellidom[0];
			int año = dateTimePicker1.Value.Year;
			string año2 = (año%100).ToString("00");
			int mes = dateTimePicker1.Value.Month;
			string mes2= mes.ToString("00");
			int dia = dateTimePicker1.Value.Day;
			string dia2 = dia.ToString("00");
			
			
			
			LblRFC2.Text += apellidop1.ToString() + apellidop2.ToString() + apellidom.ToString() + nombre.ToString() + año2 + mes2 + dia2;
			
		}
	}
}
