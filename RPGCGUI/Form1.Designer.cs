namespace RPGCGUI
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonAttaquant = new System.Windows.Forms.Button();
            this.buttonTank = new System.Windows.Forms.Button();
            this.buttonPolyvalent = new System.Windows.Forms.Button();
            this.textBoxInterface = new System.Windows.Forms.TextBox();
            this.attaque1 = new System.Windows.Forms.Button();
            this.attaque2 = new System.Windows.Forms.Button();
            this.attaque3 = new System.Windows.Forms.Button();
            this.attaque4 = new System.Windows.Forms.Button();
            this.labelInterface = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAttaquant
            // 
            this.buttonAttaquant.Location = new System.Drawing.Point(2, 305);
            this.buttonAttaquant.Name = "buttonAttaquant";
            this.buttonAttaquant.Size = new System.Drawing.Size(75, 23);
            this.buttonAttaquant.TabIndex = 0;
            this.buttonAttaquant.Text = "Attaquant";
            this.buttonAttaquant.UseVisualStyleBackColor = true;
            this.buttonAttaquant.Click += new System.EventHandler(this.buttonAttaquant_Click);
            // 
            // buttonTank
            // 
            this.buttonTank.Location = new System.Drawing.Point(2, 334);
            this.buttonTank.Name = "buttonTank";
            this.buttonTank.Size = new System.Drawing.Size(75, 23);
            this.buttonTank.TabIndex = 1;
            this.buttonTank.Text = "Tank";
            this.buttonTank.UseVisualStyleBackColor = true;
            this.buttonTank.Click += new System.EventHandler(this.buttonTank_Click);
            // 
            // buttonPolyvalent
            // 
            this.buttonPolyvalent.Location = new System.Drawing.Point(2, 363);
            this.buttonPolyvalent.Name = "buttonPolyvalent";
            this.buttonPolyvalent.Size = new System.Drawing.Size(75, 23);
            this.buttonPolyvalent.TabIndex = 2;
            this.buttonPolyvalent.Text = "Polyvalent";
            this.buttonPolyvalent.UseVisualStyleBackColor = true;
            this.buttonPolyvalent.Click += new System.EventHandler(this.buttonPolyvalent_Click);
            // 
            // textBoxInterface
            // 
            this.textBoxInterface.Location = new System.Drawing.Point(174, 113);
            this.textBoxInterface.Name = "textBoxInterface";
            this.textBoxInterface.Size = new System.Drawing.Size(478, 22);
            this.textBoxInterface.TabIndex = 3;
            // 
            // attaque1
            // 
            this.attaque1.Location = new System.Drawing.Point(174, 200);
            this.attaque1.Name = "attaque1";
            this.attaque1.Size = new System.Drawing.Size(110, 51);
            this.attaque1.TabIndex = 5;
            this.attaque1.Text = "Attaque1";
            this.attaque1.UseVisualStyleBackColor = true;
            this.attaque1.Click += new System.EventHandler(this.attaque1_Click);
            // 
            // attaque2
            // 
            this.attaque2.Location = new System.Drawing.Point(542, 200);
            this.attaque2.Name = "attaque2";
            this.attaque2.Size = new System.Drawing.Size(110, 51);
            this.attaque2.TabIndex = 6;
            this.attaque2.Text = "Attaque2";
            this.attaque2.UseVisualStyleBackColor = true;
            // 
            // attaque3
            // 
            this.attaque3.Location = new System.Drawing.Point(174, 306);
            this.attaque3.Name = "attaque3";
            this.attaque3.Size = new System.Drawing.Size(110, 51);
            this.attaque3.TabIndex = 7;
            this.attaque3.Text = "Attaque3";
            this.attaque3.UseVisualStyleBackColor = true;
            // 
            // attaque4
            // 
            this.attaque4.Location = new System.Drawing.Point(542, 305);
            this.attaque4.Name = "attaque4";
            this.attaque4.Size = new System.Drawing.Size(110, 51);
            this.attaque4.TabIndex = 8;
            this.attaque4.Text = "Attaque4";
            this.attaque4.UseVisualStyleBackColor = true;
            // 
            // labelInterface
            // 
            this.labelInterface.AutoSize = true;
            this.labelInterface.Location = new System.Drawing.Point(399, 142);
            this.labelInterface.Name = "labelInterface";
            this.labelInterface.Size = new System.Drawing.Size(0, 16);
            this.labelInterface.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelInterface);
            this.Controls.Add(this.attaque4);
            this.Controls.Add(this.attaque3);
            this.Controls.Add(this.attaque2);
            this.Controls.Add(this.attaque1);
            this.Controls.Add(this.textBoxInterface);
            this.Controls.Add(this.buttonPolyvalent);
            this.Controls.Add(this.buttonTank);
            this.Controls.Add(this.buttonAttaquant);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAttaquant;
        private System.Windows.Forms.Button buttonTank;
        private System.Windows.Forms.Button buttonPolyvalent;
        private System.Windows.Forms.TextBox textBoxInterface;
        private System.Windows.Forms.Button attaque1;
        private System.Windows.Forms.Button attaque2;
        private System.Windows.Forms.Button attaque3;
        private System.Windows.Forms.Button attaque4;
        private System.Windows.Forms.Label labelInterface;
    }
}

