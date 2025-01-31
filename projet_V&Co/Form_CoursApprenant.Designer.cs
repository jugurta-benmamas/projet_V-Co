namespace projet_V_Co
{
    partial class Form_CoursApprenant
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
            this.lbl_deconnexion = new System.Windows.Forms.Label();
            this.pictBox_avatar = new System.Windows.Forms.PictureBox();
            this.lbl_nomEntreprise = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.btn_quitter = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbtn_nonCompris = new System.Windows.Forms.RadioButton();
            this.rdbtn_compris = new System.Windows.Forms.RadioButton();
            this.btn_valider = new Krypton.Toolkit.KryptonButton();
            this.txtbox_contenuCours = new System.Windows.Forms.TextBox();
            this.lbl_titreCours = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.lbl_deconnexion.TabIndex = 9;
            this.lbl_deconnexion.Text = "Déconnexion";
            this.lbl_deconnexion.Click += new System.EventHandler(this.lbl_deconnexion_Click);
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
            this.pictBox_avatar.TabIndex = 8;
            this.pictBox_avatar.TabStop = false;
            // 
            // lbl_nomEntreprise
            // 
            this.lbl_nomEntreprise.AutoSize = true;
            this.lbl_nomEntreprise.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomEntreprise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_nomEntreprise.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomEntreprise.ForeColor = System.Drawing.Color.White;
            this.lbl_nomEntreprise.Location = new System.Drawing.Point(53, 16);
            this.lbl_nomEntreprise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomEntreprise.Name = "lbl_nomEntreprise";
            this.lbl_nomEntreprise.Size = new System.Drawing.Size(111, 40);
            this.lbl_nomEntreprise.TabIndex = 6;
            this.lbl_nomEntreprise.Text = "V&&Co";
            this.lbl_nomEntreprise.Click += new System.EventHandler(this.lbl_nomEntreprise_Click);
            // 
            // lbl_titre
            // 
            this.lbl_titre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titre.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.White;
            this.lbl_titre.Location = new System.Drawing.Point(0, 0);
            this.lbl_titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Padding = new System.Windows.Forms.Padding(0, 37, 0, 0);
            this.lbl_titre.Size = new System.Drawing.Size(1929, 101);
            this.lbl_titre.TabIndex = 7;
            this.lbl_titre.Text = "Cours";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitter.Image = global::projet_V_Co.Properties.Resources.btn_quitter;
            this.btn_quitter.Location = new System.Drawing.Point(1864, 949);
            this.btn_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(52, 50);
            this.btn_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quitter.TabIndex = 10;
            this.btn_quitter.TabStop = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::projet_V_Co.Properties.Resources.fond_cours_2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.rdbtn_nonCompris);
            this.panel1.Controls.Add(this.rdbtn_compris);
            this.panel1.Controls.Add(this.btn_valider);
            this.panel1.Controls.Add(this.txtbox_contenuCours);
            this.panel1.Controls.Add(this.lbl_titreCours);
            this.panel1.Location = new System.Drawing.Point(179, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1666, 804);
            this.panel1.TabIndex = 11;
            // 
            // rdbtn_nonCompris
            // 
            this.rdbtn_nonCompris.AutoSize = true;
            this.rdbtn_nonCompris.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_nonCompris.Location = new System.Drawing.Point(923, 635);
            this.rdbtn_nonCompris.Name = "rdbtn_nonCompris";
            this.rdbtn_nonCompris.Size = new System.Drawing.Size(239, 31);
            this.rdbtn_nonCompris.TabIndex = 16;
            this.rdbtn_nonCompris.TabStop = true;
            this.rdbtn_nonCompris.Text = "Je n\'ai pas compris";
            this.rdbtn_nonCompris.UseVisualStyleBackColor = true;
            // 
            // rdbtn_compris
            // 
            this.rdbtn_compris.AutoSize = true;
            this.rdbtn_compris.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_compris.Location = new System.Drawing.Point(590, 635);
            this.rdbtn_compris.Name = "rdbtn_compris";
            this.rdbtn_compris.Size = new System.Drawing.Size(159, 31);
            this.rdbtn_compris.TabIndex = 15;
            this.rdbtn_compris.TabStop = true;
            this.rdbtn_compris.Text = "J\'ai compris";
            this.rdbtn_compris.UseVisualStyleBackColor = true;
            // 
            // btn_valider
            // 
            this.btn_valider.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_valider.CornerRoundingRadius = 20F;
            this.btn_valider.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_valider.Location = new System.Drawing.Point(685, 710);
            this.btn_valider.Margin = new System.Windows.Forms.Padding(4);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_valider.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_valider.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_valider.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_valider.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_valider.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_valider.Size = new System.Drawing.Size(251, 50);
            this.btn_valider.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_valider.StateCommon.Border.Rounding = 20F;
            this.btn_valider.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_valider.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_valider.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_valider.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_valider.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_valider.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_valider.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_valider.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_valider.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_valider.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_valider.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_valider.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_valider.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_valider.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_valider.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_valider.TabIndex = 14;
            this.btn_valider.Values.Text = "Valider";
            // 
            // txtbox_contenuCours
            // 
            this.txtbox_contenuCours.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_contenuCours.Location = new System.Drawing.Point(53, 106);
            this.txtbox_contenuCours.Multiline = true;
            this.txtbox_contenuCours.Name = "txtbox_contenuCours";
            this.txtbox_contenuCours.ReadOnly = true;
            this.txtbox_contenuCours.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_contenuCours.Size = new System.Drawing.Size(1544, 473);
            this.txtbox_contenuCours.TabIndex = 1;
            this.txtbox_contenuCours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_titreCours
            // 
            this.lbl_titreCours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titreCours.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreCours.Location = new System.Drawing.Point(0, 0);
            this.lbl_titreCours.Name = "lbl_titreCours";
            this.lbl_titreCours.Size = new System.Drawing.Size(1666, 116);
            this.lbl_titreCours.TabIndex = 0;
            this.lbl_titreCours.Text = "Titre du cours";
            this.lbl_titreCours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_CoursApprenant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::projet_V_Co.Properties.Resources.Fond_test_H;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1929, 1012);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.lbl_deconnexion);
            this.Controls.Add(this.pictBox_avatar);
            this.Controls.Add(this.lbl_nomEntreprise);
            this.Controls.Add(this.lbl_titre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_CoursApprenant";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_CoursApprenant";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_deconnexion;
        private System.Windows.Forms.PictureBox pictBox_avatar;
        private System.Windows.Forms.Label lbl_nomEntreprise;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.PictureBox btn_quitter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_titreCours;
        private System.Windows.Forms.TextBox txtbox_contenuCours;
        private Krypton.Toolkit.KryptonButton btn_valider;
        private System.Windows.Forms.RadioButton rdbtn_nonCompris;
        private System.Windows.Forms.RadioButton rdbtn_compris;
    }
}