namespace Práctica.Ejercicio01
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BPrimero = new System.Windows.Forms.Button();
            this.BSegundo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BPrimero
            // 
            this.BPrimero.Location = new System.Drawing.Point(537, 53);
            this.BPrimero.Name = "BPrimero";
            this.BPrimero.Size = new System.Drawing.Size(112, 34);
            this.BPrimero.TabIndex = 0;
            this.BPrimero.Text = "Boton 1";
            this.BPrimero.UseVisualStyleBackColor = true;
            this.BPrimero.Click += new System.EventHandler(this.button1_Click);
            // 
            // BSegundo
            // 
            this.BSegundo.Location = new System.Drawing.Point(525, 188);
            this.BSegundo.Name = "BSegundo";
            this.BSegundo.Size = new System.Drawing.Size(112, 34);
            this.BSegundo.TabIndex = 1;
            this.BSegundo.Text = "Botón 2";
            this.BSegundo.UseVisualStyleBackColor = true;
            this.BSegundo.Click += new System.EventHandler(this.BSegundo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BSegundo);
            this.Controls.Add(this.BPrimero);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BPrimero;
        private System.Windows.Forms.Button BSegundo;
    }
}

