using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Imc i = new Imc();

            i.Altura = double.Parse(txtAltura.Text);
            i.Peso = double.Parse(txtPeso.Text);

            lblResult.Text = "O seu IMC é: " + i.CalcularImc().ToString("F2");

            if(i.CalcularImc()>18.5 && i.CalcularImc() < 25)
            {
                lblDesc.Text = "Peso Normal";
            }
            else
            {
                lblDesc.Text = "Peso Anormal";
            }
        }
    }
}
