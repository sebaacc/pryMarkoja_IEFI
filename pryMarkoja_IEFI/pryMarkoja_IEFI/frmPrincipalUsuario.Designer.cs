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
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pPrincipal = new System.Windows.Forms.Panel();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.cmbTarea = new System.Windows.Forms.ComboBox();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtComentario = new System.Windows.Forms.TextBox();
            this.gbDetalle = new System.Windows.Forms.GroupBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTarea = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tSessionTimer = new System.Windows.Forms.Timer(this.components);
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.pControles.SuspendLayout();
            this.BarraDeEstadoUsuario.SuspendLayout();
            this.pPrincipal.SuspendLayout();
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
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(100, 96);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 27);
            this.dtpFecha.TabIndex = 8;
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
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
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
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.ComboBox cmbTarea;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtComentario;
        private System.Windows.Forms.GroupBox gbDetalle;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTarea;
        private System.Windows.Forms.DateTimePicker dtpFecha;
    }
}