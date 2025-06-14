﻿namespace pryMarkoja_IEFI
{
    partial class frmTarea
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
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.lblTituloTareas = new System.Windows.Forms.Label();
            this.dgvTareas = new System.Windows.Forms.DataGridView();
            this.TipoTarea = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lugar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Comentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnGrabar = new System.Windows.Forms.Button();
            this.btnAgregarTarea = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblReclamo = new System.Windows.Forms.Label();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pCanvas5 = new System.Windows.Forms.Panel();
            this.pCanvas4 = new System.Windows.Forms.Panel();
            this.pCanvas3 = new System.Windows.Forms.Panel();
            this.pCanvas2 = new System.Windows.Forms.Panel();
            this.pCanvas = new System.Windows.Forms.Panel();
            this.chkRecibo = new System.Windows.Forms.CheckBox();
            this.chkSalario = new System.Windows.Forms.CheckBox();
            this.chkVacacion = new System.Windows.Forms.CheckBox();
            this.chkEstudio = new System.Windows.Forms.CheckBox();
            this.chkInsumo = new System.Windows.Forms.CheckBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.bgWorker = new System.ComponentModel.BackgroundWorker();
            this.menuTareas = new System.Windows.Forms.MenuStrip();
            this.ventanaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.volverAMenúPrincipalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).BeginInit();
            this.panel1.SuspendLayout();
            this.menuTareas.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.AutoScroll = true;
            this.pPrincipal.Controls.Add(this.lblTituloTareas);
            this.pPrincipal.Controls.Add(this.dgvTareas);
            this.pPrincipal.Controls.Add(this.btnGrabar);
            this.pPrincipal.Controls.Add(this.btnAgregarTarea);
            this.pPrincipal.Controls.Add(this.lblDetalle);
            this.pPrincipal.Controls.Add(this.panel1);
            this.pPrincipal.Controls.Add(this.dtpFecha);
            this.pPrincipal.Controls.Add(this.cmbLugar);
            this.pPrincipal.Controls.Add(this.cmbTarea);
            this.pPrincipal.Controls.Add(this.lblComentario);
            this.pPrincipal.Controls.Add(this.txtComentario);
            this.pPrincipal.Controls.Add(this.lblLugar);
            this.pPrincipal.Controls.Add(this.lblFecha);
            this.pPrincipal.Controls.Add(this.lblTarea);
            this.pPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPrincipal.Location = new System.Drawing.Point(0, 24);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(963, 738);
            this.pPrincipal.TabIndex = 2;
            // 
            // lblTituloTareas
            // 
            this.lblTituloTareas.AutoSize = true;
            this.lblTituloTareas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloTareas.Location = new System.Drawing.Point(194, 9);
            this.lblTituloTareas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTituloTareas.Name = "lblTituloTareas";
            this.lblTituloTareas.Size = new System.Drawing.Size(255, 24);
            this.lblTituloTareas.TabIndex = 13;
            this.lblTituloTareas.Text = "Registrar tareas realizadas";
            // 
            // dgvTareas
            // 
            this.dgvTareas.AllowUserToAddRows = false;
            this.dgvTareas.AllowUserToDeleteRows = false;
            this.dgvTareas.AllowUserToResizeColumns = false;
            this.dgvTareas.AllowUserToResizeRows = false;
            this.dgvTareas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvTareas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoTarea,
            this.Lugar,
            this.Fecha,
            this.Detalle,
            this.Comentario});
            this.dgvTareas.Location = new System.Drawing.Point(197, 462);
            this.dgvTareas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvTareas.MultiSelect = false;
            this.dgvTareas.Name = "dgvTareas";
            this.dgvTareas.ReadOnly = true;
            this.dgvTareas.RowHeadersVisible = false;
            this.dgvTareas.RowHeadersWidth = 51;
            this.dgvTareas.RowTemplate.Height = 24;
            this.dgvTareas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTareas.Size = new System.Drawing.Size(904, 195);
            this.dgvTareas.TabIndex = 12;
            // 
            // TipoTarea
            // 
            this.TipoTarea.HeaderText = "Tipo de Tarea";
            this.TipoTarea.MinimumWidth = 6;
            this.TipoTarea.Name = "TipoTarea";
            this.TipoTarea.ReadOnly = true;
            this.TipoTarea.Width = 124;
            // 
            // Lugar
            // 
            this.Lugar.HeaderText = "Lugar";
            this.Lugar.MinimumWidth = 6;
            this.Lugar.Name = "Lugar";
            this.Lugar.ReadOnly = true;
            this.Lugar.Width = 75;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 6;
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 77;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalle";
            this.Detalle.MinimumWidth = 6;
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            this.Detalle.Width = 84;
            // 
            // Comentario
            // 
            this.Comentario.HeaderText = " Comentario";
            this.Comentario.MinimumWidth = 6;
            this.Comentario.Name = "Comentario";
            this.Comentario.ReadOnly = true;
            this.Comentario.Width = 120;
            // 
            // btnGrabar
            // 
            this.btnGrabar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabar.Location = new System.Drawing.Point(990, 687);
            this.btnGrabar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGrabar.Name = "btnGrabar";
            this.btnGrabar.Size = new System.Drawing.Size(111, 27);
            this.btnGrabar.TabIndex = 11;
            this.btnGrabar.Text = "Grabar y Salir";
            this.btnGrabar.UseVisualStyleBackColor = true;
            this.btnGrabar.Click += new System.EventHandler(this.btnGrabar_Click);
            // 
            // btnAgregarTarea
            // 
            this.btnAgregarTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTarea.Location = new System.Drawing.Point(623, 414);
            this.btnAgregarTarea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregarTarea.Name = "btnAgregarTarea";
            this.btnAgregarTarea.Size = new System.Drawing.Size(111, 27);
            this.btnAgregarTarea.TabIndex = 10;
            this.btnAgregarTarea.Text = "Agregar Tarea";
            this.btnAgregarTarea.UseVisualStyleBackColor = true;
            this.btnAgregarTarea.Click += new System.EventHandler(this.btnAgregarTarea_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(724, 64);
            this.lblDetalle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(60, 17);
            this.lblDetalle.TabIndex = 9;
            this.lblDetalle.Text = "Detalle: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblReclamo);
            this.panel1.Controls.Add(this.lblLicencia);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pCanvas5);
            this.panel1.Controls.Add(this.pCanvas4);
            this.panel1.Controls.Add(this.pCanvas3);
            this.panel1.Controls.Add(this.pCanvas2);
            this.panel1.Controls.Add(this.pCanvas);
            this.panel1.Controls.Add(this.chkRecibo);
            this.panel1.Controls.Add(this.chkSalario);
            this.panel1.Controls.Add(this.chkVacacion);
            this.panel1.Controls.Add(this.chkEstudio);
            this.panel1.Controls.Add(this.chkInsumo);
            this.panel1.Location = new System.Drawing.Point(707, 83);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 314);
            this.panel1.TabIndex = 0;
            // 
            // lblReclamo
            // 
            this.lblReclamo.AutoSize = true;
            this.lblReclamo.Location = new System.Drawing.Point(116, 225);
            this.lblReclamo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReclamo.Name = "lblReclamo";
            this.lblReclamo.Size = new System.Drawing.Size(75, 17);
            this.lblReclamo.TabIndex = 12;
            this.lblReclamo.Text = "Reclamo:";
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(116, 117);
            this.lblLicencia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(73, 17);
            this.lblLicencia.TabIndex = 11;
            this.lblLicencia.Text = "Licencia:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Uniforme (pauta):";
            // 
            // pCanvas5
            // 
            this.pCanvas5.Location = new System.Drawing.Point(129, 266);
            this.pCanvas5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCanvas5.Name = "pCanvas5";
            this.pCanvas5.Size = new System.Drawing.Size(51, 28);
            this.pCanvas5.TabIndex = 9;
            this.pCanvas5.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas5_Paint);
            // 
            // pCanvas4
            // 
            this.pCanvas4.Location = new System.Drawing.Point(129, 244);
            this.pCanvas4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCanvas4.Name = "pCanvas4";
            this.pCanvas4.Size = new System.Drawing.Size(51, 28);
            this.pCanvas4.TabIndex = 8;
            this.pCanvas4.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas4_Paint);
            // 
            // pCanvas3
            // 
            this.pCanvas3.Location = new System.Drawing.Point(129, 160);
            this.pCanvas3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCanvas3.Name = "pCanvas3";
            this.pCanvas3.Size = new System.Drawing.Size(51, 28);
            this.pCanvas3.TabIndex = 7;
            this.pCanvas3.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas3_Paint);
            // 
            // pCanvas2
            // 
            this.pCanvas2.Location = new System.Drawing.Point(129, 137);
            this.pCanvas2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCanvas2.Name = "pCanvas2";
            this.pCanvas2.Size = new System.Drawing.Size(51, 28);
            this.pCanvas2.TabIndex = 6;
            this.pCanvas2.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas2_Paint);
            // 
            // pCanvas
            // 
            this.pCanvas.Location = new System.Drawing.Point(129, 46);
            this.pCanvas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(51, 28);
            this.pCanvas.TabIndex = 5;
            this.pCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas_Paint);
            // 
            // chkRecibo
            // 
            this.chkRecibo.AutoSize = true;
            this.chkRecibo.Location = new System.Drawing.Point(186, 270);
            this.chkRecibo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkRecibo.Name = "chkRecibo";
            this.chkRecibo.Size = new System.Drawing.Size(77, 21);
            this.chkRecibo.TabIndex = 4;
            this.chkRecibo.Text = "Recibo";
            this.chkRecibo.UseVisualStyleBackColor = true;
            // 
            // chkSalario
            // 
            this.chkSalario.AutoSize = true;
            this.chkSalario.Location = new System.Drawing.Point(186, 249);
            this.chkSalario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkSalario.Name = "chkSalario";
            this.chkSalario.Size = new System.Drawing.Size(78, 21);
            this.chkSalario.TabIndex = 3;
            this.chkSalario.Text = "Salario";
            this.chkSalario.UseVisualStyleBackColor = true;
            // 
            // chkVacacion
            // 
            this.chkVacacion.AutoSize = true;
            this.chkVacacion.Location = new System.Drawing.Point(186, 165);
            this.chkVacacion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkVacacion.Name = "chkVacacion";
            this.chkVacacion.Size = new System.Drawing.Size(93, 21);
            this.chkVacacion.TabIndex = 2;
            this.chkVacacion.Text = "Vacación";
            this.chkVacacion.UseVisualStyleBackColor = true;
            // 
            // chkEstudio
            // 
            this.chkEstudio.AutoSize = true;
            this.chkEstudio.Location = new System.Drawing.Point(186, 141);
            this.chkEstudio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkEstudio.Name = "chkEstudio";
            this.chkEstudio.Size = new System.Drawing.Size(81, 21);
            this.chkEstudio.TabIndex = 1;
            this.chkEstudio.Text = "Estudio";
            this.chkEstudio.UseVisualStyleBackColor = true;
            // 
            // chkInsumo
            // 
            this.chkInsumo.AutoSize = true;
            this.chkInsumo.Location = new System.Drawing.Point(186, 50);
            this.chkInsumo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chkInsumo.Name = "chkInsumo";
            this.chkInsumo.Size = new System.Drawing.Size(78, 21);
            this.chkInsumo.TabIndex = 0;
            this.chkInsumo.Text = "Insumo";
            this.chkInsumo.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(334, 128);
            this.dtpFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(327, 23);
            this.dtpFecha.TabIndex = 8;
            // 
            // cmbLugar
            // 
            this.cmbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(334, 196);
            this.cmbLugar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(327, 25);
            this.cmbLugar.TabIndex = 7;
            // 
            // cmbTarea
            // 
            this.cmbTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(334, 62);
            this.cmbTarea.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(327, 25);
            this.cmbTarea.TabIndex = 6;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(198, 253);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(88, 17);
            this.lblComentario.TabIndex = 5;
            this.lblComentario.Text = "Comentario: ";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(201, 271);
            this.txtComentario.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(460, 126);
            this.txtComentario.TabIndex = 4;
            this.txtComentario.TextChanged += new System.EventHandler(this.txtComentario_TextChanged);
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(198, 198);
            this.lblLugar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(49, 17);
            this.lblLugar.TabIndex = 2;
            this.lblLugar.Text = "Lugar:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(198, 132);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(55, 17);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.Location = new System.Drawing.Point(198, 64);
            this.lblTarea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(116, 17);
            this.lblTarea.TabIndex = 0;
            this.lblTarea.Text = "Tarea realizada: ";
            // 
            // menuTareas
            // 
            this.menuTareas.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuTareas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventanaToolStripMenuItem});
            this.menuTareas.Location = new System.Drawing.Point(0, 0);
            this.menuTareas.Name = "menuTareas";
            this.menuTareas.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuTareas.Size = new System.Drawing.Size(963, 24);
            this.menuTareas.TabIndex = 4;
            this.menuTareas.Text = "menuStrip1";
            // 
            // ventanaToolStripMenuItem
            // 
            this.ventanaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverAMenúPrincipalToolStripMenuItem});
            this.ventanaToolStripMenuItem.Name = "ventanaToolStripMenuItem";
            this.ventanaToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ventanaToolStripMenuItem.Text = "Ventana";
            // 
            // volverAMenúPrincipalToolStripMenuItem
            // 
            this.volverAMenúPrincipalToolStripMenuItem.Name = "volverAMenúPrincipalToolStripMenuItem";
            this.volverAMenúPrincipalToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.volverAMenúPrincipalToolStripMenuItem.Text = "← Volver a Menú principal...";
            this.volverAMenúPrincipalToolStripMenuItem.Click += new System.EventHandler(this.volverAMenúPrincipalToolStripMenuItem_Click);
            // 
            // frmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 762);
            this.Controls.Add(this.pPrincipal);
            this.Controls.Add(this.menuTareas);
            this.MainMenuStrip = this.menuTareas;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmTarea";
            this.Text = "Tareas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTareas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuTareas.ResumeLayout(false);
            this.menuTareas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.Panel panel1;
        private System.ComponentModel.BackgroundWorker bgWorker;
        private System.Windows.Forms.Label lblDetalle;
        private System.Windows.Forms.CheckBox chkRecibo;
        private System.Windows.Forms.CheckBox chkSalario;
        private System.Windows.Forms.CheckBox chkVacacion;
        private System.Windows.Forms.CheckBox chkEstudio;
        private System.Windows.Forms.CheckBox chkInsumo;
        private System.Windows.Forms.Panel pCanvas;
        private System.Windows.Forms.Panel pCanvas2;
        private System.Windows.Forms.Panel pCanvas3;
        private System.Windows.Forms.Panel pCanvas5;
        private System.Windows.Forms.Panel pCanvas4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.Label lblReclamo;
        private System.Windows.Forms.Button btnAgregarTarea;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.DataGridView dgvTareas;
        private System.Windows.Forms.MenuStrip menuTareas;
        private System.Windows.Forms.ToolStripMenuItem ventanaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem volverAMenúPrincipalToolStripMenuItem;
        private System.Windows.Forms.Label lblTituloTareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoTarea;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lugar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Comentario;
    }
}