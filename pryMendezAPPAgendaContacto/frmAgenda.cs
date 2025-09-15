namespace pryMendezAPPAgendaContacto
{
    public partial class frmAgenda : Form
    {
        public frmAgenda()
        {
            InitializeComponent();
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
        string vContacto = "";
        string vNumero = "";
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            vContacto = txtContacto.Text;
            vNumero = mtbNumero.Text;


            lstCompleto.Items.Add("contacto" + vContacto
                + "numero" + vNumero);

            //limpiar controles
            txtContacto.Text = "";
            mtbNumero.Text = "";
        }

    
       

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            frmVerCContactos ventanaVerContacto = new frmVerCContactos();
           


        }
    }
}
