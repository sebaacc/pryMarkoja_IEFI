namespace pryMarkoja_IEFI
{
    partial class frmRegistro
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
            this.pControles = new System.Windows.Forms.Panel();
            this.pLogin = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnRegistro = new System.Windows.Forms.Button();
            this.lblBienvenidaLogin2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.txtPuesto = new System.Windows.Forms.TextBox();
            this.lblPuesto = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.pControles.SuspendLayout();
            this.pLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pControles
            // 
            this.pControles.Controls.Add(this.pLogin);
            this.pControles.Controls.Add(this.btnSalir);
            this.pControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControles.Location = new System.Drawing.Point(0, 0);
            this.pControles.Margin = new System.Windows.Forms.Padding(4);
            this.pControles.Name = "pControles";
            this.pControles.Size = new System.Drawing.Size(1065, 670);
            this.pControles.TabIndex = 2;
            this.pControles.Paint += new System.Windows.Forms.PaintEventHandler(this.pControles_Paint);
            // 
            // pLogin
            // 
            this.pLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pLogin.Controls.Add(this.dtpFechaNacimiento);
            this.pLogin.Controls.Add(this.lblFechaNacimiento);
            this.pLogin.Controls.Add(this.txtNombre);
            this.pLogin.Controls.Add(this.lblNombre);
            this.pLogin.Controls.Add(this.txtApellido);
            this.pLogin.Controls.Add(this.lblApellido);
            this.pLogin.Controls.Add(this.txtPuesto);
            this.pLogin.Controls.Add(this.lblPuesto);
            this.pLogin.Controls.Add(this.pbLogo);
            this.pLogin.Controls.Add(this.btnRegistro);
            this.pLogin.Controls.Add(this.lblBienvenidaLogin2);
            this.pLogin.Controls.Add(this.txtUsuario);
            this.pLogin.Controls.Add(this.txtContraseña);
            this.pLogin.Controls.Add(this.lblUsuario);
            this.pLogin.Controls.Add(this.lblContraseña);
            this.pLogin.Location = new System.Drawing.Point(301, 54);
            this.pLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(469, 590);
            this.pLogin.TabIndex = 1;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(196, 32);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(85, 69);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // btnRegistro
            // 
            this.btnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistro.Location = new System.Drawing.Point(137, 532);
            this.btnRegistro.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistro.Name = "btnRegistro";
            this.btnRegistro.Size = new System.Drawing.Size(188, 39);
            this.btnRegistro.TabIndex = 2;
            this.btnRegistro.Text = "Registrarme";
            this.btnRegistro.UseVisualStyleBackColor = true;
            this.btnRegistro.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lblBienvenidaLogin2
            // 
            this.lblBienvenidaLogin2.AutoSize = true;
            this.lblBienvenidaLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidaLogin2.Location = new System.Drawing.Point(179, 117);
            this.lblBienvenidaLogin2.Name = "lblBienvenidaLogin2";
            this.lblBienvenidaLogin2.Size = new System.Drawing.Size(122, 25);
            this.lblBienvenidaLogin2.TabIndex = 8;
            this.lblBienvenidaLogin2.Text = "Registrate! ";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(102, 432);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(267, 22);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(102, 492);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(267, 22);
            this.txtContraseña.TabIndex = 1;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(99, 405);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(54, 16);
            this.lblUsuario.TabIndex = 3;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(102, 467);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(76, 16);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(937, 616);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 28);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // txtPuesto
            // 
            this.txtPuesto.Location = new System.Drawing.Point(102, 308);
            this.txtPuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPuesto.Name = "txtPuesto";
            this.txtPuesto.Size = new System.Drawing.Size(267, 22);
            this.txtPuesto.TabIndex = 10;
            // 
            // lblPuesto
            // 
            this.lblPuesto.AutoSize = true;
            this.lblPuesto.Location = new System.Drawing.Point(99, 282);
            this.lblPuesto.Name = "lblPuesto";
            this.lblPuesto.Size = new System.Drawing.Size(49, 16);
            this.lblPuesto.TabIndex = 11;
            this.lblPuesto.Text = "Puesto";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(102, 248);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(267, 22);
            this.txtApellido.TabIndex = 12;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(99, 222);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(57, 16);
            this.lblApellido.TabIndex = 13;
            this.lblApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(102, 188);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(267, 22);
            this.txtNombre.TabIndex = 14;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(99, 158);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 15;
            this.lblNombre.Text = "Nombre";
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(99, 340);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(132, 16);
            this.lblFechaNacimiento.TabIndex = 17;
            this.lblFechaNacimiento.Text = "Fecha de nacimiento";
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(102, 369);
            this.dtpFechaNacimiento.MaxDate = new System.DateTime(9950, 12, 25, 0, 0, 0, 0);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(267, 22);
            this.dtpFechaNacimiento.TabIndex = 18;
            // 
            // frmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 670);
            this.Controls.Add(this.pControles);
            this.Name = "frmRegistro";
            this.Text = "Registro";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pControles.ResumeLayout(false);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnRegistro;
        private System.Windows.Forms.Label lblBienvenidaLogin2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtPuesto;
        private System.Windows.Forms.Label lblPuesto;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label lblFechaNacimiento;
    }
}