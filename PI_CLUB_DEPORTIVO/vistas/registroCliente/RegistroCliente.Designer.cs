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
            optAPTrue.Location = new Point(23, 42);
            optAPTrue.Margin = new Padding(4, 4, 4, 4);
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
            optAPFalse.Location = new Point(23, 81);
            optAPFalse.Margin = new Padding(4, 4, 4, 4);
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
            optSocio.Location = new Point(49, 42);
            optSocio.Margin = new Padding(4, 4, 4, 4);
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
            optNoSocio.Location = new Point(49, 78);
            optNoSocio.Margin = new Padding(4, 4, 4, 4);
            optNoSocio.Name = "optNoSocio";
            optNoSocio.Size = new Size(98, 27);
            optNoSocio.TabIndex = 10;
            optNoSocio.TabStop = true;
            optNoSocio.Text = "No socio";
            optNoSocio.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Dock = DockStyle.Fill;
            btnRegistrar.Location = new Point(61, 4);
            btnRegistrar.Margin = new Padding(4, 4, 4, 4);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(130, 48);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += BtnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Dock = DockStyle.Fill;
            btnLimpiar.Location = new Point(61, 60);
            btnLimpiar.Margin = new Padding(4, 4, 4, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(130, 48);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += LimpiarCampos;
            // 
            // btnVolver
            // 
            btnVolver.Dock = DockStyle.Fill;
            btnVolver.Location = new Point(61, 116);
            btnVolver.Margin = new Padding(4, 4, 4, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(130, 50);
            btnVolver.TabIndex = 13;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // ffNombre
            // 
            ffNombre.Location = new Point(69, 112);
            ffNombre.Margin = new Padding(4, 3, 4, 3);
            ffNombre.Name = "ffNombre";
            ffNombre.Size = new Size(591, 83);
            ffNombre.TabIndex = 1;
            ffNombre.Title = "Nombre";
            // 
            // ffApellido
            // 
            ffApellido.Location = new Point(69, 202);
            ffApellido.Margin = new Padding(4, 3, 4, 3);
            ffApellido.Name = "ffApellido";
            ffApellido.Size = new Size(591, 83);
            ffApellido.TabIndex = 2;
            ffApellido.Title = "Apellido";
            // 
            // ffDomicilio
            // 
            ffDomicilio.Location = new Point(69, 382);
            ffDomicilio.Margin = new Padding(4, 3, 4, 3);
            ffDomicilio.Name = "ffDomicilio";
            ffDomicilio.Size = new Size(591, 83);
            ffDomicilio.TabIndex = 5;
            ffDomicilio.Title = "Domicilio";
            // 
            // ffCorreo
            // 
            ffCorreo.Location = new Point(69, 471);
            ffCorreo.Margin = new Padding(4, 3, 4, 3);
            ffCorreo.Name = "ffCorreo";
            ffCorreo.Size = new Size(591, 83);
            ffCorreo.TabIndex = 6;
            ffCorreo.Title = "Correo";
            // 
            // ffDni
            // 
            ffDni.Location = new Point(69, 292);
            ffDni.Margin = new Padding(4, 3, 4, 3);
            ffDni.Name = "ffDni";
            ffDni.Size = new Size(262, 83);
            ffDni.TabIndex = 3;
            ffDni.Title = "DNI";
            ffDni.KeyPress += OnlyNumberKey;
            // 
            // ffTelefono
            // 
            ffTelefono.Location = new Point(339, 291);
            ffTelefono.Margin = new Padding(4, 3, 4, 3);
            ffTelefono.Name = "ffTelefono";
            ffTelefono.Size = new Size(257, 83);
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
            gbAptoFisico.Location = new Point(69, 560);
            gbAptoFisico.Margin = new Padding(4, 4, 4, 4);
            gbAptoFisico.Name = "gbAptoFisico";
            gbAptoFisico.Padding = new Padding(4, 4, 4, 4);
            gbAptoFisico.Size = new Size(282, 143);
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
            gbTipoCliente.Location = new Point(379, 560);
            gbTipoCliente.Margin = new Padding(4, 4, 4, 4);
            gbTipoCliente.Name = "gbTipoCliente";
            gbTipoCliente.Padding = new Padding(4, 4, 4, 4);
            gbTipoCliente.Size = new Size(282, 143);
            gbTipoCliente.TabIndex = 17;
            gbTipoCliente.TabStop = false;
            gbTipoCliente.Text = "Tipo de cliente";
            // 
            // lblTitleForm
            // 
            lblTitleForm.AutoSize = true;
            lblTitleForm.Location = new Point(69, 65);
            lblTitleForm.Margin = new Padding(4, 0, 4, 0);
            lblTitleForm.Name = "lblTitleForm";
            lblTitleForm.Size = new Size(245, 23);
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
            tableLayoutPanel1.Location = new Point(689, 114);
            tableLayoutPanel1.Margin = new Padding(4, 4, 4, 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(195, 170);
            tableLayoutPanel1.TabIndex = 19;
            // 
            // iconRegistrar
            // 
            iconRegistrar.AutoSize = true;
            iconRegistrar.Dock = DockStyle.Fill;
            iconRegistrar.ForeColor = Color.White;
            iconRegistrar.Location = new Point(4, 0);
            iconRegistrar.Margin = new Padding(4, 0, 4, 0);
            iconRegistrar.Name = "iconRegistrar";
            iconRegistrar.Size = new Size(49, 56);
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
            iconLimpiar.Location = new Point(4, 56);
            iconLimpiar.Margin = new Padding(4, 0, 4, 0);
            iconLimpiar.Name = "iconLimpiar";
            iconLimpiar.Size = new Size(49, 56);
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
            iconVolver.Location = new Point(4, 112);
            iconVolver.Margin = new Padding(4, 0, 4, 0);
            iconVolver.Name = "iconVolver";
            iconVolver.Size = new Size(49, 58);
            iconVolver.TabIndex = 16;
            iconVolver.Text = "label3";
            iconVolver.TextAlign = ContentAlignment.MiddleRight;
            iconVolver.UseCompatibleTextRendering = true;
            // 
            // RegistroCliente
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 754);
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
            Margin = new Padding(5, 5, 5, 5);
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