namespace pryMarkoja_IEFI
{
    partial class frmAgregarLugar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarLugar));
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.btnAgregarLugar = new System.Windows.Forms.Button();
            this.lblNombreLugar = new System.Windows.Forms.Label();
            this.txtNombreLugarNuevo = new System.Windows.Forms.TextBox();
            this.gbElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.btnAgregarLugar);
            this.gbElementos.Controls.Add(this.lblNombreLugar);
            this.gbElementos.Controls.Add(this.txtNombreLugarNuevo);
            this.gbElementos.Location = new System.Drawing.Point(217, 121);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Size = new System.Drawing.Size(367, 219);
            this.gbElementos.TabIndex = 4;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Agregar nuevo lugar";
            // 
            // btnAgregarLugar
            // 
            this.btnAgregarLugar.Location = new System.Drawing.Point(244, 157);
            this.btnAgregarLugar.Name = "btnAgregarLugar";
            this.btnAgregarLugar.Size = new System.Drawing.Size(88, 40);
            this.btnAgregarLugar.TabIndex = 1;
            this.btnAgregarLugar.Text = "Agregar";
            this.btnAgregarLugar.UseVisualStyleBackColor = true;
            this.btnAgregarLugar.Click += new System.EventHandler(this.btnAgregarLugar_Click);
            // 
            // lblNombreLugar
            // 
            this.lblNombreLugar.AutoSize = true;
            this.lblNombreLugar.Location = new System.Drawing.Point(45, 60);
            this.lblNombreLugar.Name = "lblNombreLugar";
            this.lblNombreLugar.Size = new System.Drawing.Size(126, 16);
            this.lblNombreLugar.TabIndex = 2;
            this.lblNombreLugar.Text = "Nombre de la tarea:";
            // 
            // txtNombreLugarNuevo
            // 
            this.txtNombreLugarNuevo.Location = new System.Drawing.Point(48, 86);
            this.txtNombreLugarNuevo.Name = "txtNombreLugarNuevo";
            this.txtNombreLugarNuevo.Size = new System.Drawing.Size(284, 22);
            this.txtNombreLugarNuevo.TabIndex = 0;
            // 
            // frmAgregarLugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbElementos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAgregarLugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar lugar";
            this.gbElementos.ResumeLayout(false);
            this.gbElementos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.Button btnAgregarLugar;
        private System.Windows.Forms.Label lblNombreLugar;
        private System.Windows.Forms.TextBox txtNombreLugarNuevo;
    }
}