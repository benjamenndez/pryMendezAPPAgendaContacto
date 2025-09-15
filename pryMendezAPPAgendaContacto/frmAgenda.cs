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
            vecContacto[indice] = mtbCantContacto.Text;
            vecTelefono[indice] = mtbNumero.Text;
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;


            lstCompleto.Items.Add("contacto" + vContacto
                + "numero" + vNumero);
            //mostrar resultados usando un contador que acumula
            vContador = vContador + 1;
            txtContacto.Text = Convert.ToString(vContador);
            dtpFechaHora.Text = Convert.ToString(vFecha);

            //limpiar controles
            txtContacto.Text = "";
            mtbNumero.Text = "";

            indice++;
            txtContacto.Focus();
        }




        private void btnAbrir_Click(object sender, EventArgs e)
        {
            frmVerCContactos ventanaVerContacto = new frmVerCContactos();



        }

        
    }
}
