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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

