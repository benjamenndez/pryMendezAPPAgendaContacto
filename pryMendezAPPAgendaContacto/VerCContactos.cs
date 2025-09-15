using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMendezAPPAgendaContacto
{
    public partial class frmVerCContactos : Form
    {
        public frmVerCContactos()
        {
            InitializeComponent();
        }
        //declaracion de variables
        public string[] vecNombre = new string[5];
        int indice = 0;
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            indice++; //indice = indice + 1;
            lstDatos.Text = vecNombre[indice];
            if (vecNombre.Length <= (indice + 1))
            {
                btnAceptar.Enabled = false;
            }
        }

        private void frmVerCContactos_Load(object sender, EventArgs e)
        {
            vecNombre[0] = "nike";
            vecNombre[1] = "adidas";
            vecNombre[2] = "puma";
            lstDatos.Text = vecNombre[0];
            //llamar al formulario gestion
            frmAgenda ventaGestion = new frmAgenda();
            ventaGestion.ShowDialog();
        }
    }
}
