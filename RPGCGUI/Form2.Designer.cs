namespace RPGCGUI
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
            this.attaque1 = new System.Windows.Forms.Button();
            this.attaque2 = new System.Windows.Forms.Button();
            this.attaque3 = new System.Windows.Forms.Button();
            this.attaque4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // attaque1
            // 
            this.attaque1.Location = new System.Drawing.Point(12, 12);
            this.attaque1.Name = "attaque1";
            this.attaque1.Size = new System.Drawing.Size(144, 52);
            this.attaque1.TabIndex = 0;
            this.attaque1.Text = "attaque1";
            this.attaque1.UseVisualStyleBackColor = true;
            this.attaque1.Click += new System.EventHandler(this.attaque1_Click);
            // 
            // attaque2
            // 
            this.attaque2.Location = new System.Drawing.Point(352, 15);
            this.attaque2.Name = "attaque2";
            this.attaque2.Size = new System.Drawing.Size(144, 49);
            this.attaque2.TabIndex = 1;
            this.attaque2.Text = "attaque2";
            this.attaque2.UseVisualStyleBackColor = true;
            // 
            // attaque3
            // 
            this.attaque3.Location = new System.Drawing.Point(12, 170);
            this.attaque3.Name = "attaque3";
            this.attaque3.Size = new System.Drawing.Size(144, 49);
            this.attaque3.TabIndex = 2;
            this.attaque3.Text = "attaque3";
            this.attaque3.UseVisualStyleBackColor = true;
            // 
            // attaque4
            // 
            this.attaque4.Location = new System.Drawing.Point(352, 170);
            this.attaque4.Name = "attaque4";
            this.attaque4.Size = new System.Drawing.Size(144, 49);
            this.attaque4.TabIndex = 3;
            this.attaque4.Text = "attaque4";
            this.attaque4.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 231);
            this.Controls.Add(this.attaque4);
            this.Controls.Add(this.attaque3);
            this.Controls.Add(this.attaque2);
            this.Controls.Add(this.attaque1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button attaque1;
        private System.Windows.Forms.Button attaque2;
        private System.Windows.Forms.Button attaque3;
        private System.Windows.Forms.Button attaque4;
    }
}