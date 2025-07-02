
namespace ATM
{
    partial class frmPrincipal
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
            this.mesPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmTareas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmEmpresa = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmFrom1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cuentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mesPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // mesPrincipal
            // 
            this.mesPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mesPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmTareas});
            this.mesPrincipal.Location = new System.Drawing.Point(0, 0);
            this.mesPrincipal.Name = "mesPrincipal";
            this.mesPrincipal.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.mesPrincipal.Size = new System.Drawing.Size(1375, 28);
            this.mesPrincipal.TabIndex = 1;
            this.mesPrincipal.Text = "menuStrip1";
            // 
            // tsmTareas
            // 
            this.tsmTareas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmEmpresa,
            this.tsmFrom1,
            this.cuentasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.tsmTareas.Name = "tsmTareas";
            this.tsmTareas.Size = new System.Drawing.Size(64, 24);
            this.tsmTareas.Text = "Tareas";
            // 
            // tsmEmpresa
            // 
            this.tsmEmpresa.Name = "tsmEmpresa";
            this.tsmEmpresa.Size = new System.Drawing.Size(185, 26);
            this.tsmEmpresa.Text = "Empresa...";
            this.tsmEmpresa.Click += new System.EventHandler(this.tsmEmpresa_Click);
            // 
            // tsmFrom1
            // 
            this.tsmFrom1.Name = "tsmFrom1";
            this.tsmFrom1.Size = new System.Drawing.Size(185, 26);
            this.tsmFrom1.Text = "Fromulario 1...";
            this.tsmFrom1.Click += new System.EventHandler(this.tsmFrom1_Click);
            // 
            // cuentasToolStripMenuItem
            // 
            this.cuentasToolStripMenuItem.Name = "cuentasToolStripMenuItem";
            this.cuentasToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.cuentasToolStripMenuItem.Text = "Cuentas";
            this.cuentasToolStripMenuItem.Click += new System.EventHandler(this.cuentasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(185, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 907);
            this.Controls.Add(this.mesPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mesPrincipal;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPrincipal";
            this.Text = "frmPrincipal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.mesPrincipal.ResumeLayout(false);
            this.mesPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mesPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmTareas;
        private System.Windows.Forms.ToolStripMenuItem tsmFrom1;
        private System.Windows.Forms.ToolStripMenuItem tsmEmpresa;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cuentasToolStripMenuItem;
    }
}