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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHistorial));
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
            this.dgvHistorial.Location = new System.Drawing.Point(35, 192);
            this.dgvHistorial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 24;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(794, 338);
            this.dgvHistorial.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(32, 15);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(255, 18);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Opciones de búsqueda de tareas";
            // 
            // cmbTipoTarea
            // 
            this.cmbTipoTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTarea.FormattingEnabled = true;
            this.cmbTipoTarea.Location = new System.Drawing.Point(86, 30);
            this.cmbTipoTarea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTipoTarea.Name = "cmbTipoTarea";
            this.cmbTipoTarea.Size = new System.Drawing.Size(103, 21);
            this.cmbTipoTarea.TabIndex = 2;
            this.cmbTipoTarea.SelectedIndexChanged += new System.EventHandler(this.cmbTipoTarea_SelectedIndexChanged);
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(141, 104);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(210, 20);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Location = new System.Drawing.Point(12, 106);
            this.lblBuscarUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(99, 13);
            this.lblBuscarUsuario.TabIndex = 4;
            this.lblBuscarUsuario.Text = "Nombre de usuario:";
            // 
            // lblTipoTarea
            // 
            this.lblTipoTarea.AutoSize = true;
            this.lblTipoTarea.Location = new System.Drawing.Point(12, 33);
            this.lblTipoTarea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTipoTarea.Name = "lblTipoTarea";
            this.lblTipoTarea.Size = new System.Drawing.Size(73, 13);
            this.lblTipoTarea.TabIndex = 5;
            this.lblTipoTarea.Text = "Tipo de tarea:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(203, 32);
            this.lblLugar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(37, 13);
            this.lblLugar.TabIndex = 7;
            this.lblLugar.Text = "Lugar:";
            // 
            // cmbLugar
            // 
            this.cmbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(247, 30);
            this.cmbLugar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(104, 21);
            this.cmbLugar.TabIndex = 6;
            this.cmbLugar.SelectedIndexChanged += new System.EventHandler(this.cmbLugar_SelectedIndexChanged);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(377, 100);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(70, 27);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(455, 61);
            this.lblFinal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(38, 13);
            this.lblFinal.TabIndex = 6;
            this.lblFinal.Text = "Hasta:";
            // 
            // dtpHasta
            // 
            this.dtpHasta.Location = new System.Drawing.Point(510, 58);
            this.dtpHasta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpHasta.Name = "dtpHasta";
            this.dtpHasta.Size = new System.Drawing.Size(151, 20);
            this.dtpHasta.TabIndex = 7;
            this.dtpHasta.ValueChanged += new System.EventHandler(this.dtpHasta_ValueChanged);
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(452, 30);
            this.lblInicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(41, 13);
            this.lblInicio.TabIndex = 2;
            this.lblInicio.Text = "Desde:";
            // 
            // btnFiltrarFecha
            // 
            this.btnFiltrarFecha.Location = new System.Drawing.Point(510, 100);
            this.btnFiltrarFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnFiltrarFecha.Name = "btnFiltrarFecha";
            this.btnFiltrarFecha.Size = new System.Drawing.Size(150, 27);
            this.btnFiltrarFecha.TabIndex = 4;
            this.btnFiltrarFecha.Text = "Filtrar por fecha";
            this.btnFiltrarFecha.UseVisualStyleBackColor = true;
            this.btnFiltrarFecha.Click += new System.EventHandler(this.btnFiltrarFecha_Click);
            // 
            // dtpDesde
            // 
            this.dtpDesde.Location = new System.Drawing.Point(509, 28);
            this.dtpDesde.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDesde.Name = "dtpDesde";
            this.dtpDesde.Size = new System.Drawing.Size(151, 20);
            this.dtpDesde.TabIndex = 5;
            this.dtpDesde.ValueChanged += new System.EventHandler(this.dtpDesde_ValueChanged);
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
            this.gbFiltros.Location = new System.Drawing.Point(35, 46);
            this.gbFiltros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbFiltros.Size = new System.Drawing.Size(794, 141);
            this.gbFiltros.TabIndex = 10;
            this.gbFiltros.TabStop = false;
            this.gbFiltros.Text = "Filtros de búsqueda";
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(692, 100);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(85, 27);
            this.btnLimpiarFiltros.TabIndex = 11;
            this.btnLimpiarFiltros.Text = "Limpiar filtros";
            this.btnLimpiarFiltros.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltros.Click += new System.EventHandler(this.btnLimpiarFiltros_Click);
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 548);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvHistorial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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