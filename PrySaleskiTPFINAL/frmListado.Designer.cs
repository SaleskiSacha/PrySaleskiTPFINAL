namespace PrySaleskiTPFINAL
{
    partial class frmListado
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
            this.dgvMostrar = new System.Windows.Forms.DataGridView();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.mrcApellidop = new System.Windows.Forms.GroupBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.mrcBuscaar = new System.Windows.Forms.GroupBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.btnAcep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).BeginInit();
            this.mrcApellidop.SuspendLayout();
            this.mrcBuscaar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMostrar
            // 
            this.dgvMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMostrar.Location = new System.Drawing.Point(-1, 102);
            this.dgvMostrar.Name = "dgvMostrar";
            this.dgvMostrar.Size = new System.Drawing.Size(788, 150);
            this.dgvMostrar.TabIndex = 0;
            this.dgvMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMostrar_CellContentClick);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(6, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(90, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Filtrar por Apellido";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(6, 56);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // mrcApellidop
            // 
            this.mrcApellidop.Controls.Add(this.txtApellido);
            this.mrcApellidop.Controls.Add(this.lblNombre);
            this.mrcApellidop.Controls.Add(this.btnAceptar);
            this.mrcApellidop.Location = new System.Drawing.Point(22, 12);
            this.mrcApellidop.Name = "mrcApellidop";
            this.mrcApellidop.Size = new System.Drawing.Size(296, 84);
            this.mrcApellidop.TabIndex = 5;
            this.mrcApellidop.TabStop = false;
            this.mrcApellidop.Text = "Buscar";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(109, 32);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(181, 20);
            this.txtApellido.TabIndex = 5;
            // 
            // mrcBuscaar
            // 
            this.mrcBuscaar.Controls.Add(this.txtDireccion);
            this.mrcBuscaar.Controls.Add(this.lblDireccion);
            this.mrcBuscaar.Controls.Add(this.btnAcep);
            this.mrcBuscaar.Location = new System.Drawing.Point(468, 12);
            this.mrcBuscaar.Name = "mrcBuscaar";
            this.mrcBuscaar.Size = new System.Drawing.Size(299, 84);
            this.mrcBuscaar.TabIndex = 6;
            this.mrcBuscaar.TabStop = false;
            this.mrcBuscaar.Text = "Buscar";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(112, 28);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(181, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(-3, 35);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(98, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Filtrar por Direccion";
            this.lblDireccion.Click += new System.EventHandler(this.lblDireccion_Click);
            // 
            // btnAcep
            // 
            this.btnAcep.Location = new System.Drawing.Point(6, 56);
            this.btnAcep.Name = "btnAcep";
            this.btnAcep.Size = new System.Drawing.Size(75, 23);
            this.btnAcep.TabIndex = 4;
            this.btnAcep.Text = "ACEPTAR";
            this.btnAcep.UseVisualStyleBackColor = true;
            this.btnAcep.Click += new System.EventHandler(this.btnAcep_Click);
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 253);
            this.Controls.Add(this.mrcBuscaar);
            this.Controls.Add(this.mrcApellidop);
            this.Controls.Add(this.dgvMostrar);
            this.Name = "frmListado";
            this.Text = "frmListado";
            this.Load += new System.EventHandler(this.frmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMostrar)).EndInit();
            this.mrcApellidop.ResumeLayout(false);
            this.mrcApellidop.PerformLayout();
            this.mrcBuscaar.ResumeLayout(false);
            this.mrcBuscaar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMostrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.GroupBox mrcApellidop;
        private System.Windows.Forms.GroupBox mrcBuscaar;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Button btnAcep;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDireccion;
    }
}