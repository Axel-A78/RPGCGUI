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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // attaque1
            // 
            this.attaque1.Location = new System.Drawing.Point(2, 2);
            this.attaque1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.attaque1.Name = "attaque1";
            this.attaque1.Size = new System.Drawing.Size(188, 89);
            this.attaque1.TabIndex = 0;
            this.attaque1.Text = "attaque1";
            this.attaque1.UseVisualStyleBackColor = true;
            this.attaque1.Click += new System.EventHandler(this.attaque1_Click);
            // 
            // attaque2
            // 
            this.attaque2.Location = new System.Drawing.Point(194, 2);
            this.attaque2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.attaque2.Name = "attaque2";
            this.attaque2.Size = new System.Drawing.Size(188, 89);
            this.attaque2.TabIndex = 1;
            this.attaque2.Text = "attaque2";
            this.attaque2.UseVisualStyleBackColor = true;
            // 
            // attaque3
            // 
            this.attaque3.Location = new System.Drawing.Point(2, 95);
            this.attaque3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.attaque3.Name = "attaque3";
            this.attaque3.Size = new System.Drawing.Size(188, 90);
            this.attaque3.TabIndex = 2;
            this.attaque3.Text = "attaque3";
            this.attaque3.UseVisualStyleBackColor = true;
            // 
            // attaque4
            // 
            this.attaque4.Location = new System.Drawing.Point(194, 95);
            this.attaque4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.attaque4.Name = "attaque4";
            this.attaque4.Size = new System.Drawing.Size(188, 90);
            this.attaque4.TabIndex = 3;
            this.attaque4.Text = "attaque4";
            this.attaque4.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.attaque2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.attaque4, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.attaque1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.attaque3, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 187);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 188);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button attaque1;
        private System.Windows.Forms.Button attaque2;
        private System.Windows.Forms.Button attaque3;
        private System.Windows.Forms.Button attaque4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}