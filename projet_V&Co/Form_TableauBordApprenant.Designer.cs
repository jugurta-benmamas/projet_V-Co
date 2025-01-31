namespace projet_V_Co
{
    partial class Form_TableauBordApprenant
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
            this.lbl_nomEntreprise = new System.Windows.Forms.Label();
            this.lbl_bonjour = new System.Windows.Forms.Label();
            this.lbl_deconnexion = new System.Windows.Forms.Label();
            this.lbl_titreModule = new System.Windows.Forms.Label();
            this.lbl_titreProgression = new System.Windows.Forms.Label();
            this.flwPanel_module = new System.Windows.Forms.FlowLayoutPanel();
            this.flwPanel_progression = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_aucuneProgression = new System.Windows.Forms.Label();
            this.lbl_toutAfficher = new System.Windows.Forms.Label();
            this.btn_quitter = new System.Windows.Forms.PictureBox();
            this.pictBox_avatar = new System.Windows.Forms.PictureBox();
            this.flwPanel_progression.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nomEntreprise
            // 
            this.lbl_nomEntreprise.AutoSize = true;
            this.lbl_nomEntreprise.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomEntreprise.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomEntreprise.ForeColor = System.Drawing.Color.White;
            this.lbl_nomEntreprise.Location = new System.Drawing.Point(53, 16);
            this.lbl_nomEntreprise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomEntreprise.Name = "lbl_nomEntreprise";
            this.lbl_nomEntreprise.Size = new System.Drawing.Size(111, 40);
            this.lbl_nomEntreprise.TabIndex = 0;
            this.lbl_nomEntreprise.Text = "V&&Co";
            // 
            // lbl_bonjour
            // 
            this.lbl_bonjour.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bonjour.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_bonjour.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bonjour.ForeColor = System.Drawing.Color.White;
            this.lbl_bonjour.Location = new System.Drawing.Point(0, 0);
            this.lbl_bonjour.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_bonjour.Name = "lbl_bonjour";
            this.lbl_bonjour.Padding = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.lbl_bonjour.Size = new System.Drawing.Size(1917, 88);
            this.lbl_bonjour.TabIndex = 1;
            this.lbl_bonjour.Text = "Bonjour Apprenant !!";
            this.lbl_bonjour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_deconnexion
            // 
            this.lbl_deconnexion.AutoSize = true;
            this.lbl_deconnexion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_deconnexion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deconnexion.ForeColor = System.Drawing.Color.White;
            this.lbl_deconnexion.Location = new System.Drawing.Point(1676, 92);
            this.lbl_deconnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_deconnexion.Name = "lbl_deconnexion";
            this.lbl_deconnexion.Size = new System.Drawing.Size(121, 23);
            this.lbl_deconnexion.TabIndex = 3;
            this.lbl_deconnexion.Text = "Déconnexion";
            this.lbl_deconnexion.Click += new System.EventHandler(this.lbl_deconnexion_Click);
            
            // 
            // lbl_titreModule
            // 
            this.lbl_titreModule.AutoSize = true;
            this.lbl_titreModule.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titreModule.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreModule.ForeColor = System.Drawing.Color.White;
            this.lbl_titreModule.Location = new System.Drawing.Point(263, 110);
            this.lbl_titreModule.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titreModule.Name = "lbl_titreModule";
            this.lbl_titreModule.Size = new System.Drawing.Size(259, 59);
            this.lbl_titreModule.TabIndex = 4;
            this.lbl_titreModule.Text = "Modules :";
            // 
            // lbl_titreProgression
            // 
            this.lbl_titreProgression.AutoSize = true;
            this.lbl_titreProgression.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titreProgression.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreProgression.ForeColor = System.Drawing.Color.White;
            this.lbl_titreProgression.Location = new System.Drawing.Point(263, 688);
            this.lbl_titreProgression.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titreProgression.Name = "lbl_titreProgression";
            this.lbl_titreProgression.Size = new System.Drawing.Size(348, 59);
            this.lbl_titreProgression.TabIndex = 7;
            this.lbl_titreProgression.Text = "Progression :";
            // 
            // flwPanel_module
            // 
            this.flwPanel_module.BackColor = System.Drawing.Color.Transparent;
            this.flwPanel_module.Location = new System.Drawing.Point(329, 195);
            this.flwPanel_module.Margin = new System.Windows.Forms.Padding(4);
            this.flwPanel_module.Name = "flwPanel_module";
            this.flwPanel_module.Size = new System.Drawing.Size(1375, 465);
            this.flwPanel_module.TabIndex = 8;
            // 
            // flwPanel_progression
            // 
            this.flwPanel_progression.BackColor = System.Drawing.Color.Transparent;
            this.flwPanel_progression.Controls.Add(this.lbl_aucuneProgression);
            this.flwPanel_progression.Location = new System.Drawing.Point(329, 768);
            this.flwPanel_progression.Margin = new System.Windows.Forms.Padding(4);
            this.flwPanel_progression.Name = "flwPanel_progression";
            this.flwPanel_progression.Size = new System.Drawing.Size(1375, 226);
            this.flwPanel_progression.TabIndex = 0;
            // 
            // lbl_aucuneProgression
            // 
            this.lbl_aucuneProgression.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aucuneProgression.ForeColor = System.Drawing.Color.White;
            this.lbl_aucuneProgression.Location = new System.Drawing.Point(3, 0);
            this.lbl_aucuneProgression.Name = "lbl_aucuneProgression";
            this.lbl_aucuneProgression.Size = new System.Drawing.Size(1372, 217);
            this.lbl_aucuneProgression.TabIndex = 0;
            this.lbl_aucuneProgression.Text = "Aucune progression pour le moment...";
            this.lbl_aucuneProgression.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_toutAfficher
            // 
            this.lbl_toutAfficher.AutoSize = true;
            this.lbl_toutAfficher.BackColor = System.Drawing.Color.Transparent;
            this.lbl_toutAfficher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_toutAfficher.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_toutAfficher.ForeColor = System.Drawing.Color.White;
            this.lbl_toutAfficher.Location = new System.Drawing.Point(1586, 724);
            this.lbl_toutAfficher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_toutAfficher.Name = "lbl_toutAfficher";
            this.lbl_toutAfficher.Size = new System.Drawing.Size(118, 23);
            this.lbl_toutAfficher.TabIndex = 9;
            this.lbl_toutAfficher.Text = "Tout afficher";
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitter.Image = global::projet_V_Co.Properties.Resources.btn_quitter;
            this.btn_quitter.Location = new System.Drawing.Point(1852, 944);
            this.btn_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(52, 50);
            this.btn_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quitter.TabIndex = 5;
            this.btn_quitter.TabStop = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // pictBox_avatar
            // 
            this.pictBox_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pictBox_avatar.Image = global::projet_V_Co.Properties.Resources.logo_Utilisateur;
            this.pictBox_avatar.Location = new System.Drawing.Point(1685, 13);
            this.pictBox_avatar.Margin = new System.Windows.Forms.Padding(4);
            this.pictBox_avatar.Name = "pictBox_avatar";
            this.pictBox_avatar.Size = new System.Drawing.Size(105, 83);
            this.pictBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBox_avatar.TabIndex = 2;
            this.pictBox_avatar.TabStop = false;
            // 
            // Form_TableauBordApprenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::projet_V_Co.Properties.Resources.Fond_test_H;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1917, 1021);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.lbl_toutAfficher);
            this.Controls.Add(this.flwPanel_progression);
            this.Controls.Add(this.flwPanel_module);
            this.Controls.Add(this.lbl_titreProgression);
            this.Controls.Add(this.lbl_titreModule);
            this.Controls.Add(this.lbl_deconnexion);
            this.Controls.Add(this.pictBox_avatar);
            this.Controls.Add(this.lbl_nomEntreprise);
            this.Controls.Add(this.lbl_bonjour);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_TableauBordApprenant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_TableauBordApprenant";
            this.flwPanel_progression.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nomEntreprise;
        private System.Windows.Forms.Label lbl_bonjour;
        private System.Windows.Forms.PictureBox pictBox_avatar;
        private System.Windows.Forms.Label lbl_deconnexion;
        private System.Windows.Forms.Label lbl_titreModule;
        private System.Windows.Forms.PictureBox btn_quitter;
        private System.Windows.Forms.Label lbl_titreProgression;
        private System.Windows.Forms.FlowLayoutPanel flwPanel_module;
        private System.Windows.Forms.FlowLayoutPanel flwPanel_progression;
        private System.Windows.Forms.Label lbl_toutAfficher;
        private System.Windows.Forms.Label lbl_aucuneProgression;
    }
}

