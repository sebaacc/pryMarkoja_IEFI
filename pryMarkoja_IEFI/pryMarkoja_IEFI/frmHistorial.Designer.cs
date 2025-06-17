namespace pryMarkoja_IEFI
{
    partial class frmHistorial
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
            this.dgvHistorial = new System.Windows.Forms.DataGridView();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmbTipoTarea = new System.Windows.Forms.ComboBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.lblTipoTarea = new System.Windows.Forms.Label();
            this.lblLugar = new System.Windows.Forms.Label();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblFinal = new System.Windows.Forms.Label();
            this.dtpHasta = new System.Windows.Forms.DateTimePicker();
            this.lblInicio = new System.Windows.Forms.Label();
            this.btnFiltrarFecha = new System.Windows.Forms.Button();
            this.dtpDesde = new System.Windows.Forms.DateTimePicker();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
            this.gbFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvHistorial
            // 
            this.dgvHistorial.AllowUserToAddRows = false;
            this.dgvHistorial.AllowUserToDeleteRows = false;
            this.dgvHistorial.AllowUserToResizeRows = false;
            this.dgvHistorial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistorial.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHistorial.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvHistorial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistorial.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvHistorial.Location = new System.Drawing.Point(47, 236);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 24;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(1058, 416);
            this.dgvHistorial.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(43, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(305, 22);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Opciones de búsqueda de tareas";
            // 
            // cmbTipoTarea
            // 
            this.cmbTipoTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTarea.FormattingEnabled = true;
            this.cmbTipoTarea.Location = new System.Drawing.Point(114, 37);
            this.cmbTipoTarea.Name = "cmbTipoTarea";
            this.cmbTipoTarea.Size = new System.Drawing.Size(136, 24);
            this.cmbTipoTarea.TabIndex = 2;
            this.cmbTipoTarea.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTarea_SelectedIndexChanged);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(188, 128);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(278, 22);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Location = new System.Drawing.Point(16, 131);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(125, 16);
            this.lblBuscarUsuario.TabIndex = 4;
            this.lblBuscarUsuario.Text = "Nombre de usuario:";
            // 
            // lblTipoTarea
            // 
            this.lblTipoTarea.AutoSize = true;
            this.lblTipoTarea.Location = new System.Drawing.Point(16, 41);
            this.lblTipoTarea.Name = "lblTipoTarea";
            this.lblTipoTarea.Size = new System.Drawing.Size(91, 16);
            this.lblTipoTarea.TabIndex = 5;
            this.lblTipoTarea.Text = "Tipo de tarea:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(271, 40);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(44, 16);
            this.lblLugar.TabIndex = 7;
            this.lblLugar.Text = "Lugar:";
            // 
            // cmbLugar
            // 
            this.cmbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(329, 37);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(137, 24);
            this.cmbLugar.TabIndex = 6;
            this.cmbLugar.SelectedIndexChanged += new System.EventHandler(this.cmbLugar_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(503, 123);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(94, 33);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(607, 75);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(46, 16);
            this.lblFinal.TabIndex = 6;
            this.lblFinal.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(680, 72);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(200, 22);
            this.dtpHasta.TabIndex = 7;
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(602, 37);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(51, 16);
            this.lblInicio.TabIndex = 2;
            this.lblInicio.Text = "Desde:";
            // 
            // btnFiltrarFecha
            // 
            this.btnFiltrarFecha.Location = new System.Drawing.Point(680, 123);
            this.btnFiltrarFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrarFecha.Name = "btnFiltrarFecha";
            this.btnFiltrarFecha.Size = new System.Drawing.Size(200, 33);
            this.btnFiltrarFecha.TabIndex = 4;
            this.btnFiltrarFecha.Text = "Filtrar por fecha";
            this.btnFiltrarFecha.UseVisualStyleBackColor = true;
            this.btnFiltrarFecha.Click += new System.EventHandler(this.btnFiltrarFecha_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(679, 34);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(200, 22);
            this.dtpDesde.TabIndex = 5;
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.btnLimpiarFiltros);
            this.gbFiltros.Controls.Add(this.lblFinal);
            this.gbFiltros.Controls.Add(this.btnBuscar);
            this.gbFiltros.Controls.Add(this.dtpHasta);
            this.gbFiltros.Controls.Add(this.cmbTipoTarea);
            this.gbFiltros.Controls.Add(this.lblInicio);
            this.gbFiltros.Controls.Add(this.txtNombreUsuario);
            this.gbFiltros.Controls.Add(this.btnFiltrarFecha);
            this.gbFiltros.Controls.Add(this.dtpDesde);
            this.gbFiltros.Controls.Add(this.lblLugar);
            this.gbFiltros.Controls.Add(this.lblBuscarUsuario);
            this.gbFiltros.Controls.Add(this.cmbLugar);
            this.gbFiltros.Controls.Add(this.lblTipoTarea);
            this.gbFiltros.Location = new System.Drawing.Point(47, 57);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(1058, 173);
            this.gbFiltros.TabIndex = 10;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros de búsqueda";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(923, 123);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(113, 33);
            this.btnLimpiarFiltros.TabIndex = 11;
            this.btnLimpiarFiltros.Text = "Limpiar filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 674);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvHistorial);
            this.Name = "frmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de tareas";
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHistorial;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cmbTipoTarea;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.Label lblTipoTarea;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.DateTimePicker dtpHasta;
        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.Button btnFiltrarFecha;
        private System.Windows.Forms.DateTimePicker dtpDesde;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.Button btnLimpiarFiltros;
    }
}