using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace lib_vco
{
    /// <summary>
    /// Représente un utilisateur dans le système, avec des propriétés pour l'identifiant, le nom, le prénom, le login, le mot de passe et le rôle.
    /// </summary>
    public class utilisateur
    {
        #region Propriétés
        // Propriétés privées représentant les attributs d'un utilisateur
        private int uti_id;               // Identifiant unique de l'utilisateur
        private string uti_nom;           // Nom de l'utilisateur
        private string uti_prenom;        // Prénom de l'utilisateur
        private string uti_login;         // Login de l'utilisateur
        private string uti_motdepasse;   // Mot de passe de l'utilisateur
        private string uti_role;          // Rôle de l'utilisateur (ex: admin, formateur, apprenant)
        #endregion

        #region Constructeur
        /// <summary>
        /// Initialise une nouvelle instance de la classe utilisateur avec les paramètres fournis.
        /// </summary>
        /// <param name="uti_id">Identifiant de l'utilisateur.</param>
        /// <param name="uti_nom">Nom de l'utilisateur.</param>
        /// <param name="uti_prenom">Prénom de l'utilisateur.</param>
        /// <param name="uti_login">Login de l'utilisateur.</param>
        /// <param name="uti_motdepasse">Mot de passe de l'utilisateur.</param>
        /// <param name="uti_role">Rôle de l'utilisateur.</param>
        public utilisateur(
            int uti_id, string uti_nom, string uti_prenom, string uti_login, string uti_motdepasse, string uti_role)
        {
            this.uti_id = uti_id;
            this.uti_nom = uti_nom;
            this.uti_prenom = uti_prenom;
            this.uti_login = uti_login;
            this.uti_motdepasse = uti_motdepasse;
            this.uti_role = uti_role;
        }
        #endregion

        #region Property
        // Propriétés publiques pour accéder aux attributs privés de la classe
        /// <summary>
        /// Obtient ou modifie la valeur de l'identifiant d'un utilisateur.
        /// </summary>
        public int Uti_id
        {
            get { return uti_id; }
            set { uti_id = value; }
        }
        /// <summary>
        /// Obtient ou modifie la valeur du nom d'un utilisateur.
        /// </summary>
        public string Uti_nom
        {
            get { return uti_nom; }
            set { uti_nom = value; }
        }
        /// <summary>
        /// Obtient ou modifie la valeur du prénom d'un utilisateur.
        /// </summary>
        public string Uti_prenom
        {
            get { return uti_prenom; }
            set { uti_prenom = value; }
        }
        /// <summary>
        /// Obtient ou modifie la valeur du login d'un utilisateur.
        /// </summary>
        public string Uti_login
        {
            get { return uti_login; }
            set { uti_login = value; }
        }
        /// <summary>
        /// Obtient ou modifie la valeur du mot de passe d'un utilisateur.
        /// </summary>
        public string Uti_motdepasse
        {
            get { return uti_motdepasse; }
            set { uti_motdepasse = value; }
        }
        /// <summary>
        /// Obtient ou modifie la valeur du rôle d'un utilisateur.
        /// </summary>
        public string Uti_role
        {
            get { return uti_role; }
            set { uti_role = value; }
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Ajoute un nouvel utilisateur à la base de données en utilisant une procédure stockée.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void AjouterUtilisateur(MySqlConnection connection)
        {
            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_ajouterUtilisateur", connection);
            command.CommandType = CommandType.StoredProcedure; // Indique que c'est une procédure stockée

            // Ajouter les paramètres nécessaires pour la procédure
            command.Parameters.AddWithValue("@uti_nom", this.Uti_nom);
            command.Parameters.AddWithValue("@uti_prenom", this.Uti_prenom);
            command.Parameters.AddWithValue("@uti_role", this.Uti_role);

            // Exécuter la commande
            command.ExecuteNonQuery();

            // Libérer la commande
            command.Dispose();
        }


        /// <summary>
        /// Récupère la liste de tous les utilisateurs de la base de données en utilisant la procédure stockée `proc_listeUtilisateurs`.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        /// <returns>Une liste d'utilisateurs.</returns>
        public static List<utilisateur> RecupUtilisateurs(MySqlConnection connection)
        {
            List<utilisateur> utilisateurs = new List<utilisateur>();

            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_listeUtilisateurs", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Exécuter la commande et lire les résultats
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                utilisateurs.Add(new utilisateur(
                    Convert.ToInt32(reader["uti_id"]),
                    reader["uti_nom"].ToString(),
                    reader["uti_prenom"].ToString(),
                    reader["uti_login"].ToString(),
                    null, // Ne pas récupérer le mot de passe pour des raisons de sécurité
                    reader["uti_role"].ToString()
                ));
            }

            // Fermer le lecteur et libérer la commande
            reader.Close();
            command.Dispose();

            return utilisateurs; // Retourne la liste des utilisateurs récupérés
        }


        /// <summary>
        /// Met à jour les informations d'un utilisateur dans la base de données en utilisant la procédure stockée `proc_modifierUtilisateur`.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void MettreAJourUtilisateur(MySqlConnection connection)
        {
            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_modifierUtilisateur", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Ajout des paramètres pour la procédure
            command.Parameters.AddWithValue("id_uti", this.uti_id);
            command.Parameters.AddWithValue("nom_uti", this.uti_nom);
            command.Parameters.AddWithValue("prenom_uti", this.uti_prenom);
            command.Parameters.AddWithValue("login_uti", this.uti_login);
            command.Parameters.AddWithValue("role_uti", this.uti_role); // Vérifie que le rôle est valide

            // Exécute la procédure
            command.ExecuteNonQuery();

            // Libérer la commande
            command.Dispose();
        }


        /// <summary>
        /// Supprime un utilisateur de la base de données en utilisant la procédure stockée `proc_supprimerUtilisateur.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void SupprimerUtilisateur(MySqlConnection connection)
        {
            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_supprimerUtilisateur", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Ajouter l'identifiant de l'utilisateur à supprimer
            command.Parameters.AddWithValue("@id_uti", this.uti_id);

            // Exécuter la procédure pour supprimer l'utilisateur
            command.ExecuteNonQuery();

            // Libérer la commande
            command.Dispose();
        }


        /// <summary>
        /// Vérifie les informations de connexion d'un utilisateur dans la base de données.
        /// Cette méthode exécute une requête SQL pour vérifier si les informations de connexion (login et mot de passe)
        /// correspondent à un utilisateur existant dans la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        /// <returns>Le prénom de l'utilisateur si la connexion est réussie, sinon null.</returns>
        public string ConnexionUtilisateur(MySqlConnection connection)
        {
            string query = "SELECT uti_role, uti_prenom FROM utilisateur WHERE uti_login = @uti_login AND uti_motPasse = @uti_motdepasse";
            MySqlCommand cmd = new MySqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@uti_login", this.uti_login);
            cmd.Parameters.AddWithValue("@uti_motdepasse", this.uti_motdepasse);

            var result = cmd.ExecuteScalar();
            if (result != null)
            {
                return result.ToString();
            }

            return null;
        }


        #endregion
    }
}
