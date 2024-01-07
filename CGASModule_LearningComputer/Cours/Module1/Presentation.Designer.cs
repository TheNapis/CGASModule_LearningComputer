namespace CGASModule_LearningComputer.Cours.Module1
{
    partial class Presentation
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Module_Start = new FontAwesome.Sharp.IconButton();
            this.Return_Button = new FontAwesome.Sharp.IconButton();
            this.NextPage_Button = new FontAwesome.Sharp.IconButton();
            this.ReturnPage_Button = new FontAwesome.Sharp.IconButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.page11 = new CGASModule_LearningComputer.Cours.Module1.Page1();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Turquoise;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(45)))), ((int)(((byte)(85)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Module 1\r\nCopier / Coller / Couper\r\n\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 370);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(400, 88);
            this.label2.TabIndex = 2;
            this.label2.Text = "Je copie, coupe et colle pour déplacer \r\nfacilement des éléments \r\nde l\'ordinateu" +
    "r\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Module_Start
            // 
            this.Module_Start.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Module_Start.FlatAppearance.BorderSize = 0;
            this.Module_Start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Module_Start.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Module_Start.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.Module_Start.IconColor = System.Drawing.Color.Black;
            this.Module_Start.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Module_Start.Location = new System.Drawing.Point(209, 475);
            this.Module_Start.Name = "Module_Start";
            this.Module_Start.Size = new System.Drawing.Size(224, 60);
            this.Module_Start.TabIndex = 4;
            this.Module_Start.Text = "Commencer le module";
            this.Module_Start.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Module_Start.UseVisualStyleBackColor = false;
            this.Module_Start.Click += new System.EventHandler(this.Module_Start_Click);
            // 
            // Return_Button
            // 
            this.Return_Button.BackColor = System.Drawing.Color.LightCoral;
            this.Return_Button.FlatAppearance.BorderSize = 0;
            this.Return_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Return_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Return_Button.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.Return_Button.IconColor = System.Drawing.Color.Black;
            this.Return_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Return_Button.IconSize = 40;
            this.Return_Button.Location = new System.Drawing.Point(47, 475);
            this.Return_Button.Name = "Return_Button";
            this.Return_Button.Size = new System.Drawing.Size(141, 60);
            this.Return_Button.TabIndex = 3;
            this.Return_Button.Text = "Retour";
            this.Return_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Return_Button.UseVisualStyleBackColor = false;
            this.Return_Button.Click += new System.EventHandler(this.Return_Button_Click);
            // 
            // NextPage_Button
            // 
            this.NextPage_Button.BackColor = System.Drawing.Color.Cyan;
            this.NextPage_Button.FlatAppearance.BorderSize = 0;
            this.NextPage_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextPage_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextPage_Button.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.NextPage_Button.IconColor = System.Drawing.Color.Black;
            this.NextPage_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.NextPage_Button.Location = new System.Drawing.Point(253, 475);
            this.NextPage_Button.Name = "NextPage_Button";
            this.NextPage_Button.Size = new System.Drawing.Size(180, 60);
            this.NextPage_Button.TabIndex = 6;
            this.NextPage_Button.Text = "Suivant";
            this.NextPage_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.NextPage_Button.UseVisualStyleBackColor = false;
            // 
            // ReturnPage_Button
            // 
            this.ReturnPage_Button.BackColor = System.Drawing.Color.Cyan;
            this.ReturnPage_Button.FlatAppearance.BorderSize = 0;
            this.ReturnPage_Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReturnPage_Button.Font = new System.Drawing.Font("Microsoft YaHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReturnPage_Button.IconChar = FontAwesome.Sharp.IconChar.ArrowRight;
            this.ReturnPage_Button.IconColor = System.Drawing.Color.Black;
            this.ReturnPage_Button.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ReturnPage_Button.Location = new System.Drawing.Point(47, 475);
            this.ReturnPage_Button.Name = "ReturnPage_Button";
            this.ReturnPage_Button.Rotation = 180D;
            this.ReturnPage_Button.Size = new System.Drawing.Size(180, 60);
            this.ReturnPage_Button.TabIndex = 5;
            this.ReturnPage_Button.Text = "Retour";
            this.ReturnPage_Button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ReturnPage_Button.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CGASModule_LearningComputer.Properties.Resources.module1image;
            this.pictureBox1.Location = new System.Drawing.Point(106, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 257);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // page11
            // 
            this.page11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.page11.Location = new System.Drawing.Point(0, 80);
            this.page11.Name = "page11";
            this.page11.Size = new System.Drawing.Size(484, 378);
            this.page11.TabIndex = 7;
            // 
            // Presentation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(117)))), ((int)(((byte)(216)))));
            this.Controls.Add(this.Module_Start);
            this.Controls.Add(this.Return_Button);
            this.Controls.Add(this.NextPage_Button);
            this.Controls.Add(this.ReturnPage_Button);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.page11);
            this.Name = "Presentation";
            this.Size = new System.Drawing.Size(484, 563);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton Return_Button;
        private FontAwesome.Sharp.IconButton Module_Start;
        private FontAwesome.Sharp.IconButton ReturnPage_Button;
        private FontAwesome.Sharp.IconButton NextPage_Button;
        private Page1 page11;
    }
}
