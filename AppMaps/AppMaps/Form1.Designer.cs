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
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.Buscador = new System.Windows.Forms.TabPage();
            this.Reportes = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.TabMapa.SuspendLayout();
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
            this.TabMapa.Controls.Add(this.gmap);
            this.TabMapa.Location = new System.Drawing.Point(4, 22);
            this.TabMapa.Name = "TabMapa";
            this.TabMapa.Padding = new System.Windows.Forms.Padding(3);
            this.TabMapa.Size = new System.Drawing.Size(687, 346);
            this.TabMapa.TabIndex = 0;
            this.TabMapa.Text = "Mapa";
            this.TabMapa.UseVisualStyleBackColor = true;
            this.TabMapa.Click += new System.EventHandler(this.TabMapa_Click);
            // 
            // gmap
            // 
            this.gmap.Bearing = 0F;
            this.gmap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gmap.CanDragMap = true;
            this.gmap.EmptyTileColor = System.Drawing.Color.Navy;
            this.gmap.GrayScaleMode = false;
            this.gmap.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gmap.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.gmap.LevelsKeepInMemmory = 5;
            this.gmap.Location = new System.Drawing.Point(0, 0);
            this.gmap.MarkersEnabled = true;
            this.gmap.MaxZoom = 20;
            this.gmap.MinZoom = 2;
            this.gmap.MouseWheelZoomEnabled = true;
            this.gmap.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gmap.Name = "gmap";
            this.gmap.NegativeMode = false;
            this.gmap.PolygonsEnabled = true;
            this.gmap.RetryLoadTile = 0;
            this.gmap.RoutesEnabled = true;
            this.gmap.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gmap.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gmap.ShowTileGridLines = false;
            this.gmap.Size = new System.Drawing.Size(687, 346);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 0D;
            this.gmap.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // Buscador
            // 
            this.Buscador.Location = new System.Drawing.Point(4, 22);
            this.Buscador.Name = "Buscador";
            this.Buscador.Padding = new System.Windows.Forms.Padding(3);
            this.Buscador.Size = new System.Drawing.Size(687, 346);
            this.Buscador.TabIndex = 1;
            this.Buscador.Text = "Navegar";
            this.Buscador.UseVisualStyleBackColor = true;
            // 
            // Reportes
            // 
            this.Reportes.Location = new System.Drawing.Point(4, 22);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(687, 346);
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
            this.TabMapa.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabMapa;
        private System.Windows.Forms.TabPage Buscador;
        private System.Windows.Forms.TabPage Reportes;
        private GMap.NET.WindowsForms.GMapControl gmap;
    }
}

