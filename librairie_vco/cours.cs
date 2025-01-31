using MySql.Data.MySqlClient;

namespace librairie_vco
{
    /// <summary>
    /// Représente un cours dans l'application.
    /// </summary>
    public class cours
    {
        #region Propriétés
        private int cours_id;
        private string cours_titre;
        private string cours_description;
        private int theme_id; // Clé étrangère vers le thème
        #endregion

        #region Constructeur
        /// <summary>
        /// Initialise un nouveau cours avec ses propriétés.
        /// </summary>
        /// <param name="cours_id">L'identifiant du cours.</param>
        /// <param name="cours_titre">Le titre du cours.</param>
        /// <param name="cours_description">La description du cours.</param>
        /// <param name="theme_id">L'identifiant du thème associé au cours.</param>
        public cours(int cours_id, string cours_titre, string cours_description, int theme_id)
        {
            this.cours_id = cours_id;
            this.cours_titre = cours_titre;
            this.cours_description = cours_description;
            this.theme_id = theme_id;
        }
        #endregion

        #region Property
        /// <summary>
        /// Obtient ou modifie l'identifiant du cours.
        /// </summary>
        public int Cours_id
        {
            get { return cours_id; }
            set { cours_id = value; }
        }

        /// <summary>
        /// Obtient ou modifie le titre du cours.
        /// </summary>
        public string Cours_titre
        {
            get { return cours_titre; }
            set { cours_titre = value; }
        }

        /// <summary>
        /// Obtient ou modifie la description du cours.
        /// </summary>
        public string Cours_description
        {
            get { return cours_description; }
            set { cours_description = value; }
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Ajoute un nouveau cours à la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void AjouterCours(MySqlConnection connection)
        {
            string query = "INSERT INTO cours (cours_titre, cours_description, theme_id) VALUES (@titre, @description, @theme_id)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@titre", this.Cours_titre);
                command.Parameters.AddWithValue("@description", this.Cours_description);
                command.Parameters.AddWithValue("@theme_id", this.theme_id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Met à jour les informations d'un cours dans la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void MettreAJourCours(MySqlConnection connection)
        {
            string query = "UPDATE cours SET cours_titre = @titre, cours_description = @description WHERE cours_id = @id";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@titre", this.Cours_titre);
                command.Parameters.AddWithValue("@description", this.Cours_description);
                command.Parameters.AddWithValue("@id", this.Cours_id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Supprime un cours de la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void SupprimerCours(MySqlConnection connection)
        {
            string query = "DELETE FROM cours WHERE cours_id = @id";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", this.Cours_id);
                command.ExecuteNonQuery();
            }
        }
        #endregion
    }
}
