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
using MySql.Data.MySqlClient;
using lib_vco;

namespace projet_V_Co
{
    public partial class Form_TableauBordFormateur : Form
    {
        MySqlConnection laConnection;

        public Form_TableauBordFormateur()
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

            // Vérifie si la PictureBox est valide et si son Tag contient un module
            if (pictureBox != null && pictureBox.Tag is module moduleSelectionne)
            {
                // Cache le formulaire actuel et ouvre le formulaire de module pour le formateur
                this.Hide();
                Form_ModuleFormateur formModuleForm = new Form_ModuleFormateur(moduleSelectionne);
                formModuleForm.Closed += (s, args) => this.Close();
                formModuleForm.Show();
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

        private void btn_gererModule_Click(object sender, EventArgs e)
        {
            // Cache le formulaire actuel et ouvre le formulaire pour gérer les modules du formateur
            this.Hide();
            Form_GererModulesFormateur gererModule = new Form_GererModulesFormateur();
            gererModule.Closed += (s, args) => this.Close();
            gererModule.Show();
        }

        private void btn_gererTheme_Click(object sender, EventArgs e)
        {
            // Cache le formulaire actuel et ouvre le formulaire pour gérer les tèmes du formateur
            this.Hide();
            Form_GererThemesFormateur gererTheme = new Form_GererThemesFormateur();
            gererTheme.Closed += (s, args) => this.Close();
            gererTheme.Show();
        }

        private void btn_gererCours_Click(object sender, EventArgs e)
        {
            // Cache le formulaire actuel et ouvre le formulaire pour gérer les cours du formateur
            this.Hide();
            Form_GererCoursFormateur gererCours = new Form_GererCoursFormateur();
            gererCours.Closed += (s, args) => this.Close();
            gererCours.Show();
        }
    }
}
