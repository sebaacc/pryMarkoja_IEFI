namespace pryMarkoja_IEFI
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.pControles = new System.Windows.Forms.Panel();
            this.BarraDeEstadoUsuario = new System.Windows.Forms.StatusStrip();
            this.lblTiempoTitulo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTiempoStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tSessionTimer = new System.Windows.Forms.Timer(this.components);
            this.pControles.SuspendLayout();
            this.BarraDeEstadoUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pControles
            // 
            this.pControles.Controls.Add(this.BarraDeEstadoUsuario);
            this.pControles.Controls.Add(this.btnCerrarSesion);
            this.pControles.Controls.Add(this.pPrincipal);
            this.pControles.Controls.Add(this.btnSalir);
            this.pControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControles.Location = new System.Drawing.Point(0, 0);
            this.pControles.Margin = new System.Windows.Forms.Padding(4);
            this.pControles.Name = "pControles";
            this.pControles.Size = new System.Drawing.Size(1067, 554);
            this.pControles.TabIndex = 2;
            // 
            // BarraDeEstadoUsuario
            // 
            this.BarraDeEstadoUsuario.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.BarraDeEstadoUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTiempoTitulo,
            this.lblTiempoStatus});
            this.BarraDeEstadoUsuario.Location = new System.Drawing.Point(0, 528);
            this.BarraDeEstadoUsuario.Name = "BarraDeEstadoUsuario";
            this.BarraDeEstadoUsuario.Size = new System.Drawing.Size(1067, 26);
            this.BarraDeEstadoUsuario.TabIndex = 5;
            this.BarraDeEstadoUsuario.Text = "barra de estado";
            // 
            // lblTiempoTitulo
            // 
            this.lblTiempoTitulo.Name = "lblTiempoTitulo";
            this.lblTiempoTitulo.Size = new System.Drawing.Size(146, 20);
            this.lblTiempoTitulo.Text = "Tiempo transcurrido:";
            // 
            // lblTiempoStatus
            // 
            this.lblTiempoStatus.Name = "lblTiempoStatus";
            this.lblTiempoStatus.Size = new System.Drawing.Size(15, 20);
            this.lblTiempoStatus.Text = "-";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(907, 444);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(136, 28);
            this.btnCerrarSesion.TabIndex = 3;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pPrincipal
            // 
            this.pPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pPrincipal.Location = new System.Drawing.Point(103, 45);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(756, 483);
            this.pPrincipal.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(907, 500);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 28);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tSessionTimer
            // 
            this.tSessionTimer.Interval = 1000;
            this.tSessionTimer.Tick += new System.EventHandler(this.tSessionTimer_Tick);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pControles);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipal";
            this.Text = "Menú principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pControles.ResumeLayout(false);
            this.pControles.PerformLayout();
            this.BarraDeEstadoUsuario.ResumeLayout(false);
            this.BarraDeEstadoUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Timer tSessionTimer;
        private System.Windows.Forms.StatusStrip BarraDeEstadoUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblTiempoTitulo;
        private System.Windows.Forms.ToolStripStatusLabel lblTiempoStatus;
    }
}