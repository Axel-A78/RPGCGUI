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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.DisplayChoice = new RPGCGUI.RjButton();
            this.ChooseTank = new RPGCGUI.RoundButton();
            this.ChoosePolyvalent = new RPGCGUI.RoundButton();
            this.ChooseAtk = new RPGCGUI.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // DisplayChoice
            // 
            this.DisplayChoice.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.DisplayChoice.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.DisplayChoice.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.DisplayChoice.BorderRadius = 20;
            this.DisplayChoice.BorderSize = 2;
            this.DisplayChoice.FlatAppearance.BorderSize = 0;
            this.DisplayChoice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DisplayChoice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayChoice.ForeColor = System.Drawing.Color.White;
            this.DisplayChoice.Location = new System.Drawing.Point(133, 46);
            this.DisplayChoice.Name = "DisplayChoice";
            this.DisplayChoice.Size = new System.Drawing.Size(339, 96);
            this.DisplayChoice.TabIndex = 7;
            this.DisplayChoice.Text = "Qui allez-vous choisir ?";
            this.DisplayChoice.TextColor = System.Drawing.Color.White;
            this.DisplayChoice.UseVisualStyleBackColor = false;
            // 
            // ChooseTank
            // 
            this.ChooseTank.BackColor = System.Drawing.Color.IndianRed;
            this.ChooseTank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChooseTank.BackgroundImage")));
            this.ChooseTank.FlatAppearance.BorderSize = 0;
            this.ChooseTank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseTank.Location = new System.Drawing.Point(398, 248);
            this.ChooseTank.Name = "ChooseTank";
            this.ChooseTank.Size = new System.Drawing.Size(122, 117);
            this.ChooseTank.TabIndex = 6;
            this.ChooseTank.UseVisualStyleBackColor = false;
            this.ChooseTank.Click += new System.EventHandler(this.ChooseTank_Click);
            // 
            // ChoosePolyvalent
            // 
            this.ChoosePolyvalent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ChoosePolyvalent.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChoosePolyvalent.BackgroundImage")));
            this.ChoosePolyvalent.FlatAppearance.BorderSize = 0;
            this.ChoosePolyvalent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoosePolyvalent.Location = new System.Drawing.Point(237, 248);
            this.ChoosePolyvalent.Name = "ChoosePolyvalent";
            this.ChoosePolyvalent.Size = new System.Drawing.Size(124, 117);
            this.ChoosePolyvalent.TabIndex = 5;
            this.ChoosePolyvalent.UseVisualStyleBackColor = false;
            this.ChoosePolyvalent.Click += new System.EventHandler(this.ChoosePolyvalent_Click);
            // 
            // ChooseAtk
            // 
            this.ChooseAtk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ChooseAtk.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChooseAtk.BackgroundImage")));
            this.ChooseAtk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ChooseAtk.FlatAppearance.BorderSize = 0;
            this.ChooseAtk.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseAtk.Location = new System.Drawing.Point(85, 248);
            this.ChooseAtk.Name = "ChooseAtk";
            this.ChooseAtk.Size = new System.Drawing.Size(116, 117);
            this.ChooseAtk.TabIndex = 4;
            this.ChooseAtk.UseVisualStyleBackColor = false;
            this.ChooseAtk.Click += new System.EventHandler(this.ChooseAtk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.DisplayChoice);
            this.Controls.Add(this.ChooseTank);
            this.Controls.Add(this.ChoosePolyvalent);
            this.Controls.Add(this.ChooseAtk);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private RoundButton ChooseAtk;
        private System.Windows.Forms.BindingSource bindingSource1;
        private RoundButton ChoosePolyvalent;
        private RoundButton ChooseTank;
        private RjButton DisplayChoice;
    }
}

