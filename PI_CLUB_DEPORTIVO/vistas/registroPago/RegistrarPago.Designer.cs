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
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            btnComprobante = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // txtClienteID
            // 
            txtClienteID.Location = new Point(58, 123);
            txtClienteID.Margin = new Padding(2, 2, 2, 2);
            txtClienteID.Name = "txtClienteID";
            txtClienteID.Size = new Size(287, 25);
            txtClienteID.TabIndex = 2;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(420, 119);
            btnBuscar.Margin = new Padding(2, 2, 2, 2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(138, 34);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "BUSCAR";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiarBuscar
            // 
            btnLimpiarBuscar.Location = new Point(616, 118);
            btnLimpiarBuscar.Margin = new Padding(2, 2, 2, 2);
            btnLimpiarBuscar.Name = "btnLimpiarBuscar";
            btnLimpiarBuscar.Size = new Size(138, 35);
            btnLimpiarBuscar.TabIndex = 4;
            btnLimpiarBuscar.Text = "LIMPIAR";
            btnLimpiarBuscar.UseVisualStyleBackColor = true;
            btnLimpiarBuscar.Click += btnLimpiarBuscar_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.ForeColor = SystemColors.ControlLight;
            lblCliente.Location = new Point(58, 96);
            lblCliente.Margin = new Padding(2, 0, 2, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(69, 19);
            lblCliente.TabIndex = 5;
            lblCliente.Text = "Cliente ID";
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(482, 274);
            txtMonto.Margin = new Padding(2, 2, 2, 2);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(167, 25);
            txtMonto.TabIndex = 8;
            // 
            // cmbFormaPago
            // 
            cmbFormaPago.FormattingEnabled = true;
            cmbFormaPago.Items.AddRange(new object[] { "Tarjeta", "Efectivo" });
            cmbFormaPago.Location = new Point(128, 329);
            cmbFormaPago.Margin = new Padding(2, 2, 2, 2);
            cmbFormaPago.Name = "cmbFormaPago";
            cmbFormaPago.Size = new Size(149, 25);
            cmbFormaPago.TabIndex = 9;
            cmbFormaPago.SelectedIndexChanged += cmbFormaPago_SelectedIndexChanged;
            // 
            // cmbPromocion
            // 
            cmbPromocion.AutoCompleteCustomSource.AddRange(new string[] { "1", "3", "6" });
            cmbPromocion.FormattingEnabled = true;
            cmbPromocion.Items.AddRange(new object[] { "1", "3", "6" });
            cmbPromocion.Location = new Point(482, 325);
            cmbPromocion.Margin = new Padding(2, 2, 2, 2);
            cmbPromocion.Name = "cmbPromocion";
            cmbPromocion.Size = new Size(167, 25);
            cmbPromocion.TabIndex = 10;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(65, 395);
            btnRegistrar.Margin = new Padding(2, 2, 2, 2);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(152, 32);
            btnRegistrar.TabIndex = 11;
            btnRegistrar.Text = "REGISTRAR PAGO";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(296, 395);
            btnLimpiar.Margin = new Padding(2, 2, 2, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(166, 31);
            btnLimpiar.TabIndex = 12;
            btnLimpiar.Text = "LIMPIAR";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.ForeColor = SystemColors.ControlLight;
            lblFecha.Location = new Point(58, 207);
            lblFecha.Margin = new Padding(2, 0, 2, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(44, 19);
            lblFecha.TabIndex = 13;
            lblFecha.Text = "Fecha";
            // 
            // lblFechaVto
            // 
            lblFechaVto.AutoSize = true;
            lblFechaVto.ForeColor = SystemColors.ControlLight;
            lblFechaVto.Location = new Point(372, 206);
            lblFechaVto.Margin = new Padding(2, 0, 2, 0);
            lblFechaVto.Name = "lblFechaVto";
            lblFechaVto.Size = new Size(123, 19);
            lblFechaVto.TabIndex = 14;
            lblFechaVto.Text = "Fecha Vencimiento";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.ForeColor = SystemColors.ControlLight;
            lblMonto.Location = new Point(382, 276);
            lblMonto.Margin = new Padding(2, 0, 2, 0);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(51, 19);
            lblMonto.TabIndex = 15;
            lblMonto.Text = "Monto";
            // 
            // cmbActividad
            // 
            cmbActividad.AutoCompleteCustomSource.AddRange(new string[] { "Zumba", "Yoga", "Crossfit", "Funcional", "Pilates", "Spinning", "Boxeo" });
            cmbActividad.FormattingEnabled = true;
            cmbActividad.Items.AddRange(new object[] { "Zumba", "Yoga", "Crossfit", "Funcional", "Pilates", "Spinning", "Boxeo" });
            cmbActividad.Location = new Point(128, 274);
            cmbActividad.Margin = new Padding(2, 2, 2, 2);
            cmbActividad.Name = "cmbActividad";
            cmbActividad.Size = new Size(149, 25);
            cmbActividad.TabIndex = 16;
            cmbActividad.SelectedValueChanged += cmbActividad_SelectedValueChanged;
            // 
            // lblActividad
            // 
            lblActividad.AutoSize = true;
            lblActividad.ForeColor = SystemColors.ControlLight;
            lblActividad.Location = new Point(58, 280);
            lblActividad.Margin = new Padding(2, 0, 2, 0);
            lblActividad.Name = "lblActividad";
            lblActividad.Size = new Size(65, 19);
            lblActividad.TabIndex = 17;
            lblActividad.Text = "Actividad";
            // 
            // lblForma
            // 
            lblForma.AutoSize = true;
            lblForma.ForeColor = SystemColors.ControlLight;
            lblForma.Location = new Point(58, 331);
            lblForma.Margin = new Padding(2, 0, 2, 0);
            lblForma.Name = "lblForma";
            lblForma.Size = new Size(48, 19);
            lblForma.TabIndex = 18;
            lblForma.Text = "Forma";
            // 
            // lblPromocion
            // 
            lblPromocion.AutoSize = true;
            lblPromocion.ForeColor = SystemColors.ControlLight;
            lblPromocion.Location = new Point(382, 329);
            lblPromocion.Margin = new Padding(2, 0, 2, 0);
            lblPromocion.Name = "lblPromocion";
            lblPromocion.Size = new Size(75, 19);
            lblPromocion.TabIndex = 19;
            lblPromocion.Text = "Promocion";
            // 
            // lblClienteResultado
            // 
            lblClienteResultado.AutoSize = true;
            lblClienteResultado.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblClienteResultado.ForeColor = SystemColors.Control;
            lblClienteResultado.Location = new Point(61, 163);
            lblClienteResultado.Margin = new Padding(2, 0, 2, 0);
            lblClienteResultado.Name = "lblClienteResultado";
            lblClienteResultado.Size = new Size(141, 20);
            lblClienteResultado.TabIndex = 20;
            lblClienteResultado.Text = "Datos Encontrados";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(105, 206);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.MaxDate = new DateTime(2100, 12, 31, 0, 0, 0, 0);
            dateTimePicker1.MinDate = new DateTime(2025, 1, 1, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(240, 26);
            dateTimePicker1.TabIndex = 21;
            dateTimePicker1.Value = new DateTime(2025, 6, 17, 0, 0, 0, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(496, 203);
            dateTimePicker2.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(258, 25);
            dateTimePicker2.TabIndex = 2;
            // 
            // btnComprobante
            // 
            btnComprobante.Location = new Point(544, 395);
            btnComprobante.Margin = new Padding(2, 2, 2, 2);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(166, 31);
            btnComprobante.TabIndex = 22;
            btnComprobante.Text = "COMPROBANTE";
            btnComprobante.UseVisualStyleBackColor = true;
            btnComprobante.Visible = false;
            btnComprobante.Click += btnComprobante_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(326, 60);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 20);
            label1.TabIndex = 23;
            label1.Text = "REGISTRO DE PAGO";
            // 
            // button1
            // 
            button1.Location = new Point(58, 52);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 34);
            button1.TabIndex = 24;
            button1.Text = "VOLVER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // RegistrarPago
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            ClientSize = new Size(800, 500);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(btnComprobante);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
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
            Controls.Add(lblCliente);
            Controls.Add(btnLimpiarBuscar);
            Controls.Add(btnBuscar);
            Controls.Add(txtClienteID);
            Margin = new Padding(2, 2, 2, 2);
            Name = "RegistrarPago";
            Load += RegistrarPago_Load;
            Controls.SetChildIndex(txtClienteID, 0);
            Controls.SetChildIndex(btnBuscar, 0);
            Controls.SetChildIndex(btnLimpiarBuscar, 0);
            Controls.SetChildIndex(lblCliente, 0);
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
            Controls.SetChildIndex(dateTimePicker1, 0);
            Controls.SetChildIndex(dateTimePicker2, 0);
            Controls.SetChildIndex(btnComprobante, 0);
            Controls.SetChildIndex(label1, 0);
            Controls.SetChildIndex(button1, 0);
            ResumeLayout(false);
            PerformLayout();
            // 

        }

        #endregion

        private TextBox txtClienteID;
        private Button btnBuscar;
        private Button btnLimpiarBuscar;
        private Label lblCliente;
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
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button btnComprobante;
        private Label label1;
        private Button button1;
    }
}