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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalUsuario));
            this.pControles = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.BarraDeEstadoUsuario = new System.Windows.Forms.StatusStrip();
            this.lblTiempoTitulo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTiempoStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuUsuario = new System.Windows.Forms.MenuStrip();
            this.tareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearTareaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verHistorialDeTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tSessionTimer = new System.Windows.Forms.Timer(this.components);
            this.pControles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.BarraDeEstadoUsuario.SuspendLayout();
            this.menuUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // pControles
            // 
            this.pControles.Controls.Add(this.pbLogo);
            this.pControles.Controls.Add(this.BarraDeEstadoUsuario);
            this.pControles.Controls.Add(this.menuUsuario);
            this.pControles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pControles.Location = new System.Drawing.Point(0, 0);
            this.pControles.Margin = new System.Windows.Forms.Padding(4);
            this.pControles.Name = "pControles";
            this.pControles.Size = new System.Drawing.Size(1067, 554);
            this.pControles.TabIndex = 2;
            // 
            // pbLogo
            // 
            this.pbLogo.Image = global::pryMarkoja_IEFI.Properties.Resources.auditoria;
            this.pbLogo.Location = new System.Drawing.Point(492, 220);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(85, 69);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 10;
            this.pbLogo.TabStop = false;
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
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión...";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(186, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // tSessionTimer
            // 
            this.tSessionTimer.Interval = 1000;
            this.tSessionTimer.Tick += new System.EventHandler(this.tSessionTimer_Tick);
            // 
            // frmPrincipalUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.pControles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuUsuario;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPrincipalUsuario";
            this.Text = "Menú principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pControles.ResumeLayout(false);
            this.pControles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.BarraDeEstadoUsuario.ResumeLayout(false);
            this.BarraDeEstadoUsuario.PerformLayout();
            this.menuUsuario.ResumeLayout(false);
            this.menuUsuario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pControles;
        private System.Windows.Forms.Timer tSessionTimer;
        private System.Windows.Forms.StatusStrip BarraDeEstadoUsuario;
        private System.Windows.Forms.ToolStripStatusLabel lblTiempoTitulo;
        private System.Windows.Forms.ToolStripStatusLabel lblTiempoStatus;
        private System.Windows.Forms.MenuStrip menuUsuario;
        private System.Windows.Forms.ToolStripMenuItem tareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearTareaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verHistorialDeTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}