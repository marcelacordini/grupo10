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
            optAPTrue = new RadioButton();
            optAPFalse = new RadioButton();
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
            gbAptoFisico = new GroupBox();
            gbTipoCliente = new GroupBox();
            gbAptoFisico.SuspendLayout();
            gbTipoCliente.SuspendLayout();
            SuspendLayout();
            // 
            // optAPTrue
            // 
            optAPTrue.AutoSize = true;
            optAPTrue.Font = new Font("Segoe UI", 10F);
            optAPTrue.Location = new Point(21, 36);
            optAPTrue.Name = "optAPTrue";
            optAPTrue.Size = new Size(117, 27);
            optAPTrue.TabIndex = 7;
            optAPTrue.TabStop = true;
            optAPTrue.Text = "Presentado";
            optAPTrue.UseVisualStyleBackColor = true;
            // 
            // optAPFalse
            // 
            optAPFalse.AutoSize = true;
            optAPFalse.Font = new Font("Segoe UI", 10F);
            optAPFalse.Location = new Point(21, 71);
            optAPFalse.Name = "optAPFalse";
            optAPFalse.Size = new Size(145, 27);
            optAPFalse.TabIndex = 8;
            optAPFalse.TabStop = true;
            optAPFalse.Text = "No presentado";
            optAPFalse.UseVisualStyleBackColor = true;
            // 
            // optSocio
            // 
            optSocio.AutoSize = true;
            optSocio.Font = new Font("Segoe UI", 10F);
            optSocio.Location = new Point(44, 36);
            optSocio.Name = "optSocio";
            optSocio.Size = new Size(72, 27);
            optSocio.TabIndex = 9;
            optSocio.TabStop = true;
            optSocio.Text = "Socio";
            optSocio.UseVisualStyleBackColor = true;
            // 
            // optNoSocio
            // 
            optNoSocio.AutoSize = true;
            optNoSocio.Font = new Font("Segoe UI", 10F);
            optNoSocio.Location = new Point(44, 68);
            optNoSocio.Name = "optNoSocio";
            optNoSocio.Size = new Size(98, 27);
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
            btnLimpiar.Click += LimpiarCampos;
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
            ffDni.TabIndex = 3;
            ffDni.Title = "DNI";
            ffDni.KeyPress += OnlyNumberKey;
            // 
            // ffTelefono
            // 
            ffTelefono.Location = new Point(325, 190);
            ffTelefono.Name = "ffTelefono";
            ffTelefono.Size = new Size(258, 72);
            ffTelefono.TabIndex = 4;
            ffTelefono.Title = "Teléfono";
            ffTelefono.KeyPress += OnlyNumberKey;
            // 
            // gbAptoFisico
            // 
            gbAptoFisico.Controls.Add(optAPTrue);
            gbAptoFisico.Controls.Add(optAPFalse);
            gbAptoFisico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbAptoFisico.Location = new Point(57, 424);
            gbAptoFisico.Name = "gbAptoFisico";
            gbAptoFisico.Size = new Size(250, 125);
            gbAptoFisico.TabIndex = 16;
            gbAptoFisico.TabStop = false;
            gbAptoFisico.Text = "Apto Físico";
            // 
            // gbTipoCliente
            // 
            gbTipoCliente.Controls.Add(optNoSocio);
            gbTipoCliente.Controls.Add(optSocio);
            gbTipoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbTipoCliente.Location = new Point(333, 424);
            gbTipoCliente.Name = "gbTipoCliente";
            gbTipoCliente.Size = new Size(250, 125);
            gbTipoCliente.TabIndex = 17;
            gbTipoCliente.TabStop = false;
            gbTipoCliente.Text = "Tipo de cliente";
            // 
            // RegistroCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 576);
            Controls.Add(gbTipoCliente);
            Controls.Add(ffTelefono);
            Controls.Add(ffDni);
            Controls.Add(ffCorreo);
            Controls.Add(ffDomicilio);
            Controls.Add(btnVolver);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(ffApellido);
            Controls.Add(ffNombre);
            Controls.Add(gbAptoFisico);
            Name = "RegistroCliente";
            Text = "REGISTRO CLIENTE";
            gbAptoFisico.ResumeLayout(false);
            gbAptoFisico.PerformLayout();
            gbTipoCliente.ResumeLayout(false);
            gbTipoCliente.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private RadioButton optAPTrue;
        private RadioButton optAPFalse;
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
        private GroupBox gbAptoFisico;
        private GroupBox gbTipoCliente;
    }
}