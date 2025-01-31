using lib_vco;
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

namespace projet_V_Co
{
    public partial class Form_CoursAdmin : Form
    {
        // Connexion à la base de données
        private MySqlConnection laConnection;
        // Panel pour le menu
        private Panel menuPanel;
        // Cours sélectionné par l'apprenant
        private cours coursSelectionne;

        public Form_CoursAdmin(cours cours)
        {
            // Initialise les composants de l'interface
            InitializeComponent();
            coursSelectionne = cours; // Stocke le cours sélectionné

            // Initialise le menu burger
            InitializeBurgerMenu();

            try
            {
                // Initialise la connexion à la base de données
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["bddString"].ConnectionString);
                laConnection.Open(); // Ouvre la connexion

                // Affiche le contenu du cours
                AfficherContenuCours();
            }
            catch (MySqlException)
            {
                // Affiche un message d'erreur en cas de problème d'accès aux données
                MessageBox.Show("Problème d'accès à vos données. Contactez votre administrateur.", "Erreur rencontrée", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Méthode pour déconnecter l'utilisateur et revenir à la connexion
        private void deconnexion()
        {
            try
            {
                // Ferme la connexion si elle est ouverte
                if (laConnection != null && laConnection.State == System.Data.ConnectionState.Open)
                {
                    laConnection.Close();
                }

                // Cache le formulaire actuel
                this.Hide();
                // Crée un nouveau formulaire de connexion
                Form_Connexion connexion = new Form_Connexion();
                // Ferme le formulaire de cours lors de la fermeture de la connexion
                connexion.Closed += (s, args) => this.Close();
                // Affiche le formulaire de connexion
                connexion.Show();
            }
            catch (MySqlException)
            {
                // Affiche un message d'erreur si la déconnexion échoue
                MessageBox.Show("La déconnexion n'a pas abouti", "Déconnexion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // Méthode pour afficher le contenu du cours sélectionné
        private void AfficherContenuCours()
        {
            lbl_titreCours.Text = coursSelectionne.Cours_titre; // Met à jour le titre du cours
            txtbox_contenuCours.Text = coursSelectionne.Cours_contenu; // Met à jour le contenu du cours
                                                                       // Sélectionne le début du texte
            txtbox_contenuCours.Select(0, 0);
        }

        // Méthode pour initialiser le menu burger
        private void InitializeBurgerMenu()
        {
            // Crée le bouton du menu burger
            Button burgerButton = new Button
            {
                Text = "☰",
                Font = new Font("Arial", 15, FontStyle.Bold),
                Size = new Size(70, 50),
                Location = new Point(25, 115)
            };
            // Associe l'événement de clic
            burgerButton.Click += BurgerButton_Click;

            // Initialise le panel du menu
            menuPanel = new Panel
            {
                Size = new Size(100, 90),
                Location = new Point(12, 165),
                BackColor = Color.LightGray,
                Visible = false // Le menu est initialement masqué
            };

            // Crée des boutons pour le menu
            Button tableauBord = new Button { Text = "Tableau de bord", Dock = DockStyle.Top };
            Button gererUtilisateur = new Button { Text = "Utilisateurs", Dock = DockStyle.Top };

            // Associe les événements de clic pour les boutons du menu
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

        // Événement déclenché lors du clic sur le bouton burger
        private void BurgerButton_Click(object sender, EventArgs e)
        {
            menuPanel.Visible = !menuPanel.Visible; // Alterne la visibilité du menu
        }

        // Événement déclenché lors du clic sur le bouton du tableau de bord
        private void tableauBord_Click(object sender, EventArgs e)
        {
            this.Hide(); // Cache le formulaire actuel
            Form_TableauBordAdmin formTableauBordAdmin = new Form_TableauBordAdmin(); // Crée une nouvelle instance du tableau de bord admin
            formTableauBordAdmin.Closed += (s, args) => this.Close(); // Ferme ce formulaire à la fermeture du tableau de bord
            formTableauBordAdmin.Show(); // Affiche le tableau de bord admin
        }

        // Événement déclenché lors du clic sur le bouton de gestion des utilisateurs
        private void gererUtilisateur_Click(object sender, EventArgs e)
        {
            this.Hide(); // Cache le formulaire actuel
            Form_GererUtilisateurs gererUtilisateurs = new Form_GererUtilisateurs(); // Crée une nouvelle instance du gestionnaire d'utilisateurs
            gererUtilisateurs.Closed += (s, args) => this.Close(); // Ferme ce formulaire à la fermeture du gestionnaire d'utilisateurs
            gererUtilisateurs.Show(); // Affiche le gestionnaire d'utilisateurs
        }

        // Événement déclenché lors du clic sur le bouton de quitter
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Quitte l'application
        }

        // Événement déclenché lors du clic sur le label de déconnexion
        private void lbl_deconnexion_Click(object sender, EventArgs e)
        {
            deconnexion(); // Appelle la méthode de déconnexion
        }

        // Événement déclenché lors du clic sur le label du nom de l'entreprise
        private void lbl_nomEntreprise_Click(object sender, EventArgs e)
        {
            this.Hide(); // Cache le formulaire actuel
            Form_TableauBordAdmin formTableauBordAdmin = new Form_TableauBordAdmin(); // Crée une nouvelle instance du tableau de bord admin
            formTableauBordAdmin.Closed += (s, args) => this.Close(); // Ferme ce formulaire à la fermeture du tableau de bord
            formTableauBordAdmin.Show(); // Affiche le tableau de bord admin
        }
    }

}


