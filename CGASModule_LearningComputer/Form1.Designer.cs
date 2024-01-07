namespace CGASModule_LearningComputer
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Module1 = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.presentation1 = new CGASModule_LearningComputer.Cours.Module1.Presentation();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "J’apprends à utiliser un ordinateur !";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Module1
            // 
            this.Button_Module1.BackColor = System.Drawing.Color.Turquoise;
            this.Button_Module1.FlatAppearance.BorderSize = 0;
            this.Button_Module1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Module1.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Module1.IconChar = FontAwesome.Sharp.IconChar.Copy;
            this.Button_Module1.IconColor = System.Drawing.Color.Black;
            this.Button_Module1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Button_Module1.Location = new System.Drawing.Point(43, 128);
            this.Button_Module1.Name = "Button_Module1";
            this.Button_Module1.Size = new System.Drawing.Size(400, 74);
            this.Button_Module1.TabIndex = 1;
            this.Button_Module1.Text = "Module 1\r\nCopier / Coller / Couper";
            this.Button_Module1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Button_Module1.UseVisualStyleBackColor = false;
            this.Button_Module1.Click += new System.EventHandler(this.Button_Module1_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.label2.Location = new System.Drawing.Point(0, 537);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(484, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Année 2024 - V 1.0 - Un module CGAS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // presentation1
            // 
            this.presentation1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.presentation1.Location = new System.Drawing.Point(0, 0);
            this.presentation1.Name = "presentation1";
            this.presentation1.Size = new System.Drawing.Size(484, 563);
            this.presentation1.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.ClientSize = new System.Drawing.Size(484, 561);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Button_Module1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.presentation1);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "J\'apprends à utiliser un ordinateur";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton Button_Module1;
        private System.Windows.Forms.Label label2;
        private Cours.Module1.Presentation presentation1;
    }
}

