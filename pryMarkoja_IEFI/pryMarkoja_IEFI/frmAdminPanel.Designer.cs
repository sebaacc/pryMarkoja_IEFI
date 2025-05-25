namespace pryMarkoja_IEFI
{
    partial class frmAdminPanel
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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnDesactivar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblNombreU = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.barraEstadoInf = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioAdmin = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaHoraSistema = new System.Windows.Forms.ToolStripStatusLabel();
            this.TiempoSistema = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.pControles.SuspendLayout();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.barraEstadoInf.SuspendLayout();
            this.SuspendLayout();
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
            this.pControles.TabIndex = 3;
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
            this.pPrincipal.Controls.Add(this.btnDesactivar);
            this.pPrincipal.Controls.Add(this.btnBuscar);
            this.pPrincipal.Controls.Add(this.lblTitulo);
            this.pPrincipal.Controls.Add(this.lblNombreU);
            this.pPrincipal.Controls.Add(this.txtBuscar);
            this.pPrincipal.Controls.Add(this.dgvUsuarios);
            this.pPrincipal.Location = new System.Drawing.Point(100, 45);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(756, 506);
            this.pPrincipal.TabIndex = 1;
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.BackColor = System.Drawing.Color.IndianRed;
            this.btnDesactivar.Location = new System.Drawing.Point(563, 55);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(150, 33);
            this.btnDesactivar.TabIndex = 5;
            this.btnDesactivar.Text = "Desactivar Usuario";
            this.btnDesactivar.UseVisualStyleBackColor = false;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(115, 98);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(207, 23);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(30, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(227, 25);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Búsqueda de usuarios";
            // 
            // lblNombreU
            // 
            this.lblNombreU.AutoSize = true;
            this.lblNombreU.Location = new System.Drawing.Point(37, 63);
            this.lblNombreU.Name = "lblNombreU";
            this.lblNombreU.Size = new System.Drawing.Size(59, 16);
            this.lblNombreU.TabIndex = 2;
            this.lblNombreU.Text = "Nombre:";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(115, 60);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(207, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(40, 142);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.RowTemplate.Height = 24;
            this.dgvUsuarios.Size = new System.Drawing.Size(673, 352);
            this.dgvUsuarios.TabIndex = 0;
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
            this.barraEstadoInf.TabIndex = 4;
            this.barraEstadoInf.Text = "Barra de estado";
            // 
            // lblUsuarioAdmin
            // 
            this.lblUsuarioAdmin.Margin = new System.Windows.Forms.Padding(10, 4, 0, 2);
            this.lblUsuarioAdmin.Name = "lblUsuarioAdmin";
            this.lblUsuarioAdmin.Size = new System.Drawing.Size(104, 20);
            this.lblUsuarioAdmin.Text = "Administrador";
            // 
            // lblFechaHoraSistema
            // 
            this.lblFechaHoraSistema.Margin = new System.Windows.Forms.Padding(0, 4, 2, 2);
            this.lblFechaHoraSistema.Name = "lblFechaHoraSistema";
            this.lblFechaHoraSistema.Size = new System.Drawing.Size(45, 20);
            this.lblFechaHoraSistema.Text = "______";
            // 
            // TiempoSistema
            // 
            this.TiempoSistema.Enabled = true;
            this.TiempoSistema.Interval = 1000;
            this.TiempoSistema.Tick += new System.EventHandler(this.TiempoSistema_Tick);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(740, 20);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // frmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 607);
            this.Controls.Add(this.barraEstadoInf);
            this.Controls.Add(this.pControles);
            this.Name = "frmAdminPanel";
            this.Text = "Panel de administrador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdminPanel_Load);
            this.pControles.ResumeLayout(false);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.barraEstadoInf.ResumeLayout(false);
            this.barraEstadoInf.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnDesactivar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreU;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.StatusStrip barraEstadoInf;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioAdmin;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaHoraSistema;
        private System.Windows.Forms.Timer TiempoSistema;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}