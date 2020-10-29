namespace Ejemplo01
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
            this.BPrimero = new System.Windows.Forms.Button();
            this.BSegundo = new System.Windows.Forms.Button();
            this.TCuadroTexto = new System.Windows.Forms.TextBox();
            this.LEtiqueta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BPrimero
            // 
            this.BPrimero.Location = new System.Drawing.Point(239, 129);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(112, 34);
            this.BPrimero.TabIndex = 0;
            this.BPrimero.Text = "Botón";
            this.BPrimero.UseVisualStyleBackColor = true;
            this.BPrimero.Click += new System.EventHandler(this.button1_Click);
            // 
            // BSegundo
            // 
            this.BSegundo.Location = new System.Drawing.Point(240, 193);
            this.BSegundo.Name = "BSegundo";
            this.BSegundo.Size = new System.Drawing.Size(112, 34);
            this.BSegundo.TabIndex = 1;
            this.BSegundo.Text = "Otro botón";
            this.BSegundo.UseVisualStyleBackColor = true;
            this.BSegundo.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // TCuadroTexto
            // 
            this.TCuadroTexto.Location = new System.Drawing.Point(240, 78);
            this.TCuadroTexto.Name = "TCuadroTexto";
            this.TCuadroTexto.Size = new System.Drawing.Size(150, 31);
            this.TCuadroTexto.TabIndex = 2;
            // 
            // LEtiqueta
            // 
            this.LEtiqueta.AutoSize = true;
            this.LEtiqueta.Location = new System.Drawing.Point(279, 26);
            this.LEtiqueta.Name = "LEtiqueta";
            this.LEtiqueta.Size = new System.Drawing.Size(63, 25);
            this.LEtiqueta.TabIndex = 3;
            this.LEtiqueta.Text = "TEXTO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LEtiqueta);
            this.Controls.Add(this.TCuadroTexto);
            this.Controls.Add(this.BSegundo);
            this.Controls.Add(this.BPrimero);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.Button BSegundo;
        private System.Windows.Forms.TextBox TCuadroTexto;
        private System.Windows.Forms.Label LEtiqueta;
    }
}

