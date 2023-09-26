namespace button._9
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
            this.btntopla = new System.Windows.Forms.Button();
            this.btncikar = new System.Windows.Forms.Button();
            this.btncarp = new System.Windows.Forms.Button();
            this.btnböl = new System.Windows.Forms.Button();
            this.lblsayi1 = new System.Windows.Forms.Label();
            this.lblsayi2 = new System.Windows.Forms.Label();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.txtsayi1 = new System.Windows.Forms.TextBox();
            this.txtsayi2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btntopla
            // 
            this.btntopla.Location = new System.Drawing.Point(186, 47);
            this.btntopla.Name = "btntopla";
            this.btntopla.Size = new System.Drawing.Size(95, 74);
            this.btntopla.TabIndex = 0;
            this.btntopla.Text = "TOPLA";
            this.btntopla.UseVisualStyleBackColor = true;
            this.btntopla.Click += new System.EventHandler(this.btntopla_Click);
            // 
            // btncikar
            // 
            this.btncikar.Location = new System.Drawing.Point(314, 47);
            this.btncikar.Name = "btncikar";
            this.btncikar.Size = new System.Drawing.Size(95, 74);
            this.btncikar.TabIndex = 1;
            this.btncikar.Text = "ÇIKAR";
            this.btncikar.UseVisualStyleBackColor = true;
            this.btncikar.Click += new System.EventHandler(this.btncikar_Click);
            // 
            // btncarp
            // 
            this.btncarp.Location = new System.Drawing.Point(186, 167);
            this.btncarp.Name = "btncarp";
            this.btncarp.Size = new System.Drawing.Size(95, 74);
            this.btncarp.TabIndex = 2;
            this.btncarp.Text = "ÇARP";
            this.btncarp.UseVisualStyleBackColor = true;
            this.btncarp.Click += new System.EventHandler(this.btncarp_Click);
            // 
            // btnböl
            // 
            this.btnböl.Location = new System.Drawing.Point(314, 167);
            this.btnböl.Name = "btnböl";
            this.btnböl.Size = new System.Drawing.Size(95, 74);
            this.btnböl.TabIndex = 3;
            this.btnböl.Text = "BÖL";
            this.btnböl.UseVisualStyleBackColor = true;
            this.btnböl.Click += new System.EventHandler(this.btnböl_Click);
            // 
            // lblsayi1
            // 
            this.lblsayi1.AutoSize = true;
            this.lblsayi1.Location = new System.Drawing.Point(12, 118);
            this.lblsayi1.Name = "lblsayi1";
            this.lblsayi1.Size = new System.Drawing.Size(36, 13);
            this.lblsayi1.TabIndex = 4;
            this.lblsayi1.Text = "Sayı 1";
            // 
            // lblsayi2
            // 
            this.lblsayi2.AutoSize = true;
            this.lblsayi2.Location = new System.Drawing.Point(12, 195);
            this.lblsayi2.Name = "lblsayi2";
            this.lblsayi2.Size = new System.Drawing.Size(36, 13);
            this.lblsayi2.TabIndex = 5;
            this.lblsayi2.Text = "Sayı 2";
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.Location = new System.Drawing.Point(34, 299);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(47, 13);
            this.lblsonuc.TabIndex = 6;
            this.lblsonuc.Text = "Sonuç =";
            // 
            // txtsayi1
            // 
            this.txtsayi1.Location = new System.Drawing.Point(75, 118);
            this.txtsayi1.Name = "txtsayi1";
            this.txtsayi1.Size = new System.Drawing.Size(81, 20);
            this.txtsayi1.TabIndex = 7;
            // 
            // txtsayi2
            // 
            this.txtsayi2.Location = new System.Drawing.Point(75, 195);
            this.txtsayi2.Name = "txtsayi2";
            this.txtsayi2.Size = new System.Drawing.Size(81, 20);
            this.txtsayi2.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(421, 397);
            this.Controls.Add(this.txtsayi2);
            this.Controls.Add(this.txtsayi1);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.lblsayi2);
            this.Controls.Add(this.lblsayi1);
            this.Controls.Add(this.btnböl);
            this.Controls.Add(this.btncarp);
            this.Controls.Add(this.btncikar);
            this.Controls.Add(this.btntopla);
            this.Name = "Form1";
            this.Text = "ÇIKIŞ DÖNER TARİHE GÖMMEYE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btntopla;
        private System.Windows.Forms.Button btncikar;
        private System.Windows.Forms.Button btncarp;
        private System.Windows.Forms.Button btnböl;
        private System.Windows.Forms.Label lblsayi1;
        private System.Windows.Forms.Label lblsayi2;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.TextBox txtsayi1;
        private System.Windows.Forms.TextBox txtsayi2;
    }
}

