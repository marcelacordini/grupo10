namespace PI_CLUB_DEPORTIVO.vistas
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            lblTiyulo = new Label();
            pictureBox1 = new PictureBox();
            btnIngresar = new Button();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblTiyulo
            // 
            lblTiyulo.AutoSize = true;
            lblTiyulo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTiyulo.Location = new Point(309, 42);
            lblTiyulo.Name = "lblTiyulo";
            lblTiyulo.Size = new Size(118, 21);
            lblTiyulo.TabIndex = 0;
            lblTiyulo.Text = "Diseño de login";
            lblTiyulo.Click += lblTiyulo_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 124);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(220, 214);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(389, 336);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(202, 53);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(333, 145);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(333, 23);
            txtUsuario.TabIndex = 4;
            txtUsuario.Text = "USUARIO";
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(333, 215);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(333, 23);
            txtPass.TabIndex = 5;
            txtPass.Text = "CONTRASENA";
            txtPass.TextChanged += textBox1_TextChanged;
            txtPass.Enter += textPass_Enter;
            txtPass.Leave += textPass_Leave;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(btnIngresar);
            Controls.Add(pictureBox1);
            Controls.Add(lblTiyulo);
            Name = "frmLogin";
            Text = "frmLogin";
            Load += frmLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTiyulo;
        private PictureBox pictureBox1;
        private Button btnIngresar;
        private TextBox txtUsuario;
        private TextBox txtPass;
    }
}