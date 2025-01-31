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

namespace projet_V_Co
{
    public partial class Form_GererThemesAdmin : Form
    {
        private MySqlConnection laConnection; // La connexion à la base de données
        private Panel menuPanel;
        public Form_GererThemesAdmin()
        {
            InitializeComponent();
            try
            {
                // Initialiser la connexion à la base de données
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["bddString"].ConnectionString);
                // Ouvre la connexion à la base de données
                laConnection.Open();
                AfficherThemes(); // Appel à la méthode pour charger les modules
                dataGridView_themes.CellClick += DataGridViewThemes_CellClick; // l'événement CellClick
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

        private void AfficherThemes()
        {
            try
            {
                // Récupère la liste des thèmes associés à un module donné
                List<theme> themes = theme.RecupTheme(laConnection);

                // Crée un DataTable pour lier les données au DataGridView
                DataTable dt = new DataTable();
                dt.Columns.Add("theme_id"); // Colonne pour l'ID du thème
                dt.Columns.Add("Titre");     // Colonne pour le titre du thème
                dt.Columns.Add("Module");     // Colonne pour le titre du module

                // Remplit le DataTable avec les thèmes récupérés
                foreach (var th in themes)
                {
                    dt.Rows.Add(th.Theme_id, th.Theme_nom, th.Mod_id); // Assurez-vous que Mod_titre est une propriété de l'objet theme
                }

                // Lier le DataTable au DataGridView
                dataGridView_themes.DataSource = dt;

                // Cacher la colonne de l'ID
                dataGridView_themes.Columns["theme_id"].Visible = false; // Cacher la colonne "theme_id"
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de la récupération des thèmes : " + ex.Message);
            }
        }



        private void DataGridViewThemes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie que l'index de ligne est valide
            if (e.RowIndex >= 0)
            {
                // Récupérer la ligne sélectionnée
                DataGridViewRow row = dataGridView_themes.Rows[e.RowIndex];

                // Assignation des valeurs aux TextBox
                txtbox_titre.Text = row.Cells["Titre"].Value.ToString();
                txtbox_module.Text = row.Cells["Module"].Value.ToString();
            }
        }

        private void btn_ajoutTheme_Click(object sender, EventArgs e)
        {
            // Vérifie que les TextBox ne sont pas vides
            if (string.IsNullOrWhiteSpace(txtbox_titre.Text) ||
                string.IsNullOrWhiteSpace(txtbox_module.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            // Crée un nouveau thème
            theme nouveauTheme = new theme(0, // id, à 0 pour l'auto-incrémentation
                                               txtbox_titre.Text,
                                               int.Parse(txtbox_module.Text));

            try
            {
                // Ajoute le thème à la base de données
                nouveauTheme.AjouterTheme(laConnection); // Assurez-vous que cette méthode est implémentée dans votre classe
                MessageBox.Show("Thème ajouté avec succès !");

                // Rafraîchir la liste des thèmes affichés
                AfficherThemes();
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de l'ajout du thème : " + ex.Message);
            }
        }

        private void btn_suppTheme_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une ligne est sélectionnée dans le DataGridView
            if (dataGridView_themes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un thème à supprimer.");
                return;
            }

            // Récupérer le thème sélectionné
            DataGridViewRow selectedRow = dataGridView_themes.SelectedRows[0];
            int themeId = Convert.ToInt32(selectedRow.Cells["theme_id"].Value); // Utiliser "theme_id"

            // Appelle la procédure de suppression
            MySqlCommand cmd = new MySqlCommand("proc_supprimerTheme", laConnection)
            {
                CommandType = CommandType.StoredProcedure
            };
            cmd.Parameters.AddWithValue("@id_theme", themeId); // Correspond au nom du paramètre de la procédure
            cmd.ExecuteNonQuery(); // Exécute la commande

            MessageBox.Show("Thème supprimé avec succès !");

            // Rafraîchir la liste des thèmes affichés
            AfficherThemes();

            // Libérer les ressources manuellement
            cmd.Dispose(); // Libération des ressources de la commande
        }


        private void btn_modifTheme_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une ligne est sélectionnée dans le DataGridView
            if (dataGridView_themes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un thème à modifier.");
                return;
            }

            // Récupérer le thème sélectionné
            DataGridViewRow selectedRow = dataGridView_themes.SelectedRows[0];
            int themeId = Convert.ToInt32(selectedRow.Cells["theme_id"].Value); // Utiliser "theme_id"

            // Vérifie que les TextBox ne sont pas vides
            if (string.IsNullOrWhiteSpace(txtbox_titre.Text) ||
                string.IsNullOrWhiteSpace(txtbox_module.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            try
            {
                // Créer une instance du thème
                theme themeAModifier = new theme(themeId,
                                                  txtbox_titre.Text,
                                                  int.Parse(txtbox_module.Text));

                // Appel de la méthode pour mettre à jour le thème
                themeAModifier.ModifierTheme(laConnection); // Assurez-vous que cette méthode est implémentée dans votre classe
                MessageBox.Show("Thème modifié avec succès !");

                // Rafraîchir la liste des thèmes affichés
                AfficherThemes();
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de la modification du thème : " + ex.Message);
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
            Button utilisateurs = new Button { Text = "Utilisateurs", Dock = DockStyle.Top };

            // Associe l'événement de clic pour le tableau de bord
            tableauBord.Click += tableauBord_Click;
            utilisateurs.Click += gererUtilisateur_Click;
            tableauBord.Cursor = Cursors.Hand;
            utilisateurs.Cursor = Cursors.Hand;

            // Ajoute les boutons au menu
            menuPanel.Controls.Add(tableauBord);
            menuPanel.Controls.Add(utilisateurs);

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
            // Cache le formulaire actuel et ouvre le tableau de bord pour l'admin
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
            // Ferme l'application
            Application.Exit();
        }
    }
}
