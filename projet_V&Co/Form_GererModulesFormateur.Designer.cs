namespace projet_V_Co
{
    partial class Form_GererModulesFormateur
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
            this.txtbox_image = new Krypton.Toolkit.KryptonTextBox();
            this.txtbox_titre = new Krypton.Toolkit.KryptonTextBox();
            this.lbl_image = new System.Windows.Forms.Label();
            this.lbl_titreInfos = new System.Windows.Forms.Label();
            this.panel_informations = new System.Windows.Forms.Panel();
            this.btn_ajoutUtilisateur = new Krypton.Toolkit.KryptonButton();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.btn_modifUtilisateur = new Krypton.Toolkit.KryptonButton();
            this.btn_suppUtilisateur = new Krypton.Toolkit.KryptonButton();
            this.dataGridView_modules = new System.Windows.Forms.DataGridView();
            this.lbl_titreLesUti = new System.Windows.Forms.Label();
            this.panel_lesUtilisateurs = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pictBox_avatar = new System.Windows.Forms.PictureBox();
            this.lbl_nomEntreprise = new System.Windows.Forms.Label();
            this.btn_quitter = new System.Windows.Forms.PictureBox();
            this.lbl_titre = new System.Windows.Forms.Label();
            this.lbl_deconnexion = new System.Windows.Forms.Label();
            this.panel_informations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_modules)).BeginInit();
            this.panel_lesUtilisateurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_image
            // 
            this.txtbox_image.CornerRoundingRadius = 20F;
            this.txtbox_image.Location = new System.Drawing.Point(169, 233);
            this.txtbox_image.Name = "txtbox_image";
            this.txtbox_image.Size = new System.Drawing.Size(442, 38);
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
            // lbl_image
            // 
            this.lbl_image.AutoSize = true;
            this.lbl_image.BackColor = System.Drawing.Color.Transparent;
            this.lbl_image.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_image.Location = new System.Drawing.Point(62, 233);
            this.lbl_image.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(113, 32);
            this.lbl_image.TabIndex = 57;
            this.lbl_image.Text = "Image :";
            // 
            // lbl_titreInfos
            // 
            this.lbl_titreInfos.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titreInfos.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreInfos.Location = new System.Drawing.Point(0, 0);
            this.lbl_titreInfos.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titreInfos.Name = "lbl_titreInfos";
            this.lbl_titreInfos.Size = new System.Drawing.Size(684, 94);
            this.lbl_titreInfos.TabIndex = 55;
            this.lbl_titreInfos.Text = "Recap";
            this.lbl_titreInfos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_informations
            // 
            this.panel_informations.BackColor = System.Drawing.Color.Transparent;
            this.panel_informations.BackgroundImage = global::projet_V_Co.Properties.Resources.fond_connexion2;
            this.panel_informations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_informations.Controls.Add(this.btn_ajoutUtilisateur);
            this.panel_informations.Controls.Add(this.txtbox_image);
            this.panel_informations.Controls.Add(this.txtbox_titre);
            this.panel_informations.Controls.Add(this.lbl_image);
            this.panel_informations.Controls.Add(this.lbl_nom);
            this.panel_informations.Controls.Add(this.lbl_titreInfos);
            this.panel_informations.Controls.Add(this.btn_modifUtilisateur);
            this.panel_informations.Controls.Add(this.btn_suppUtilisateur);
            this.panel_informations.Location = new System.Drawing.Point(644, 130);
            this.panel_informations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_informations.Name = "panel_informations";
            this.panel_informations.Size = new System.Drawing.Size(684, 682);
            this.panel_informations.TabIndex = 64;
            // 
            // btn_ajoutUtilisateur
            // 
            this.btn_ajoutUtilisateur.CornerRoundingRadius = 50F;
            this.btn_ajoutUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajoutUtilisateur.Location = new System.Drawing.Point(67, 568);
            this.btn_ajoutUtilisateur.Name = "btn_ajoutUtilisateur";
            this.btn_ajoutUtilisateur.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutUtilisateur.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutUtilisateur.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutUtilisateur.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutUtilisateur.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajoutUtilisateur.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_ajoutUtilisateur.Size = new System.Drawing.Size(128, 55);
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
            this.btn_ajoutUtilisateur.Click += new System.EventHandler(this.btn_ajoutModule_Click);
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
            // btn_modifUtilisateur
            // 
            this.btn_modifUtilisateur.CornerRoundingRadius = 50F;
            this.btn_modifUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modifUtilisateur.Location = new System.Drawing.Point(274, 568);
            this.btn_modifUtilisateur.Name = "btn_modifUtilisateur";
            this.btn_modifUtilisateur.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifUtilisateur.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifUtilisateur.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifUtilisateur.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifUtilisateur.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modifUtilisateur.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_modifUtilisateur.Size = new System.Drawing.Size(128, 55);
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
            this.btn_modifUtilisateur.Click += new System.EventHandler(this.btn_modifModule_Click);
            // 
            // btn_suppUtilisateur
            // 
            this.btn_suppUtilisateur.CornerRoundingRadius = 50F;
            this.btn_suppUtilisateur.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suppUtilisateur.Location = new System.Drawing.Point(467, 568);
            this.btn_suppUtilisateur.Name = "btn_suppUtilisateur";
            this.btn_suppUtilisateur.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppUtilisateur.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppUtilisateur.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppUtilisateur.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppUtilisateur.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suppUtilisateur.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_suppUtilisateur.Size = new System.Drawing.Size(129, 55);
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
            this.btn_suppUtilisateur.Click += new System.EventHandler(this.btn_suppModule_Click);
            // 
            // dataGridView_modules
            // 
            this.dataGridView_modules.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_modules.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView_modules.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_modules.Location = new System.Drawing.Point(32, 97);
            this.dataGridView_modules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView_modules.MultiSelect = false;
            this.dataGridView_modules.Name = "dataGridView_modules";
            this.dataGridView_modules.RowHeadersVisible = false;
            this.dataGridView_modules.RowHeadersWidth = 51;
            this.dataGridView_modules.RowTemplate.Height = 24;
            this.dataGridView_modules.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_modules.Size = new System.Drawing.Size(364, 530);
            this.dataGridView_modules.TabIndex = 58;
            // 
            // lbl_titreLesUti
            // 
            this.lbl_titreLesUti.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titreLesUti.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreLesUti.Location = new System.Drawing.Point(0, 0);
            this.lbl_titreLesUti.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titreLesUti.Name = "lbl_titreLesUti";
            this.lbl_titreLesUti.Size = new System.Drawing.Size(452, 94);
            this.lbl_titreLesUti.TabIndex = 57;
            this.lbl_titreLesUti.Text = "Les Modules";
            this.lbl_titreLesUti.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_lesUtilisateurs
            // 
            this.panel_lesUtilisateurs.BackColor = System.Drawing.Color.Transparent;
            this.panel_lesUtilisateurs.BackgroundImage = global::projet_V_Co.Properties.Resources.fond_connexion2;
            this.panel_lesUtilisateurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_lesUtilisateurs.Controls.Add(this.dataGridView_modules);
            this.panel_lesUtilisateurs.Controls.Add(this.lbl_titreLesUti);
            this.panel_lesUtilisateurs.Location = new System.Drawing.Point(171, 130);
            this.panel_lesUtilisateurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_lesUtilisateurs.Name = "panel_lesUtilisateurs";
            this.panel_lesUtilisateurs.Size = new System.Drawing.Size(452, 682);
            this.panel_lesUtilisateurs.TabIndex = 63;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pictBox_avatar
            // 
            this.pictBox_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pictBox_avatar.Image = global::projet_V_Co.Properties.Resources.logo_Utilisateur;
            this.pictBox_avatar.Location = new System.Drawing.Point(1260, 20);
            this.pictBox_avatar.Name = "pictBox_avatar";
            this.pictBox_avatar.Size = new System.Drawing.Size(79, 67);
            this.pictBox_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictBox_avatar.TabIndex = 60;
            this.pictBox_avatar.TabStop = false;
            // 
            // lbl_nomEntreprise
            // 
            this.lbl_nomEntreprise.AutoSize = true;
            this.lbl_nomEntreprise.BackColor = System.Drawing.Color.Transparent;
            this.lbl_nomEntreprise.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_nomEntreprise.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomEntreprise.ForeColor = System.Drawing.Color.White;
            this.lbl_nomEntreprise.Location = new System.Drawing.Point(36, 22);
            this.lbl_nomEntreprise.Name = "lbl_nomEntreprise";
            this.lbl_nomEntreprise.Size = new System.Drawing.Size(89, 32);
            this.lbl_nomEntreprise.TabIndex = 58;
            this.lbl_nomEntreprise.Text = "V&&Co";
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_quitter.Image = global::projet_V_Co.Properties.Resources.btn_quitter;
            this.btn_quitter.Location = new System.Drawing.Point(1389, 778);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(39, 41);
            this.btn_quitter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_quitter.TabIndex = 62;
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
            this.lbl_titre.TabIndex = 59;
            this.lbl_titre.Text = "Gérer les Modules";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_deconnexion
            // 
            this.lbl_deconnexion.AutoSize = true;
            this.lbl_deconnexion.BackColor = System.Drawing.Color.Transparent;
            this.lbl_deconnexion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_deconnexion.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deconnexion.ForeColor = System.Drawing.Color.White;
            this.lbl_deconnexion.Location = new System.Drawing.Point(1253, 84);
            this.lbl_deconnexion.Name = "lbl_deconnexion";
            this.lbl_deconnexion.Size = new System.Drawing.Size(99, 18);
            this.lbl_deconnexion.TabIndex = 61;
            this.lbl_deconnexion.Text = "Déconnexion";
            this.lbl_deconnexion.Click += new System.EventHandler(this.lbl_deconnexion_Click);
            // 
            // Form_GererModulesFormateur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::projet_V_Co.Properties.Resources.Fond_test_H;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1438, 820);
            this.Controls.Add(this.panel_informations);
            this.Controls.Add(this.panel_lesUtilisateurs);
            this.Controls.Add(this.pictBox_avatar);
            this.Controls.Add(this.lbl_nomEntreprise);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.lbl_titre);
            this.Controls.Add(this.lbl_deconnexion);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_GererModulesFormateur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AjoutModule";
            this.panel_informations.ResumeLayout(false);
            this.panel_informations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_modules)).EndInit();
            this.panel_lesUtilisateurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonTextBox txtbox_image;
        private Krypton.Toolkit.KryptonTextBox txtbox_titre;
        private System.Windows.Forms.Label lbl_image;
        private System.Windows.Forms.Label lbl_titreInfos;
        private System.Windows.Forms.Panel panel_informations;
        private Krypton.Toolkit.KryptonButton btn_ajoutUtilisateur;
        private System.Windows.Forms.Label lbl_nom;
        private Krypton.Toolkit.KryptonButton btn_modifUtilisateur;
        private Krypton.Toolkit.KryptonButton btn_suppUtilisateur;
        private System.Windows.Forms.DataGridView dataGridView_modules;
        private System.Windows.Forms.Label lbl_titreLesUti;
        private System.Windows.Forms.Panel panel_lesUtilisateurs;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pictBox_avatar;
        private System.Windows.Forms.Label lbl_nomEntreprise;
        private System.Windows.Forms.PictureBox btn_quitter;
        private System.Windows.Forms.Label lbl_titre;
        private System.Windows.Forms.Label lbl_deconnexion;
    }
}