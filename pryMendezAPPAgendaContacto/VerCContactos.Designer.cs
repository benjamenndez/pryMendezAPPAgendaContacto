namespace pryMendezAPPAgendaContacto
{
    partial class frmVerCContactos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAceptar = new Button();
            btnAtras = new Button();
            lstDatos = new ListBox();
            SuspendLayout();
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = SystemColors.GradientActiveCaption;
            btnAceptar.Location = new Point(199, 237);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(171, 45);
            btnAceptar.TabIndex = 0;
            btnAceptar.Text = "Siguiente";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = SystemColors.GradientActiveCaption;
            btnAtras.Location = new Point(22, 237);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(171, 45);
            btnAtras.TabIndex = 1;
            btnAtras.Text = "Atras";
            btnAtras.UseVisualStyleBackColor = false;
            // 
            // lstDatos
            // 
            lstDatos.FormattingEnabled = true;
            lstDatos.ItemHeight = 15;
            lstDatos.Location = new Point(22, 25);
            lstDatos.Name = "lstDatos";
            lstDatos.Size = new Size(348, 169);
            lstDatos.TabIndex = 2;
            // 
            // frmVerCContactos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(397, 309);
            Controls.Add(lstDatos);
            Controls.Add(btnAtras);
            Controls.Add(btnAceptar);
            Name = "frmVerCContactos";
            Text = "VerAllContactos";
            Load += frmVerCContactos_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAceptar;
        private Button btnAtras;
        private ListBox lstDatos;
    }
}