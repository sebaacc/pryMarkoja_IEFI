namespace pryMarkoja_IEFI
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.btnSalir = new System.Windows.Forms.Button();
            this.pControles = new System.Windows.Forms.Panel();
            this.pLogin = new System.Windows.Forms.Panel();
            this.chkContraVisible = new System.Windows.Forms.CheckBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lblBienvenidaLogin2 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblPreguntaR = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblLinkRegistrarse = new System.Windows.Forms.LinkLabel();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.pControles.SuspendLayout();
            this.pLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(724, 472);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // pControles
            // 
            this.pControles.Controls.Add(this.pLogin);
            this.pControles.Controls.Add(this.btnSalir);
            this.pControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControles.Location = new System.Drawing.Point(0, 0);
            this.pControles.Name = "pControles";
            this.pControles.Size = new System.Drawing.Size(820, 516);
            this.pControles.TabIndex = 0;
            this.pControles.Paint += new System.Windows.Forms.PaintEventHandler(this.pControles_Paint);
            // 
            // pLogin
            // 
            this.pLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pLogin.Controls.Add(this.chkContraVisible);
            this.pLogin.Controls.Add(this.pbLogo);
            this.pLogin.Controls.Add(this.btnLogin);
            this.pLogin.Controls.Add(this.lblBienvenidaLogin2);
            this.pLogin.Controls.Add(this.txtUsuario);
            this.pLogin.Controls.Add(this.txtContraseña);
            this.pLogin.Controls.Add(this.lblPreguntaR);
            this.pLogin.Controls.Add(this.lblUsuario);
            this.pLogin.Controls.Add(this.lblLinkRegistrarse);
            this.pLogin.Controls.Add(this.lblContraseña);
            this.pLogin.Location = new System.Drawing.Point(221, 44);
            this.pLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pLogin.Name = "pLogin";
            this.pLogin.Size = new System.Drawing.Size(376, 424);
            this.pLogin.TabIndex = 0;
            // 
            // chkContraVisible
            // 
            this.chkContraVisible.AutoSize = true;
            this.chkContraVisible.Location = new System.Drawing.Point(89, 275);
            this.chkContraVisible.Name = "chkContraVisible";
            this.chkContraVisible.Size = new System.Drawing.Size(118, 17);
            this.chkContraVisible.TabIndex = 2;
            this.chkContraVisible.Text = "Mostrar Contraseña";
            this.chkContraVisible.UseVisualStyleBackColor = true;
            this.chkContraVisible.CheckedChanged += new System.EventHandler(this.chkContraVisible_CheckedChanged);
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::pryMarkoja_IEFI.Properties.Resources.auditoria;
            this.pbLogo.Location = new System.Drawing.Point(157, 29);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(64, 56);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 9;
            this.pbLogo.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Location = new System.Drawing.Point(117, 353);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(141, 32);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Ingresar";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lblBienvenidaLogin2
            // 
            this.lblBienvenidaLogin2.AutoSize = true;
            this.lblBienvenidaLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidaLogin2.Location = new System.Drawing.Point(17, 102);
            this.lblBienvenidaLogin2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBienvenidaLogin2.Name = "lblBienvenidaLogin2";
            this.lblBienvenidaLogin2.Size = new System.Drawing.Size(344, 20);
            this.lblBienvenidaLogin2.TabIndex = 7;
            this.lblBienvenidaLogin2.Text = "Te damos la bienvenida a AuditoríaMaster";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(89, 180);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(201, 20);
            this.txtUsuario.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(89, 250);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(201, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            this.txtContraseña.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtContraseña_KeyDown);
            // 
            // lblPreguntaR
            // 
            this.lblPreguntaR.AutoSize = true;
            this.lblPreguntaR.Location = new System.Drawing.Point(87, 297);
            this.lblPreguntaR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPreguntaR.Name = "lblPreguntaR";
            this.lblPreguntaR.Size = new System.Drawing.Size(140, 13);
            this.lblPreguntaR.TabIndex = 6;
            this.lblPreguntaR.Text = "¿Todavía no tenés cuenta?";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(89, 159);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(43, 13);
            this.lblUsuario.TabIndex = 8;
            this.lblUsuario.Text = "Usuario";
            // 
            // lblLinkRegistrarse
            // 
            this.lblLinkRegistrarse.AutoSize = true;
            this.lblLinkRegistrarse.Location = new System.Drawing.Point(232, 297);
            this.lblLinkRegistrarse.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLinkRegistrarse.Name = "lblLinkRegistrarse";
            this.lblLinkRegistrarse.Size = new System.Drawing.Size(60, 13);
            this.lblLinkRegistrarse.TabIndex = 4;
            this.lblLinkRegistrarse.TabStop = true;
            this.lblLinkRegistrarse.Text = "Registrarse";
            this.lblLinkRegistrarse.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLinkRegistrarse_LinkClicked);
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(89, 230);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(61, 13);
            this.lblContraseña.TabIndex = 4;
            this.lblContraseña.Text = "Contraseña";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 516);
            this.Controls.Add(this.pControles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de sesión";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pControles.ResumeLayout(false);
            this.pLogin.ResumeLayout(false);
            this.pLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.Panel pLogin;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lblBienvenidaLogin2;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblPreguntaR;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.LinkLabel lblLinkRegistrarse;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.CheckBox chkContraVisible;
    }
}

