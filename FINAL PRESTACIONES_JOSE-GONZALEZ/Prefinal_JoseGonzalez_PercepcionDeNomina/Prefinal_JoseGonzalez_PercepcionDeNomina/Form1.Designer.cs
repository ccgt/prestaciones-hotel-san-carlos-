namespace Prefinal_JoseGonzalez_PercepcionDeNomina
{
    partial class Form1
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
            this.pERCEPCIONESToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bono14ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aguinaldoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horasExtrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horaExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.despidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pERCEPCIONESToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(725, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pERCEPCIONESToolStripMenuItem
            // 
            this.pERCEPCIONESToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bono14ToolStripMenuItem,
            this.aguinaldoToolStripMenuItem,
            this.horasExtrasToolStripMenuItem,
            this.horaExtraToolStripMenuItem,
            this.despidoToolStripMenuItem});
            this.pERCEPCIONESToolStripMenuItem.Name = "pERCEPCIONESToolStripMenuItem";
            this.pERCEPCIONESToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.pERCEPCIONESToolStripMenuItem.Text = "PERCEPCIONES";
            // 
            // bono14ToolStripMenuItem
            // 
            this.bono14ToolStripMenuItem.Name = "bono14ToolStripMenuItem";
            this.bono14ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bono14ToolStripMenuItem.Text = "Bono 14";
            this.bono14ToolStripMenuItem.Click += new System.EventHandler(this.bono14ToolStripMenuItem_Click);
            // 
            // aguinaldoToolStripMenuItem
            // 
            this.aguinaldoToolStripMenuItem.Name = "aguinaldoToolStripMenuItem";
            this.aguinaldoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aguinaldoToolStripMenuItem.Text = "Aguinaldo";
            this.aguinaldoToolStripMenuItem.Click += new System.EventHandler(this.aguinaldoToolStripMenuItem_Click);
            // 
            // horasExtrasToolStripMenuItem
            // 
            this.horasExtrasToolStripMenuItem.Name = "horasExtrasToolStripMenuItem";
            this.horasExtrasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.horasExtrasToolStripMenuItem.Text = "Hora Extra";
            this.horasExtrasToolStripMenuItem.Click += new System.EventHandler(this.horasExtrasToolStripMenuItem_Click);
            // 
            // horaExtraToolStripMenuItem
            // 
            this.horaExtraToolStripMenuItem.Name = "horaExtraToolStripMenuItem";
            this.horaExtraToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.horaExtraToolStripMenuItem.Text = "Vacaciones";
            this.horaExtraToolStripMenuItem.Click += new System.EventHandler(this.horaExtraToolStripMenuItem_Click);
            // 
            // despidoToolStripMenuItem
            // 
            this.despidoToolStripMenuItem.Name = "despidoToolStripMenuItem";
            this.despidoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.despidoToolStripMenuItem.Text = "Despido";
            this.despidoToolStripMenuItem.Click += new System.EventHandler(this.despidoToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pERCEPCIONESToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bono14ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aguinaldoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horasExtrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horaExtraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem despidoToolStripMenuItem;
    }
}

