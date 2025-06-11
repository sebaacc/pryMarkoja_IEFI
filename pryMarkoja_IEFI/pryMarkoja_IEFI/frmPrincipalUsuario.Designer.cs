namespace pryMarkoja_IEFI
{
    partial class frmPrincipalUsuario
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
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.tSessionTimer = new System.Windows.Forms.Timer(this.components);
            this.menuUsuario = new System.Windows.Forms.MenuStrip();
            this.sesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHistorialDeTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pControles.SuspendLayout();
            this.BarraDeEstadoUsuario.SuspendLayout();
            this.pPrincipal.SuspendLayout();
            this.menuUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pControles
            // 
            this.pControles.Controls.Add(this.BarraDeEstadoUsuario);
            this.pControles.Controls.Add(this.menuUsuario);
            this.pControles.Controls.Add(this.pPrincipal);
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
            // pPrincipal
            // 
            this.pPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pPrincipal.Controls.Add(this.dtpFecha);
            this.pPrincipal.Controls.Add(this.cmbLugar);
            this.pPrincipal.Controls.Add(this.cmbTarea);
            this.pPrincipal.Controls.Add(this.lblComentario);
            this.pPrincipal.Controls.Add(this.txtComentario);
            this.pPrincipal.Controls.Add(this.gbDetalle);
            this.pPrincipal.Controls.Add(this.lblLugar);
            this.pPrincipal.Controls.Add(this.lblFecha);
            this.pPrincipal.Controls.Add(this.lblTarea);
            this.pPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPrincipal.Location = new System.Drawing.Point(103, 45);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(756, 483);
            this.pPrincipal.TabIndex = 1;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(100, 96);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 27);
            this.dtpFecha.TabIndex = 8;
            // 
            // cmbLugar
            // 
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(421, 96);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(121, 28);
            this.cmbLugar.TabIndex = 7;
            // 
            // cmbTarea
            // 
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(100, 38);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(121, 28);
            this.cmbTarea.TabIndex = 6;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(32, 346);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(65, 20);
            this.lblComentario.TabIndex = 5;
            this.lblComentario.Text = "Fecha: ";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(36, 369);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(668, 89);
            this.txtComentario.TabIndex = 4;
            // 
            // gbDetalle
            // 
            this.gbDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbDetalle.Location = new System.Drawing.Point(36, 135);
            this.gbDetalle.Name = "gbDetalle";
            this.gbDetalle.Size = new System.Drawing.Size(668, 203);
            this.gbDetalle.TabIndex = 3;
            this.gbDetalle.TabStop = false;
            this.gbDetalle.Text = "Detalle";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(358, 99);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(57, 20);
            this.lblLugar.TabIndex = 2;
            this.lblLugar.Text = "Lugar:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(32, 99);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.Location = new System.Drawing.Point(32, 41);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(62, 20);
            this.lblTarea.TabIndex = 0;
            this.lblTarea.Text = "Tarea: ";
            // 
            // tSessionTimer
            // 
            this.tSessionTimer.Interval = 1000;
            this.tSessionTimer.Tick += new System.EventHandler(this.tSessionTimer_Tick);
            // 
            // menuUsuario
            // 
            this.menuUsuario.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuUsuario.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tareasToolStripMenuItem,
            this.sesiónToolStripMenuItem});
            this.menuUsuario.Location = new System.Drawing.Point(0, 0);
            this.menuUsuario.Name = "menuUsuario";
            this.menuUsuario.Size = new System.Drawing.Size(1067, 28);
            this.menuUsuario.TabIndex = 6;
            this.menuUsuario.Text = "menuStrip1";
            // 
            // sesiónToolStripMenuItem
            // 
            this.sesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.sesiónToolStripMenuItem.Name = "sesiónToolStripMenuItem";
            this.sesiónToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.sesiónToolStripMenuItem.Text = "Sesión";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión...";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tareasToolStripMenuItem
            // 
            this.tareasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearTareaToolStripMenuItem,
            this.verHistorialDeTareasToolStripMenuItem});
            this.tareasToolStripMenuItem.Name = "tareasToolStripMenuItem";
            this.tareasToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.tareasToolStripMenuItem.Text = "Tareas";
            // 
            // crearTareaToolStripMenuItem
            // 
            this.crearTareaToolStripMenuItem.Name = "crearTareaToolStripMenuItem";
            this.crearTareaToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.crearTareaToolStripMenuItem.Text = "Crear tarea...";
            this.crearTareaToolStripMenuItem.Click += new System.EventHandler(this.crearTareaToolStripMenuItem_Click);
            // 
            // verHistorialDeTareasToolStripMenuItem
            // 
            this.verHistorialDeTareasToolStripMenuItem.Name = "verHistorialDeTareasToolStripMenuItem";
            this.verHistorialDeTareasToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.verHistorialDeTareasToolStripMenuItem.Text = "Ver historial de tareas...";
            this.verHistorialDeTareasToolStripMenuItem.Click += new System.EventHandler(this.verHistorialDeTareasToolStripMenuItem_Click);
            // 
            // frmPrincipalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pControles);
            this.MainMenuStrip = this.menuUsuario;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipalUsuario";
            this.Text = "Menú principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pControles.ResumeLayout(false);
            this.pControles.PerformLayout();
            this.BarraDeEstadoUsuario.ResumeLayout(false);
            this.BarraDeEstadoUsuario.PerformLayout();
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.menuUsuario.ResumeLayout(false);
            this.menuUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.Panel pPrincipal;
        private System.Windows.Forms.Timer tSessionTimer;
        private System.Windows.Forms.StatusStrip BarraDeEstadoUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblTiempoTitulo;
        private System.Windows.Forms.ToolStripStatusLabel lblTiempoStatus;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.MenuStrip menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearTareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verHistorialDeTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}