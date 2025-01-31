using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using lib_vco;

namespace projet_V_Co
{
    public partial class Form_TableauBordApprenant : Form
    {
        // Connexion à la base de données
        MySqlConnection laConnection;

        
        public Form_TableauBordApprenant()
        {
            // Initialise les composants de l'interface
            InitializeComponent();

            try
            {
                // Initialiser la connexion à la base de données
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["bddString"].ConnectionString);
                // Ouvre la connexion à la base de données
                laConnection.Open();
                // Lance le chargement des modules
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
                laConnection.Close();
                this.Hide(); 
                Form_Connexion connexion = new Form_Connexion(); 
                connexion.Closed += (s, args) => this.Close(); 
                connexion.Show(); 
            }
            catch (MySqlException ex)
            {
                // Affiche un message d'erreur si la déconnexion échoue
                MessageBox.Show("La déconnexion n'a pas aboutie", "Déconnexion", MessageBoxButtons.OK);
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
                // Cache le formulaire actuel et ouvre le formulaire de module pour l'apprenant
                this.Hide();
                Form_ModuleApprenant formModuleApp = new Form_ModuleApprenant(moduleSelectionne);
                formModuleApp.Closed += (s, args) => this.Close();
                formModuleApp.Show();
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




    }
}
