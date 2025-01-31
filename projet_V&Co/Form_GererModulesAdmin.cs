using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lib_vco;
using System.Configuration;

namespace projet_V_Co
{
    public partial class Form_GererModulesAdmin : Form
    {
        private MySqlConnection laConnection; // La connexion à la base de données
        private Panel menuPanel;
        public Form_GererModulesAdmin()
        {
            InitializeComponent();

            try
            {
                // Initialiser la connexion à la base de données
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["bddString"].ConnectionString);
                // Ouvre la connexion à la base de données
                laConnection.Open();
                AfficherModules(); // Appel à la méthode pour charger les modules
                dataGridView_modules.CellClick += DataGridViewModules_CellClick; // l'événement CellClick
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

        private void AfficherModules()
        {
            try
            {
                // Récupère la liste des modules en utilisant la méthode RecupModules
                List<module> modules = module.RecupModules(laConnection);

                // Crée un DataTable pour lier les données au DataGridView
                DataTable dt = new DataTable();
                dt.Columns.Add("mod_id"); // Colonne pour l'ID du module, mais cacher
                dt.Columns.Add("Titre");
                dt.Columns.Add("Image");

                // Remplit le DataTable avec les modules récupérés
                foreach (var mod in modules)
                {
                    dt.Rows.Add(mod.ModId, mod.ModTitre, mod.ModImage);
                }

                // Lier le DataTable au DataGridView
                dataGridView_modules.DataSource = dt;

                // Cacher la colonne de l'ID
                dataGridView_modules.Columns["mod_id"].Visible = false; // Cacher la colonne "mod_id"
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de la récupération des modules : " + ex.Message);
            }
        }

        private void DataGridViewModules_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Vérifie que l'index de ligne est valide
            if (e.RowIndex >= 0)
            {
                // Récupérer la ligne sélectionnée
                DataGridViewRow row = dataGridView_modules.Rows[e.RowIndex];

                // Assignation des valeurs aux TextBox
                txtbox_titre.Text = row.Cells["Titre"].Value.ToString();
                txtbox_image.Text = row.Cells["Image"].Value.ToString(); 
            }
        }

        private void btn_ajoutModule_Click(object sender, EventArgs e)
        {
            // Vérifie que les TextBox ne sont pas vides
            if (string.IsNullOrWhiteSpace(txtbox_titre.Text) ||
                string.IsNullOrWhiteSpace(txtbox_image.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            // Crée un nouveau module
            module nouveauModule = new module(0, // id, à 0 pour l'auto-incrémentation
                                               txtbox_titre.Text,
                                               txtbox_image.Text);

            try
            {
                // Ajoute le module à la base de données
                nouveauModule.AjouterModule(laConnection); // La méthode doit gérer l'ajout
                MessageBox.Show("Module ajouté avec succès !");

                // Rafraîchir la liste des modules affichés
                AfficherModules();
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de l'ajout du module : " + ex.Message);
            }
        }

        private void btn_suppModule_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une ligne est sélectionnée dans le DataGridView
            if (dataGridView_modules.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un module à supprimer.");
                return;
            }

            // Récupérer le module sélectionné
            DataGridViewRow selectedRow = dataGridView_modules.SelectedRows[0];
            int moduleId = Convert.ToInt32(selectedRow.Cells["mod_id"].Value); 

            try
            {
                // Appelle la procédure de suppression
                MySqlCommand cmd = new MySqlCommand("proc_supprimerModule", laConnection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Parameters.AddWithValue("id_mod", moduleId); // Correspond au nom du paramètre de la procédure
                cmd.ExecuteNonQuery(); // Exécute la commande

                MessageBox.Show("Module supprimé avec succès !");

                // Rafraîchir la liste des modules affichés
                AfficherModules();
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de la suppression du module : " + ex.Message);
            }
        }

        

        private void btn_modifModule_Click(object sender, EventArgs e)
        {
            // Vérifie qu'une ligne est sélectionnée dans le DataGridView
            if (dataGridView_modules.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un module à modifier.");
                return;
            }

            // Récupérer le module sélectionné
            DataGridViewRow selectedRow = dataGridView_modules.SelectedRows[0];
            int moduleId = Convert.ToInt32(selectedRow.Cells["mod_id"].Value);

            // Vérifie que les TextBox ne sont pas vides
            if (string.IsNullOrWhiteSpace(txtbox_titre.Text) ||
                string.IsNullOrWhiteSpace(txtbox_image.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.");
                return;
            }

            try
            {
                // Créer une instance du module
                module moduleAModifier = new module(moduleId,
                                                      txtbox_titre.Text,
                                                      txtbox_image.Text);

                // Appel de la méthode pour mettre à jour le module
                moduleAModifier.ModifierModule(laConnection);
                MessageBox.Show("Module modifié avec succès !");

                // Rafraîchir la liste des modules affichés
                AfficherModules();
            }
            catch (Exception ex)
            {
                // Gérer les exceptions ici (par exemple, afficher un message d'erreur)
                MessageBox.Show("Erreur lors de la modification du module : " + ex.Message);
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
