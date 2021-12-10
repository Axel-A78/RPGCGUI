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
            this.ChooseTank = new RPGCGUI.RoundButton();
            this.ChoosePolyvalent = new RPGCGUI.RoundButton();
            this.ChooseAtk = new RPGCGUI.RoundButton();
            this.DisplayChoice = new RPGCGUI.RjButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.nameTank = new System.Windows.Forms.Label();
            this.namePolyvalent = new System.Windows.Forms.Label();
            this.nameAttaquant = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ChooseTank
            // 
            this.ChooseTank.BackColor = System.Drawing.Color.IndianRed;
            this.ChooseTank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ChooseTank.BackgroundImage")));
            this.ChooseTank.FlatAppearance.BorderSize = 0;
            this.ChooseTank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseTank.Location = new System.Drawing.Point(3, 3);
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
            this.ChoosePolyvalent.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ChoosePolyvalent.FlatAppearance.BorderSize = 0;
            this.ChoosePolyvalent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChoosePolyvalent.Location = new System.Drawing.Point(3, 187);
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
            this.ChooseAtk.Location = new System.Drawing.Point(3, 371);
            this.ChooseAtk.Name = "ChooseAtk";
            this.ChooseAtk.Size = new System.Drawing.Size(116, 117);
            this.ChooseAtk.TabIndex = 4;
            this.ChooseAtk.UseVisualStyleBackColor = false;
            this.ChooseAtk.Click += new System.EventHandler(this.ChooseAtk_Click);
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
            this.DisplayChoice.Location = new System.Drawing.Point(249, 122);
            this.DisplayChoice.Name = "DisplayChoice";
            this.DisplayChoice.Size = new System.Drawing.Size(345, 262);
            this.DisplayChoice.TabIndex = 7;
            this.DisplayChoice.Text = "Qui allez-vous choisir ?";
            this.DisplayChoice.TextColor = System.Drawing.Color.White;
            this.DisplayChoice.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ChooseTank, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ChooseAtk, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.nameTank, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.ChoosePolyvalent, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.namePolyvalent, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.nameAttaquant, 0, 5);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 77.71739F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.28261F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(132, 543);
            this.tableLayoutPanel1.TabIndex = 8;
            // 
            // nameTank
            // 
            this.nameTank.AutoSize = true;
            this.nameTank.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTank.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameTank.Location = new System.Drawing.Point(3, 143);
            this.nameTank.Name = "nameTank";
            this.nameTank.Size = new System.Drawing.Size(64, 25);
            this.nameTank.TabIndex = 7;
            this.nameTank.Text = "Tank";
            // 
            // namePolyvalent
            // 
            this.namePolyvalent.AutoSize = true;
            this.namePolyvalent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namePolyvalent.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.namePolyvalent.Location = new System.Drawing.Point(3, 317);
            this.namePolyvalent.Name = "namePolyvalent";
            this.namePolyvalent.Size = new System.Drawing.Size(122, 25);
            this.namePolyvalent.TabIndex = 8;
            this.namePolyvalent.Text = "Polyvalent";
            // 
            // nameAttaquant
            // 
            this.nameAttaquant.AutoSize = true;
            this.nameAttaquant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameAttaquant.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nameAttaquant.Location = new System.Drawing.Point(3, 505);
            this.nameAttaquant.Name = "nameAttaquant";
            this.nameAttaquant.Size = new System.Drawing.Size(72, 25);
            this.nameAttaquant.TabIndex = 9;
            this.nameAttaquant.Text = "Clebs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(823, 556);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.DisplayChoice);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private RoundButton ChoosePolyvalent;
        private RoundButton ChooseTank;
        private RoundButton ChooseAtk;
        private RjButton DisplayChoice;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label nameTank;
        private System.Windows.Forms.Label namePolyvalent;
        private System.Windows.Forms.Label nameAttaquant;
    }
}

