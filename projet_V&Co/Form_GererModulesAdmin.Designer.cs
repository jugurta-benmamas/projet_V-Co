namespace projet_V_Co
{
    partial class Form_GererModulesAdmin
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
            this.btn_ajoutModule = new Krypton.Toolkit.KryptonButton();
            this.panel_lesUtilisateurs = new System.Windows.Forms.Panel();
            this.dataGridView_modules = new System.Windows.Forms.DataGridView();
            this.lbl_titreLesModules = new System.Windows.Forms.Label();
            this.txtbox_image = new Krypton.Toolkit.KryptonTextBox();
            this.lbl_nom = new System.Windows.Forms.Label();
            this.btn_modifModule = new Krypton.Toolkit.KryptonButton();
            this.panel_informations = new System.Windows.Forms.Panel();
            this.txtbox_titre = new Krypton.Toolkit.KryptonTextBox();
            this.lbl_image = new System.Windows.Forms.Label();
            this.lbl_titreRecap = new System.Windows.Forms.Label();
            this.btn_suppModule = new Krypton.Toolkit.KryptonButton();
            this.lbl_titre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).BeginInit();
            this.panel_lesUtilisateurs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_modules)).BeginInit();
            this.panel_informations.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictBox_avatar
            // 
            this.pictBox_avatar.BackColor = System.Drawing.Color.Transparent;
            this.pictBox_avatar.Image = global::projet_V_Co.Properties.Resources.logo_Utilisateur;
            this.pictBox_avatar.Location = new System.Drawing.Point(1258, 2);
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
            this.lbl_nomEntreprise.Location = new System.Drawing.Point(34, 4);
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
            this.btn_quitter.Location = new System.Drawing.Point(1387, 760);
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
            this.lbl_deconnexion.Location = new System.Drawing.Point(1251, 66);
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
            // btn_ajoutModule
            // 
            this.btn_ajoutModule.CornerRoundingRadius = 50F;
            this.btn_ajoutModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ajoutModule.Location = new System.Drawing.Point(67, 568);
            this.btn_ajoutModule.Name = "btn_ajoutModule";
            this.btn_ajoutModule.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutModule.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutModule.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutModule.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutModule.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajoutModule.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_ajoutModule.Size = new System.Drawing.Size(128, 55);
            this.btn_ajoutModule.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_ajoutModule.StateCommon.Border.Rounding = 50F;
            this.btn_ajoutModule.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutModule.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutModule.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_ajoutModule.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutModule.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutModule.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajoutModule.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_ajoutModule.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_ajoutModule.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutModule.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutModule.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_ajoutModule.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_ajoutModule.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_ajoutModule.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_ajoutModule.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_ajoutModule.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ajoutModule.TabIndex = 56;
            this.btn_ajoutModule.Values.Text = "Ajouter";
            this.btn_ajoutModule.Click += new System.EventHandler(this.btn_ajoutModule_Click);
            // 
            // panel_lesUtilisateurs
            // 
            this.panel_lesUtilisateurs.BackColor = System.Drawing.Color.Transparent;
            this.panel_lesUtilisateurs.BackgroundImage = global::projet_V_Co.Properties.Resources.fond_connexion2;
            this.panel_lesUtilisateurs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_lesUtilisateurs.Controls.Add(this.dataGridView_modules);
            this.panel_lesUtilisateurs.Controls.Add(this.lbl_titreLesModules);
            this.panel_lesUtilisateurs.Location = new System.Drawing.Point(169, 112);
            this.panel_lesUtilisateurs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_lesUtilisateurs.Name = "panel_lesUtilisateurs";
            this.panel_lesUtilisateurs.Size = new System.Drawing.Size(452, 682);
            this.panel_lesUtilisateurs.TabIndex = 70;
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
            // lbl_titreLesModules
            // 
            this.lbl_titreLesModules.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_titreLesModules.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titreLesModules.Location = new System.Drawing.Point(0, 0);
            this.lbl_titreLesModules.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_titreLesModules.Name = "lbl_titreLesModules";
            this.lbl_titreLesModules.Size = new System.Drawing.Size(452, 94);
            this.lbl_titreLesModules.TabIndex = 57;
            this.lbl_titreLesModules.Text = "Les Modules";
            this.lbl_titreLesModules.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtbox_image
            // 
            this.txtbox_image.CornerRoundingRadius = 20F;
            this.txtbox_image.Location = new System.Drawing.Point(169, 233);
            this.txtbox_image.Name = "txtbox_image";
            this.txtbox_image.Size = new System.Drawing.Size(437, 38);
            this.txtbox_image.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtbox_image.StateCommon.Border.Rounding = 20F;
            this.txtbox_image.StateCommon.Content.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_image.TabIndex = 61;
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
            // btn_modifModule
            // 
            this.btn_modifModule.CornerRoundingRadius = 50F;
            this.btn_modifModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_modifModule.Location = new System.Drawing.Point(274, 568);
            this.btn_modifModule.Name = "btn_modifModule";
            this.btn_modifModule.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifModule.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifModule.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifModule.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifModule.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modifModule.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_modifModule.Size = new System.Drawing.Size(128, 55);
            this.btn_modifModule.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_modifModule.StateCommon.Border.Rounding = 50F;
            this.btn_modifModule.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifModule.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifModule.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_modifModule.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifModule.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifModule.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modifModule.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_modifModule.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_modifModule.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifModule.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifModule.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_modifModule.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_modifModule.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_modifModule.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_modifModule.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_modifModule.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modifModule.TabIndex = 54;
            this.btn_modifModule.Values.Text = "Modifier";
            this.btn_modifModule.Click += new System.EventHandler(this.btn_modifModule_Click);
            // 
            // panel_informations
            // 
            this.panel_informations.BackColor = System.Drawing.Color.Transparent;
            this.panel_informations.BackgroundImage = global::projet_V_Co.Properties.Resources.fond_connexion2;
            this.panel_informations.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel_informations.Controls.Add(this.btn_ajoutModule);
            this.panel_informations.Controls.Add(this.txtbox_image);
            this.panel_informations.Controls.Add(this.txtbox_titre);
            this.panel_informations.Controls.Add(this.lbl_image);
            this.panel_informations.Controls.Add(this.lbl_nom);
            this.panel_informations.Controls.Add(this.lbl_titreRecap);
            this.panel_informations.Controls.Add(this.btn_modifModule);
            this.panel_informations.Controls.Add(this.btn_suppModule);
            this.panel_informations.Location = new System.Drawing.Point(641, 112);
            this.panel_informations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel_informations.Name = "panel_informations";
            this.panel_informations.Size = new System.Drawing.Size(684, 682);
            this.panel_informations.TabIndex = 71;
            // 
            // txtbox_titre
            // 
            this.txtbox_titre.CornerRoundingRadius = 20F;
            this.txtbox_titre.Location = new System.Drawing.Point(154, 150);
            this.txtbox_titre.Name = "txtbox_titre";
            this.txtbox_titre.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtbox_titre.Size = new System.Drawing.Size(452, 38);
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
            // btn_suppModule
            // 
            this.btn_suppModule.CornerRoundingRadius = 50F;
            this.btn_suppModule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_suppModule.Location = new System.Drawing.Point(467, 568);
            this.btn_suppModule.Name = "btn_suppModule";
            this.btn_suppModule.OverrideDefault.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppModule.OverrideDefault.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppModule.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppModule.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppModule.OverrideDefault.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suppModule.PaletteMode = Krypton.Toolkit.PaletteMode.Office2010White;
            this.btn_suppModule.Size = new System.Drawing.Size(129, 55);
            this.btn_suppModule.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btn_suppModule.StateCommon.Border.Rounding = 50F;
            this.btn_suppModule.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppModule.StateNormal.Back.Color1 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppModule.StateNormal.Back.Color2 = System.Drawing.Color.DarkSlateGray;
            this.btn_suppModule.StateNormal.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppModule.StateNormal.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppModule.StateNormal.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suppModule.StatePressed.Back.Color1 = System.Drawing.Color.DarkCyan;
            this.btn_suppModule.StatePressed.Back.Color2 = System.Drawing.Color.DarkCyan;
            this.btn_suppModule.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppModule.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppModule.StatePressed.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btn_suppModule.StateTracking.Back.Color1 = System.Drawing.Color.CadetBlue;
            this.btn_suppModule.StateTracking.Back.Color2 = System.Drawing.Color.CadetBlue;
            this.btn_suppModule.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.btn_suppModule.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.btn_suppModule.StateTracking.Content.ShortText.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_suppModule.TabIndex = 53;
            this.btn_suppModule.Values.Text = "Supprimer";
            this.btn_suppModule.Click += new System.EventHandler(this.btn_suppModule_Click);
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
            this.lbl_titre.Text = "Gérer les Modules";
            this.lbl_titre.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form_GererModulesAdmin
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form_GererModulesAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_GererModulesAdmin";
            ((System.ComponentModel.ISupportInitialize)(this.pictBox_avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_quitter)).EndInit();
            this.panel_lesUtilisateurs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_modules)).EndInit();
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
        private Krypton.Toolkit.KryptonButton btn_ajoutModule;
        private System.Windows.Forms.Panel panel_lesUtilisateurs;
        private System.Windows.Forms.DataGridView dataGridView_modules;
        private System.Windows.Forms.Label lbl_titreLesModules;
        private Krypton.Toolkit.KryptonTextBox txtbox_image;
        private System.Windows.Forms.Label lbl_nom;
        private Krypton.Toolkit.KryptonButton btn_modifModule;
        private System.Windows.Forms.Panel panel_informations;
        private Krypton.Toolkit.KryptonTextBox txtbox_titre;
        private System.Windows.Forms.Label lbl_image;
        private System.Windows.Forms.Label lbl_titreRecap;
        private Krypton.Toolkit.KryptonButton btn_suppModule;
        private System.Windows.Forms.Label lbl_titre;
    }
}