using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

///<summary>
///Fecha:14/03/2023
///Autor:Juan Esteban Ortiz Rendon
///Descripcion:Realizar un algortmo que  dibuje una linea con los puntos indicados
///</summary>
namespace wDibujarLinea
{
    public partial class frmDibujarLinea : Form
    {
        public const int ancho = 5;
        Graphics maradona;

        public frmDibujarLinea()
        {
            InitializeComponent();
            maradona = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double xIni = double.Parse(txtXI.Text);
                double xFin = double.Parse(txtXF.Text);
                double yIni = double.Parse(txtYI.Text);
                double yFin = double.Parse(txtYF.Text);

                clsDibujarLinea lineo = new clsDibujarLinea(xIni, xFin, yIni, yFin);
                Pen pen = new Pen(Color.Red);
                maradona.DrawLine(pen, lineo.conseguirxIni(), lineo.conseguirxFin(), lineo.conseguiryIni(), lineo.conseguiryFin());

                txtContar.Text = Convert.ToString(clsDibujarLinea.cuente());
            }
              
                    



            catch (Exception)
            {
                MessageBox.Show("digite un valor en tipo numerico");

            }
        }
    }
}
