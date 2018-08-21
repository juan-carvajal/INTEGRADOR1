﻿namespace AppMaps
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.TabMapa = new System.Windows.Forms.TabPage();
            this.gmap = new GMap.NET.WindowsForms.GMapControl();
            this.Buscador = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Reportes = new System.Windows.Forms.TabPage();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Codigo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Ubicacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.ubicar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DataMining = new System.Windows.Forms.TabPage();
            this.calcular = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Combinacion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FrecuenciaAbsoluta = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FrecuenciaRelativa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl1.SuspendLayout();
            this.TabMapa.SuspendLayout();
            this.Buscador.SuspendLayout();
            this.Reportes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.DataMining.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.TabMapa);
            this.tabControl1.Controls.Add(this.Buscador);
            this.tabControl1.Controls.Add(this.Reportes);
            this.tabControl1.Controls.Add(this.DataMining);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 372);
            this.tabControl1.TabIndex = 0;
            // 
            // TabMapa
            // 
            this.TabMapa.Controls.Add(this.gmap);
            this.TabMapa.Location = new System.Drawing.Point(4, 22);
            this.TabMapa.Name = "TabMapa";
            this.TabMapa.Padding = new System.Windows.Forms.Padding(3);
            this.TabMapa.Size = new System.Drawing.Size(767, 346);
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
            this.gmap.Size = new System.Drawing.Size(767, 346);
            this.gmap.TabIndex = 0;
            this.gmap.Zoom = 0D;
            this.gmap.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // Buscador
            // 
            this.Buscador.Controls.Add(this.label3);
            this.Buscador.Controls.Add(this.ubicar);
            this.Buscador.Controls.Add(this.comboBox3);
            this.Buscador.Controls.Add(this.listView1);
            this.Buscador.Controls.Add(this.button1);
            this.Buscador.Controls.Add(this.comboBox1);
            this.Buscador.Controls.Add(this.label1);
            this.Buscador.Location = new System.Drawing.Point(4, 22);
            this.Buscador.Name = "Buscador";
            this.Buscador.Padding = new System.Windows.Forms.Padding(3);
            this.Buscador.Size = new System.Drawing.Size(767, 346);
            this.Buscador.TabIndex = 1;
            this.Buscador.Text = "Navegar";
            this.Buscador.UseVisualStyleBackColor = true;
            this.Buscador.Click += new System.EventHandler(this.Buscador_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Codigo,
            this.Nombre,
            this.Ubicacion});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(84, 80);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(633, 196);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(84, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Ciudad",
            "Nombre",
            "Departamento",
            "Región",
            "Área Investigación",
            "Codigo"});
            this.comboBox1.Location = new System.Drawing.Point(107, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 24);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filtros:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reportes
            // 
            this.Reportes.Controls.Add(this.chart1);
            this.Reportes.Controls.Add(this.textBox2);
            this.Reportes.Controls.Add(this.comboBox2);
            this.Reportes.Controls.Add(this.label2);
            this.Reportes.Location = new System.Drawing.Point(4, 22);
            this.Reportes.Name = "Reportes";
            this.Reportes.Size = new System.Drawing.Size(767, 346);
            this.Reportes.TabIndex = 2;
            this.Reportes.Text = "Reportes";
            this.Reportes.UseVisualStyleBackColor = true;
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(107, 73);
            this.chart1.Name = "chart1";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(463, 270);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(355, 43);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(215, 22);
            this.textBox2.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Ciudad",
            "Departamento",
            "Región",
            "Área Investigación"});
            this.comboBox2.Location = new System.Drawing.Point(107, 43);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 24);
            this.comboBox2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(103, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Filtros:";
            // 
            // Codigo
            // 
            this.Codigo.Text = "Codigo";
            this.Codigo.Width = 106;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 354;
            // 
            // Ubicacion
            // 
            this.Ubicacion.Text = "Ubicacion";
            this.Ubicacion.Width = 202;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(365, 40);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(212, 24);
            this.comboBox3.TabIndex = 5;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // ubicar
            // 
            this.ubicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ubicar.Location = new System.Drawing.Point(193, 291);
            this.ubicar.Name = "ubicar";
            this.ubicar.Size = new System.Drawing.Size(156, 28);
            this.ubicar.TabIndex = 6;
            this.ubicar.Text = "Ubicar En Mapa";
            this.ubicar.UseVisualStyleBackColor = true;
            this.ubicar.Click += new System.EventHandler(this.ubicar_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(361, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Opciones:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DataMining
            // 
            this.DataMining.Controls.Add(this.listView2);
            this.DataMining.Controls.Add(this.calcular);
            this.DataMining.Location = new System.Drawing.Point(4, 22);
            this.DataMining.Name = "DataMining";
            this.DataMining.Size = new System.Drawing.Size(767, 346);
            this.DataMining.TabIndex = 3;
            this.DataMining.Text = "Data Mining";
            this.DataMining.UseVisualStyleBackColor = true;
            // 
            // calcular
            // 
            this.calcular.Location = new System.Drawing.Point(346, 320);
            this.calcular.Name = "calcular";
            this.calcular.Size = new System.Drawing.Size(75, 23);
            this.calcular.TabIndex = 0;
            this.calcular.Text = "Calcular";
            this.calcular.UseVisualStyleBackColor = true;
            this.calcular.Click += new System.EventHandler(this.calcular_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Combinacion,
            this.FrecuenciaAbsoluta,
            this.FrecuenciaRelativa});
            this.listView2.FullRowSelect = true;
            this.listView2.GridLines = true;
            this.listView2.Location = new System.Drawing.Point(3, 3);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(761, 311);
            this.listView2.TabIndex = 1;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
          
            // 
            // Combinacion
            // 
            this.Combinacion.Text = "Combinacion";
            this.Combinacion.Width = 259;
            // 
            // FrecuenciaAbsoluta
            // 
            this.FrecuenciaAbsoluta.Text = "Frecuencia Absoluta";
            this.FrecuenciaAbsoluta.Width = 278;
            // 
            // FrecuenciaRelativa
            // 
            this.FrecuenciaRelativa.Text = "Frecuencia Relativa";
            this.FrecuenciaRelativa.Width = 231;
            // 
            // AppGMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 396);
            this.Controls.Add(this.tabControl1);
            this.Name = "AppGMaps";
            this.Text = "Grupos de Investigacion";
            this.tabControl1.ResumeLayout(false);
            this.TabMapa.ResumeLayout(false);
            this.Buscador.ResumeLayout(false);
            this.Buscador.PerformLayout();
            this.Reportes.ResumeLayout(false);
            this.Reportes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.DataMining.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage TabMapa;
        private System.Windows.Forms.TabPage Buscador;
        private System.Windows.Forms.TabPage Reportes;
        private GMap.NET.WindowsForms.GMapControl gmap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ColumnHeader Codigo;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Ubicacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ubicar;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.TabPage DataMining;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Combinacion;
        private System.Windows.Forms.ColumnHeader FrecuenciaAbsoluta;
        private System.Windows.Forms.ColumnHeader FrecuenciaRelativa;
        private System.Windows.Forms.Button calcular;
    }
}

