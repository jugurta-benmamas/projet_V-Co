namespace projet_V_Co
{
    partial class Form_GererUtilisateurs
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
            this.lbl_deconnexion = new System.Windows.Forms.Label();
            this.pictBox_avatar = new System.Windows.Forms.PictureBox();
            this.lbl_nomEntreprise = new System.Windows.Forms.Label();
            this.btn_quitter = new System.Windows.Forms.PictureBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_modifUtilisateur = new Krypton.Toolkit.KryptonButton();
            this.btn_suppUtilisateur = new Krypton.Toolkit.KryptonButton();
            this.panel_lesUtilisateurs = new System.Windows.Forms.Panel();
            this.dataGridView_utilisateurs = new System.Windows.Forms.DataGridView();
            this.lbl_titreLesUti = new System.Windows.Forms.Label();
            this.btn_ajoutUtilisateur = new Krypton.Toolkit.KryptonButton();
            this.panel_informations = new System.Windows.Forms.Panel();
            this.txtbox_role = new Krypton.Toolkit.KryptonTextBox();
            this.txtbox_login = new Krypton.Toolkit.KryptonTextBox();
            this.txtbox_prenom = new Krypton.Toolkit.KryptonTextBox();
            this.txtbox_nom = new Krypton.Toolkit.KryptonTextBox();
            this.lbl_login = new System.Windows.Forms.Label();
            this.lbl_role = new System.Windows.Forms.Label();
            this.lbl_prenom = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.lbl_titreInfos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).BeginInit();
            this.panel_lesUtilisateurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_utilisateurs)).BeginInit();
            this.panel_informations.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_deconnexion
            // 
            this.lbl_deconnexion.AutoSize = true;
            this.lbl_deconnexion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_deconnexion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deconnexion.ForeColor = System.Drawing.Color.White;
            this.lbl_deconnexion.Location = new System.Drawing.Point(1671, 101);
            this.lbl_deconnexion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_deconnexion.Name = "lbl_deconnexion";
            this.lbl_deconnexion.Size = new System.Drawing.Size(121, 23);
            this.lbl_deconnexion.TabIndex = 50;
            this.lbl_deconnexion.Text = "Déconnexion";
            this.lbl_deconnexion.Click += new System.EventHandler(this.lbl_deconnexion_Click);
            // 
            // pictBox_avatar
            // 
            this.pictBox_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pictBox_avatar.Image = global::projet_V_Co.Properties.Resources.logo_Utilisateur;
            this.pictBox_avatar.Location = new System.Drawing.Point(1680, 22);
            this.pictBox_avatar.Margin = new System.Windows.Forms.Padding(4);
            this.pictBox_avatar.Name = "pictBox_avatar";
            this.pictBox_avatar.Size = new System.Drawing.Size(105, 83);
            this.pictBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBox_avatar.TabIndex = 49;
            this.pictBox_avatar.TabStop = false;
            // 
            // lbl_nomEntreprise
            // 
            this.lbl_nomEntreprise.AutoSize = true;
            this.lbl_nomEntreprise.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomEntreprise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_nomEntreprise.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomEntreprise.ForeColor = System.Drawing.Color.White;
            this.lbl_nomEntreprise.Location = new System.Drawing.Point(48, 25);
            this.lbl_nomEntreprise.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_nomEntreprise.Name = "lbl_nomEntreprise";
            this.lbl_nomEntreprise.Size = new System.Drawing.Size(111, 40);
            this.lbl_nomEntreprise.TabIndex = 47;
            this.lbl_nomEntreprise.Text = "V&&Co";
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitter.Image = global::projet_V_Co.Properties.Resources.btn_quitter;
            this.btn_quitter.Location = new System.Drawing.Point(1852, 955);
            this.btn_quitter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(52, 50);
            this.btn_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quitter.TabIndex = 51;
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
            this.lbl_titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_titre.Name = "lbl_titre";
            this.lbl_titre.Padding = new System.Windows.Forms.Padding(0, 37, 0, 0);
            this.lbl_titre.Size = new System.Drawing.Size(1917, 101);
            this.lbl_titre.TabIndex = 48;
            this.lbl_titre.Text = "Gérer les Utilisateurs";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_modifUtilisateur
            // 
            this.btn_modifUtilisateur.CornerRoundingRadius = 50F;
            this.btn_modifUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modifUtilisateur.Location = new System.Drawing.Point(365, 699);
            this.btn_modifUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.btn_modifUtilisateur.Name = "btn_modifUtilisateur";
            this.btn_modifUtilisateur.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifUtilisateur.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifUtilisateur.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifUtilisateur.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifUtilisateur.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modifUtilisateur.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_modifUtilisateur.Size = new System.Drawing.Size(170, 68);
            this.btn_modifUtilisateur.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_modifUtilisateur.StateCommon.Border.Rounding = 50F;
            this.btn_modifUtilisateur.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifUtilisateur.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifUtilisateur.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifUtilisateur.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifUtilisateur.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifUtilisateur.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modifUtilisateur.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_modifUtilisateur.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_modifUtilisateur.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifUtilisateur.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifUtilisateur.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modifUtilisateur.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_modifUtilisateur.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_modifUtilisateur.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifUtilisateur.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifUtilisateur.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifUtilisateur.TabIndex = 54;
            this.btn_modifUtilisateur.Values.Text = "Modifier";
            this.btn_modifUtilisateur.Click += new System.EventHandler(this.btn_modifUtilisateur_Click);
            // 
            // btn_suppUtilisateur
            // 
            this.btn_suppUtilisateur.CornerRoundingRadius = 50F;
            this.btn_suppUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suppUtilisateur.Location = new System.Drawing.Point(623, 699);
            this.btn_suppUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.btn_suppUtilisateur.Name = "btn_suppUtilisateur";
            this.btn_suppUtilisateur.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppUtilisateur.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppUtilisateur.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppUtilisateur.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppUtilisateur.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suppUtilisateur.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_suppUtilisateur.Size = new System.Drawing.Size(172, 68);
            this.btn_suppUtilisateur.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_suppUtilisateur.StateCommon.Border.Rounding = 50F;
            this.btn_suppUtilisateur.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppUtilisateur.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppUtilisateur.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppUtilisateur.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppUtilisateur.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppUtilisateur.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suppUtilisateur.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_suppUtilisateur.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_suppUtilisateur.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppUtilisateur.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppUtilisateur.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suppUtilisateur.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_suppUtilisateur.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_suppUtilisateur.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppUtilisateur.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppUtilisateur.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppUtilisateur.TabIndex = 53;
            this.btn_suppUtilisateur.Values.Text = "Supprimer";
            this.btn_suppUtilisateur.Click += new System.EventHandler(this.btn_suppUtilisateur_Click);
            // 
            // panel_lesUtilisateurs
            // 
            this.panel_lesUtilisateurs.BackColor = System.Drawing.Color.Transparent;
            this.panel_lesUtilisateurs.BackgroundImage = global::projet_V_Co.Properties.Resources.fond_connexion2;
            this.panel_lesUtilisateurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_lesUtilisateurs.Controls.Add(this.dataGridView_utilisateurs);
            this.panel_lesUtilisateurs.Controls.Add(this.lbl_titreLesUti);
            this.panel_lesUtilisateurs.Location = new System.Drawing.Point(228, 158);
            this.panel_lesUtilisateurs.Name = "panel_lesUtilisateurs";
            this.panel_lesUtilisateurs.Size = new System.Drawing.Size(602, 839);
            this.panel_lesUtilisateurs.TabIndex = 56;
            // 
            // dataGridView_utilisateurs
            // 
            this.dataGridView_utilisateurs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_utilisateurs.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_utilisateurs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_utilisateurs.Location = new System.Drawing.Point(43, 119);
            this.dataGridView_utilisateurs.MultiSelect = false;
            this.dataGridView_utilisateurs.Name = "dataGridView_utilisateurs";
            this.dataGridView_utilisateurs.RowHeadersVisible = false;
            this.dataGridView_utilisateurs.RowHeadersWidth = 51;
            this.dataGridView_utilisateurs.RowTemplate.Height = 24;
            this.dataGridView_utilisateurs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_utilisateurs.Size = new System.Drawing.Size(486, 652);
            this.dataGridView_utilisateurs.TabIndex = 58;
            // 
            // lbl_titreLesUti
            // 
            this.lbl_titreLesUti.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titreLesUti.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreLesUti.Location = new System.Drawing.Point(0, 0);
            this.lbl_titreLesUti.Name = "lbl_titreLesUti";
            this.lbl_titreLesUti.Size = new System.Drawing.Size(602, 116);
            this.lbl_titreLesUti.TabIndex = 57;
            this.lbl_titreLesUti.Text = "Les Utilisateurs";
            this.lbl_titreLesUti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_ajoutUtilisateur
            // 
            this.btn_ajoutUtilisateur.CornerRoundingRadius = 50F;
            this.btn_ajoutUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajoutUtilisateur.Location = new System.Drawing.Point(89, 699);
            this.btn_ajoutUtilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.btn_ajoutUtilisateur.Name = "btn_ajoutUtilisateur";
            this.btn_ajoutUtilisateur.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutUtilisateur.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutUtilisateur.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutUtilisateur.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutUtilisateur.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajoutUtilisateur.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_ajoutUtilisateur.Size = new System.Drawing.Size(170, 68);
            this.btn_ajoutUtilisateur.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ajoutUtilisateur.StateCommon.Border.Rounding = 50F;
            this.btn_ajoutUtilisateur.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutUtilisateur.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutUtilisateur.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutUtilisateur.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutUtilisateur.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutUtilisateur.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajoutUtilisateur.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_ajoutUtilisateur.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_ajoutUtilisateur.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutUtilisateur.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutUtilisateur.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajoutUtilisateur.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_ajoutUtilisateur.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_ajoutUtilisateur.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutUtilisateur.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutUtilisateur.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutUtilisateur.TabIndex = 56;
            this.btn_ajoutUtilisateur.Values.Text = "Ajouter";
            this.btn_ajoutUtilisateur.Click += new System.EventHandler(this.btn_ajoutUtilisateur_Click);
            // 
            // panel_informations
            // 
            this.panel_informations.BackColor = System.Drawing.Color.Transparent;
            this.panel_informations.BackgroundImage = global::projet_V_Co.Properties.Resources.fond_connexion2;
            this.panel_informations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_informations.Controls.Add(this.txtbox_role);
            this.panel_informations.Controls.Add(this.txtbox_login);
            this.panel_informations.Controls.Add(this.btn_ajoutUtilisateur);
            this.panel_informations.Controls.Add(this.txtbox_prenom);
            this.panel_informations.Controls.Add(this.txtbox_nom);
            this.panel_informations.Controls.Add(this.lbl_login);
            this.panel_informations.Controls.Add(this.lbl_role);
            this.panel_informations.Controls.Add(this.lbl_prenom);
            this.panel_informations.Controls.Add(this.lbl_nom);
            this.panel_informations.Controls.Add(this.lbl_titreInfos);
            this.panel_informations.Controls.Add(this.btn_modifUtilisateur);
            this.panel_informations.Controls.Add(this.btn_suppUtilisateur);
            this.panel_informations.Location = new System.Drawing.Point(858, 158);
            this.panel_informations.Name = "panel_informations";
            this.panel_informations.Size = new System.Drawing.Size(912, 839);
            this.panel_informations.TabIndex = 57;
            // 
            // txtbox_role
            // 
            this.txtbox_role.CornerRoundingRadius = 20F;
            this.txtbox_role.Location = new System.Drawing.Point(200, 412);
            this.txtbox_role.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_role.Name = "txtbox_role";
            this.txtbox_role.Size = new System.Drawing.Size(353, 42);
            this.txtbox_role.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_role.StateCommon.Border.Rounding = 20F;
            this.txtbox_role.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_role.TabIndex = 62;
            // 
            // txtbox_login
            // 
            this.txtbox_login.CornerRoundingRadius = 20F;
            this.txtbox_login.Location = new System.Drawing.Point(218, 536);
            this.txtbox_login.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_login.Name = "txtbox_login";
            this.txtbox_login.Size = new System.Drawing.Size(353, 42);
            this.txtbox_login.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_login.StateCommon.Border.Rounding = 20F;
            this.txtbox_login.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_login.TabIndex = 63;
            // 
            // txtbox_prenom
            // 
            this.txtbox_prenom.CornerRoundingRadius = 20F;
            this.txtbox_prenom.Location = new System.Drawing.Point(254, 287);
            this.txtbox_prenom.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_prenom.Name = "txtbox_prenom";
            this.txtbox_prenom.Size = new System.Drawing.Size(353, 42);
            this.txtbox_prenom.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_prenom.StateCommon.Border.Rounding = 20F;
            this.txtbox_prenom.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_prenom.TabIndex = 61;
            // 
            // txtbox_nom
            // 
            this.txtbox_nom.CornerRoundingRadius = 20F;
            this.txtbox_nom.Location = new System.Drawing.Point(206, 184);
            this.txtbox_nom.Margin = new System.Windows.Forms.Padding(4);
            this.txtbox_nom.Name = "txtbox_nom";
            this.txtbox_nom.Size = new System.Drawing.Size(353, 42);
            this.txtbox_nom.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_nom.StateCommon.Border.Rounding = 20F;
            this.txtbox_nom.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_nom.TabIndex = 60;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.BackColor = System.Drawing.Color.Transparent;
            this.lbl_login.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(82, 536);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(129, 40);
            this.lbl_login.TabIndex = 59;
            this.lbl_login.Text = "Login :";
            // 
            // lbl_role
            // 
            this.lbl_role.AutoSize = true;
            this.lbl_role.BackColor = System.Drawing.Color.Transparent;
            this.lbl_role.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_role.Location = new System.Drawing.Point(82, 412);
            this.lbl_role.Name = "lbl_role";
            this.lbl_role.Size = new System.Drawing.Size(111, 40);
            this.lbl_role.TabIndex = 58;
            this.lbl_role.Text = "Rôle :";
            // 
            // lbl_prenom
            // 
            this.lbl_prenom.AutoSize = true;
            this.lbl_prenom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_prenom.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prenom.Location = new System.Drawing.Point(82, 287);
            this.lbl_prenom.Name = "lbl_prenom";
            this.lbl_prenom.Size = new System.Drawing.Size(165, 40);
            this.lbl_prenom.TabIndex = 57;
            this.lbl_prenom.Text = "Prénom :";
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nom.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(82, 184);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(105, 40);
            this.lbl_nom.TabIndex = 56;
            this.lbl_nom.Text = "Nom:";
            // 
            // lbl_titreInfos
            // 
            this.lbl_titreInfos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titreInfos.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreInfos.Location = new System.Drawing.Point(0, 0);
            this.lbl_titreInfos.Name = "lbl_titreInfos";
            this.lbl_titreInfos.Size = new System.Drawing.Size(912, 116);
            this.lbl_titreInfos.TabIndex = 55;
            this.lbl_titreInfos.Text = "Informations";
            this.lbl_titreInfos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_GererUtilisateurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::projet_V_Co.Properties.Resources.Fond_test_H;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1917, 1009);
            this.Controls.Add(this.panel_lesUtilisateurs);
            this.Controls.Add(this.lbl_deconnexion);
            this.Controls.Add(this.pictBox_avatar);
            this.Controls.Add(this.lbl_nomEntreprise);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.panel_informations);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_GererUtilisateurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_GererUtilisateurs";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).EndInit();
            this.panel_lesUtilisateurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_utilisateurs)).EndInit();
            this.panel_informations.ResumeLayout(false);
            this.panel_informations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_deconnexion;
        private System.Windows.Forms.PictureBox pictBox_avatar;
        private System.Windows.Forms.Label lbl_nomEntreprise;
        private System.Windows.Forms.PictureBox btn_quitter;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Krypton.Toolkit.KryptonButton btn_modifUtilisateur;
        private Krypton.Toolkit.KryptonButton btn_suppUtilisateur;
        private System.Windows.Forms.Panel panel_lesUtilisateurs;
        private Krypton.Toolkit.KryptonButton btn_ajoutUtilisateur;
        private System.Windows.Forms.Panel panel_informations;
        private System.Windows.Forms.Label lbl_titreLesUti;
        private System.Windows.Forms.Label lbl_titreInfos;
        private System.Windows.Forms.DataGridView dataGridView_utilisateurs;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.Label lbl_role;
        private System.Windows.Forms.Label lbl_prenom;
        private System.Windows.Forms.Label lbl_nom;
        private Krypton.Toolkit.KryptonTextBox txtbox_role;
        private Krypton.Toolkit.KryptonTextBox txtbox_login;
        private Krypton.Toolkit.KryptonTextBox txtbox_prenom;
        private Krypton.Toolkit.KryptonTextBox txtbox_nom;
    }
}