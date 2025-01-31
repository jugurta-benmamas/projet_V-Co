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
using MySql.Data.MySqlClient;
using lib_vco;

namespace projet_V_Co
{
    public partial class Form_GererCoursFormateur : Form
    {
        private MySqlConnection laConnection; // La connexion à la base de données
        private Panel menuPanel;
        public Form_GererCoursFormateur()
        {
            InitializeComponent();
            try
            {
                // Initialiser la connexion à la base de données
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["bddString"].ConnectionString);
                // Ouvre la connexion à la base de données
                laConnection.Open();
                AfficherCours(); // Appel à la méthode pour charger les cours
                dataGridView_cours.CellClick += DataGridViewCours_CellClick; // l'événement CellClick
                // Initialise le menu hamburger
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
                laConnection.Close();
                this.Hide();
                Form_Connexion connexion = new Form_Connexion();
                connexion.Closed += (s, args) => this.Close();
                connexion.Show();

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("La déconnexion n'as pas aboutie", "Déconnexion", MessageBoxButtons.OK);
            }
        }

        private void AfficherCours()
        {
            try
            {
                // Récupérer la liste des cours à partir de la base de données
                List<cours> coursList = cours.RecupCours(laConnection); // Assurez-vous que cette méthode existe

                // Crée un DataTable pour lier les données au DataGridView
                DataTable dt = new DataTable();
                dt.Columns.Add("cours_id"); // Colonne pour l'ID du cours
                dt.Columns.Add("Titre");     // Colonne pour le titre du cours
                dt.Columns.Add("Image");     // Colonne pour l'image du cours
                dt.Columns.Add("Contenu");    // Colonne pour le contenu du cours
                dt.Columns.Add("theme_id");   // Colonne pour l'ID du thème

                // Remplit le DataTable avec les cours récupérés
                foreach (var cours in coursList)
                {
                    dt.Rows.Add(cours.Cours_id, cours.Cours_titre, cours.Cours_imageCouverture, cours.Cours_contenu, cours.Theme_id);
                }

                // Lier le DataTable au DataGridView
                dataGridView_cours.DataSource = dt;

                // Cacher la colonne de l'ID
                dataGridView_cours.Columns["cours_id"].Visible = false; // Cacher la colonne "cours_id"
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de la récupération des cours : " + ex.Message);
            }
        }

        private void DataGridViewCours_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie que l'index de ligne est valide
            if (e.RowIndex >= 0)
            {
                // Récupérer la ligne sélectionnée
                DataGridViewRow row = dataGridView_cours.Rows[e.RowIndex];

                // Assignation des valeurs aux TextBox
                txtbox_titre.Text = row.Cells["Titre"].Value.ToString();
                txtbox_image.Text = row.Cells["Image"].Value.ToString();
                txtbox_theme.Text = row.Cells["theme_id"].Value.ToString();
                txtbox_contenuCours.Text = row.Cells["Contenu"].Value.ToString();

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

        private void btn_ajoutCours_Click(object sender, EventArgs e)
        {
            // Vérifie que les TextBox ne sont pas vides
            if (string.IsNullOrWhiteSpace(txtbox_titre.Text) ||
    string.IsNullOrWhiteSpace(txtbox_image.Text) ||
    string.IsNullOrWhiteSpace(txtbox_theme.Text) ||
    string.IsNullOrWhiteSpace(txtbox_contenuCours.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }


            // Crée un nouveau thème
            cours nouveauCours = new cours(0, // id, à 0 pour l'auto-incrémentation
                                               txtbox_titre.Text,
                                               txtbox_image.Text,
                                               txtbox_contenuCours.Text,
                                               int.Parse(txtbox_theme.Text));

            try
            {
                // Ajoute le thème à la base de données
                nouveauCours.AjouterCours(laConnection); // Assurez-vous que cette méthode est implémentée dans votre classe
                MessageBox.Show("Cours ajouté avec succès !");

                // Rafraîchir la liste des thèmes affichés
                AfficherCours();
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de l'ajout du Cours : " + ex.Message);
            }
        }

        private void btn_modifCours_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une ligne est sélectionnée dans le DataGridView
            if (dataGridView_cours.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un Cours à modifier.");
                return;
            }

            // Récupérer le thème sélectionné
            DataGridViewRow selectedRow = dataGridView_cours.SelectedRows[0];
            int coursId = Convert.ToInt32(selectedRow.Cells["cours_id"].Value); // Utiliser "theme_id"

            if (string.IsNullOrWhiteSpace(txtbox_titre.Text) ||
    string.IsNullOrWhiteSpace(txtbox_image.Text) ||
    string.IsNullOrWhiteSpace(txtbox_theme.Text) ||
    string.IsNullOrWhiteSpace(txtbox_contenuCours.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }


            try
            {
                // Créer une instance du thème
                cours coursAModifier = new cours(coursId,
                                                  txtbox_titre.Text,
                                                  txtbox_image.Text,
                                                  txtbox_contenuCours.Text,
                                                  int.Parse(txtbox_theme.Text));

                // Appel de la méthode pour mettre à jour le thème
                coursAModifier.ModifierCours(laConnection); // Assurez-vous que cette méthode est implémentée dans votre classe
                MessageBox.Show("Cours modifié avec succès !");

                // Rafraîchir la liste des thèmes affichés
                AfficherCours();
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de la modification du cours : " + ex.Message);
            }
        }

        private void btn_suppCours_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une ligne est sélectionnée dans le DataGridView
            if (dataGridView_cours.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un cours à supprimer.");
                return;
            }

            // Récupérer le thème sélectionné
            DataGridViewRow selectedRow = dataGridView_cours.SelectedRows[0];
            int coursId = Convert.ToInt32(selectedRow.Cells["cours_id"].Value); 

            // Appelle la procédure de suppression
            MySqlCommand cmd = new MySqlCommand("proc_supprimerCours", laConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@id_cours", coursId); // Correspond au nom du paramètre de la procédure
            cmd.ExecuteNonQuery(); // Exécute la commande

            MessageBox.Show("Cours supprimé avec succès !");

            // Rafraîchir la liste des thèmes affichés
            AfficherCours();

            // Libérer les ressources manuellement
            cmd.Dispose(); // Libération des ressources de la commande
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_deconnexion_Click(object sender, EventArgs e)
        {
            deconnexion();
        }
    }
}
