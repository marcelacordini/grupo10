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
            lblAptoFisico = new Label();
            optAPTrue = new RadioButton();
            optAPFalse = new RadioButton();
            lblTipoCliente = new Label();
            optSocio = new RadioButton();
            optNoSocio = new RadioButton();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            btnVolver = new Button();
            ffNombre = new PI_CLUB_DEPORTIVO.vistas.registroCliente.controles.FieldFormControl();
            ffApellido = new PI_CLUB_DEPORTIVO.vistas.registroCliente.controles.FieldFormControl();
            ffDomicilio = new PI_CLUB_DEPORTIVO.vistas.registroCliente.controles.FieldFormControl();
            ffCorreo = new PI_CLUB_DEPORTIVO.vistas.registroCliente.controles.FieldFormControl();
            ffDni = new PI_CLUB_DEPORTIVO.vistas.registroCliente.controles.FieldFormSmallControl();
            ffTelefono = new PI_CLUB_DEPORTIVO.vistas.registroCliente.controles.FieldFormSmallControl();
            SuspendLayout();
            // 
            // lblAptoFisico
            // 
            lblAptoFisico.AutoSize = true;
            lblAptoFisico.Location = new Point(59, 458);
            lblAptoFisico.Name = "lblAptoFisico";
            lblAptoFisico.Size = new Size(81, 20);
            lblAptoFisico.TabIndex = 0;
            lblAptoFisico.Text = "Apto físico";
            // 
            // optAPTrue
            // 
            optAPTrue.AutoSize = true;
            optAPTrue.Location = new Point(59, 481);
            optAPTrue.Name = "optAPTrue";
            optAPTrue.Size = new Size(104, 24);
            optAPTrue.TabIndex = 7;
            optAPTrue.TabStop = true;
            optAPTrue.Text = "Presentado";
            optAPTrue.UseVisualStyleBackColor = true;
            // 
            // optAPFalse
            // 
            optAPFalse.AutoSize = true;
            optAPFalse.Location = new Point(169, 481);
            optAPFalse.Name = "optAPFalse";
            optAPFalse.Size = new Size(129, 24);
            optAPFalse.TabIndex = 8;
            optAPFalse.TabStop = true;
            optAPFalse.Text = "No presentado";
            optAPFalse.UseVisualStyleBackColor = true;
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Location = new Point(325, 458);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(108, 20);
            lblTipoCliente.TabIndex = 0;
            lblTipoCliente.Text = "Tipo de cliente";
            // 
            // optSocio
            // 
            optSocio.AutoSize = true;
            optSocio.Location = new Point(325, 481);
            optSocio.Name = "optSocio";
            optSocio.Size = new Size(67, 24);
            optSocio.TabIndex = 9;
            optSocio.TabStop = true;
            optSocio.Text = "Socio";
            optSocio.UseVisualStyleBackColor = true;
            // 
            // optNoSocio
            // 
            optNoSocio.AutoSize = true;
            optNoSocio.Location = new Point(435, 481);
            optNoSocio.Name = "optNoSocio";
            optNoSocio.Size = new Size(89, 24);
            optNoSocio.TabIndex = 10;
            optNoSocio.TabStop = true;
            optNoSocio.Text = "No socio";
            optNoSocio.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(659, 57);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(94, 29);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += BtnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(659, 95);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(659, 140);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(94, 29);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            // 
            // ffNombre
            // 
            ffNombre.Location = new Point(57, 34);
            ffNombre.Name = "ffNombre";
            ffNombre.Size = new Size(526, 72);
            ffNombre.TabIndex = 1;
            ffNombre.Title = "Nombre";
            // 
            // ffApellido
            // 
            ffApellido.Location = new Point(57, 112);
            ffApellido.Name = "ffApellido";
            ffApellido.Size = new Size(526, 72);
            ffApellido.TabIndex = 2;
            ffApellido.Title = "Apellido";
            // 
            // ffDomicilio
            // 
            ffDomicilio.Location = new Point(57, 268);
            ffDomicilio.Name = "ffDomicilio";
            ffDomicilio.Size = new Size(526, 72);
            ffDomicilio.TabIndex = 5;
            ffDomicilio.Title = "Domicilio";
            // 
            // ffCorreo
            // 
            ffCorreo.Location = new Point(57, 346);
            ffCorreo.Name = "ffCorreo";
            ffCorreo.Size = new Size(526, 72);
            ffCorreo.TabIndex = 6;
            ffCorreo.Title = "Correo";
            // 
            // ffDni
            // 
            ffDni.Location = new Point(57, 190);
            ffDni.Name = "ffDni";
            ffDni.Size = new Size(258, 72);
            ffDni.TabIndex = 14;
            ffDni.Title = "DNI";
            ffDni.KeyPress += onlyNumberKey;
            // 
            // ffTelefono
            // 
            ffTelefono.Location = new Point(325, 190);
            ffTelefono.Name = "ffTelefono";
            ffTelefono.Size = new Size(258, 72);
            ffTelefono.TabIndex = 15;
            ffTelefono.Title = "Teléfono";
            ffTelefono.KeyPress += onlyNumberKey;
            // 
            // RegistroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 576);
            Controls.Add(ffTelefono);
            Controls.Add(ffDni);
            Controls.Add(ffCorreo);
            Controls.Add(ffDomicilio);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(optNoSocio);
            Controls.Add(optAPFalse);
            Controls.Add(optSocio);
            Controls.Add(optAPTrue);
            Controls.Add(lblTipoCliente);
            Controls.Add(lblAptoFisico);
            Controls.Add(ffApellido);
            Controls.Add(ffNombre);
            Name = "RegistroCliente";
            Text = "REGISTRO CLIENTE";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblAptoFisico;
        private RadioButton optAPTrue;
        private RadioButton optAPFalse;
        private Label lblTipoCliente;
        private RadioButton optSocio;
        private RadioButton optNoSocio;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Button btnVolver;
        private controles.FieldFormControl ffNombre;
        private controles.FieldFormControl ffApellido;
        private controles.FieldFormControl ffDomicilio;
        private controles.FieldFormControl ffCorreo;
        private controles.FieldFormSmallControl ffDni;
        private controles.FieldFormSmallControl ffTelefono;
    }
}