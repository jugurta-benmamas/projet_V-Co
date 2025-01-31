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
    public partial class Form_CoursFormateur : Form
    {
        // Connexion à la base de données
        private MySqlConnection laConnection;
        // Panel pour le menu
        private Panel menuPanel;
        // Cours sélectionné par l'apprenant
        private cours coursSelectionne;
        public Form_CoursFormateur(cours cours)
        {
            // Initialise les composants de l'interface
            InitializeComponent();
            // Assigne le cours sélectionné
            coursSelectionne = cours;
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

        
        private void AfficherContenuCours()
        {
            lbl_titreCours.Text = coursSelectionne.Cours_titre;
            txtbox_contenuCours.Text = coursSelectionne.Cours_contenu;
            // Sélectionne le début du texte
            txtbox_contenuCours.Select(0, 0);
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
            // Événement au clic sur le bouton
            burgerButton.Click += BurgerButton_Click;

            // Panel du menu
            menuPanel = new Panel
            {
                Size = new Size(100, 220),
                Location = new Point(12, 165),
                BackColor = Color.LightGray,
                Visible = false
            };

            // Boutons du menu
            Button tableauBord = new Button { Text = "Tableau de bord", Dock = DockStyle.Top };
            Button statistiques = new Button { Text = "Statistiques", Dock = DockStyle.Top };

            // Événement au clic sur le bouton tableau de bord
            tableauBord.Click += tableauBord_Click;
            tableauBord.Cursor = Cursors.Hand; // Change le curseur au survol
            statistiques.Cursor = Cursors.Hand; // Change le curseur au survol

            // Ajoute les boutons au panel du menu
            menuPanel.Controls.Add(tableauBord);
            menuPanel.Controls.Add(statistiques);

            // Ajoute le bouton burger et le panel au formulaire
            this.Controls.Add(burgerButton);
            this.Controls.Add(menuPanel);
        }


        private void BurgerButton_Click(object sender, EventArgs e)
        {
            // Bascule la visibilité du panneau de menu (menuPanel)
            menuPanel.Visible = !menuPanel.Visible;
        }

        private void tableauBord_Click(object sender, EventArgs e)
        {
            // Cache le formulaire actuel et ouvre le tableau de bord pour le formateur
            this.Hide();
            Form_TableauBordFormateur formTableauBordForm = new Form_TableauBordFormateur();
            formTableauBordForm.Closed += (s, args) => this.Close();
            formTableauBordForm.Show();
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            // Ferme l'application
            Application.Exit();
        }

        private void lbl_deconnexion_Click(object sender, EventArgs e)
        {
            // Appelle la méthode de déconnexion pour gérer la fermeture de session
            deconnexion();
        }

        private void lbl_nomEntreprise_Click(object sender, EventArgs e)
        {
            // Cache le formulaire actuel et ouvre à nouveau le tableau de bord pour le formateur
            this.Hide();
            Form_TableauBordFormateur formTableauBordForm = new Form_TableauBordFormateur();
            formTableauBordForm.Closed += (s, args) => this.Close();
            formTableauBordForm.Show();
        }

    }
}
