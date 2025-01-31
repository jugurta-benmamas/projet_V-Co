namespace projet_V_Co
{
    partial class Form_GererThemesFormateur
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
            this.lbl_nomEntreprise = new System.Windows.Forms.Label();
            this.btn_quitter = new System.Windows.Forms.PictureBox();
            this.lbl_deconnexion = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btn_ajoutTheme = new Krypton.Toolkit.KryptonButton();
            this.panel_lesUtilisateurs = new System.Windows.Forms.Panel();
            this.dataGridView_themes = new System.Windows.Forms.DataGridView();
            this.lbl_titreLesThemes = new System.Windows.Forms.Label();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.btn_modifTheme = new Krypton.Toolkit.KryptonButton();
            this.panel_informations = new System.Windows.Forms.Panel();
            this.txtbox_module = new Krypton.Toolkit.KryptonTextBox();
            this.txtbox_titre = new Krypton.Toolkit.KryptonTextBox();
            this.lbl_module = new System.Windows.Forms.Label();
            this.lbl_titreRecap = new System.Windows.Forms.Label();
            this.btn_suppTheme = new Krypton.Toolkit.KryptonButton();
            this.lbl_titre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).BeginInit();
            this.panel_lesUtilisateurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_themes)).BeginInit();
            this.panel_informations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictBox_avatar
            // 
            this.pictBox_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pictBox_avatar.Image = global::projet_V_Co.Properties.Resources.logo_Utilisateur;
            this.pictBox_avatar.Location = new System.Drawing.Point(1260, 21);
            this.pictBox_avatar.Name = "pictBox_avatar";
            this.pictBox_avatar.Size = new System.Drawing.Size(79, 67);
            this.pictBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBox_avatar.TabIndex = 67;
            this.pictBox_avatar.TabStop = false;
            // 
            // lbl_nomEntreprise
            // 
            this.lbl_nomEntreprise.AutoSize = true;
            this.lbl_nomEntreprise.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomEntreprise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_nomEntreprise.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomEntreprise.ForeColor = System.Drawing.Color.White;
            this.lbl_nomEntreprise.Location = new System.Drawing.Point(36, 23);
            this.lbl_nomEntreprise.Name = "lbl_nomEntreprise";
            this.lbl_nomEntreprise.Size = new System.Drawing.Size(89, 32);
            this.lbl_nomEntreprise.TabIndex = 65;
            this.lbl_nomEntreprise.Text = "V&&Co";
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitter.Image = global::projet_V_Co.Properties.Resources.btn_quitter;
            this.btn_quitter.Location = new System.Drawing.Point(1389, 779);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(39, 41);
            this.btn_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quitter.TabIndex = 69;
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
            this.lbl_deconnexion.Location = new System.Drawing.Point(1253, 85);
            this.lbl_deconnexion.Name = "lbl_deconnexion";
            this.lbl_deconnexion.Size = new System.Drawing.Size(99, 18);
            this.lbl_deconnexion.TabIndex = 68;
            this.lbl_deconnexion.Text = "Déconnexion";
            this.lbl_deconnexion.Click += new System.EventHandler(this.lbl_deconnexion_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btn_ajoutTheme
            // 
            this.btn_ajoutTheme.CornerRoundingRadius = 50F;
            this.btn_ajoutTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajoutTheme.Location = new System.Drawing.Point(67, 568);
            this.btn_ajoutTheme.Name = "btn_ajoutTheme";
            this.btn_ajoutTheme.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutTheme.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutTheme.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutTheme.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutTheme.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajoutTheme.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_ajoutTheme.Size = new System.Drawing.Size(128, 55);
            this.btn_ajoutTheme.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ajoutTheme.StateCommon.Border.Rounding = 50F;
            this.btn_ajoutTheme.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutTheme.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutTheme.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutTheme.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutTheme.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutTheme.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajoutTheme.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_ajoutTheme.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_ajoutTheme.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutTheme.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutTheme.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajoutTheme.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_ajoutTheme.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_ajoutTheme.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutTheme.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutTheme.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutTheme.TabIndex = 56;
            this.btn_ajoutTheme.Values.Text = "Ajouter";
            this.btn_ajoutTheme.Click += new System.EventHandler(this.btn_ajoutTheme_Click);
            // 
            // panel_lesUtilisateurs
            // 
            this.panel_lesUtilisateurs.BackColor = System.Drawing.Color.Transparent;
            this.panel_lesUtilisateurs.BackgroundImage = global::projet_V_Co.Properties.Resources.fond_connexion2;
            this.panel_lesUtilisateurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_lesUtilisateurs.Controls.Add(this.dataGridView_themes);
            this.panel_lesUtilisateurs.Controls.Add(this.lbl_titreLesThemes);
            this.panel_lesUtilisateurs.Location = new System.Drawing.Point(171, 131);
            this.panel_lesUtilisateurs.Margin = new System.Windows.Forms.Padding(2);
            this.panel_lesUtilisateurs.Name = "panel_lesUtilisateurs";
            this.panel_lesUtilisateurs.Size = new System.Drawing.Size(452, 682);
            this.panel_lesUtilisateurs.TabIndex = 70;
            // 
            // dataGridView_themes
            // 
            this.dataGridView_themes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_themes.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_themes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_themes.Location = new System.Drawing.Point(32, 97);
            this.dataGridView_themes.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView_themes.MultiSelect = false;
            this.dataGridView_themes.Name = "dataGridView_themes";
            this.dataGridView_themes.RowHeadersVisible = false;
            this.dataGridView_themes.RowHeadersWidth = 51;
            this.dataGridView_themes.RowTemplate.Height = 24;
            this.dataGridView_themes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_themes.Size = new System.Drawing.Size(364, 530);
            this.dataGridView_themes.TabIndex = 58;
            // 
            // lbl_titreLesThemes
            // 
            this.lbl_titreLesThemes.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titreLesThemes.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreLesThemes.Location = new System.Drawing.Point(0, 0);
            this.lbl_titreLesThemes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titreLesThemes.Name = "lbl_titreLesThemes";
            this.lbl_titreLesThemes.Size = new System.Drawing.Size(452, 94);
            this.lbl_titreLesThemes.TabIndex = 57;
            this.lbl_titreLesThemes.Text = "Les Thèmes";
            this.lbl_titreLesThemes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nom
            // 
            this.lbl_nom.AutoSize = true;
            this.lbl_nom.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nom.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom.Location = new System.Drawing.Point(62, 150);
            this.lbl_nom.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_nom.Name = "lbl_nom";
            this.lbl_nom.Size = new System.Drawing.Size(93, 32);
            this.lbl_nom.TabIndex = 56;
            this.lbl_nom.Text = "Titre :";
            // 
            // btn_modifTheme
            // 
            this.btn_modifTheme.CornerRoundingRadius = 50F;
            this.btn_modifTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modifTheme.Location = new System.Drawing.Point(274, 568);
            this.btn_modifTheme.Name = "btn_modifTheme";
            this.btn_modifTheme.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifTheme.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifTheme.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifTheme.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifTheme.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modifTheme.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_modifTheme.Size = new System.Drawing.Size(128, 55);
            this.btn_modifTheme.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_modifTheme.StateCommon.Border.Rounding = 50F;
            this.btn_modifTheme.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifTheme.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifTheme.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifTheme.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifTheme.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifTheme.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modifTheme.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_modifTheme.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_modifTheme.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifTheme.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifTheme.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modifTheme.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_modifTheme.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_modifTheme.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifTheme.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifTheme.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifTheme.TabIndex = 54;
            this.btn_modifTheme.Values.Text = "Modifier";
            this.btn_modifTheme.Click += new System.EventHandler(this.btn_modifTheme_Click);
            // 
            // panel_informations
            // 
            this.panel_informations.BackColor = System.Drawing.Color.Transparent;
            this.panel_informations.BackgroundImage = global::projet_V_Co.Properties.Resources.fond_connexion2;
            this.panel_informations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_informations.Controls.Add(this.btn_ajoutTheme);
            this.panel_informations.Controls.Add(this.txtbox_module);
            this.panel_informations.Controls.Add(this.txtbox_titre);
            this.panel_informations.Controls.Add(this.lbl_module);
            this.panel_informations.Controls.Add(this.lbl_nom);
            this.panel_informations.Controls.Add(this.lbl_titreRecap);
            this.panel_informations.Controls.Add(this.btn_modifTheme);
            this.panel_informations.Controls.Add(this.btn_suppTheme);
            this.panel_informations.Location = new System.Drawing.Point(644, 131);
            this.panel_informations.Margin = new System.Windows.Forms.Padding(2);
            this.panel_informations.Name = "panel_informations";
            this.panel_informations.Size = new System.Drawing.Size(684, 682);
            this.panel_informations.TabIndex = 71;
            // 
            // txtbox_module
            // 
            this.txtbox_module.CornerRoundingRadius = 20F;
            this.txtbox_module.Location = new System.Drawing.Point(194, 233);
            this.txtbox_module.Name = "txtbox_module";
            this.txtbox_module.Size = new System.Drawing.Size(121, 38);
            this.txtbox_module.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_module.StateCommon.Border.Rounding = 20F;
            this.txtbox_module.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_module.TabIndex = 61;
            // 
            // txtbox_titre
            // 
            this.txtbox_titre.CornerRoundingRadius = 20F;
            this.txtbox_titre.Location = new System.Drawing.Point(154, 150);
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
            // lbl_module
            // 
            this.lbl_module.AutoSize = true;
            this.lbl_module.BackColor = System.Drawing.Color.Transparent;
            this.lbl_module.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_module.Location = new System.Drawing.Point(62, 233);
            this.lbl_module.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_module.Name = "lbl_module";
            this.lbl_module.Size = new System.Drawing.Size(127, 32);
            this.lbl_module.TabIndex = 57;
            this.lbl_module.Text = "Module :";
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
            // btn_suppTheme
            // 
            this.btn_suppTheme.CornerRoundingRadius = 50F;
            this.btn_suppTheme.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suppTheme.Location = new System.Drawing.Point(467, 568);
            this.btn_suppTheme.Name = "btn_suppTheme";
            this.btn_suppTheme.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppTheme.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppTheme.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppTheme.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppTheme.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suppTheme.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_suppTheme.Size = new System.Drawing.Size(129, 55);
            this.btn_suppTheme.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_suppTheme.StateCommon.Border.Rounding = 50F;
            this.btn_suppTheme.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppTheme.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppTheme.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppTheme.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppTheme.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppTheme.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suppTheme.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_suppTheme.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_suppTheme.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppTheme.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppTheme.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suppTheme.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_suppTheme.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_suppTheme.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppTheme.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppTheme.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppTheme.TabIndex = 53;
            this.btn_suppTheme.Values.Text = "Supprimer";
            this.btn_suppTheme.Click += new System.EventHandler(this.btn_suppTheme_Click);
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
            this.lbl_titre.TabIndex = 66;
            this.lbl_titre.Text = "Gérer les Thèmes";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_GererThemesFormateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::projet_V_Co.Properties.Resources.Fond_test_H;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1438, 820);
            this.Controls.Add(this.pictBox_avatar);
            this.Controls.Add(this.lbl_nomEntreprise);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.lbl_deconnexion);
            this.Controls.Add(this.panel_lesUtilisateurs);
            this.Controls.Add(this.panel_informations);
            this.Controls.Add(this.lbl_titre);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_GererThemesFormateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_GererThemesFormateur";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).EndInit();
            this.panel_lesUtilisateurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_themes)).EndInit();
            this.panel_informations.ResumeLayout(false);
            this.panel_informations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictBox_avatar;
        private System.Windows.Forms.Label lbl_nomEntreprise;
        private System.Windows.Forms.PictureBox btn_quitter;
        private System.Windows.Forms.Label lbl_deconnexion;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Krypton.Toolkit.KryptonButton btn_ajoutTheme;
        private System.Windows.Forms.Panel panel_lesUtilisateurs;
        private System.Windows.Forms.DataGridView dataGridView_themes;
        private System.Windows.Forms.Label lbl_titreLesThemes;
        private System.Windows.Forms.Label lbl_nom;
        private Krypton.Toolkit.KryptonButton btn_modifTheme;
        private System.Windows.Forms.Panel panel_informations;
        private Krypton.Toolkit.KryptonTextBox txtbox_titre;
        private System.Windows.Forms.Label lbl_titreRecap;
        private Krypton.Toolkit.KryptonButton btn_suppTheme;
        private System.Windows.Forms.Label lbl_titre;
        private Krypton.Toolkit.KryptonTextBox txtbox_module;
        private System.Windows.Forms.Label lbl_module;
    }
}