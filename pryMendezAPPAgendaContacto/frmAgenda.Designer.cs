namespace pryMendezAPPAgendaContacto
{
    partial class frmAgenda
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            lblAgenda = new Label();
            lblContacto = new Label();
            lblNumero = new Label();
            mtbNumero = new MaskedTextBox();
            btnAceptar = new Button();
            btnCancelar = new Button();
            lstCompleto = new ListBox();
            txtContacto = new TextBox();
            lblCantContacto = new Label();
            lblFechaHora = new Label();
            mtbCantContacto = new MaskedTextBox();
            mtbFecha = new MaskedTextBox();
            gbGestion = new GroupBox();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // lblAgenda
            // 
            lblAgenda.AutoSize = true;
            lblAgenda.BackColor = SystemColors.ActiveCaption;
            lblAgenda.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAgenda.ForeColor = Color.FromArgb(224, 224, 224);
            lblAgenda.Location = new Point(28, 22);
            lblAgenda.Name = "lblAgenda";
            lblAgenda.Size = new Size(227, 25);
            lblAgenda.TabIndex = 0;
            lblAgenda.Text = "Gestiòn Agenda Contacto";
            // 
            // lblContacto
            // 
            lblContacto.AutoSize = true;
            lblContacto.Font = new Font("Segoe UI", 11.25F);
            lblContacto.Location = new Point(31, 92);
            lblContacto.Name = "lblContacto";
            lblContacto.Size = new Size(69, 20);
            lblContacto.TabIndex = 1;
            lblContacto.Text = "Contacto";
            // 
            // lblNumero
            // 
            lblNumero.AutoSize = true;
            lblNumero.Font = new Font("Segoe UI", 11.25F);
            lblNumero.Location = new Point(31, 157);
            lblNumero.Name = "lblNumero";
            lblNumero.Size = new Size(63, 20);
            lblNumero.TabIndex = 2;
            lblNumero.Text = "Numero";
            // 
            // mtbNumero
            // 
            mtbNumero.Enabled = false;
            mtbNumero.Location = new Point(121, 154);
            mtbNumero.Mask = "(351)000-0000";
            mtbNumero.Name = "mtbNumero";
            mtbNumero.Size = new Size(167, 23);
            mtbNumero.TabIndex = 1;
            mtbNumero.MaskInputRejected += mtbNumero_MaskInputRejected;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.GradientActiveCaption;
            btnAceptar.Enabled = false;
            btnAceptar.Location = new Point(213, 211);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 2;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = SystemColors.GradientActiveCaption;
            btnCancelar.Location = new Point(121, 211);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // lstCompleto
            // 
            lstCompleto.BackColor = SystemColors.Control;
            lstCompleto.FormattingEnabled = true;
            lstCompleto.ItemHeight = 15;
            lstCompleto.Location = new Point(28, 270);
            lstCompleto.Name = "lstCompleto";
            lstCompleto.Size = new Size(267, 94);
            lstCompleto.TabIndex = 3;
            lstCompleto.SelectedIndexChanged += lstCompleto_SelectedIndexChanged;
            // 
            // txtContacto
            // 
            txtContacto.Location = new Point(121, 93);
            txtContacto.Name = "txtContacto";
            txtContacto.Size = new Size(167, 23);
            txtContacto.TabIndex = 0;
            txtContacto.TextChanged += txtContacto_TextChanged;
            // 
            // lblCantContacto
            // 
            lblCantContacto.AutoSize = true;
            lblCantContacto.Location = new Point(28, 386);
            lblCantContacto.Name = "lblCantContacto";
            lblCantContacto.Size = new Size(87, 15);
            lblCantContacto.TabIndex = 5;
            lblCantContacto.Text = "Cant Contacto:";
            // 
            // lblFechaHora
            // 
            lblFechaHora.AutoSize = true;
            lblFechaHora.Location = new Point(28, 417);
            lblFechaHora.Name = "lblFechaHora";
            lblFechaHora.Size = new Size(79, 15);
            lblFechaHora.TabIndex = 7;
            lblFechaHora.Text = "Fecha y Hora:";
            // 
            // mtbCantContacto
            // 
            mtbCantContacto.Location = new Point(121, 380);
            mtbCantContacto.Name = "mtbCantContacto";
            mtbCantContacto.Size = new Size(54, 23);
            mtbCantContacto.TabIndex = 6;
            // 
            // mtbFecha
            // 
            mtbFecha.Location = new Point(121, 409);
            mtbFecha.Mask = "00/00/0000 00:00";
            mtbFecha.Name = "mtbFecha";
            mtbFecha.Size = new Size(100, 23);
            mtbFecha.TabIndex = 9;
            mtbFecha.ValidatingType = typeof(DateTime);
            // 
            // gbGestion
            // 
            gbGestion.Location = new Point(28, 62);
            gbGestion.Name = "gbGestion";
            gbGestion.Size = new Size(267, 182);
            gbGestion.TabIndex = 10;
            gbGestion.TabStop = false;
            gbGestion.Text = "gestion";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(121, 464);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(75, 23);
            btnLimpiar.TabIndex = 11;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(220, 464);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(75, 23);
            btnMostrar.TabIndex = 12;
            btnMostrar.Text = "Mostrar";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // frmAgenda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 600);
            Controls.Add(btnMostrar);
            Controls.Add(btnLimpiar);
            Controls.Add(mtbFecha);
            Controls.Add(mtbCantContacto);
            Controls.Add(lblFechaHora);
            Controls.Add(lblCantContacto);
            Controls.Add(txtContacto);
            Controls.Add(lstCompleto);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(mtbNumero);
            Controls.Add(lblNumero);
            Controls.Add(lblContacto);
            Controls.Add(lblAgenda);
            Controls.Add(gbGestion);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmAgenda";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblAgenda;
        private Label lblContacto;
        private Label lblNumero;
        private MaskedTextBox mtbContacto;
        private MaskedTextBox mtbNumero;
        private Button btnAceptar;
        private Button btnCancelar;
        private ListBox lstCompleto;
        private TextBox txtContacto;
        private Label lblCantContacto;
        private Label lblFechaHora;
        private MaskedTextBox mtbCantContacto;
        private MaskedTextBox mtbFecha;
        private GroupBox gbGestion;
        private Button btnLimpiar;
        private Button btnMostrar;
    }
}
