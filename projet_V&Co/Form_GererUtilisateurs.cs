using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Configuration; 
using lib_vco;
using System.Collections.Generic;
using System.Drawing;

namespace projet_V_Co
{
    public partial class Form_GererUtilisateurs : Form
    {
        private MySqlConnection laConnection; // La connexion à la base de données
        private Panel menuPanel;

        public Form_GererUtilisateurs()
        {
            InitializeComponent();
            

            try
            {
                // Initialiser la connexion à la base de données
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["bddString"].ConnectionString);
                // Ouvre la connexion à la base de données
                laConnection.Open();
                AfficherUtilisateur(); // Appel à la méthode pour charger les utilisateurs
                dataGridView_utilisateurs.CellClick += DataGridViewUtilisateurs_CellClick; // l'événement CellClick
                InitializeBurgerMenu();
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
                laConnection.Close(); // Ferme la connexion à la base de données
                this.Hide();
                Form_Connexion connexion = new Form_Connexion();
                connexion.Closed += (s, args) => this.Close();
                connexion.Show();
            }
            catch (MySqlException ex)
            {
                // Affiche un message d'erreur si la déconnexion échoue
                MessageBox.Show("La déconnexion n'as pas aboutie", "Déconnexion", MessageBoxButtons.OK);
            }
        }

        private void AfficherUtilisateur()
        {
            
            try
            {
                // Récupère la liste d'utilisateurs en utilisant la méthode RecupUtilisateurs
                List<utilisateur> utilisateurs = utilisateur.RecupUtilisateurs(laConnection);

                // Crée un DataTable pour lier les données au DataGridView
                DataTable dt = new DataTable();
                dt.Columns.Add("uti_id"); // Colonne pour l'ID utilisateur, mais cacher
                dt.Columns.Add("Nom");
                dt.Columns.Add("Prénom");
                dt.Columns.Add("Login");
                dt.Columns.Add("Rôle");

                // Remplit le DataTable avec les utilisateurs récupérés
                foreach (var user in utilisateurs)
                {
                    dt.Rows.Add(user.Uti_id, user.Uti_nom, user.Uti_prenom, user.Uti_login, user.Uti_role);
                }

                // Lier le DataTable au DataGridView
                dataGridView_utilisateurs.DataSource = dt;

                // Cacher la colonne de l'ID
                dataGridView_utilisateurs.Columns["uti_id"].Visible = false; // Cacher la colonne "uti_id"
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de la récupération des utilisateurs : " + ex.Message);
            }
        }

        private void DataGridViewUtilisateurs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie que l'index de ligne est valide
            if (e.RowIndex >= 0)
            {
                // Récupérer la ligne sélectionnée
                DataGridViewRow row = dataGridView_utilisateurs.Rows[e.RowIndex];

                // Assignation des valeurs aux TextBox
                txtbox_nom.Text = row.Cells["Nom"].Value.ToString();
                txtbox_prenom.Text = row.Cells["Prénom"].Value.ToString();
                txtbox_role.Text = row.Cells["Rôle"].Value.ToString();
                txtbox_login.Text = row.Cells["Login"].Value.ToString();
            }
        }

        private void btn_ajoutUtilisateur_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtbox_nom.Text) ||
                string.IsNullOrWhiteSpace(txtbox_prenom.Text) ||
                string.IsNullOrWhiteSpace(txtbox_role.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs sauf le login.");
                return;
            }

            // Crée un nouvel utilisateur
            utilisateur nouvelUtilisateur = new utilisateur(0, // id, à 0 pour l'auto-incrémentation
                                                            txtbox_nom.Text,
                                                            txtbox_prenom.Text,
                                                            null, // login, laissé nul car généré par le trigger
                                                            null, // mot de passe, laissé nul car généré par le trigger
                                                            txtbox_role.Text);

            try
            {
                // Ajoute l'utilisateur à la base de données
                nouvelUtilisateur.AjouterUtilisateur(laConnection); // La méthode doit gérer l'ajout sans login et mot de passe
                MessageBox.Show("Utilisateur ajouté avec succès !");

                // Rafraîchir la liste des utilisateurs affichés
                AfficherUtilisateur();
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de l'ajout de l'utilisateur : " + ex.Message);
            }
        }

        private void btn_suppUtilisateur_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une ligne est sélectionnée dans le DataGridView
            if (dataGridView_utilisateurs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à supprimer.");
                return;
            }

            // Récupérer l'utilisateur sélectionné
            DataGridViewRow selectedRow = dataGridView_utilisateurs.SelectedRows[0];
            int utilisateurId = Convert.ToInt32(selectedRow.Cells["uti_id"].Value); 

            try
            {
                // Appelle la procédure de suppression
                MySqlCommand cmd = new MySqlCommand("proc_supprimerUtilisateur", laConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("id_uti", utilisateurId); // Correspond au nom du paramètre de la procédure
                cmd.ExecuteNonQuery(); // Exécute la commande

                MessageBox.Show("Utilisateur supprimé avec succès !");

                // Rafraîchir la liste des utilisateurs affichés
                AfficherUtilisateur();
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de la suppression de l'utilisateur : " + ex.Message);
            }
        }

        

        private void btn_modifUtilisateur_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une ligne est sélectionnée dans le DataGridView
            if (dataGridView_utilisateurs.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un utilisateur à modifier.");
                return;
            }

            // Récupérer l'utilisateur sélectionné
            DataGridViewRow selectedRow = dataGridView_utilisateurs.SelectedRows[0];
            int utilisateurId = Convert.ToInt32(selectedRow.Cells["uti_id"].Value);

            // Vérifie que les TextBox ne sont pas vides
            if (string.IsNullOrWhiteSpace(txtbox_nom.Text) ||
                string.IsNullOrWhiteSpace(txtbox_prenom.Text) ||
                string.IsNullOrWhiteSpace(txtbox_role.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            try
            {
                // Créer une instance de l'utilisateur
                utilisateur utilisateurAModifier = new utilisateur(utilisateurId,
                                                                     txtbox_nom.Text,
                                                                     txtbox_prenom.Text,
                                                                     txtbox_login.Text,
                                                                     null, // mot de passe
                                                                     txtbox_role.Text);

                // Appel de la méthode pour mettre à jour l'utilisateur
                utilisateurAModifier.MettreAJourUtilisateur(laConnection);
                MessageBox.Show("Utilisateur modifié avec succès !");

                // Rafraîchir la liste des utilisateurs affichés
                AfficherUtilisateur();
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de la modification de l'utilisateur : " + ex.Message);
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
            Button gererUtilisateur = new Button { Text = "Utilisateurs", Dock = DockStyle.Top };

            // Associe l'événement de clic pour le tableau de bord
            tableauBord.Click += tableauBord_Click;
            gererUtilisateur.Click += gererUtilisateur_Click;
            tableauBord.Cursor = Cursors.Hand;
            gererUtilisateur.Cursor = Cursors.Hand;

            // Ajoute les boutons au menu
            menuPanel.Controls.Add(tableauBord);
            menuPanel.Controls.Add(gererUtilisateur);

            // Ajoute le bouton burger et le panel du menu au formulaire
            this.Controls.Add(burgerButton);
            this.Controls.Add(menuPanel);
        }


        private void BurgerButton_Click(object sender, EventArgs e)
        {
            // Bascule la visibilité du panneau de menu
            menuPanel.Visible = !menuPanel.Visible;
        }

        private void tableauBord_Click(object sender, EventArgs e)
        {
            // Cache le formulaire actuel et ouvre le tableau de bord administrateur
            this.Hide();
            Form_TableauBordAdmin formTableauBordAdmin = new Form_TableauBordAdmin();
            formTableauBordAdmin.Closed += (s, args) => this.Close();
            formTableauBordAdmin.Show();
        }

        private void gererUtilisateur_Click(object sender, EventArgs e)
        {
            // Cache le formulaire actuel et ouvre le formulaire de gestion des utilisateurs
            this.Hide();
            Form_GererUtilisateurs gererUtilisateurs = new Form_GererUtilisateurs();
            gererUtilisateurs.Closed += (s, args) => this.Close();
            gererUtilisateurs.Show();
        }

        private void lbl_deconnexion_Click(object sender, EventArgs e)
        {
            // Appelle la méthode de déconnexion
            deconnexion();
        }


        private void btn_quitter_Click(object sender, EventArgs e)
        {
            // Quitte l'application
            Application.Exit();
        }


    }
}
