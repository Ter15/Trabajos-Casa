namespace Práctica.Ejercicio05
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BSuma = new System.Windows.Forms.Button();
            this.BResta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.BResto = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.BDivision = new System.Windows.Forms.Button();
            this.BMultiplicar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BSuma
            // 
            this.BSuma.Location = new System.Drawing.Point(462, 76);
            this.BSuma.Name = "BSuma";
            this.BSuma.Size = new System.Drawing.Size(154, 74);
            this.BSuma.TabIndex = 0;
            this.BSuma.Text = "Suma";
            this.BSuma.UseVisualStyleBackColor = true;
            this.BSuma.Click += new System.EventHandler(this.BSuma_Click);
            // 
            // BResta
            // 
            this.BResta.Location = new System.Drawing.Point(462, 181);
            this.BResta.Name = "BResta";
            this.BResta.Size = new System.Drawing.Size(154, 74);
            this.BResta.TabIndex = 1;
            this.BResta.Text = "Resta";
            this.BResta.UseVisualStyleBackColor = true;
            this.BResta.Click += new System.EventHandler(this.BResta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Número 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 307);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Resultado";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(246, 98);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(150, 31);
            this.textBox1.TabIndex = 5;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(246, 181);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(150, 31);
            this.textBox2.TabIndex = 6;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(246, 316);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 31);
            this.textBox3.TabIndex = 7;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // BResto
            // 
            this.BResto.Location = new System.Drawing.Point(637, 221);
            this.BResto.Name = "BResto";
            this.BResto.Size = new System.Drawing.Size(112, 34);
            this.BResto.TabIndex = 8;
            this.BResto.Text = "% ";
            this.BResto.UseVisualStyleBackColor = true;
            this.BResto.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1585, 794);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 9;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // BDivision
            // 
            this.BDivision.Location = new System.Drawing.Point(637, 156);
            this.BDivision.Name = "BDivision";
            this.BDivision.Size = new System.Drawing.Size(112, 34);
            this.BDivision.TabIndex = 0;
            this.BDivision.Text = "/";
            this.BDivision.UseVisualStyleBackColor = true;
            this.BDivision.Click += new System.EventHandler(this.button3_Click);
            // 
            // BMultiplicar
            // 
            this.BMultiplicar.Location = new System.Drawing.Point(637, 76);
            this.BMultiplicar.Name = "BMultiplicar";
            this.BMultiplicar.Size = new System.Drawing.Size(112, 34);
            this.BMultiplicar.TabIndex = 10;
            this.BMultiplicar.Text = "*";
            this.BMultiplicar.UseVisualStyleBackColor = true;
            this.BMultiplicar.Click += new System.EventHandler(this.BMultiplicar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 509);
            this.Controls.Add(this.BMultiplicar);
            this.Controls.Add(this.BDivision);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BResto);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BResta);
            this.Controls.Add(this.BSuma);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BSuma;
        private System.Windows.Forms.Button BResta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button BResto;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button BDivision;
        private System.Windows.Forms.Button BMultiplicar;
    }
}

