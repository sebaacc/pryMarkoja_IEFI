namespace pryMarkoja_IEFI
{
    partial class frmAuditoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAuditoria));
            this.barraEstadoInf = new System.Windows.Forms.StatusStrip();
            this.lblUsuarioAdmin = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFechaHoraSistema = new System.Windows.Forms.ToolStripStatusLabel();
            this.pControles = new System.Windows.Forms.Panel();
            this.btnVolver = new System.Windows.Forms.Button();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.gbFiltroFecha = new System.Windows.Forms.GroupBox();
            this.btnFiltrarFechaYNombre = new System.Windows.Forms.Button();
            this.lblFinal = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.btnFiltrarFecha = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.gbFiltroNombre = new System.Windows.Forms.GroupBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblNombreU = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.TiempoSistema = new System.Windows.Forms.Timer(this.components);
            this.barraEstadoInf.SuspendLayout();
            this.pControles.SuspendLayout();
            this.pPrincipal.SuspendLayout();
            this.gbFiltroFecha.SuspendLayout();
            this.gbFiltroNombre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            this.SuspendLayout();
            // 
            // barraEstadoInf
            // 
            this.barraEstadoInf.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.barraEstadoInf.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUsuarioAdmin,
            this.toolStripStatusLabel1,
            this.lblFechaHoraSistema});
            this.barraEstadoInf.Location = new System.Drawing.Point(0, 587);
            this.barraEstadoInf.Name = "barraEstadoInf";
            this.barraEstadoInf.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.barraEstadoInf.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.barraEstadoInf.Size = new System.Drawing.Size(1028, 22);
            this.barraEstadoInf.TabIndex = 6;
            this.barraEstadoInf.Text = "Barra de estado";
            // 
            // lblUsuarioAdmin
            // 
            this.lblUsuarioAdmin.Margin = new System.Windows.Forms.Padding(10, 4, 0, 2);
            this.lblUsuarioAdmin.Name = "lblUsuarioAdmin";
            this.lblUsuarioAdmin.Size = new System.Drawing.Size(83, 16);
            this.lblUsuarioAdmin.Text = "Administrador";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(885, 17);
            this.toolStripStatusLabel1.Spring = true;
            // 
            // lblFechaHoraSistema
            // 
            this.lblFechaHoraSistema.Margin = new System.Windows.Forms.Padding(0, 4, 2, 2);
            this.lblFechaHoraSistema.Name = "lblFechaHoraSistema";
            this.lblFechaHoraSistema.Size = new System.Drawing.Size(37, 16);
            this.lblFechaHoraSistema.Text = "______";
            // 
            // pControles
            // 
            this.pControles.Controls.Add(this.btnVolver);
            this.pControles.Controls.Add(this.pPrincipal);
            this.pControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControles.Location = new System.Drawing.Point(0, 0);
            this.pControles.Name = "pControles";
            this.pControles.Size = new System.Drawing.Size(1028, 609);
            this.pControles.TabIndex = 5;
            // 
            // btnVolver
            // 
            this.btnVolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVolver.Location = new System.Drawing.Point(905, 524);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(102, 23);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "← Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pPrincipal
            // 
            this.pPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pPrincipal.Controls.Add(this.btnMostrarTodos);
            this.pPrincipal.Controls.Add(this.gbFiltroFecha);
            this.pPrincipal.Controls.Add(this.gbFiltroNombre);
            this.pPrincipal.Controls.Add(this.lblTitulo);
            this.pPrincipal.Controls.Add(this.dgvAuditoria);
            this.pPrincipal.Location = new System.Drawing.Point(2, 37);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(940, 451);
            this.pPrincipal.TabIndex = 1;
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(811, 507);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(102, 23);
            this.btnMostrarTodos.TabIndex = 3;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // gbFiltroFecha
            // 
            this.gbFiltroFecha.Controls.Add(this.btnFiltrarFechaYNombre);
            this.gbFiltroFecha.Controls.Add(this.lblFinal);
            this.gbFiltroFecha.Controls.Add(this.dtpHasta);
            this.gbFiltroFecha.Controls.Add(this.lblInicio);
            this.gbFiltroFecha.Controls.Add(this.btnFiltrarFecha);
            this.gbFiltroFecha.Controls.Add(this.dtpDesde);
            this.gbFiltroFecha.Location = new System.Drawing.Point(328, 40);
            this.gbFiltroFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFiltroFecha.Name = "gbFiltroFecha";
            this.gbFiltroFecha.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFiltroFecha.Size = new System.Drawing.Size(584, 91);
            this.gbFiltroFecha.TabIndex = 7;
            this.gbFiltroFecha.TabStop = false;
            this.gbFiltroFecha.Text = "Filtro por fecha";
            // 
            // btnFiltrarFechaYNombre
            // 
            this.btnFiltrarFechaYNombre.Location = new System.Drawing.Point(387, 53);
            this.btnFiltrarFechaYNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrarFechaYNombre.Name = "btnFiltrarFechaYNombre";
            this.btnFiltrarFechaYNombre.Size = new System.Drawing.Size(155, 27);
            this.btnFiltrarFechaYNombre.TabIndex = 8;
            this.btnFiltrarFechaYNombre.Text = "Filtrar por fecha y nombre";
            this.btnFiltrarFechaYNombre.UseVisualStyleBackColor = true;
            this.btnFiltrarFechaYNombre.Click += new System.EventHandler(this.btnFiltrarFechaYNombre_Click);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(338, 21);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(38, 13);
            this.lblFinal.TabIndex = 6;
            this.lblFinal.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(387, 19);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(151, 20);
            this.dtpHasta.TabIndex = 7;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(48, 21);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(41, 13);
            this.lblInicio.TabIndex = 2;
            this.lblInicio.Text = "Desde:";
            // 
            // btnFiltrarFecha
            // 
            this.btnFiltrarFecha.Location = new System.Drawing.Point(100, 53);
            this.btnFiltrarFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrarFecha.Name = "btnFiltrarFecha";
            this.btnFiltrarFecha.Size = new System.Drawing.Size(155, 27);
            this.btnFiltrarFecha.TabIndex = 4;
            this.btnFiltrarFecha.Text = "Filtrar por fecha";
            this.btnFiltrarFecha.UseVisualStyleBackColor = true;
            this.btnFiltrarFecha.Click += new System.EventHandler(this.btnFiltrarFecha_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(100, 19);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(151, 20);
            this.dtpDesde.TabIndex = 5;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
            // 
            // gbFiltroNombre
            // 
            this.gbFiltroNombre.Controls.Add(this.txtBuscar);
            this.gbFiltroNombre.Controls.Add(this.lblNombreU);
            this.gbFiltroNombre.Controls.Add(this.btnFiltrar);
            this.gbFiltroNombre.Location = new System.Drawing.Point(30, 40);
            this.gbFiltroNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFiltroNombre.Name = "gbFiltroNombre";
            this.gbFiltroNombre.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFiltroNombre.Size = new System.Drawing.Size(234, 91);
            this.gbFiltroNombre.TabIndex = 6;
            this.gbFiltroNombre.TabStop = false;
            this.gbFiltroNombre.Text = "Filtro por nombre";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(74, 19);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(156, 20);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblNombreU
            // 
            this.lblNombreU.AutoSize = true;
            this.lblNombreU.Location = new System.Drawing.Point(16, 21);
            this.lblNombreU.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreU.Name = "lblNombreU";
            this.lblNombreU.Size = new System.Drawing.Size(47, 13);
            this.lblNombreU.TabIndex = 2;
            this.lblNombreU.Text = "Nombre:";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(74, 53);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(155, 27);
            this.btnFiltrar.TabIndex = 4;
            this.btnFiltrar.Text = "Filtrar nombre";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(22, 12);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(260, 20);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Auditoría de tiempos de trabajo";
            // 
            // dgvAuditoria
            // 
            this.dgvAuditoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuditoria.Location = new System.Drawing.Point(30, 142);
            this.dgvAuditoria.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvAuditoria.Name = "dgvAuditoria";
            this.dgvAuditoria.RowHeadersWidth = 51;
            this.dgvAuditoria.RowTemplate.Height = 24;
            this.dgvAuditoria.Size = new System.Drawing.Size(883, 349);
            this.dgvAuditoria.TabIndex = 0;
            // 
            // TiempoSistema
            // 
            this.TiempoSistema.Enabled = true;
            this.TiempoSistema.Interval = 1000;
            this.TiempoSistema.Tick += new System.EventHandler(this.TiempoSistema_Tick);
            // 
            // frmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.barraEstadoInf);
            this.Controls.Add(this.pControles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAuditoria";
            this.Text = "Auditoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.barraEstadoInf.ResumeLayout(false);
            this.barraEstadoInf.PerformLayout();
            this.pControles.ResumeLayout(false);
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.gbFiltroFecha.ResumeLayout(false);
            this.gbFiltroFecha.PerformLayout();
            this.gbFiltroNombre.ResumeLayout(false);
            this.gbFiltroNombre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraEstadoInf;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioAdmin;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaHoraSistema;
        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblNombreU;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.Timer TiempoSistema;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.GroupBox gbFiltroNombre;
        private System.Windows.Forms.GroupBox gbFiltroFecha;
        private System.Windows.Forms.Button btnFiltrarFecha;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.Button btnFiltrarFechaYNombre;
    }
}