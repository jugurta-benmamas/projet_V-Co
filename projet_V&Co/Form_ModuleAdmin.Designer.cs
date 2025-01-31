namespace projet_V_Co
{
    partial class Form_ModuleAdmin
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
            this.components = new System.ComponentModel.Container();
            this.flwPanel_themes = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_deconnexion = new System.Windows.Forms.Label();
            this.pictBox_avatar = new System.Windows.Forms.PictureBox();
            this.lbl_nomEntreprise = new System.Windows.Forms.Label();
            this.btn_quitter = new System.Windows.Forms.PictureBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).BeginInit();
            this.SuspendLayout();
            // 
            // flwPanel_themes
            // 
            this.flwPanel_themes.BackColor = System.Drawing.Color.Transparent;
            this.flwPanel_themes.Location = new System.Drawing.Point(138, 110);
            this.flwPanel_themes.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flwPanel_themes.Name = "flwPanel_themes";
            this.flwPanel_themes.Size = new System.Drawing.Size(1208, 574);
            this.flwPanel_themes.TabIndex = 43;
            // 
            // lbl_deconnexion
            // 
            this.lbl_deconnexion.AutoSize = true;
            this.lbl_deconnexion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_deconnexion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deconnexion.ForeColor = System.Drawing.Color.White;
            this.lbl_deconnexion.Location = new System.Drawing.Point(1253, 80);
            this.lbl_deconnexion.Name = "lbl_deconnexion";
            this.lbl_deconnexion.Size = new System.Drawing.Size(99, 18);
            this.lbl_deconnexion.TabIndex = 41;
            this.lbl_deconnexion.Text = "Déconnexion";
            this.lbl_deconnexion.Click += new System.EventHandler(this.lbl_deconnexion_Click);
            // 
            // pictBox_avatar
            // 
            this.pictBox_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pictBox_avatar.Image = global::projet_V_Co.Properties.Resources.logo_Utilisateur;
            this.pictBox_avatar.Location = new System.Drawing.Point(1260, 15);
            this.pictBox_avatar.Name = "pictBox_avatar";
            this.pictBox_avatar.Size = new System.Drawing.Size(79, 67);
            this.pictBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBox_avatar.TabIndex = 40;
            this.pictBox_avatar.TabStop = false;
            // 
            // lbl_nomEntreprise
            // 
            this.lbl_nomEntreprise.AutoSize = true;
            this.lbl_nomEntreprise.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomEntreprise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_nomEntreprise.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomEntreprise.ForeColor = System.Drawing.Color.White;
            this.lbl_nomEntreprise.Location = new System.Drawing.Point(36, 18);
            this.lbl_nomEntreprise.Name = "lbl_nomEntreprise";
            this.lbl_nomEntreprise.Size = new System.Drawing.Size(89, 32);
            this.lbl_nomEntreprise.TabIndex = 38;
            this.lbl_nomEntreprise.Text = "V&&Co";
            this.lbl_nomEntreprise.Click += new System.EventHandler(this.lbl_nomEntreprise_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitter.Image = global::projet_V_Co.Properties.Resources.btn_quitter;
            this.btn_quitter.Location = new System.Drawing.Point(1389, 774);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(39, 41);
            this.btn_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quitter.TabIndex = 42;
            this.btn_quitter.TabStop = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // lbl_titre
            // 
            this.lbl_titre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titre.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titre.Font = new System.Drawing.Font("Arial", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.White;
            this.lbl_titre.Location = new System.Drawing.Point(0, 0);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.lbl_titre.Size = new System.Drawing.Size(1438, 82);
            this.lbl_titre.TabIndex = 39;
            this.lbl_titre.Text = "Nom Modules";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // Form_ModuleAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::projet_V_Co.Properties.Resources.Fond_test_H;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1438, 820);
            this.Controls.Add(this.flwPanel_themes);
            this.Controls.Add(this.lbl_deconnexion);
            this.Controls.Add(this.pictBox_avatar);
            this.Controls.Add(this.lbl_nomEntreprise);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.lbl_titre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_ModuleAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_ModuleAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flwPanel_themes;
        private System.Windows.Forms.Label lbl_deconnexion;
        private System.Windows.Forms.PictureBox pictBox_avatar;
        private System.Windows.Forms.Label lbl_nomEntreprise;
        private System.Windows.Forms.PictureBox btn_quitter;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}