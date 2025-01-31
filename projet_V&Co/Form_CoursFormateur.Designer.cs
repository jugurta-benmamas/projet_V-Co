namespace projet_V_Co
{
    partial class Form_CoursFormateur
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtbox_contenuCours = new System.Windows.Forms.TextBox();
            this.lbl_titreCours = new System.Windows.Forms.Label();
            this.btn_quitter = new System.Windows.Forms.PictureBox();
            this.lbl_deconnexion = new System.Windows.Forms.Label();
            this.pictBox_avatar = new System.Windows.Forms.PictureBox();
            this.lbl_nomEntreprise = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = global::projet_V_Co.Properties.Resources.fond_cours_2;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.txtbox_contenuCours);
            this.panel1.Controls.Add(this.lbl_titreCours);
            this.panel1.Location = new System.Drawing.Point(179, 160);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1666, 804);
            this.panel1.TabIndex = 17;
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
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitter.Image = global::projet_V_Co.Properties.Resources.btn_quitter;
            this.btn_quitter.Location = new System.Drawing.Point(1864, 956);
            this.btn_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(52, 50);
            this.btn_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quitter.TabIndex = 16;
            this.btn_quitter.TabStop = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // lbl_deconnexion
            // 
            this.lbl_deconnexion.AutoSize = true;
            this.lbl_deconnexion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_deconnexion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deconnexion.ForeColor = System.Drawing.Color.White;
            this.lbl_deconnexion.Location = new System.Drawing.Point(1676, 99);
            this.lbl_deconnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_deconnexion.Name = "lbl_deconnexion";
            this.lbl_deconnexion.Size = new System.Drawing.Size(121, 23);
            this.lbl_deconnexion.TabIndex = 15;
            this.lbl_deconnexion.Text = "Déconnexion";
            this.lbl_deconnexion.Click += new System.EventHandler(this.lbl_deconnexion_Click);
            // 
            // pictBox_avatar
            // 
            this.pictBox_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pictBox_avatar.Image = global::projet_V_Co.Properties.Resources.logo_Utilisateur;
            this.pictBox_avatar.Location = new System.Drawing.Point(1685, 20);
            this.pictBox_avatar.Margin = new System.Windows.Forms.Padding(4);
            this.pictBox_avatar.Name = "pictBox_avatar";
            this.pictBox_avatar.Size = new System.Drawing.Size(105, 83);
            this.pictBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBox_avatar.TabIndex = 14;
            this.pictBox_avatar.TabStop = false;
            // 
            // lbl_nomEntreprise
            // 
            this.lbl_nomEntreprise.AutoSize = true;
            this.lbl_nomEntreprise.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomEntreprise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_nomEntreprise.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomEntreprise.ForeColor = System.Drawing.Color.White;
            this.lbl_nomEntreprise.Location = new System.Drawing.Point(53, 23);
            this.lbl_nomEntreprise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomEntreprise.Name = "lbl_nomEntreprise";
            this.lbl_nomEntreprise.Size = new System.Drawing.Size(111, 40);
            this.lbl_nomEntreprise.TabIndex = 12;
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
            this.lbl_titre.TabIndex = 13;
            this.lbl_titre.Text = "Cours";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_CoursFormateur
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
            this.Name = "Form_CoursFormateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_CoursFormateur";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbox_contenuCours;
        private System.Windows.Forms.Label lbl_titreCours;
        private System.Windows.Forms.PictureBox btn_quitter;
        private System.Windows.Forms.Label lbl_deconnexion;
        private System.Windows.Forms.PictureBox pictBox_avatar;
        private System.Windows.Forms.Label lbl_nomEntreprise;
        private System.Windows.Forms.Label lbl_titre;
    }
}