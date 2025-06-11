namespace pryMarkoja_IEFI
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
            this.lblDetalle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.pCanvas2 = new System.Windows.Forms.Panel();
            this.pCanvas3 = new System.Windows.Forms.Panel();
            this.pCanvas4 = new System.Windows.Forms.Panel();
            this.pCanvas5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLicencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pPrincipal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pPrincipal
            // 
            this.pPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pPrincipal.AutoScroll = true;
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
            this.pPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pPrincipal.Location = new System.Drawing.Point(149, 41);
            this.pPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pPrincipal.Name = "pPrincipal";
            this.pPrincipal.Size = new System.Drawing.Size(1193, 693);
            this.pPrincipal.TabIndex = 2;
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetalle.Location = new System.Drawing.Point(32, 136);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(72, 20);
            this.lblDetalle.TabIndex = 9;
            this.lblDetalle.Text = "Detalle: ";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
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
            this.panel1.Location = new System.Drawing.Point(36, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1104, 270);
            this.panel1.TabIndex = 0;
            // 
            // pCanvas
            // 
            this.pCanvas.Location = new System.Drawing.Point(99, 65);
            this.pCanvas.Name = "pCanvas";
            this.pCanvas.Size = new System.Drawing.Size(68, 35);
            this.pCanvas.TabIndex = 5;
            this.pCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas_Paint);
            // 
            // chkRecibo
            // 
            this.chkRecibo.AutoSize = true;
            this.chkRecibo.Location = new System.Drawing.Point(546, 97);
            this.chkRecibo.Name = "chkRecibo";
            this.chkRecibo.Size = new System.Drawing.Size(89, 24);
            this.chkRecibo.TabIndex = 4;
            this.chkRecibo.Text = "Recibo";
            this.chkRecibo.UseVisualStyleBackColor = true;
            // 
            // chkSalario
            // 
            this.chkSalario.AutoSize = true;
            this.chkSalario.Location = new System.Drawing.Point(546, 71);
            this.chkSalario.Name = "chkSalario";
            this.chkSalario.Size = new System.Drawing.Size(90, 24);
            this.chkSalario.TabIndex = 3;
            this.chkSalario.Text = "Salario";
            this.chkSalario.UseVisualStyleBackColor = true;
            // 
            // chkVacacion
            // 
            this.chkVacacion.AutoSize = true;
            this.chkVacacion.Location = new System.Drawing.Point(901, 97);
            this.chkVacacion.Name = "chkVacacion";
            this.chkVacacion.Size = new System.Drawing.Size(108, 24);
            this.chkVacacion.TabIndex = 2;
            this.chkVacacion.Text = "Vacación";
            this.chkVacacion.UseVisualStyleBackColor = true;
            // 
            // chkEstudio
            // 
            this.chkEstudio.AutoSize = true;
            this.chkEstudio.Location = new System.Drawing.Point(901, 67);
            this.chkEstudio.Name = "chkEstudio";
            this.chkEstudio.Size = new System.Drawing.Size(94, 24);
            this.chkEstudio.TabIndex = 1;
            this.chkEstudio.Text = "Estudio";
            this.chkEstudio.UseVisualStyleBackColor = true;
            // 
            // chkInsumo
            // 
            this.chkInsumo.AutoSize = true;
            this.chkInsumo.Location = new System.Drawing.Point(172, 69);
            this.chkInsumo.Name = "chkInsumo";
            this.chkInsumo.Size = new System.Drawing.Size(91, 24);
            this.chkInsumo.TabIndex = 0;
            this.chkInsumo.Text = "Insumo";
            this.chkInsumo.UseVisualStyleBackColor = true;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(403, 30);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(200, 27);
            this.dtpFecha.TabIndex = 8;
            // 
            // cmbLugar
            // 
            this.cmbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(819, 29);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(121, 28);
            this.cmbLugar.TabIndex = 7;
            // 
            // cmbTarea
            // 
            this.cmbTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTarea.FormattingEnabled = true;
            this.cmbTarea.Location = new System.Drawing.Point(100, 29);
            this.cmbTarea.Name = "cmbTarea";
            this.cmbTarea.Size = new System.Drawing.Size(121, 28);
            this.cmbTarea.TabIndex = 6;
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentario.Location = new System.Drawing.Point(32, 477);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(105, 20);
            this.lblComentario.TabIndex = 5;
            this.lblComentario.Text = "Comentario: ";
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(36, 500);
            this.txtComentario.Multiline = true;
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(1104, 147);
            this.txtComentario.TabIndex = 4;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLugar.Location = new System.Drawing.Point(756, 33);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(57, 20);
            this.lblLugar.TabIndex = 2;
            this.lblLugar.Text = "Lugar:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(332, 33);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(65, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha: ";
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarea.Location = new System.Drawing.Point(32, 33);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(62, 20);
            this.lblTarea.TabIndex = 0;
            this.lblTarea.Text = "Tarea: ";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(13, 41);
            this.btnVolver.Margin = new System.Windows.Forms.Padding(4);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(100, 28);
            this.btnVolver.TabIndex = 3;
            this.btnVolver.Text = "← Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // pCanvas2
            // 
            this.pCanvas2.Location = new System.Drawing.Point(828, 63);
            this.pCanvas2.Name = "pCanvas2";
            this.pCanvas2.Size = new System.Drawing.Size(68, 35);
            this.pCanvas2.TabIndex = 6;
            this.pCanvas2.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas2_Paint);
            // 
            // pCanvas3
            // 
            this.pCanvas3.Location = new System.Drawing.Point(828, 91);
            this.pCanvas3.Name = "pCanvas3";
            this.pCanvas3.Size = new System.Drawing.Size(68, 35);
            this.pCanvas3.TabIndex = 7;
            this.pCanvas3.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas3_Paint);
            // 
            // pCanvas4
            // 
            this.pCanvas4.Location = new System.Drawing.Point(471, 65);
            this.pCanvas4.Name = "pCanvas4";
            this.pCanvas4.Size = new System.Drawing.Size(68, 35);
            this.pCanvas4.TabIndex = 8;
            this.pCanvas4.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas4_Paint);
            // 
            // pCanvas5
            // 
            this.pCanvas5.Location = new System.Drawing.Point(471, 93);
            this.pCanvas5.Name = "pCanvas5";
            this.pCanvas5.Size = new System.Drawing.Size(68, 35);
            this.pCanvas5.TabIndex = 9;
            this.pCanvas5.Paint += new System.Windows.Forms.PaintEventHandler(this.pCanvas5_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 10;
            this.label1.Text = "Uniforme (pauta):";
            // 
            // lblLicencia
            // 
            this.lblLicencia.AutoSize = true;
            this.lblLicencia.Location = new System.Drawing.Point(810, 38);
            this.lblLicencia.Name = "lblLicencia";
            this.lblLicencia.Size = new System.Drawing.Size(86, 20);
            this.lblLicencia.TabIndex = 11;
            this.lblLicencia.Text = "Licencia:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Uniforme (pauta):";
            // 
            // frmTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 838);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pPrincipal);
            this.Name = "frmTarea";
            this.Text = "Tareas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pPrincipal.ResumeLayout(false);
            this.pPrincipal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Panel pCanvas2;
        private System.Windows.Forms.Panel pCanvas3;
        private System.Windows.Forms.Panel pCanvas5;
        private System.Windows.Forms.Panel pCanvas4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLicencia;
        private System.Windows.Forms.Label label2;
    }
}