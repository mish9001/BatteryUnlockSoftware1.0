namespace BatteryUnlockSoftware1._0
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.BtnAuthenticate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(419, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 64);
            this.label1.TabIndex = 0;
            this.label1.Text = "UnlockME 1.0";
            // 
            // BtnAuthenticate
            // 
            this.BtnAuthenticate.Location = new System.Drawing.Point(997, 190);
            this.BtnAuthenticate.Name = "BtnAuthenticate";
            this.BtnAuthenticate.Size = new System.Drawing.Size(272, 87);
            this.BtnAuthenticate.TabIndex = 1;
            this.BtnAuthenticate.Text = "Authenticate Access";
            this.BtnAuthenticate.UseVisualStyleBackColor = true;
            this.BtnAuthenticate.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(1012, 531);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(272, 87);
            this.button2.TabIndex = 2;
            this.button2.Text = "Unlock Stack";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1363, 700);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnAuthenticate);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "UnlockME 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnAuthenticate;
        private System.Windows.Forms.Button button2;
    }
}

