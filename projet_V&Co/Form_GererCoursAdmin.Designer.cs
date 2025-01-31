namespace projet_V_Co
{
    partial class Form_GererCoursAdmin
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
            this.pictBox_avatar = new System.Windows.Forms.PictureBox();
            this.txtbox_contenuCours = new System.Windows.Forms.TextBox();
            this.lbl_contenu = new System.Windows.Forms.Label();
            this.txtbox_theme = new Krypton.Toolkit.KryptonTextBox();
            this.lbl_theme = new System.Windows.Forms.Label();
            this.btn_quitter = new System.Windows.Forms.PictureBox();
            this.btn_modifCours = new Krypton.Toolkit.KryptonButton();
            this.btn_suppCours = new Krypton.Toolkit.KryptonButton();
            this.lbl_nomEntreprise = new System.Windows.Forms.Label();
            this.dataGridView_cours = new System.Windows.Forms.DataGridView();
            this.lbl_titreLesCours = new System.Windows.Forms.Label();
            this.panel_lesUtilisateurs = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_ajoutCours = new Krypton.Toolkit.KryptonButton();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.panel_informations = new System.Windows.Forms.Panel();
            this.txtbox_image = new Krypton.Toolkit.KryptonTextBox();
            this.txtbox_titre = new Krypton.Toolkit.KryptonTextBox();
            this.lbl_image = new System.Windows.Forms.Label();
            this.lbl_titreRecap = new System.Windows.Forms.Label();
            this.lbl_deconnexion = new System.Windows.Forms.Label();
            this.lbl_titre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cours)).BeginInit();
            this.panel_lesUtilisateurs.SuspendLayout();
            this.panel_informations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictBox_avatar
            // 
            this.pictBox_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pictBox_avatar.Image = global::projet_V_Co.Properties.Resources.logo_Utilisateur;
            this.pictBox_avatar.Location = new System.Drawing.Point(1257, 1);
            this.pictBox_avatar.Name = "pictBox_avatar";
            this.pictBox_avatar.Size = new System.Drawing.Size(79, 67);
            this.pictBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBox_avatar.TabIndex = 88;
            this.pictBox_avatar.TabStop = false;
            // 
            // txtbox_contenuCours
            // 
            this.txtbox_contenuCours.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_contenuCours.Location = new System.Drawing.Point(67, 323);
            this.txtbox_contenuCours.Margin = new System.Windows.Forms.Padding(2);
            this.txtbox_contenuCours.Multiline = true;
            this.txtbox_contenuCours.Name = "txtbox_contenuCours";
            this.txtbox_contenuCours.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtbox_contenuCours.Size = new System.Drawing.Size(529, 219);
            this.txtbox_contenuCours.TabIndex = 65;
            this.txtbox_contenuCours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_contenu
            // 
            this.lbl_contenu.AutoSize = true;
            this.lbl_contenu.BackColor = System.Drawing.Color.Transparent;
            this.lbl_contenu.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_contenu.Location = new System.Drawing.Point(62, 289);
            this.lbl_contenu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_contenu.Name = "lbl_contenu";
            this.lbl_contenu.Size = new System.Drawing.Size(144, 32);
            this.lbl_contenu.TabIndex = 64;
            this.lbl_contenu.Text = "Contenu :";
            // 
            // txtbox_theme
            // 
            this.txtbox_theme.CornerRoundingRadius = 20F;
            this.txtbox_theme.Location = new System.Drawing.Point(190, 223);
            this.txtbox_theme.Name = "txtbox_theme";
            this.txtbox_theme.Size = new System.Drawing.Size(121, 38);
            this.txtbox_theme.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_theme.StateCommon.Border.Rounding = 20F;
            this.txtbox_theme.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_theme.TabIndex = 63;
            // 
            // lbl_theme
            // 
            this.lbl_theme.AutoSize = true;
            this.lbl_theme.BackColor = System.Drawing.Color.Transparent;
            this.lbl_theme.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_theme.Location = new System.Drawing.Point(62, 228);
            this.lbl_theme.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_theme.Name = "lbl_theme";
            this.lbl_theme.Size = new System.Drawing.Size(123, 32);
            this.lbl_theme.TabIndex = 62;
            this.lbl_theme.Text = "Thème :";
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitter.Image = global::projet_V_Co.Properties.Resources.btn_quitter;
            this.btn_quitter.Location = new System.Drawing.Point(1386, 759);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(39, 41);
            this.btn_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quitter.TabIndex = 90;
            this.btn_quitter.TabStop = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // btn_modifCours
            // 
            this.btn_modifCours.CornerRoundingRadius = 50F;
            this.btn_modifCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modifCours.Location = new System.Drawing.Point(274, 568);
            this.btn_modifCours.Name = "btn_modifCours";
            this.btn_modifCours.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifCours.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifCours.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifCours.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifCours.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modifCours.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_modifCours.Size = new System.Drawing.Size(128, 55);
            this.btn_modifCours.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_modifCours.StateCommon.Border.Rounding = 50F;
            this.btn_modifCours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifCours.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifCours.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifCours.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifCours.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifCours.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modifCours.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_modifCours.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_modifCours.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifCours.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifCours.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modifCours.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_modifCours.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_modifCours.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifCours.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifCours.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifCours.TabIndex = 54;
            this.btn_modifCours.Values.Text = "Modifier";
            this.btn_modifCours.Click += new System.EventHandler(this.btn_modifCours_Click);
            // 
            // btn_suppCours
            // 
            this.btn_suppCours.CornerRoundingRadius = 50F;
            this.btn_suppCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suppCours.Location = new System.Drawing.Point(467, 568);
            this.btn_suppCours.Name = "btn_suppCours";
            this.btn_suppCours.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppCours.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppCours.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppCours.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppCours.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suppCours.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_suppCours.Size = new System.Drawing.Size(129, 55);
            this.btn_suppCours.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_suppCours.StateCommon.Border.Rounding = 50F;
            this.btn_suppCours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppCours.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppCours.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppCours.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppCours.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppCours.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suppCours.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_suppCours.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_suppCours.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppCours.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppCours.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suppCours.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_suppCours.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_suppCours.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppCours.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppCours.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppCours.TabIndex = 53;
            this.btn_suppCours.Values.Text = "Supprimer";
            this.btn_suppCours.Click += new System.EventHandler(this.btn_suppCours_Click);
            // 
            // lbl_nomEntreprise
            // 
            this.lbl_nomEntreprise.AutoSize = true;
            this.lbl_nomEntreprise.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomEntreprise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_nomEntreprise.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomEntreprise.ForeColor = System.Drawing.Color.White;
            this.lbl_nomEntreprise.Location = new System.Drawing.Point(33, 3);
            this.lbl_nomEntreprise.Name = "lbl_nomEntreprise";
            this.lbl_nomEntreprise.Size = new System.Drawing.Size(89, 32);
            this.lbl_nomEntreprise.TabIndex = 86;
            this.lbl_nomEntreprise.Text = "V&&Co";
            // 
            // dataGridView_cours
            // 
            this.dataGridView_cours.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_cours.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_cours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_cours.Location = new System.Drawing.Point(32, 97);
            this.dataGridView_cours.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_cours.MultiSelect = false;
            this.dataGridView_cours.Name = "dataGridView_cours";
            this.dataGridView_cours.RowHeadersVisible = false;
            this.dataGridView_cours.RowHeadersWidth = 51;
            this.dataGridView_cours.RowTemplate.Height = 24;
            this.dataGridView_cours.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_cours.Size = new System.Drawing.Size(364, 530);
            this.dataGridView_cours.TabIndex = 58;
            // 
            // lbl_titreLesCours
            // 
            this.lbl_titreLesCours.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titreLesCours.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreLesCours.Location = new System.Drawing.Point(0, 0);
            this.lbl_titreLesCours.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titreLesCours.Name = "lbl_titreLesCours";
            this.lbl_titreLesCours.Size = new System.Drawing.Size(452, 94);
            this.lbl_titreLesCours.TabIndex = 57;
            this.lbl_titreLesCours.Text = "Les Cours";
            this.lbl_titreLesCours.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_lesUtilisateurs
            // 
            this.panel_lesUtilisateurs.BackColor = System.Drawing.Color.Transparent;
            this.panel_lesUtilisateurs.BackgroundImage = global::projet_V_Co.Properties.Resources.fond_connexion2;
            this.panel_lesUtilisateurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_lesUtilisateurs.Controls.Add(this.dataGridView_cours);
            this.panel_lesUtilisateurs.Controls.Add(this.lbl_titreLesCours);
            this.panel_lesUtilisateurs.Location = new System.Drawing.Point(168, 111);
            this.panel_lesUtilisateurs.Margin = new System.Windows.Forms.Padding(2);
            this.panel_lesUtilisateurs.Name = "panel_lesUtilisateurs";
            this.panel_lesUtilisateurs.Size = new System.Drawing.Size(452, 682);
            this.panel_lesUtilisateurs.TabIndex = 91;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_ajoutCours
            // 
            this.btn_ajoutCours.CornerRoundingRadius = 50F;
            this.btn_ajoutCours.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajoutCours.Location = new System.Drawing.Point(67, 568);
            this.btn_ajoutCours.Name = "btn_ajoutCours";
            this.btn_ajoutCours.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutCours.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutCours.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutCours.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutCours.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajoutCours.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_ajoutCours.Size = new System.Drawing.Size(128, 55);
            this.btn_ajoutCours.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ajoutCours.StateCommon.Border.Rounding = 50F;
            this.btn_ajoutCours.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutCours.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutCours.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutCours.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutCours.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutCours.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajoutCours.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_ajoutCours.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_ajoutCours.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutCours.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutCours.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajoutCours.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_ajoutCours.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_ajoutCours.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutCours.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutCours.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutCours.TabIndex = 56;
            this.btn_ajoutCours.Values.Text = "Ajouter";
            this.btn_ajoutCours.Click += new System.EventHandler(this.btn_ajoutCours_Click);
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nom.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(62, 99);
            this.lbl_nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(93, 32);
            this.lbl_nom.TabIndex = 56;
            this.lbl_nom.Text = "Titre :";
            // 
            // panel_informations
            // 
            this.panel_informations.BackColor = System.Drawing.Color.Transparent;
            this.panel_informations.BackgroundImage = global::projet_V_Co.Properties.Resources.fond_connexion2;
            this.panel_informations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_informations.Controls.Add(this.txtbox_contenuCours);
            this.panel_informations.Controls.Add(this.lbl_contenu);
            this.panel_informations.Controls.Add(this.txtbox_theme);
            this.panel_informations.Controls.Add(this.lbl_theme);
            this.panel_informations.Controls.Add(this.btn_ajoutCours);
            this.panel_informations.Controls.Add(this.txtbox_image);
            this.panel_informations.Controls.Add(this.txtbox_titre);
            this.panel_informations.Controls.Add(this.lbl_image);
            this.panel_informations.Controls.Add(this.lbl_nom);
            this.panel_informations.Controls.Add(this.lbl_titreRecap);
            this.panel_informations.Controls.Add(this.btn_modifCours);
            this.panel_informations.Controls.Add(this.btn_suppCours);
            this.panel_informations.Location = new System.Drawing.Point(641, 111);
            this.panel_informations.Margin = new System.Windows.Forms.Padding(2);
            this.panel_informations.Name = "panel_informations";
            this.panel_informations.Size = new System.Drawing.Size(684, 682);
            this.panel_informations.TabIndex = 92;
            // 
            // txtbox_image
            // 
            this.txtbox_image.CornerRoundingRadius = 20F;
            this.txtbox_image.Location = new System.Drawing.Point(194, 162);
            this.txtbox_image.Name = "txtbox_image";
            this.txtbox_image.Size = new System.Drawing.Size(417, 38);
            this.txtbox_image.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_image.StateCommon.Border.Rounding = 20F;
            this.txtbox_image.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_image.TabIndex = 61;
            // 
            // txtbox_titre
            // 
            this.txtbox_titre.CornerRoundingRadius = 20F;
            this.txtbox_titre.Location = new System.Drawing.Point(154, 99);
            this.txtbox_titre.Name = "txtbox_titre";
            this.txtbox_titre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtbox_titre.Size = new System.Drawing.Size(457, 38);
            this.txtbox_titre.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_titre.StateCommon.Border.Rounding = 20F;
            this.txtbox_titre.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_titre.TabIndex = 60;
            // 
            // lbl_image
            // 
            this.lbl_image.AutoSize = true;
            this.lbl_image.BackColor = System.Drawing.Color.Transparent;
            this.lbl_image.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_image.Location = new System.Drawing.Point(62, 162);
            this.lbl_image.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(113, 32);
            this.lbl_image.TabIndex = 57;
            this.lbl_image.Text = "Image :";
            // 
            // lbl_titreRecap
            // 
            this.lbl_titreRecap.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titreRecap.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreRecap.Location = new System.Drawing.Point(0, 0);
            this.lbl_titreRecap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titreRecap.Name = "lbl_titreRecap";
            this.lbl_titreRecap.Size = new System.Drawing.Size(684, 94);
            this.lbl_titreRecap.TabIndex = 55;
            this.lbl_titreRecap.Text = "Recap";
            this.lbl_titreRecap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_deconnexion
            // 
            this.lbl_deconnexion.AutoSize = true;
            this.lbl_deconnexion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_deconnexion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deconnexion.ForeColor = System.Drawing.Color.White;
            this.lbl_deconnexion.Location = new System.Drawing.Point(1250, 65);
            this.lbl_deconnexion.Name = "lbl_deconnexion";
            this.lbl_deconnexion.Size = new System.Drawing.Size(99, 18);
            this.lbl_deconnexion.TabIndex = 89;
            this.lbl_deconnexion.Text = "Déconnexion";
            this.lbl_deconnexion.Click += new System.EventHandler(this.lbl_deconnexion_Click);
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
            this.lbl_titre.TabIndex = 87;
            this.lbl_titre.Text = "Gérer les Cours";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_GererCoursAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::projet_V_Co.Properties.Resources.Fond_test_H;
            this.ClientSize = new System.Drawing.Size(1438, 820);
            this.Controls.Add(this.pictBox_avatar);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.lbl_nomEntreprise);
            this.Controls.Add(this.panel_lesUtilisateurs);
            this.Controls.Add(this.panel_informations);
            this.Controls.Add(this.lbl_deconnexion);
            this.Controls.Add(this.lbl_titre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_GererCoursAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_GererCoursAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_cours)).EndInit();
            this.panel_lesUtilisateurs.ResumeLayout(false);
            this.panel_informations.ResumeLayout(false);
            this.panel_informations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBox_avatar;
        private System.Windows.Forms.TextBox txtbox_contenuCours;
        private System.Windows.Forms.Label lbl_contenu;
        private Krypton.Toolkit.KryptonTextBox txtbox_theme;
        private System.Windows.Forms.Label lbl_theme;
        private System.Windows.Forms.PictureBox btn_quitter;
        private Krypton.Toolkit.KryptonButton btn_modifCours;
        private Krypton.Toolkit.KryptonButton btn_suppCours;
        private System.Windows.Forms.Label lbl_nomEntreprise;
        private System.Windows.Forms.DataGridView dataGridView_cours;
        private System.Windows.Forms.Label lbl_titreLesCours;
        private System.Windows.Forms.Panel panel_lesUtilisateurs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Krypton.Toolkit.KryptonButton btn_ajoutCours;
        private System.Windows.Forms.Label lbl_nom;
        private System.Windows.Forms.Panel panel_informations;
        private Krypton.Toolkit.KryptonTextBox txtbox_image;
        private Krypton.Toolkit.KryptonTextBox txtbox_titre;
        private System.Windows.Forms.Label lbl_image;
        private System.Windows.Forms.Label lbl_titreRecap;
        private System.Windows.Forms.Label lbl_deconnexion;
        private System.Windows.Forms.Label lbl_titre;
    }
}