namespace pryMendezAPPAgendaContacto
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
        }
        //def variables globales
        string vContacto = "";
        string vNumero = "";
        int vContador = 0;
        DateTime vFecha = DateTime.Now;
        int indice = 0;
        string[] vecTelefono = new string[5];
        string[] vecContacto = new string[5];


        private void lstCompleto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtContacto_TextChanged(object sender, EventArgs e)
        {
            if (txtContacto.Text == "")
            {
                mtbNumero.Enabled = false;
            }
            else
            {
                mtbNumero.Enabled = true;
            }
        }

        private void mtbNumero_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (mtbNumero.Text == "")
            {
                btnAceptar.Enabled = false;
            }
            else
            {
                btnAceptar.Enabled = true;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            vecContacto[indice] = txtContacto.Text;
            vecTelefono[indice] = mtbNumero.Text;
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;


            lstCompleto.Items.Add("contacto" + vContacto
                + "numero" + vNumero);
            vContador = vContador + 1;
            mtbCantContacto.Text = Convert.ToString(vContador);
            mtbFecha.Text = Convert.ToString(vFecha);

            //limpiar controles
            txtContacto.Text = "";
            mtbNumero.Text = "";

            indice++;
            txtContacto.Focus();
        }


        private void btnMostrar_Click(object sender, EventArgs e)
        {
            indice = 0;
            while (indice < 5)
            {
                if (vecContacto [indice] != null)
                {
                    lstCompleto.Items.Add(vecContacto[indice] + " | " + vecTelefono[indice]);
                }
                indice++;
            }
            for (int indice = 0; indice < 5; indice++)
            {
                vecContacto[indice] = null;
                vecTelefono[indice] = null;
            }
        }
    }
}
