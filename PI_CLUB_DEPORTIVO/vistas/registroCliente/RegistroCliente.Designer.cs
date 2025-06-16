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
            lblTitleForm = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            iconRegistrar = new Label();
            iconLimpiar = new Label();
            iconVolver = new Label();
            gbAptoFisico.SuspendLayout();
            gbTipoCliente.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // optAPTrue
            // 
            optAPTrue.AutoSize = true;
            optAPTrue.Font = new Font("Segoe UI", 10F);
            optAPTrue.Location = new Point(18, 31);
            optAPTrue.Name = "optAPTrue";
            optAPTrue.Size = new Size(96, 23);
            optAPTrue.TabIndex = 7;
            optAPTrue.TabStop = true;
            optAPTrue.Text = "Presentado";
            optAPTrue.UseVisualStyleBackColor = true;
            // 
            // optAPFalse
            // 
            optAPFalse.AutoSize = true;
            optAPFalse.Font = new Font("Segoe UI", 10F);
            optAPFalse.Location = new Point(18, 60);
            optAPFalse.Name = "optAPFalse";
            optAPFalse.Size = new Size(118, 23);
            optAPFalse.TabIndex = 8;
            optAPFalse.TabStop = true;
            optAPFalse.Text = "No presentado";
            optAPFalse.UseVisualStyleBackColor = true;
            // 
            // optSocio
            // 
            optSocio.AutoSize = true;
            optSocio.Font = new Font("Segoe UI", 10F);
            optSocio.Location = new Point(38, 31);
            optSocio.Name = "optSocio";
            optSocio.Size = new Size(59, 23);
            optSocio.TabIndex = 9;
            optSocio.TabStop = true;
            optSocio.Text = "Socio";
            optSocio.UseVisualStyleBackColor = true;
            // 
            // optNoSocio
            // 
            optNoSocio.AutoSize = true;
            optNoSocio.Font = new Font("Segoe UI", 10F);
            optNoSocio.Location = new Point(38, 58);
            optNoSocio.Name = "optNoSocio";
            optNoSocio.Size = new Size(80, 23);
            optNoSocio.TabIndex = 10;
            optNoSocio.TabStop = true;
            optNoSocio.Text = "No socio";
            optNoSocio.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Dock = DockStyle.Fill;
            btnRegistrar.Location = new Point(48, 3);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(101, 36);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += BtnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Dock = DockStyle.Fill;
            btnLimpiar.Location = new Point(48, 45);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(101, 36);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += LimpiarCampos;
            // 
            // btnVolver
            // 
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.Location = new Point(48, 87);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(101, 36);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ffNombre
            // 
            ffNombre.Location = new Point(54, 83);
            ffNombre.Margin = new Padding(3, 2, 3, 2);
            ffNombre.Name = "ffNombre";
            ffNombre.Size = new Size(460, 61);
            ffNombre.TabIndex = 1;
            ffNombre.Title = "Nombre";
            // 
            // ffApellido
            // 
            ffApellido.Location = new Point(54, 149);
            ffApellido.Margin = new Padding(3, 2, 3, 2);
            ffApellido.Name = "ffApellido";
            ffApellido.Size = new Size(460, 61);
            ffApellido.TabIndex = 2;
            ffApellido.Title = "Apellido";
            // 
            // ffDomicilio
            // 
            ffDomicilio.Location = new Point(54, 282);
            ffDomicilio.Margin = new Padding(3, 2, 3, 2);
            ffDomicilio.Name = "ffDomicilio";
            ffDomicilio.Size = new Size(460, 61);
            ffDomicilio.TabIndex = 5;
            ffDomicilio.Title = "Domicilio";
            // 
            // ffCorreo
            // 
            ffCorreo.Location = new Point(54, 348);
            ffCorreo.Margin = new Padding(3, 2, 3, 2);
            ffCorreo.Name = "ffCorreo";
            ffCorreo.Size = new Size(460, 61);
            ffCorreo.TabIndex = 6;
            ffCorreo.Title = "Correo";
            // 
            // ffDni
            // 
            ffDni.Location = new Point(54, 216);
            ffDni.Margin = new Padding(3, 2, 3, 2);
            ffDni.Name = "ffDni";
            ffDni.Size = new Size(226, 61);
            ffDni.TabIndex = 3;
            ffDni.Title = "DNI";
            ffDni.KeyPress += OnlyNumberKey;
            // 
            // ffTelefono
            // 
            ffTelefono.Location = new Point(288, 216);
            ffTelefono.Margin = new Padding(3, 2, 3, 2);
            ffTelefono.Name = "ffTelefono";
            ffTelefono.Size = new Size(226, 61);
            ffTelefono.TabIndex = 4;
            ffTelefono.Title = "Teléfono";
            ffTelefono.KeyPress += OnlyNumberKey;
            // 
            // gbAptoFisico
            // 
            gbAptoFisico.Controls.Add(optAPTrue);
            gbAptoFisico.Controls.Add(optAPFalse);
            gbAptoFisico.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbAptoFisico.ForeColor = Color.White;
            gbAptoFisico.Location = new Point(54, 414);
            gbAptoFisico.Name = "gbAptoFisico";
            gbAptoFisico.Size = new Size(219, 106);
            gbAptoFisico.TabIndex = 16;
            gbAptoFisico.TabStop = false;
            gbAptoFisico.Text = "Apto Físico";
            // 
            // gbTipoCliente
            // 
            gbTipoCliente.Controls.Add(optNoSocio);
            gbTipoCliente.Controls.Add(optSocio);
            gbTipoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            gbTipoCliente.ForeColor = Color.White;
            gbTipoCliente.Location = new Point(295, 414);
            gbTipoCliente.Name = "gbTipoCliente";
            gbTipoCliente.Size = new Size(219, 106);
            gbTipoCliente.TabIndex = 17;
            gbTipoCliente.TabStop = false;
            gbTipoCliente.Text = "Tipo de cliente";
            // 
            // lblTitleForm
            // 
            lblTitleForm.AutoSize = true;
            lblTitleForm.Location = new Point(54, 48);
            lblTitleForm.Name = "lblTitleForm";
            lblTitleForm.Size = new Size(198, 19);
            lblTitleForm.TabIndex = 18;
            lblTitleForm.Text = "REGISTRO DE NUEVO CLIENTE";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 29.6052628F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70.39474F));
            tableLayoutPanel1.Controls.Add(btnVolver, 1, 2);
            tableLayoutPanel1.Controls.Add(btnLimpiar, 1, 1);
            tableLayoutPanel1.Controls.Add(btnRegistrar, 1, 0);
            tableLayoutPanel1.Controls.Add(iconRegistrar, 0, 0);
            tableLayoutPanel1.Controls.Add(iconLimpiar, 0, 1);
            tableLayoutPanel1.Controls.Add(iconVolver, 0, 2);
            tableLayoutPanel1.Location = new Point(536, 84);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(152, 126);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // iconRegistrar
            // 
            iconRegistrar.AutoSize = true;
            iconRegistrar.Dock = DockStyle.Fill;
            iconRegistrar.ForeColor = Color.White;
            iconRegistrar.Location = new Point(3, 0);
            iconRegistrar.Name = "iconRegistrar";
            iconRegistrar.Size = new Size(39, 42);
            iconRegistrar.TabIndex = 14;
            iconRegistrar.Text = "label1";
            iconRegistrar.TextAlign = ContentAlignment.MiddleRight;
            iconRegistrar.UseCompatibleTextRendering = true;
            // 
            // iconLimpiar
            // 
            iconLimpiar.AutoSize = true;
            iconLimpiar.Dock = DockStyle.Fill;
            iconLimpiar.ForeColor = Color.White;
            iconLimpiar.Location = new Point(3, 42);
            iconLimpiar.Name = "iconLimpiar";
            iconLimpiar.Size = new Size(39, 42);
            iconLimpiar.TabIndex = 15;
            iconLimpiar.Text = "label2";
            iconLimpiar.TextAlign = ContentAlignment.MiddleRight;
            iconLimpiar.UseCompatibleTextRendering = true;
            // 
            // iconVolver
            // 
            iconVolver.AutoSize = true;
            iconVolver.Dock = DockStyle.Fill;
            iconVolver.ForeColor = Color.White;
            iconVolver.Location = new Point(3, 84);
            iconVolver.Name = "iconVolver";
            iconVolver.Size = new Size(39, 42);
            iconVolver.TabIndex = 16;
            iconVolver.Text = "label3";
            iconVolver.TextAlign = ContentAlignment.MiddleRight;
            iconVolver.UseCompatibleTextRendering = true;
            // 
            // RegistroCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 557);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lblTitleForm);
            Controls.Add(gbTipoCliente);
            Controls.Add(ffTelefono);
            Controls.Add(ffDni);
            Controls.Add(ffCorreo);
            Controls.Add(ffDomicilio);
            Controls.Add(ffApellido);
            Controls.Add(ffNombre);
            Controls.Add(gbAptoFisico);
            Name = "RegistroCliente";
            Text = "REGISTRO CLIENTE";
            Controls.SetChildIndex(gbAptoFisico, 0);
            Controls.SetChildIndex(ffNombre, 0);
            Controls.SetChildIndex(ffApellido, 0);
            Controls.SetChildIndex(ffDomicilio, 0);
            Controls.SetChildIndex(ffCorreo, 0);
            Controls.SetChildIndex(ffDni, 0);
            Controls.SetChildIndex(ffTelefono, 0);
            Controls.SetChildIndex(gbTipoCliente, 0);
            Controls.SetChildIndex(lblTitleForm, 0);
            Controls.SetChildIndex(tableLayoutPanel1, 0);
            gbAptoFisico.ResumeLayout(false);
            gbAptoFisico.PerformLayout();
            gbTipoCliente.ResumeLayout(false);
            gbTipoCliente.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
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
        private Label lblTitleForm;
        private TableLayoutPanel tableLayoutPanel1;
        private Label iconRegistrar;
        private Label iconLimpiar;
        private Label iconVolver;
    }
}