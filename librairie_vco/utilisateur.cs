using System;
using System.Data;
using MySql.Data.MySqlClient;

namespace librairie_vco
{
    /// <summary>
    /// Représente un utilisateur
    /// </summary>
    public class utilisateur
    {
        
        #region Propriétés
        private int uti_id;
        private string uti_nom;
        private string uti_prenom;
        private string uti_login;
        private string uti_motdepasse;
        private string uti_role;
        #endregion

        #region Constructeur
        /// <summary>
        /// Initialise 
        /// </summary>
        /// <param name="uti_id"></param>
        /// <param name="uti_nom"></param>
        /// <param name="uti_prenom"></param>
        /// <param name="uti_login"></param>
        /// <param name="uti_motdepasse"></param>
        /// <param name="uti_role"></param>
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
        /// <summary>
        /// obtient ou modifie la valeur de l'id d'un utilisateur
        /// </summary>
        public int Uti_id
        {
            get { return uti_id; }
            set { uti_id = value; }
        }
        /// <summary>
        /// obtient ou modifie la valeur du nom d'un utilisateur
        /// </summary>
        public string Uti_nom
        {
            get { return uti_nom; }
            set { uti_nom = value; }
        }
        /// <summary>
        /// obtient ou modifie la valeur du prénom d'un utilisateur
        /// </summary>
        public string Uti_prenom
        {
            get { return uti_prenom; }
            set { uti_prenom = value; }
        }
        /// <summary>
        /// obtient ou modifie la valeur du login d'un utilisateur
        /// </summary>
        public string Uti_login
        {
            get { return uti_login; }
            set { uti_login = value; }
        }
        /// <summary>
        /// obtient ou modifie la valeur du mot de passe d'un utilisateur
        /// </summary>
        public string Uti_motdepasse
        {
            get { return uti_motdepasse; }
            set { uti_motdepasse = value; }
        }
        /// <summary>
        /// obtient ou modifie la valeur du rôle d'un utilisateur
        /// </summary>
        public string Uti_role
        {
            get { return uti_role; }
            set { uti_role = value; }
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Ajoute un nouvel utilisateur à la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void AjouterUtilisateur(MySqlConnection connection)
        {
            string query = "INSERT INTO utilisateurs (uti_nom, uti_prenom, uti_login, uti_motdepasse, uti_role) VALUES (@nom, @prenom, @login, @motdepasse, @role)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nom", this.Uti_nom);
                command.Parameters.AddWithValue("@prenom", this.Uti_prenom);
                command.Parameters.AddWithValue("@login", this.Uti_login);
                command.Parameters.AddWithValue("@motdepasse", this.Uti_motdepasse);
                command.Parameters.AddWithValue("@role", this.Uti_role);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Récupère un utilisateur de la base de données par son identifiant.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        /// <param name="id">L'identifiant de l'utilisateur à récupérer.</param>
        /// <returns>L'utilisateur correspondant ou null si aucun utilisateur n'est trouvé.</returns>
        public static utilisateur GetUtilisateurById(MySqlConnection connection, int id)
        {
            string query = "SELECT * FROM utilisateurs WHERE uti_id = @id";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", id);
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new utilisateur(
                            reader.GetInt32("uti_id"),
                            reader.GetString("uti_nom"),
                            reader.GetString("uti_prenom"),
                            reader.GetString("uti_login"),
                            reader.GetString("uti_motdepasse"),
                            reader.GetString("uti_role"));
                    }
                }
            }
            return null; // Si aucun utilisateur n'est trouvé
        }

        /// <summary>
        /// Met à jour les informations d'un utilisateur dans la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void MettreAJourUtilisateur(MySqlConnection connection)
        {
            string query = "UPDATE utilisateurs SET uti_nom = @nom, uti_prenom = @prenom, uti_login = @login, uti_motdepasse = @motdepasse, uti_role = @role WHERE uti_id = @id";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", this.Uti_id);
                command.Parameters.AddWithValue("@nom", this.Uti_nom);
                command.Parameters.AddWithValue("@prenom", this.Uti_prenom);
                command.Parameters.AddWithValue("@login", this.Uti_login);
                command.Parameters.AddWithValue("@motdepasse", this.Uti_motdepasse);
                command.Parameters.AddWithValue("@role", this.Uti_role);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Supprime un utilisateur de la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void SupprimerUtilisateur(MySqlConnection connection)
        {
            string query = "DELETE FROM utilisateurs WHERE uti_id = @id";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", this.Uti_id);
                command.ExecuteNonQuery();
            }
        }
        #endregion

    }
}

