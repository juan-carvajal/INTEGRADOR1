namespace AppMaps
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.codigo = new System.Windows.Forms.TextBox();
            this.nombre = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.MonthCalendar();
            this.ciudad = new System.Windows.Forms.ComboBox();
            this.dpto = new System.Windows.Forms.ComboBox();
            this.pais = new System.Windows.Forms.ComboBox();
            this.region = new System.Windows.Forms.ComboBox();
            this.area = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 0;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha Creación:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ciudad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 314);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Departamento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(38, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "País:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(38, 374);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Región:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 404);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 20);
            this.label9.TabIndex = 8;
            this.label9.Text = "Area:";
            // 
            // codigo
            // 
            this.codigo.Location = new System.Drawing.Point(195, 23);
            this.codigo.Name = "codigo";
            this.codigo.Size = new System.Drawing.Size(248, 20);
            this.codigo.TabIndex = 9;
            this.codigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(195, 62);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(248, 20);
            this.nombre.TabIndex = 10;
            this.nombre.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(195, 102);
            this.fecha.Name = "fecha";
            this.fecha.TabIndex = 11;
            this.fecha.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // ciudad
            // 
            this.ciudad.FormattingEnabled = true;
            this.ciudad.Location = new System.Drawing.Point(195, 283);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(248, 21);
            this.ciudad.TabIndex = 12;
            this.ciudad.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dpto
            // 
            this.dpto.FormattingEnabled = true;
            this.dpto.Location = new System.Drawing.Point(195, 313);
            this.dpto.Name = "dpto";
            this.dpto.Size = new System.Drawing.Size(248, 21);
            this.dpto.TabIndex = 13;
            this.dpto.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // pais
            // 
            this.pais.FormattingEnabled = true;
            this.pais.Location = new System.Drawing.Point(195, 344);
            this.pais.Name = "pais";
            this.pais.Size = new System.Drawing.Size(248, 21);
            this.pais.TabIndex = 14;
            this.pais.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // region
            // 
            this.region.FormattingEnabled = true;
            this.region.Location = new System.Drawing.Point(195, 373);
            this.region.Name = "region";
            this.region.Size = new System.Drawing.Size(248, 21);
            this.region.TabIndex = 15;
            this.region.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // area
            // 
            this.area.FormattingEnabled = true;
            this.area.Location = new System.Drawing.Point(195, 403);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(248, 21);
            this.area.TabIndex = 16;
            this.area.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(195, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 17;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 482);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.area);
            this.Controls.Add(this.region);
            this.Controls.Add(this.pais);
            this.Controls.Add(this.dpto);
            this.Controls.Add(this.ciudad);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.codigo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Agregar Registro";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox codigo;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.MonthCalendar fecha;
        private System.Windows.Forms.ComboBox ciudad;
        private System.Windows.Forms.ComboBox dpto;
        private System.Windows.Forms.ComboBox pais;
        private System.Windows.Forms.ComboBox region;
        private System.Windows.Forms.ComboBox area;
        private System.Windows.Forms.Button button1;
    }
}