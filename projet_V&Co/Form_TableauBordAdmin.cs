using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib_vco;

namespace projet_V_Co
{
    public partial class Form_TableauBordAdmin : Form
    {
        MySqlConnection laConnection;
        public Form_TableauBordAdmin()
        {
            InitializeComponent();
            try
            {
                // Initialiser la connexion à la base de données
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["bddString"].ConnectionString);
                laConnection.Open();
                AfficherModule();
            }
            catch (MySqlException ex)
            {
                // Afficher un message d'erreur si la connexion échoue
                MessageBox.Show("Problème d'accès à vos données. Contacter votre administrateur", "Erreur rencontrée", MessageBoxButtons.OK);
            }
        }

        private void deconnexion()
        {
            try
            {
                // Ferme la connexion à la base de données
                laConnection.Close();

                // Cache le formulaire actuel
                this.Hide();

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


        private void AfficherModule()
        {
            try
            {
                // Récupère la liste des modules depuis la base de données
                List<module> modules = module.RecupModules(laConnection);

                // Parcourt chaque module récupéré
                foreach (var module in modules)
                {
                    // Crée un panneau pour chaque module
                    Panel modulePanel = new Panel
                    {
                        Size = new Size(200, 150),
                        Margin = new Padding(20)
                    };

                    // Crée une PictureBox pour afficher l'image du module
                    PictureBox pictureBox = new PictureBox
                    {
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Dock = DockStyle.Top,
                        Height = 100,
                        Cursor = Cursors.Hand,
                        Tag = module // Stocke le module dans la propriété Tag pour y accéder dans l'événement
                    };

                    try
                    {
                        // Essaye de charger l'image du module depuis l'URL
                        pictureBox.Image = Image.FromStream(new System.Net.WebClient().OpenRead(module.ModImage));
                    }
                    catch
                    {
                        // Si l'image ne peut pas être chargée, utilise une image par défaut
                        pictureBox.Image = Properties.Resources.ModuleDefaut;
                    }

                    // Ajouter un gestionnaire d'événements Click pour la PictureBox
                    pictureBox.Click += PictureBox_Click;

                    // Crée une étiquette pour le titre du module
                    Label titreModule = new Label
                    {
                        Text = $"Module {module.ModId} : {module.ModTitre}",
                        Dock = DockStyle.Bottom,
                        TextAlign = ContentAlignment.MiddleCenter,
                        AutoSize = true,
                        MaximumSize = new Size(200, 0),
                        Font = new Font("Arial", 10, FontStyle.Bold),
                        ForeColor = Color.White
                    };

                    // Ajoute la PictureBox et l'étiquette au panneau du module
                    modulePanel.Controls.Add(pictureBox);
                    modulePanel.Controls.Add(titreModule);
                    flwPanel_module.Controls.Add(modulePanel);
                }
            }
            catch (Exception ex)
            {
                // Affiche un message d'erreur en cas de problème lors du chargement des modules
                MessageBox.Show("Une erreur est survenue lors du chargement des modules.", "Erreur", MessageBoxButtons.OK);
            }
        }



        private void PictureBox_Click(object sender, EventArgs e)
        {
            // Récupère la PictureBox qui a déclenché l'événement
            PictureBox pictureBox = sender as PictureBox;

            // Vérifie si la PictureBox est valide et si son Tag est un module
            if (pictureBox != null && pictureBox.Tag is module moduleSelectionne)
            {
                // Cache le formulaire actuel
                this.Hide();

                // Crée une nouvelle instance de Form_ModuleAdmin avec le module sélectionné
                Form_ModuleAdmin formModuleAdmin = new Form_ModuleAdmin(moduleSelectionne);

                // Ferme le formulaire actuel lorsque Form_ModuleAdmin est fermé
                formModuleAdmin.Closed += (s, args) => this.Close();

                // Affiche le formulaire de gestion du module
                formModuleAdmin.Show();
            }
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            // Quitte l'application
            Application.Exit();
        }

        private void lbl_deconnexion_Click(object sender, EventArgs e)
        {
            // Appelle la méthode de déconnexion
            deconnexion();
        }

        private void btn_accesGererUtilisateur_Click(object sender, EventArgs e)
        {
            // Cache le formulaire actuel
            this.Hide();

            // Crée une nouvelle instance de Form_GererUtilisateurs
            Form_GererUtilisateurs gererUtilisateurs = new Form_GererUtilisateurs();

            // Ferme le formulaire actuel lorsque Form_GererUtilisateurs est fermé
            gererUtilisateurs.Closed += (s, args) => this.Close();

            // Affiche le formulaire de gestion des utilisateurs
            gererUtilisateurs.Show();
        }

        

        private void btn_gererTheme_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_GererThemesAdmin gererTheme = new Form_GererThemesAdmin();
            gererTheme.Closed += (s, args) => this.Close();
            gererTheme.Show();
        }

        private void btn_gererModule_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_GererModulesAdmin gererModule = new Form_GererModulesAdmin();
            gererModule.Closed += (s, args) => this.Close();
            gererModule.Show();
        }

        private void btn_gererCours_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_GererCoursAdmin gererCours = new Form_GererCoursAdmin();
            gererCours.Closed += (s, args) => this.Close();
            gererCours.Show();
        }
    }
}

