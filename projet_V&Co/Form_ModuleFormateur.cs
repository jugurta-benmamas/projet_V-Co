using lib_vco;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet_V_Co
{
    public partial class Form_ModuleFormateur : Form
    {
        // Module actuellement sélectionné
        private module moduleSelectionne;
        // Connexion à la base de données
        MySqlConnection laConnection;
        // Panel pour le menu de navigation
        private Panel menuPanel;
        public Form_ModuleFormateur(module module)
        {
            // Initialise les composants de l'interface
            InitializeComponent();
            // Assigne le module sélectionné
            moduleSelectionne = module;
            

            try
            {
                // Établit la connexion à la base de données
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["bddString"].ConnectionString);
                laConnection.Open();
                // Affiche les détails du module sélectionné
                AfficherDetailsModule();
                // Initialise le menu hamburger
                InitializeBurgerMenu();
            }
            catch (MySqlException ex)
            {
                // Affiche un message d'erreur si la connexion échoue
                MessageBox.Show("Problème d'accès à vos données. Contacter votre administrateur", "Erreur rencontrée", MessageBoxButtons.OK);
            }
        }


        private void deconnexion()
        {
            try
            {
                laConnection.Close(); // Ferme la connexion à la base de données
                this.Hide(); // Cache le formulaire actuel

                // Crée une nouvelle instance du formulaire de connexion
                Form_Connexion connexion = new Form_Connexion();

                // Ferme le formulaire actuel lorsque le formulaire de connexion est fermé
                connexion.Closed += (s, args) => this.Close();

                // Affiche le formulaire de connexion
                connexion.Show();
            }
            catch (MySqlException ex)
            {
                // Affiche un message d'erreur si la déconnexion échoue
                MessageBox.Show("La déconnexion n'a pas abouti", "Déconnexion", MessageBoxButtons.OK);
            }
        }



        private void AfficherDetailsModule()
        {
            // Affiche le titre du module sélectionné
            lbl_titre.Text = moduleSelectionne.ModTitre;

            try
            {
                // Récupérer les thèmes du module sélectionné
                List<theme> themes = theme.RecupThemeModule(laConnection, moduleSelectionne.ModId);

                // Vider le panel des thèmes avant d'ajouter de nouveaux thèmes
                flwPanel_themes.Controls.Clear();

                foreach (var theme in themes)
                {
                    // Créer un panel pour chaque thème
                    Panel themePanel = new Panel
                    {
                        AutoSize = true,
                        Margin = new Padding(20),
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    // Créer et configurer le label du titre du thème
                    Label themeTitre = new Label
                    {
                        // Affiche le nom du thème
                        Text = theme.Theme_nom,
                        Font = new Font("Arial", 12, FontStyle.Bold),
                        ForeColor = Color.White,
                        Dock = DockStyle.Top,
                        AutoSize = true
                    };
                    // Ajoute le label au panel du thème
                    themePanel.Controls.Add(themeTitre);

                    // Récupérer les cours associés au thème
                    List<cours> coursAssocies = cours.RecupCoursTheme(laConnection, theme.Theme_id);

                    // Créer un FlowLayoutPanel pour les cours, qui s'affichent horizontalement
                    FlowLayoutPanel coursPanel = new FlowLayoutPanel
                    {
                        Size = new Size(1100, 150),
                        AutoScroll = true, // Permet de faire défiler le contenu
                        FlowDirection = FlowDirection.LeftToRight, // Aligne les cours en ligne
                        WrapContents = false // Ne pas passer à la ligne
                    };

                    foreach (var cours in coursAssocies)
                    {
                        // Créer un panel pour chaque cours
                        Panel coursPanelItem = new Panel
                        {
                            Size = new Size(180, 120),
                            Margin = new Padding(5, 20, 5, 0)
                        };

                        // Créer une PictureBox pour l'image du cours
                        PictureBox pictureBox = new PictureBox
                        {
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Dock = DockStyle.Top,
                            Height = 80,
                            Margin = new Padding(0, 0, 0, 5),
                            Cursor = Cursors.Hand,
                            Tag = cours // Stocke le cours dans la propriété Tag pour y accéder dans l'événement
                        };

                        // Tenter de charger l'image
                        try
                        {
                            pictureBox.Image = Image.FromStream(new System.Net.WebClient().OpenRead(cours.Cours_imageCouverture));
                        }
                        catch
                        {
                            // Utilise une image par défaut en cas d'erreur de chargement
                            pictureBox.Image = Properties.Resources.ModuleDefaut;
                        }

                        // Associe l'événement de clic à la méthode
                        pictureBox.Click += PictureBox_Click;

                        // Créer et configurer le label pour le titre du cours
                        Label coursLabel = new Label
                        {
                            Text = cours.Cours_titre,
                            AutoSize = true,
                            ForeColor = Color.White,
                            Dock = DockStyle.None
                        };

                        // Ajuster la position du label par rapport au PictureBox
                        coursLabel.Location = new Point(0, pictureBox.Height); // Positionner le label juste sous l'image

                        // Ajouter l'image et le titre au panel du cours
                        coursPanelItem.Controls.Add(pictureBox);
                        coursPanelItem.Controls.Add(coursLabel);

                        // Ajouter le panel de cours au panel de cours principal
                        coursPanel.Controls.Add(coursPanelItem);
                    }

                    // Ajouter le panel de cours au panel de thème
                    themePanel.Controls.Add(coursPanel);
                    // Ajouter le panel de thème au FlowLayoutPanel principal
                    flwPanel_themes.Controls.Add(themePanel);
                }
            }
            catch (Exception ex)
            {
                // Affiche un message d'erreur en cas de problème lors du chargement des thèmes et cours
                MessageBox.Show("Erreur lors du chargement des thèmes et cours : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Récupère la PictureBox qui a déclenché l'événement
            PictureBox pictureBox = sender as PictureBox;

            if (pictureBox != null && pictureBox.Tag is cours cours)
            {
                // Cache le formulaire actuel et ouvre le formulaire du cours
                this.Hide();
                Form_CoursFormateur formCoursForm = new Form_CoursFormateur(cours);
                formCoursForm.Closed += (s, args) => this.Close();
                formCoursForm.Show();
            }
        }


        private void InitializeBurgerMenu()
        {
            // Bouton du menu burger
            Button burgerButton = new Button
            {
                Text = "☰",
                Font = new Font("Arial", 15, FontStyle.Bold),
                Size = new Size(70, 50),
                Location = new Point(25, 115)
            };
            // Associe l'événement de clic
            burgerButton.Click += BurgerButton_Click;

            // Panel du menu
            menuPanel = new Panel
            {
                Size = new Size(100, 90),
                Location = new Point(12, 165),
                BackColor = Color.LightGray,
                Visible = false // Le menu est initialement masqué
            };

            // Créer des boutons pour le menu
            Button tableauBord = new Button { Text = "Tableau de bord", Dock = DockStyle.Top };
            Button statistiques = new Button { Text = "Statistiques", Dock = DockStyle.Top };

            // Associe l'événement de clic pour le tableau de bord
            tableauBord.Click += tableauBord_Click;
            tableauBord.Cursor = Cursors.Hand;
            statistiques.Cursor = Cursors.Hand;

            // Ajoute les boutons au menu
            menuPanel.Controls.Add(tableauBord);
            menuPanel.Controls.Add(statistiques);

            // Ajoute le bouton burger et le panel du menu au formulaire
            this.Controls.Add(burgerButton);
            this.Controls.Add(menuPanel);
        }


        private void BurgerButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = !menuPanel.Visible; // Basculer la visibilité du panneau de menu
        }

        private void tableauBord_Click(object sender, EventArgs e)
        {
            this.Hide(); // Cacher le formulaire actuel
            Form_TableauBordFormateur formTableauBordForm = new Form_TableauBordFormateur(); // Créer une nouvelle instance du tableau de bord formateur
            formTableauBordForm.Closed += (s, args) => this.Close(); // Fermer le formulaire actuel lorsque le tableau de bord formateur se ferme
            formTableauBordForm.Show(); // Afficher le tableau de bord formateur
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Quitter l'application
        }

        private void lbl_deconnexion_Click(object sender, EventArgs e)
        {
            deconnexion(); // Appeler la méthode de déconnexion
        }

        private void lbl_nomEntreprise_Click(object sender, EventArgs e)
        {
            this.Hide(); // Cacher le formulaire actuel
            Form_TableauBordFormateur formTableauBordForm = new Form_TableauBordFormateur(); // Créer une nouvelle instance du tableau de bord formateur
            formTableauBordForm.Closed += (s, args) => this.Close(); // Fermer le formulaire actuel lorsque le tableau de bord formateur se ferme
            formTableauBordForm.Show(); // Afficher le tableau de bord formateur
        }

      

    }
}

