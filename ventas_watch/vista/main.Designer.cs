namespace ventas_watch
{
    partial class main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nUEVOCLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vERCLIENTESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENTASToolStripMenuItem,
            this.pRODUCTOSToolStripMenuItem,
            this.cLIENTESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(578, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vENTASToolStripMenuItem
            // 
            this.vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            this.vENTASToolStripMenuItem.Size = new System.Drawing.Size(60, 22);
            this.vENTASToolStripMenuItem.Text = "VENTAS";
            // 
            // pRODUCTOSToolStripMenuItem
            // 
            this.pRODUCTOSToolStripMenuItem.Name = "pRODUCTOSToolStripMenuItem";
            this.pRODUCTOSToolStripMenuItem.Size = new System.Drawing.Size(86, 22);
            this.pRODUCTOSToolStripMenuItem.Text = "PRODUCTOS";
            // 
            // cLIENTESToolStripMenuItem
            // 
            this.cLIENTESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nUEVOCLIENTEToolStripMenuItem,
            this.vERCLIENTESToolStripMenuItem});
            this.cLIENTESToolStripMenuItem.Name = "cLIENTESToolStripMenuItem";
            this.cLIENTESToolStripMenuItem.Size = new System.Drawing.Size(69, 22);
            this.cLIENTESToolStripMenuItem.Text = "CLIENTES";
            // 
            // nUEVOCLIENTEToolStripMenuItem
            // 
            this.nUEVOCLIENTEToolStripMenuItem.Name = "nUEVOCLIENTEToolStripMenuItem";
            this.nUEVOCLIENTEToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nUEVOCLIENTEToolStripMenuItem.Text = "NUEVO CLIENTE";
            this.nUEVOCLIENTEToolStripMenuItem.Click += new System.EventHandler(this.nUEVOCLIENTEToolStripMenuItem_Click);
            // 
            // vERCLIENTESToolStripMenuItem
            // 
            this.vERCLIENTESToolStripMenuItem.Name = "vERCLIENTESToolStripMenuItem";
            this.vERCLIENTESToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.vERCLIENTESToolStripMenuItem.Text = "VER CLIENTES";
            this.vERCLIENTESToolStripMenuItem.Click += new System.EventHandler(this.vERCLIENTESToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 311);
            this.Controls.Add(this.menuStrip1);
            this.Name = "main";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIENTESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nUEVOCLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vERCLIENTESToolStripMenuItem;
    }
}

