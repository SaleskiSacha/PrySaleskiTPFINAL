﻿namespace PrySaleskiTPFINAL
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.barraDeEstado = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioTS = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerHora = new System.Windows.Forms.Timer(this.components);
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.barraDeEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(342, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 20);
            this.toolStripMenuItem1.Text = "Registro de empleados";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(134, 20);
            this.toolStripMenuItem2.Text = "Listado de empleados";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(50, 20);
            this.toolStripMenuItem3.Text = "Editor";
            // 
            // barraDeEstado
            // 
            this.barraDeEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus,
            this.lblUsuarioTS});
            this.barraDeEstado.Location = new System.Drawing.Point(0, 120);
            this.barraDeEstado.Name = "barraDeEstado";
            this.barraDeEstado.Size = new System.Drawing.Size(342, 22);
            this.barraDeEstado.TabIndex = 15;
            this.barraDeEstado.Text = "statusStrip1";
            this.barraDeEstado.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.barraDeEstado_ItemClicked);
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(28, 17);
            this.lblStatus.Text = "BD: ";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // lblUsuarioTS
            // 
            this.lblUsuarioTS.Name = "lblUsuarioTS";
            this.lblUsuarioTS.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblUsuarioTS.Size = new System.Drawing.Size(0, 17);
            // 
            // timerHora
            // 
            this.timerHora.Enabled = true;
            this.timerHora.Tick += new System.EventHandler(this.timerHora_Tick);
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(-3, 94);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(10, 13);
            this.lblHora.TabIndex = 16;
            this.lblHora.Text = " ";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(-3, 107);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(0, 13);
            this.lblFecha.TabIndex = 17;
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 142);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.barraDeEstado);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.barraDeEstado.ResumeLayout(false);
            this.barraDeEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.StatusStrip barraDeEstado;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioTS;
        private System.Windows.Forms.Timer timerHora;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
    }
}

