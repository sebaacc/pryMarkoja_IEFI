namespace pryMarkoja_IEFI
{
    partial class frmPrincipalAdmin
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
            this.barraEstadoInf = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioAdmin = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaHoraSistema = new System.Windows.Forms.ToolStripStatusLabel();
            this.pControles = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnAuditoria = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.TiempoSistema = new System.Windows.Forms.Timer(this.components);
            this.barraEstadoInf.SuspendLayout();
            this.pControles.SuspendLayout();
            this.pPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraEstadoInf
            // 
            this.barraEstadoInf.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barraEstadoInf.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuarioAdmin,
            this.toolStripStatusLabel1,
            this.lblFechaHoraSistema});
            this.barraEstadoInf.Location = new System.Drawing.Point(0, 581);
            this.barraEstadoInf.Name = "barraEstadoInf";
            this.barraEstadoInf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barraEstadoInf.Size = new System.Drawing.Size(1061, 26);
            this.barraEstadoInf.TabIndex = 6;
            this.barraEstadoInf.Text = "Barra de estado";
            // 
            // lblUsuarioAdmin
            // 
            this.lblUsuarioAdmin.Margin = new System.Windows.Forms.Padding(10, 4, 0, 2);
            this.lblUsuarioAdmin.Name = "lblUsuarioAdmin";
            this.lblUsuarioAdmin.Size = new System.Drawing.Size(104, 20);
            this.lblUsuarioAdmin.Text = "Administrador";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(885, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // lblFechaHoraSistema
            // 
            this.lblFechaHoraSistema.Margin = new System.Windows.Forms.Padding(0, 4, 2, 2);
            this.lblFechaHoraSistema.Name = "lblFechaHoraSistema";
            this.lblFechaHoraSistema.Size = new System.Drawing.Size(45, 20);
            this.lblFechaHoraSistema.Text = "______";
            // 
            // pControles
            // 
            this.pControles.Controls.Add(this.btnCerrarSesion);
            this.pControles.Controls.Add(this.pPrincipal);
            this.pControles.Controls.Add(this.btnSalir);
            this.pControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControles.Location = new System.Drawing.Point(0, 0);
            this.pControles.Margin = new System.Windows.Forms.Padding(4);
            this.pControles.Name = "pControles";
            this.pControles.Size = new System.Drawing.Size(1061, 607);
            this.pControles.TabIndex = 5;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.Location = new System.Drawing.Point(897, 463);
            this.btnCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(136, 28);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.Text = "Cerrar sesión";
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pPrincipal
            // 
            this.pPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pPrincipal.Controls.Add(this.btnAuditoria);
            this.pPrincipal.Controls.Add(this.btnUsuarios);
            this.pPrincipal.Controls.Add(this.lblTitulo);
            this.pPrincipal.Location = new System.Drawing.Point(100, 45);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(756, 506);
            this.pPrincipal.TabIndex = 1;
            // 
            // btnAuditoria
            // 
            this.btnAuditoria.Location = new System.Drawing.Point(273, 307);
            this.btnAuditoria.Name = "btnAuditoria";
            this.btnAuditoria.Size = new System.Drawing.Size(207, 45);
            this.btnAuditoria.TabIndex = 5;
            this.btnAuditoria.Text = "Auditoría";
            this.btnAuditoria.UseVisualStyleBackColor = true;
            this.btnAuditoria.Click += new System.EventHandler(this.btnAuditoria_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.Location = new System.Drawing.Point(273, 163);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(207, 45);
            this.btnUsuarios.TabIndex = 4;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = true;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(30, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(242, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Panel de administración";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalir.Location = new System.Drawing.Point(897, 523);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(136, 28);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // TiempoSistema
            // 
            this.TiempoSistema.Enabled = true;
            this.TiempoSistema.Interval = 1000;
            this.TiempoSistema.Tick += new System.EventHandler(this.TiempoSistema_Tick);
            // 
            // frmPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 607);
            this.Controls.Add(this.barraEstadoInf);
            this.Controls.Add(this.pControles);
            this.Name = "frmPrincipalAdmin";
            this.Text = "Panel Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barraEstadoInf.ResumeLayout(false);
            this.barraEstadoInf.PerformLayout();
            this.pControles.ResumeLayout(false);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraEstadoInf;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioAdmin;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaHoraSistema;
        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAuditoria;
        private System.Windows.Forms.Timer TiempoSistema;
    }
}