namespace PI_CLUB_DEPORTIVO.vistas.registroCliente
{
    partial class RegistroCliente
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
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblApellido = new Label();
            txtApellido = new TextBox();
            lblDni = new Label();
            txtDni = new TextBox();
            txtTelefono = new TextBox();
            lblTelefono = new Label();
            lblDomicilio = new Label();
            txtDomicilio = new TextBox();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblAptoFisico = new Label();
            optAPTrue = new RadioButton();
            optAPFalse = new RadioButton();
            lblTipoCliente = new Label();
            optSocio = new RadioButton();
            optNoSocio = new RadioButton();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(57, 33);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(57, 56);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(526, 27);
            txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.Location = new Point(57, 95);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(66, 20);
            lblApellido.TabIndex = 0;
            lblApellido.Text = "Apellido";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(57, 118);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(526, 27);
            txtApellido.TabIndex = 1;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(59, 162);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 0;
            lblDni.Text = "DNI";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(59, 185);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(258, 27);
            txtDni.TabIndex = 1;
            txtDni.KeyPress += onlyNumberKey;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(325, 185);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(258, 27);
            txtTelefono.TabIndex = 1;
            txtTelefono.KeyPress += onlyNumberKey;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(325, 162);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(67, 20);
            lblTelefono.TabIndex = 0;
            lblTelefono.Text = "Teléfono";
            // 
            // lblDomicilio
            // 
            lblDomicilio.AutoSize = true;
            lblDomicilio.Location = new Point(57, 233);
            lblDomicilio.Name = "lblDomicilio";
            lblDomicilio.Size = new Size(74, 20);
            lblDomicilio.TabIndex = 0;
            lblDomicilio.Text = "Domicilio";
            // 
            // txtDomicilio
            // 
            txtDomicilio.Location = new Point(57, 256);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(526, 27);
            txtDomicilio.TabIndex = 1;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(59, 305);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(54, 20);
            lblCorreo.TabIndex = 0;
            lblCorreo.Text = "Correo";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(59, 328);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(526, 27);
            txtCorreo.TabIndex = 1;
            // 
            // lblAptoFisico
            // 
            lblAptoFisico.AutoSize = true;
            lblAptoFisico.Location = new Point(59, 377);
            lblAptoFisico.Name = "lblAptoFisico";
            lblAptoFisico.Size = new Size(81, 20);
            lblAptoFisico.TabIndex = 0;
            lblAptoFisico.Text = "Apto físico";
            // 
            // optAPTrue
            // 
            optAPTrue.AutoSize = true;
            optAPTrue.Location = new Point(59, 400);
            optAPTrue.Name = "optAPTrue";
            optAPTrue.Size = new Size(104, 24);
            optAPTrue.TabIndex = 2;
            optAPTrue.TabStop = true;
            optAPTrue.Text = "Presentado";
            optAPTrue.UseVisualStyleBackColor = true;
            // 
            // optAPFalse
            // 
            optAPFalse.AutoSize = true;
            optAPFalse.Location = new Point(169, 400);
            optAPFalse.Name = "optAPFalse";
            optAPFalse.Size = new Size(129, 24);
            optAPFalse.TabIndex = 2;
            optAPFalse.TabStop = true;
            optAPFalse.Text = "No presentado";
            optAPFalse.UseVisualStyleBackColor = true;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(325, 377);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(108, 20);
            lblTipoCliente.TabIndex = 0;
            lblTipoCliente.Text = "Tipo de cliente";
            // 
            // optSocio
            // 
            optSocio.AutoSize = true;
            optSocio.Location = new Point(325, 400);
            optSocio.Name = "optSocio";
            optSocio.Size = new Size(67, 24);
            optSocio.TabIndex = 2;
            optSocio.TabStop = true;
            optSocio.Text = "Socio";
            optSocio.UseVisualStyleBackColor = true;
            // 
            // optNoSocio
            // 
            optNoSocio.AutoSize = true;
            optNoSocio.Location = new Point(435, 400);
            optNoSocio.Name = "optNoSocio";
            optNoSocio.Size = new Size(89, 24);
            optNoSocio.TabIndex = 2;
            optNoSocio.TabStop = true;
            optNoSocio.Text = "No socio";
            optNoSocio.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(659, 57);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 3;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += BtnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(659, 95);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(659, 140);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 3;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // RegistroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 463);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(optNoSocio);
            Controls.Add(optAPFalse);
            Controls.Add(optSocio);
            Controls.Add(optAPTrue);
            Controls.Add(txtCorreo);
            Controls.Add(txtDomicilio);
            Controls.Add(txtApellido);
            Controls.Add(txtTelefono);
            Controls.Add(txtDni);
            Controls.Add(lblCorreo);
            Controls.Add(txtNombre);
            Controls.Add(lblDomicilio);
            Controls.Add(lblApellido);
            Controls.Add(lblTelefono);
            Controls.Add(lblTipoCliente);
            Controls.Add(lblDni);
            Controls.Add(lblAptoFisico);
            Controls.Add(lblNombre);
            Name = "RegistroCliente";
            Text = "REGISTRO CLIENTE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblApellido;
        private TextBox txtApellido;
        private Label lblDni;
        private TextBox txtDni;
        private TextBox txtTelefono;
        private Label lblTelefono;
        private Label lblDomicilio;
        private TextBox txtDomicilio;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblAptoFisico;
        private RadioButton optAPTrue;
        private RadioButton optAPFalse;
        private Label lblTipoCliente;
        private RadioButton optSocio;
        private RadioButton optNoSocio;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnVolver;
    }
}