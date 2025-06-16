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
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).BeginInit();
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
            this.dgvHistorial.Location = new System.Drawing.Point(53, 94);
            this.dgvHistorial.Name = "dgvHistorial";
            this.dgvHistorial.ReadOnly = true;
            this.dgvHistorial.RowHeadersVisible = false;
            this.dgvHistorial.RowHeadersWidth = 51;
            this.dgvHistorial.RowTemplate.Height = 24;
            this.dgvHistorial.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorial.Size = new System.Drawing.Size(1036, 568);
            this.dgvHistorial.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(49, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(305, 22);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Opciones de búsqueda de tareas";
            // 
            // cmbTipoTarea
            // 
            this.cmbTipoTarea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoTarea.FormattingEnabled = true;
            this.cmbTipoTarea.Location = new System.Drawing.Point(148, 55);
            this.cmbTipoTarea.Name = "cmbTipoTarea";
            this.cmbTipoTarea.Size = new System.Drawing.Size(136, 24);
            this.cmbTipoTarea.TabIndex = 2;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(693, 56);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(253, 22);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Location = new System.Drawing.Point(542, 59);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(125, 16);
            this.lblBuscarUsuario.TabIndex = 4;
            this.lblBuscarUsuario.Text = "Nombre de usuario:";
            // 
            // lblTipoTarea
            // 
            this.lblTipoTarea.AutoSize = true;
            this.lblTipoTarea.Location = new System.Drawing.Point(50, 59);
            this.lblTipoTarea.Name = "lblTipoTarea";
            this.lblTipoTarea.Size = new System.Drawing.Size(91, 16);
            this.lblTipoTarea.TabIndex = 5;
            this.lblTipoTarea.Text = "Tipo de tarea:";
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(324, 59);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(44, 16);
            this.lblLugar.TabIndex = 7;
            this.lblLugar.Text = "Lugar:";
            // 
            // cmbLugar
            // 
            this.cmbLugar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLugar.FormattingEnabled = true;
            this.cmbLugar.Location = new System.Drawing.Point(382, 56);
            this.cmbLugar.Name = "cmbLugar";
            this.cmbLugar.Size = new System.Drawing.Size(137, 24);
            this.cmbLugar.TabIndex = 6;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(976, 53);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(113, 28);
            this.btnBuscar.TabIndex = 8;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 674);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblLugar);
            this.Controls.Add(this.cmbLugar);
            this.Controls.Add(this.lblTipoTarea);
            this.Controls.Add(this.lblBuscarUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.cmbTipoTarea);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvHistorial);
            this.Name = "frmHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Historial de tareas";
            this.Load += new System.EventHandler(this.frmHistorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorial)).EndInit();
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
    }
}