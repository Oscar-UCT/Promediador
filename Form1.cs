using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promediador
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int promedioFinal;
        int notaMayor;
        int notaMenor;
        
        private void calcular_btn_Click(object sender, EventArgs e)
        {
            int primeraNota = (int)nota1.Value * (int)(porcentaje1.Value / 10);
            int segundaNota = (int)nota2.Value * (int)(porcentaje2.Value / 10);
            int terceraNota = (int)nota3.Value * (int)(porcentaje3.Value / 10);
            int cuartaNota = (int)nota4.Value * (int)(porcentaje4.Value / 10);


            promedioFinal = (primeraNota + segundaNota + terceraNota + cuartaNota) / ((int)(porcentaje1.Value / 10) + (int)(porcentaje2.Value / 10) + (int)(porcentaje3.Value / 10) + (int)(porcentaje4.Value / 10));


            int[] notas = { primeraNota / (int)(porcentaje1.Value / 10), segundaNota / (int)(porcentaje2.Value / 10), terceraNota / (int)(porcentaje3.Value / 10), cuartaNota / (int)(porcentaje4.Value / 10) };
            notaMayorVentana.Text = notas.Max().ToString();
            notaMenorVentana.Text = notas.Min().ToString();


            promedioVentana.Text = promedioFinal.ToString();
            if (promedioFinal >= 39)
            {
                aprobado.Text = "Aprobado.";
                aprobado.ForeColor = Color.Green;
            }
            else
            {
                aprobado.Text = "Desaprobado.";
                aprobado.ForeColor = Color.Red;
            }
        }

        private void nota1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nota2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nota3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void nota4_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
