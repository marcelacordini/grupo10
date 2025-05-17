namespace PI_CLUB_DEPORTIVO.vistas.registroCliente
{
    partial class PopUpConfirmacion
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
            lblMensaje = new Label();
            lblNro = new Label();
            lblTipo = new Label();
            lblId = new Label();
            lblTipoCliente = new Label();
            btnEmitirCarnet = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Font = new Font("Segoe UI", 12F);
            lblMensaje.Location = new Point(153, 38);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(187, 28);
            lblMensaje.TabIndex = 0;
            lblMensaje.Text = "Cliente dado de alta";
            // 
            // lblNro
            // 
            lblNro.AutoSize = true;
            lblNro.Font = new Font("Segoe UI", 12F);
            lblNro.Location = new Point(153, 76);
            lblNro.Name = "lblNro";
            lblNro.Size = new Size(59, 28);
            lblNro.TabIndex = 0;
            lblNro.Text = "Nro.: ";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Font = new Font("Segoe UI", 12F);
            lblTipo.Location = new Point(153, 116);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(55, 28);
            lblTipo.TabIndex = 0;
            lblTipo.Text = "Tipo:";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblId.Location = new Point(218, 73);
            lblId.Name = "lblId";
            lblId.Size = new Size(73, 31);
            lblId.TabIndex = 1;
            lblId.Text = "label1";
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold);
            lblTipoCliente.Location = new Point(218, 114);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(77, 31);
            lblTipoCliente.TabIndex = 2;
            lblTipoCliente.Text = "label2";
            // 
            // btnEmitirCarnet
            // 
            btnEmitirCarnet.Font = new Font("Segoe UI", 12F);
            btnEmitirCarnet.Location = new Point(153, 183);
            btnEmitirCarnet.Name = "btnEmitirCarnet";
            btnEmitirCarnet.Size = new Size(182, 40);
            btnEmitirCarnet.TabIndex = 3;
            btnEmitirCarnet.Text = "EMITIR CARNET";
            btnEmitirCarnet.UseVisualStyleBackColor = true;
            btnEmitirCarnet.Click += btnEmitirCarnet_Click;
            // 
            // btnOK
            // 
            btnOK.Font = new Font("Segoe UI", 12F);
            btnOK.Location = new Point(421, 183);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(94, 40);
            btnOK.TabIndex = 3;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += BtnCerrar_Click;
            // 
            // PopUpConfirmacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 258);
            Controls.Add(btnOK);
            Controls.Add(btnEmitirCarnet);
            Controls.Add(lblTipoCliente);
            Controls.Add(lblId);
            Controls.Add(lblTipo);
            Controls.Add(lblNro);
            Controls.Add(lblMensaje);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "PopUpConfirmacion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "CLIENTE REGISTRADO";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMensaje;
        private Label lblNro;
        private Label lblTipo;
        private Label lblId;
        private Label lblTipoCliente;
        private Button btnEmitirCarnet;
        private Button btnOK;
    }
}