namespace PI_CLUB_DEPORTIVO.vistas
{
    partial class RegistrarPago
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
            txtClienteID = new TextBox();
            btnBuscar = new Button();
            btnLimpiarBuscar = new Button();
            lblCliente = new Label();
            txtFecha = new TextBox();
            txtVencimiento = new TextBox();
            txtMonto = new TextBox();
            cmbFormaPago = new ComboBox();
            cmbPromocion = new ComboBox();
            btnRegistrar = new Button();
            btnLimpiar = new Button();
            lblFecha = new Label();
            lblFechaVto = new Label();
            lblMonto = new Label();
            cmbActividad = new ComboBox();
            lblActividad = new Label();
            lblForma = new Label();
            lblPromocion = new Label();
            lblClienteResultado = new Label();
            SuspendLayout();
            // 
            // txtClienteID
            // 
            txtClienteID.Location = new Point(83, 114);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(285, 30);
            txtClienteID.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(486, 114);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(178, 30);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiarBuscar
            // 
            btnLimpiarBuscar.Location = new Point(720, 114);
            btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            btnLimpiarBuscar.Size = new Size(178, 30);
            btnLimpiarBuscar.TabIndex = 4;
            btnLimpiarBuscar.Text = "LIMPIAR";
            btnLimpiarBuscar.UseVisualStyleBackColor = true;
            btnLimpiarBuscar.Click += btnLimpiarBuscar_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.ForeColor = SystemColors.ControlLight;
            lblCliente.Location = new Point(83, 78);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(85, 23);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente ID";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(172, 239);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(188, 30);
            txtFecha.TabIndex = 6;
            // 
            // txtVencimiento
            // 
            txtVencimiento.Location = new Point(685, 239);
            txtVencimiento.Name = "txtVencimiento";
            txtVencimiento.Size = new Size(213, 30);
            txtVencimiento.TabIndex = 7;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(685, 312);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(213, 30);
            txtMonto.TabIndex = 8;
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Items.AddRange(new object[] { "Tarjeta", "Efectivo" });
            cmbFormaPago.Location = new Point(172, 393);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(190, 31);
            cmbFormaPago.TabIndex = 9;
            // 
            // cmbPromocion
            // 
            cmbPromocion.FormattingEnabled = true;
            cmbPromocion.Items.AddRange(new object[] { "3", "6" });
            cmbPromocion.Location = new Point(685, 388);
            cmbPromocion.Name = "cmbPromocion";
            cmbPromocion.Size = new Size(213, 31);
            cmbPromocion.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(92, 482);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(196, 43);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR PAGO";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(404, 484);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(214, 42);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = SystemColors.ControlLight;
            lblFecha.Location = new Point(83, 242);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(54, 23);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "Fecha";
            // 
            // lblFechaVto
            // 
            lblFechaVto.AutoSize = true;
            lblFechaVto.ForeColor = SystemColors.ControlLight;
            lblFechaVto.Location = new Point(507, 246);
            lblFechaVto.Name = "lblFechaVto";
            lblFechaVto.Size = new Size(154, 23);
            lblFechaVto.TabIndex = 14;
            lblFechaVto.Text = "Fecha Vencimiento";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.ForeColor = SystemColors.ControlLight;
            lblMonto.Location = new Point(600, 319);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(61, 23);
            lblMonto.TabIndex = 15;
            lblMonto.Text = "Monto";
            // 
            // cmbActividad
            // 
            cmbActividad.AutoCompleteCustomSource.AddRange(new string[] { "Zumba", "Yoga", "Crossfit", "Funcional", "Pilates", "Spinning", "Boxeo" });
            cmbActividad.FormattingEnabled = true;
            cmbActividad.Items.AddRange(new object[] { "Tarjeta", "Efectivo" });
            cmbActividad.Location = new Point(172, 319);
            cmbActividad.Name = "cmbActividad";
            cmbActividad.Size = new Size(190, 31);
            cmbActividad.TabIndex = 16;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.ForeColor = SystemColors.ControlLight;
            lblActividad.Location = new Point(83, 327);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(80, 23);
            lblActividad.TabIndex = 17;
            lblActividad.Text = "Actividad";
            // 
            // lblForma
            // 
            lblForma.AutoSize = true;
            lblForma.ForeColor = SystemColors.ControlLight;
            lblForma.Location = new Point(83, 396);
            lblForma.Name = "lblForma";
            lblForma.Size = new Size(58, 23);
            lblForma.TabIndex = 18;
            lblForma.Text = "Forma";
            // 
            // lblPromocion
            // 
            lblPromocion.AutoSize = true;
            lblPromocion.ForeColor = SystemColors.ControlLight;
            lblPromocion.Location = new Point(568, 393);
            lblPromocion.Name = "lblPromocion";
            lblPromocion.Size = new Size(93, 23);
            lblPromocion.TabIndex = 19;
            lblPromocion.Text = "Promocion";
            // 
            // lblClienteResultado
            // 
            lblClienteResultado.AutoSize = true;
            lblClienteResultado.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClienteResultado.ForeColor = SystemColors.Control;
            lblClienteResultado.Location = new Point(86, 169);
            lblClienteResultado.Name = "lblClienteResultado";
            lblClienteResultado.Size = new Size(63, 25);
            lblClienteResultado.TabIndex = 20;
            lblClienteResultado.Text = "label1";
            // 
            // RegistrarPago
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            ClientSize = new Size(1029, 676);
            Controls.Add(lblClienteResultado);
            Controls.Add(lblPromocion);
            Controls.Add(lblForma);
            Controls.Add(lblActividad);
            Controls.Add(cmbActividad);
            Controls.Add(lblMonto);
            Controls.Add(lblFechaVto);
            Controls.Add(lblFecha);
            Controls.Add(btnLimpiar);
            Controls.Add(btnRegistrar);
            Controls.Add(cmbPromocion);
            Controls.Add(cmbFormaPago);
            Controls.Add(txtMonto);
            Controls.Add(txtVencimiento);
            Controls.Add(txtFecha);
            Controls.Add(lblCliente);
            Controls.Add(btnLimpiarBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(txtClienteID);
            Name = "RegistrarPago";
            Controls.SetChildIndex(txtClienteID, 0);
            Controls.SetChildIndex(btnBuscar, 0);
            Controls.SetChildIndex(btnLimpiarBuscar, 0);
            Controls.SetChildIndex(lblCliente, 0);
            Controls.SetChildIndex(txtFecha, 0);
            Controls.SetChildIndex(txtVencimiento, 0);
            Controls.SetChildIndex(txtMonto, 0);
            Controls.SetChildIndex(cmbFormaPago, 0);
            Controls.SetChildIndex(cmbPromocion, 0);
            Controls.SetChildIndex(btnRegistrar, 0);
            Controls.SetChildIndex(btnLimpiar, 0);
            Controls.SetChildIndex(lblFecha, 0);
            Controls.SetChildIndex(lblFechaVto, 0);
            Controls.SetChildIndex(lblMonto, 0);
            Controls.SetChildIndex(cmbActividad, 0);
            Controls.SetChildIndex(lblActividad, 0);
            Controls.SetChildIndex(lblForma, 0);
            Controls.SetChildIndex(lblPromocion, 0);
            Controls.SetChildIndex(lblClienteResultado, 0);
            ResumeLayout(false);
            PerformLayout();
            // 

        }

        #endregion

        private TextBox txtClienteID;
        private Button btnBuscar;
        private Button btnLimpiarBuscar;
        private Label lblCliente;
        private TextBox txtFecha;
        private TextBox txtVencimiento;
        private TextBox txtMonto;
        private ComboBox cmbFormaPago;
        private ComboBox cmbPromocion;
        private Button btnRegistrar;
        private Button btnLimpiar;
        private Label lblFecha;
        private Label lblFechaVto;
        private Label lblMonto;
        private ComboBox cmbActividad;
        private Label lblActividad;
        private Label lblForma;
        private Label lblPromocion;
        private Label lblClienteResultado;
    }
}