namespace AppMaps
{
    partial class AppGMaps
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabMapa = new System.Windows.Forms.TabPage();
            this.Buscador = new System.Windows.Forms.TabPage();
            this.Reportes = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabMapa);
            this.tabControl1.Controls.Add(this.Buscador);
            this.tabControl1.Controls.Add(this.Reportes);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(695, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // TabMapa
            // 
            this.TabMapa.Location = new System.Drawing.Point(4, 22);
            this.TabMapa.Name = "TabMapa";
            this.TabMapa.Padding = new System.Windows.Forms.Padding(3);
            this.TabMapa.Size = new System.Drawing.Size(687, 346);
            this.TabMapa.TabIndex = 0;
            this.TabMapa.Text = "Mapa";
            this.TabMapa.UseVisualStyleBackColor = true;
            // 
            // Buscador
            // 
            this.Buscador.Location = new System.Drawing.Point(4, 22);
            this.Buscador.Name = "Buscador";
            this.Buscador.Padding = new System.Windows.Forms.Padding(3);
            this.Buscador.Size = new System.Drawing.Size(252, 211);
            this.Buscador.TabIndex = 1;
            this.Buscador.Text = "Navegar";
            this.Buscador.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            this.Reportes.Location = new System.Drawing.Point(4, 22);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(252, 211);
            this.Reportes.TabIndex = 2;
            this.Reportes.Text = "Reportes";
            this.Reportes.UseVisualStyleBackColor = true;
            // 
            // AppGMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 396);
            this.Controls.Add(this.tabControl1);
            this.Name = "AppGMaps";
            this.Text = "Grupos de Investigacion";
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabMapa;
        private System.Windows.Forms.TabPage Buscador;
        private System.Windows.Forms.TabPage Reportes;
    }
}

