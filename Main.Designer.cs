namespace Codificador
{
    partial class Main
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
            this.btnCod = new System.Windows.Forms.Button();
            this.btnDec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCod
            // 
            this.btnCod.Location = new System.Drawing.Point(90, 98);
            this.btnCod.Name = "btnCod";
            this.btnCod.Size = new System.Drawing.Size(98, 33);
            this.btnCod.TabIndex = 0;
            this.btnCod.Text = "Codificar";
            this.btnCod.UseVisualStyleBackColor = true;
            this.btnCod.Click += new System.EventHandler(this.btnCod_Click);
            // 
            // btnDec
            // 
            this.btnDec.Location = new System.Drawing.Point(90, 161);
            this.btnDec.Name = "btnDec";
            this.btnDec.Size = new System.Drawing.Size(98, 33);
            this.btnDec.TabIndex = 1;
            this.btnDec.Text = "Decodificar";
            this.btnDec.UseVisualStyleBackColor = true;
            this.btnDec.Click += new System.EventHandler(this.btnDec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(54, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 38);
            this.label1.TabIndex = 2;
            this.label1.Text = "DECOTEXT";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDec);
            this.Controls.Add(this.btnCod);
            this.Name = "Main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCod;
        private System.Windows.Forms.Button btnDec;
        private System.Windows.Forms.Label label1;
    }
}