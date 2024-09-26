namespace Promediador
{
    partial class Form1
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
            this.calcular_btn = new System.Windows.Forms.Button();
            this.nota1 = new System.Windows.Forms.NumericUpDown();
            this.nota2 = new System.Windows.Forms.NumericUpDown();
            this.nota3 = new System.Windows.Forms.NumericUpDown();
            this.nota4 = new System.Windows.Forms.NumericUpDown();
            this.aprobado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.promedioVentana = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.notaMayorVentana = new System.Windows.Forms.Label();
            this.notaMenorVentana = new System.Windows.Forms.Label();
            this.porcentaje1 = new System.Windows.Forms.NumericUpDown();
            this.porcentaje2 = new System.Windows.Forms.NumericUpDown();
            this.porcentaje3 = new System.Windows.Forms.NumericUpDown();
            this.porcentaje4 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nota1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje4)).BeginInit();
            this.SuspendLayout();
            // 
            // calcular_btn
            // 
            this.calcular_btn.Font = new System.Drawing.Font("Malgun Gothic Semilight", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcular_btn.Location = new System.Drawing.Point(113, 313);
            this.calcular_btn.Name = "calcular_btn";
            this.calcular_btn.Size = new System.Drawing.Size(192, 52);
            this.calcular_btn.TabIndex = 4;
            this.calcular_btn.Text = "Calcular";
            this.calcular_btn.UseVisualStyleBackColor = true;
            this.calcular_btn.Click += new System.EventHandler(this.calcular_btn_Click);
            // 
            // nota1
            // 
            this.nota1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota1.Location = new System.Drawing.Point(64, 76);
            this.nota1.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nota1.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(115, 52);
            this.nota1.TabIndex = 5;
            this.nota1.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nota1.ValueChanged += new System.EventHandler(this.nota1_ValueChanged);
            // 
            // nota2
            // 
            this.nota2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota2.Location = new System.Drawing.Point(64, 134);
            this.nota2.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nota2.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(115, 52);
            this.nota2.TabIndex = 6;
            this.nota2.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nota2.ValueChanged += new System.EventHandler(this.nota2_ValueChanged);
            // 
            // nota3
            // 
            this.nota3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota3.Location = new System.Drawing.Point(64, 192);
            this.nota3.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nota3.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(115, 52);
            this.nota3.TabIndex = 7;
            this.nota3.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nota3.ValueChanged += new System.EventHandler(this.nota3_ValueChanged);
            // 
            // nota4
            // 
            this.nota4.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nota4.Location = new System.Drawing.Point(64, 250);
            this.nota4.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.nota4.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nota4.Name = "nota4";
            this.nota4.Size = new System.Drawing.Size(115, 52);
            this.nota4.TabIndex = 8;
            this.nota4.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nota4.ValueChanged += new System.EventHandler(this.nota4_ValueChanged);
            // 
            // aprobado
            // 
            this.aprobado.AutoSize = true;
            this.aprobado.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aprobado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.aprobado.Location = new System.Drawing.Point(446, 312);
            this.aprobado.Name = "aprobado";
            this.aprobado.Size = new System.Drawing.Size(171, 46);
            this.aprobado.TabIndex = 9;
            this.aprobado.Text = "Aprobado";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 46);
            this.label2.TabIndex = 10;
            this.label2.Text = "Promedio:";
            // 
            // promedioVentana
            // 
            this.promedioVentana.AutoSize = true;
            this.promedioVentana.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.promedioVentana.Location = new System.Drawing.Point(617, 75);
            this.promedioVentana.Name = "promedioVentana";
            this.promedioVentana.Size = new System.Drawing.Size(57, 46);
            this.promedioVentana.TabIndex = 11;
            this.promedioVentana.Text = "40";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 133);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(205, 46);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nota mayor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(394, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 46);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nota menor:";
            // 
            // notaMayorVentana
            // 
            this.notaMayorVentana.AutoSize = true;
            this.notaMayorVentana.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaMayorVentana.Location = new System.Drawing.Point(617, 133);
            this.notaMayorVentana.Name = "notaMayorVentana";
            this.notaMayorVentana.Size = new System.Drawing.Size(57, 46);
            this.notaMayorVentana.TabIndex = 14;
            this.notaMayorVentana.Text = "40";
            // 
            // notaMenorVentana
            // 
            this.notaMenorVentana.AutoSize = true;
            this.notaMenorVentana.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaMenorVentana.Location = new System.Drawing.Point(619, 191);
            this.notaMenorVentana.Name = "notaMenorVentana";
            this.notaMenorVentana.Size = new System.Drawing.Size(57, 46);
            this.notaMenorVentana.TabIndex = 15;
            this.notaMenorVentana.Text = "40";
            // 
            // porcentaje1
            // 
            this.porcentaje1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentaje1.Location = new System.Drawing.Point(203, 76);
            this.porcentaje1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.porcentaje1.Name = "porcentaje1";
            this.porcentaje1.Size = new System.Drawing.Size(102, 52);
            this.porcentaje1.TabIndex = 16;
            this.porcentaje1.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // porcentaje2
            // 
            this.porcentaje2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentaje2.Location = new System.Drawing.Point(203, 134);
            this.porcentaje2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.porcentaje2.Name = "porcentaje2";
            this.porcentaje2.Size = new System.Drawing.Size(102, 52);
            this.porcentaje2.TabIndex = 17;
            this.porcentaje2.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // porcentaje3
            // 
            this.porcentaje3.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentaje3.Location = new System.Drawing.Point(203, 192);
            this.porcentaje3.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.porcentaje3.Name = "porcentaje3";
            this.porcentaje3.Size = new System.Drawing.Size(102, 52);
            this.porcentaje3.TabIndex = 18;
            this.porcentaje3.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // porcentaje4
            // 
            this.porcentaje4.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.porcentaje4.Location = new System.Drawing.Point(203, 250);
            this.porcentaje4.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.porcentaje4.Name = "porcentaje4";
            this.porcentaje4.Size = new System.Drawing.Size(102, 52);
            this.porcentaje4.TabIndex = 19;
            this.porcentaje4.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 46);
            this.label4.TabIndex = 20;
            this.label4.Text = "Notas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Malgun Gothic Semilight", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(226, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 46);
            this.label5.TabIndex = 21;
            this.label5.Text = "%";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.porcentaje4);
            this.Controls.Add(this.porcentaje3);
            this.Controls.Add(this.porcentaje2);
            this.Controls.Add(this.porcentaje1);
            this.Controls.Add(this.notaMenorVentana);
            this.Controls.Add(this.notaMayorVentana);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.promedioVentana);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.aprobado);
            this.Controls.Add(this.nota4);
            this.Controls.Add(this.nota3);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota1);
            this.Controls.Add(this.calcular_btn);
            this.Name = "Form1";
            this.Text = "Promediador";
            ((System.ComponentModel.ISupportInitialize)(this.nota1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nota4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.porcentaje4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calcular_btn;
        private System.Windows.Forms.NumericUpDown nota1;
        private System.Windows.Forms.NumericUpDown nota2;
        private System.Windows.Forms.NumericUpDown nota3;
        private System.Windows.Forms.NumericUpDown nota4;
        private System.Windows.Forms.Label aprobado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label promedioVentana;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label notaMayorVentana;
        private System.Windows.Forms.Label notaMenorVentana;
        private System.Windows.Forms.NumericUpDown porcentaje1;
        private System.Windows.Forms.NumericUpDown porcentaje2;
        private System.Windows.Forms.NumericUpDown porcentaje3;
        private System.Windows.Forms.NumericUpDown porcentaje4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

