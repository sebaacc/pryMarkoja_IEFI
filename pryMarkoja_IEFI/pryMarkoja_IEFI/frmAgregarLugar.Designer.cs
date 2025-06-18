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
            this.gbEliminar = new System.Windows.Forms.GroupBox();
            this.cmbLugar = new System.Windows.Forms.ComboBox();
            this.btnEliminarLugar = new System.Windows.Forms.Button();
            this.lblTarea = new System.Windows.Forms.Label();
            this.gbElementos.SuspendLayout();
            this.gbEliminar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.btnAgregarLugar);
            this.gbElementos.Controls.Add(this.lblNombreLugar);
            this.gbElementos.Controls.Add(this.txtNombreLugarNuevo);
            this.gbElementos.Location = new System.Drawing.Point(160, 35);
            this.gbElementos.Margin = new System.Windows.Forms.Padding(2);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Padding = new System.Windows.Forms.Padding(2);
            this.gbElementos.Size = new System.Drawing.Size(275, 142);
            this.gbElementos.TabIndex = 4;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Agregar nuevo lugar";
            // 
            // btnAgregarLugar
            // 
            this.btnAgregarLugar.Location = new System.Drawing.Point(184, 91);
            this.btnAgregarLugar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregarLugar.Name = "btnAgregarLugar";
            this.btnAgregarLugar.Size = new System.Drawing.Size(66, 32);
            this.btnAgregarLugar.TabIndex = 1;
            this.btnAgregarLugar.Text = "Agregar";
            this.btnAgregarLugar.UseVisualStyleBackColor = true;
            this.btnAgregarLugar.Click += new System.EventHandler(this.btnAgregarLugar_Click);
            // 
            // lblNombreLugar
            // 
            this.lblNombreLugar.AutoSize = true;
            this.lblNombreLugar.Location = new System.Drawing.Point(34, 36);
            this.lblNombreLugar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreLugar.Name = "lblNombreLugar";
            this.lblNombreLugar.Size = new System.Drawing.Size(90, 13);
            this.lblNombreLugar.TabIndex = 2;
            this.lblNombreLugar.Text = "Nombre del lugar:";
            // 
            // txtNombreLugarNuevo
            // 
            this.txtNombreLugarNuevo.Location = new System.Drawing.Point(36, 57);
            this.txtNombreLugarNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreLugarNuevo.Name = "txtNombreLugarNuevo";
            this.txtNombreLugarNuevo.Size = new System.Drawing.Size(214, 20);
            this.txtNombreLugarNuevo.TabIndex = 0;
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.cmbLugar);
            this.gbEliminar.Controls.Add(this.btnEliminarLugar);
            this.gbEliminar.Controls.Add(this.lblTarea);
            this.gbEliminar.Location = new System.Drawing.Point(160, 195);
            this.gbEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Padding = new System.Windows.Forms.Padding(2);
            this.gbEliminar.Size = new System.Drawing.Size(275, 142);
            this.gbEliminar.TabIndex = 5;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Eliminar lugar";
            // 
            // cmbLugar
            // 
            this.cmbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(129, 54);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(121, 21);
            this.cmbLugar.TabIndex = 3;
            // 
            // btnEliminarLugar
            // 
            this.btnEliminarLugar.Location = new System.Drawing.Point(184, 91);
            this.btnEliminarLugar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarLugar.Name = "btnEliminarLugar";
            this.btnEliminarLugar.Size = new System.Drawing.Size(66, 32);
            this.btnEliminarLugar.TabIndex = 1;
            this.btnEliminarLugar.Text = "Eliminar";
            this.btnEliminarLugar.UseVisualStyleBackColor = true;
            this.btnEliminarLugar.Click += new System.EventHandler(this.btnEliminarLugar_Click);
            // 
            // lblTarea
            // 
            this.lblTarea.AutoSize = true;
            this.lblTarea.Location = new System.Drawing.Point(34, 54);
            this.lblTarea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTarea.Name = "lblTarea";
            this.lblTarea.Size = new System.Drawing.Size(84, 13);
            this.lblTarea.TabIndex = 2;
            this.lblTarea.Text = "Lugar a eliminar:";
            // 
            // frmAgregarLugar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.gbEliminar);
            this.Controls.Add(this.gbElementos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmAgregarLugar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar lugar";
            this.gbElementos.ResumeLayout(false);
            this.gbElementos.PerformLayout();
            this.gbEliminar.ResumeLayout(false);
            this.gbEliminar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.Button btnAgregarLugar;
        private System.Windows.Forms.Label lblNombreLugar;
        private System.Windows.Forms.TextBox txtNombreLugarNuevo;
        private System.Windows.Forms.GroupBox gbEliminar;
        private System.Windows.Forms.ComboBox cmbLugar;
        private System.Windows.Forms.Button btnEliminarLugar;
        private System.Windows.Forms.Label lblTarea;
    }
}