using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumeroRandom
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (int.Parse(tbNumeroMinimo.Text) > int.Parse(tbNumeroMaximo.Text))
            {
                MessageBox.Show("El número mínimo debe ser menor que el número máximo", "Error al ingresar números", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var random = new Random();
                int numero = random.Next(int.Parse(tbNumeroMinimo.Text), int.Parse(tbNumeroMaximo.Text) + 1);
                lblNumero.Text = numero.ToString();
            }
        }

        private void tbNumeroMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tbNumeroMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
