namespace PI_CLUB_DEPORTIVO.vistas
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            btnIngresar_Click = new Button();
            label1 = new Label();
            txtUsuario = new TextBox();
            txtPass = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnIngresar_Click
            // 
            btnIngresar_Click.Location = new Point(414, 289);
            btnIngresar_Click.Name = "btnIngresar_Click";
            btnIngresar_Click.Size = new Size(234, 62);
            btnIngresar_Click.TabIndex = 0;
            btnIngresar_Click.Text = "Ingresar";
            btnIngresar_Click.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(344, 83);
            label1.Name = "label1";
            label1.Size = new Size(64, 28);
            label1.TabIndex = 1;
            label1.Text = "Login";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(344, 159);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(304, 27);
            txtUsuario.TabIndex = 2;
            txtUsuario.Text = "Usuario";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtPass
            // 
            txtPass.Location = new Point(344, 214);
            txtPass.Name = "txtPass";
            txtPass.Size = new Size(304, 27);
            txtPass.TabIndex = 3;
            txtPass.Text = "Contraseña";
            txtPass.TextChanged += textBox1_TextChanged;
            txtPass.Enter += txtPass_Enter;
            txtPass.Leave += txtPass_Leave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(81, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(183, 198);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(txtPass);
            Controls.Add(txtUsuario);
            Controls.Add(label1);
            Controls.Add(btnIngresar_Click);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngresar_Click;
        private Label label1;
        private TextBox txtUsuario;
        private TextBox txtPass;
        private PictureBox pictureBox1;
    }
}