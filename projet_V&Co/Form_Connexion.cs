using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using lib_vco;
using System.Configuration;
using System.Data.Common;
using System.Text.RegularExpressions;

namespace projet_V_Co
{
    public partial class Form_Connexion : Form
    {
        // Connexion à la base de données
        MySqlConnection laConnection;

        public Form_Connexion()
        {
            // Initialise les composants de l'interface
            InitializeComponent();

            try
            {
                // Récupère la chaîne de connexion depuis le fichier de configuration
                laConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["bddString"].ConnectionString);
                // Ouvre la connexion à la base de données
                laConnection.Open();
            }
            catch (Exception ex)
            {
                // Affiche un message d'erreur si la connexion échoue
                string message = "Problème d'accès à vos données. Contacter votre administrateur.";
                MessageBox.Show(message);
            }
        }

        private void btn_connexion_Click(object sender, EventArgs e)
        {
            // Récupère le login et le mot de passe de l'utilisateur
            string uti_login = txtbox_login.Text;
            string uti_motPasse = txtbox_mdp.Text;

            try
            {
                // Crée un nouvel utilisateur avec les informations fournies
                utilisateur user = new utilisateur(0, "", "", uti_login, uti_motPasse, "");
                // Tente de se connecter et récupère le rôle de l'utilisateur
                string uti_role = user.ConnexionUtilisateur(laConnection);

                if (uti_role != null)
                {
                    // Vérifie le rôle sélectionné par l'utilisateur
                    string roleSelectionne = "";
                    if (rdbtn_apprenant.Checked)
                        roleSelectionne = "apprenant";
                    else if (rdbtn_formateur.Checked)
                        roleSelectionne = "formateur";
                    else if (rdbtn_admin.Checked)
                        roleSelectionne = "admin";

                    // Vérifie si le rôle de l'utilisateur correspond au rôle sélectionné
                    if (uti_role == roleSelectionne)
                    {
                        // Ouvre le tableau de bord correspondant au rôle
                        if (uti_role == "apprenant")
                        {
                            this.Hide(); // Cache le formulaire de connexion
                            Form_TableauBordApprenant apprenant = new Form_TableauBordApprenant();
                            apprenant.Closed += (s, args) => this.Close(); // Ferme le formulaire de connexion à la fermeture du tableau de bord
                            apprenant.Show(); // Affiche le tableau de bord apprenant
                        }
                        else if (uti_role == "formateur")
                        {
                            this.Hide();
                            Form_TableauBordFormateur formateur = new Form_TableauBordFormateur();
                            formateur.Closed += (s, args) => this.Close();
                            formateur.Show(); // Affiche le tableau de bord formateur
                        }
                        else if (uti_role == "admin")
                        {
                            this.Hide();
                            Form_TableauBordAdmin admin = new Form_TableauBordAdmin();
                            admin.Closed += (s, args) => this.Close();
                            admin.Show(); // Affiche le tableau de bord administrateur
                        }
                    }
                    else
                    {
                        // Affiche un message d'erreur si les rôles ne correspondent pas
                        MessageBox.Show("Le rôle sélectionné ne correspond pas à votre rôle enregistré.");
                    }
                }
                else
                {
                    // Affiche un message d'erreur si le nom d'utilisateur ou le mot de passe est incorrect
                    MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.");
                }
            }
            catch (MySqlException ex)
            {
                // Affiche un message d'erreur en cas d'exception lors de la connexion
                MessageBox.Show("Erreur lors de la tentative de connexion : " + ex.Message);
            }
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            // Quitte l'application
            Application.Exit();
        }
    }

}
