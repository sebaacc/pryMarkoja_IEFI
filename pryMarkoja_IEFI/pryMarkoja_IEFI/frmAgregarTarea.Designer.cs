namespace pryMarkoja_IEFI
{
    partial class frmAgregarTarea
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
            this.txtNombreTareaNuevo = new System.Windows.Forms.TextBox();
            this.btnAgregarTipoTarea = new System.Windows.Forms.Button();
            this.lblNombreTarea = new System.Windows.Forms.Label();
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.gbElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreTareaNuevo
            // 
            this.txtNombreTareaNuevo.Location = new System.Drawing.Point(48, 86);
            this.txtNombreTareaNuevo.Name = "txtNombreTareaNuevo";
            this.txtNombreTareaNuevo.Size = new System.Drawing.Size(284, 22);
            this.txtNombreTareaNuevo.TabIndex = 0;
            // 
            // btnAgregarTipoTarea
            // 
            this.btnAgregarTipoTarea.Location = new System.Drawing.Point(244, 157);
            this.btnAgregarTipoTarea.Name = "btnAgregarTipoTarea";
            this.btnAgregarTipoTarea.Size = new System.Drawing.Size(88, 40);
            this.btnAgregarTipoTarea.TabIndex = 1;
            this.btnAgregarTipoTarea.Text = "Agregar";
            this.btnAgregarTipoTarea.UseVisualStyleBackColor = true;
            // 
            // lblNombreTarea
            // 
            this.lblNombreTarea.AutoSize = true;
            this.lblNombreTarea.Location = new System.Drawing.Point(45, 60);
            this.lblNombreTarea.Name = "lblNombreTarea";
            this.lblNombreTarea.Size = new System.Drawing.Size(126, 16);
            this.lblNombreTarea.TabIndex = 2;
            this.lblNombreTarea.Text = "Nombre de la tarea:";
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.btnAgregarTipoTarea);
            this.gbElementos.Controls.Add(this.lblNombreTarea);
            this.gbElementos.Controls.Add(this.txtNombreTareaNuevo);
            this.gbElementos.Location = new System.Drawing.Point(218, 130);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Size = new System.Drawing.Size(367, 219);
            this.gbElementos.TabIndex = 3;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Agregar nuevo tipo de tarea";
            // 
            // frmAgregarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbElementos);
            this.Name = "frmAgregarTarea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar tipo de tarea";
            this.gbElementos.ResumeLayout(false);
            this.gbElementos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreTareaNuevo;
        private System.Windows.Forms.Button btnAgregarTipoTarea;
        private System.Windows.Forms.Label lblNombreTarea;
        private System.Windows.Forms.GroupBox gbElementos;
    }
}