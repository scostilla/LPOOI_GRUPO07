namespace Vistas
{
    partial class FrmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDePeriodosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeDireccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aBMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consutasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sistemaToolStripMenuItem,
            this.aBMToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeClientesToolStripMenuItem,
            this.altaDePeriodosToolStripMenuItem,
            this.altaDeDireccionToolStripMenuItem});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // altaDeClientesToolStripMenuItem
            // 
            this.altaDeClientesToolStripMenuItem.Name = "altaDeClientesToolStripMenuItem";
            this.altaDeClientesToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.altaDeClientesToolStripMenuItem.Text = "Alta de Clientes";
            this.altaDeClientesToolStripMenuItem.Click += new System.EventHandler(this.altaDeClientesToolStripMenuItem_Click);
            // 
            // altaDePeriodosToolStripMenuItem
            // 
            this.altaDePeriodosToolStripMenuItem.Name = "altaDePeriodosToolStripMenuItem";
            this.altaDePeriodosToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.altaDePeriodosToolStripMenuItem.Text = "Alta de Periodos";
            this.altaDePeriodosToolStripMenuItem.Click += new System.EventHandler(this.altaDePeriodosToolStripMenuItem_Click);
            // 
            // altaDeDireccionToolStripMenuItem
            // 
            this.altaDeDireccionToolStripMenuItem.Name = "altaDeDireccionToolStripMenuItem";
            this.altaDeDireccionToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.altaDeDireccionToolStripMenuItem.Text = "Alta de Destinos";
            this.altaDeDireccionToolStripMenuItem.Click += new System.EventHandler(this.altaDeDireccionToolStripMenuItem_Click);
            // 
            // aBMToolStripMenuItem
            // 
            this.aBMToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultasToolStripMenuItem,
            this.consutasToolStripMenuItem});
            this.aBMToolStripMenuItem.Name = "aBMToolStripMenuItem";
            this.aBMToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
            this.aBMToolStripMenuItem.Text = "Gestion de Usuarios";
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consultasToolStripMenuItem.Text = "Agregar";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // consutasToolStripMenuItem
            // 
            this.consutasToolStripMenuItem.Name = "consutasToolStripMenuItem";
            this.consutasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.consutasToolStripMenuItem.Text = "Consutas";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDePeriodosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeDireccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aBMToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consutasToolStripMenuItem;
    }
}