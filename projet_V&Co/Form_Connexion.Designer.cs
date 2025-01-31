namespace projet_V_Co
{
    partial class Form_Connexion
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
            this.lbl_titre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_quitter = new System.Windows.Forms.PictureBox();
            this.pictBox_logoVco = new System.Windows.Forms.PictureBox();
            this.panel_Connexion = new System.Windows.Forms.Panel();
            this.txtbox_mdp = new Krypton.Toolkit.KryptonTextBox();
            this.txtbox_login = new Krypton.Toolkit.KryptonTextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.btn_connexion = new Krypton.Toolkit.KryptonButton();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_mdpOublié = new System.Windows.Forms.Label();
            this.rdbtn_apprenant = new System.Windows.Forms.RadioButton();
            this.rdbtn_admin = new System.Windows.Forms.RadioButton();
            this.lbl_mdp = new System.Windows.Forms.Label();
            this.rdbtn_formateur = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_logoVco)).BeginInit();
            this.panel_Connexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_titre
            // 
            this.lbl_titre.AutoSize = true;
            this.lbl_titre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_titre.Font = new System.Drawing.Font("Arial", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titre.ForeColor = System.Drawing.Color.White;
            this.lbl_titre.Location = new System.Drawing.Point(571, 57);
            this.lbl_titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Size = new System.Drawing.Size(174, 63);
            this.lbl_titre.TabIndex = 17;
            this.lbl_titre.Text = "V&&Co";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(571, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 67);
            this.label1.TabIndex = 16;
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitter.Image = global::projet_V_Co.Properties.Resources.btn_quitter;
            this.btn_quitter.Location = new System.Drawing.Point(1247, 927);
            this.btn_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(52, 50);
            this.btn_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quitter.TabIndex = 22;
            this.btn_quitter.TabStop = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // pictBox_logoVco
            // 
            this.pictBox_logoVco.BackColor = System.Drawing.Color.Transparent;
            this.pictBox_logoVco.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictBox_logoVco.Image = global::projet_V_Co.Properties.Resources.Logo_V_Co;
            this.pictBox_logoVco.Location = new System.Drawing.Point(16, 15);
            this.pictBox_logoVco.Margin = new System.Windows.Forms.Padding(4);
            this.pictBox_logoVco.Name = "pictBox_logoVco";
            this.pictBox_logoVco.Size = new System.Drawing.Size(139, 122);
            this.pictBox_logoVco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictBox_logoVco.TabIndex = 15;
            this.pictBox_logoVco.TabStop = false;
            // 
            // panel_Connexion
            // 
            this.panel_Connexion.BackColor = System.Drawing.Color.Transparent;
            this.panel_Connexion.BackgroundImage = global::projet_V_Co.Properties.Resources.fond_connexion2;
            this.panel_Connexion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel_Connexion.Controls.Add(this.txtbox_mdp);
            this.panel_Connexion.Controls.Add(this.txtbox_login);
            this.panel_Connexion.Controls.Add(this.lbl_login);
            this.panel_Connexion.Controls.Add(this.btn_connexion);
            this.panel_Connexion.Controls.Add(this.lbl_role);
            this.panel_Connexion.Controls.Add(this.lbl_mdpOublié);
            this.panel_Connexion.Controls.Add(this.rdbtn_apprenant);
            this.panel_Connexion.Controls.Add(this.rdbtn_admin);
            this.panel_Connexion.Controls.Add(this.lbl_mdp);
            this.panel_Connexion.Controls.Add(this.rdbtn_formateur);
            this.panel_Connexion.Location = new System.Drawing.Point(285, 123);
            this.panel_Connexion.Margin = new System.Windows.Forms.Padding(4);
            this.panel_Connexion.Name = "panel_Connexion";
            this.panel_Connexion.Size = new System.Drawing.Size(787, 681);
            this.panel_Connexion.TabIndex = 21;
            // 
            // txtbox_mdp
            // 
            this.txtbox_mdp.CornerRoundingRadius = 20F;
            this.txtbox_mdp.Location = new System.Drawing.Point(241, 251);
            this.txtbox_mdp.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_mdp.Name = "txtbox_mdp";
            this.txtbox_mdp.PasswordChar = '*';
            this.txtbox_mdp.Size = new System.Drawing.Size(284, 42);
            this.txtbox_mdp.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_mdp.StateCommon.Border.Rounding = 20F;
            this.txtbox_mdp.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F);
            this.txtbox_mdp.TabIndex = 16;
            // 
            // txtbox_login
            // 
            this.txtbox_login.CornerRoundingRadius = 20F;
            this.txtbox_login.Location = new System.Drawing.Point(241, 116);
            this.txtbox_login.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_login.Name = "txtbox_login";
            this.txtbox_login.Size = new System.Drawing.Size(284, 42);
            this.txtbox_login.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_login.StateCommon.Border.Rounding = 20F;
            this.txtbox_login.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_login.TabIndex = 15;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(319, 69);
            this.lbl_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(109, 42);
            this.lbl_login.TabIndex = 14;
            this.lbl_login.Text = "Login";
            // 
            // btn_connexion
            // 
            this.btn_connexion.CornerRoundingRadius = 20F;
            this.btn_connexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_connexion.Location = new System.Drawing.Point(255, 560);
            this.btn_connexion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_connexion.Name = "btn_connexion";
            this.btn_connexion.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_connexion.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_connexion.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_connexion.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_connexion.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_connexion.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_connexion.Size = new System.Drawing.Size(251, 50);
            this.btn_connexion.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_connexion.StateCommon.Border.Rounding = 20F;
            this.btn_connexion.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connexion.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_connexion.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_connexion.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_connexion.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_connexion.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_connexion.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_connexion.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_connexion.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_connexion.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_connexion.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_connexion.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_connexion.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_connexion.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_connexion.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_connexion.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_connexion.TabIndex = 13;
            this.btn_connexion.Values.Text = "Connexion";
            this.btn_connexion.Click += new System.EventHandler(this.btn_connexion_Click);
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(331, 370);
            this.lbl_role.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(93, 42);
            this.lbl_role.TabIndex = 11;
            this.lbl_role.Text = "Rôle";
            // 
            // lbl_mdpOublié
            // 
            this.lbl_mdpOublié.AutoSize = true;
            this.lbl_mdpOublié.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_mdpOublié.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mdpOublié.Location = new System.Drawing.Point(309, 302);
            this.lbl_mdpOublié.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mdpOublié.Name = "lbl_mdpOublié";
            this.lbl_mdpOublié.Size = new System.Drawing.Size(146, 16);
            this.lbl_mdpOublié.TabIndex = 12;
            this.lbl_mdpOublié.Text = "Mot de passe oublié ?";
            // 
            // rdbtn_apprenant
            // 
            this.rdbtn_apprenant.AutoSize = true;
            this.rdbtn_apprenant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtn_apprenant.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_apprenant.Location = new System.Drawing.Point(479, 447);
            this.rdbtn_apprenant.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtn_apprenant.Name = "rdbtn_apprenant";
            this.rdbtn_apprenant.Size = new System.Drawing.Size(145, 31);
            this.rdbtn_apprenant.TabIndex = 6;
            this.rdbtn_apprenant.TabStop = true;
            this.rdbtn_apprenant.Text = "Apprenant";
            this.rdbtn_apprenant.UseVisualStyleBackColor = true;
            // 
            // rdbtn_admin
            // 
            this.rdbtn_admin.AutoSize = true;
            this.rdbtn_admin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtn_admin.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_admin.Location = new System.Drawing.Point(176, 447);
            this.rdbtn_admin.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtn_admin.Name = "rdbtn_admin";
            this.rdbtn_admin.Size = new System.Drawing.Size(101, 31);
            this.rdbtn_admin.TabIndex = 4;
            this.rdbtn_admin.Text = "Admin";
            this.rdbtn_admin.UseVisualStyleBackColor = true;
            // 
            // lbl_mdp
            // 
            this.lbl_mdp.AutoSize = true;
            this.lbl_mdp.Font = new System.Drawing.Font("Arial", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mdp.Location = new System.Drawing.Point(249, 204);
            this.lbl_mdp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_mdp.Name = "lbl_mdp";
            this.lbl_mdp.Size = new System.Drawing.Size(238, 42);
            this.lbl_mdp.TabIndex = 10;
            this.lbl_mdp.Text = "Mot de passe";
            // 
            // rdbtn_formateur
            // 
            this.rdbtn_formateur.AutoSize = true;
            this.rdbtn_formateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtn_formateur.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbtn_formateur.Location = new System.Drawing.Point(305, 447);
            this.rdbtn_formateur.Margin = new System.Windows.Forms.Padding(4);
            this.rdbtn_formateur.Name = "rdbtn_formateur";
            this.rdbtn_formateur.Size = new System.Drawing.Size(144, 31);
            this.rdbtn_formateur.TabIndex = 5;
            this.rdbtn_formateur.TabStop = true;
            this.rdbtn_formateur.Text = "Formateur";
            this.rdbtn_formateur.UseVisualStyleBackColor = true;
            // 
            // Form_Connexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = global::projet_V_Co.Properties.Resources.Fond_test_H;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1312, 990);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictBox_logoVco);
            this.Controls.Add(this.panel_Connexion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_Connexion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_CoursApprenant";
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_logoVco)).EndInit();
            this.panel_Connexion.ResumeLayout(false);
            this.panel_Connexion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_quitter;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictBox_logoVco;
        private System.Windows.Forms.Panel panel_Connexion;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_mdpOublié;
        private System.Windows.Forms.RadioButton rdbtn_apprenant;
        private System.Windows.Forms.RadioButton rdbtn_admin;
        private System.Windows.Forms.Label lbl_mdp;
        private System.Windows.Forms.RadioButton rdbtn_formateur;
        private Krypton.Toolkit.KryptonButton btn_connexion;
        private System.Windows.Forms.Label lbl_login;
        private Krypton.Toolkit.KryptonTextBox txtbox_login;
        private Krypton.Toolkit.KryptonTextBox txtbox_mdp;
    }
}