using MySql.Data.MySqlClient;

namespace librairie_vco
{
    /// <summary>
    /// Représente la progression d'un utilisateur dans un cours.
    /// </summary>
    public class progression
    {
        #region Propriétés
        private int progression_id;
        private int utilisateur_id; // Clé étrangère vers l'utilisateur
        private int cours_id; // Clé étrangère vers le cours
        private bool compris; // Indique si le cours a été compris
        #endregion

        #region Constructeur
        /// <summary>
        /// Initialise une nouvelle progression avec ses propriétés.
        /// </summary>
        /// <param name="progression_id">L'identifiant de la progression.</param>
        /// <param name="utilisateur_id">L'identifiant de l'utilisateur associé à la progression.</param>
        /// <param name="cours_id">L'identifiant du cours associé à la progression.</param>
        /// <param name="compris">Indique si le cours a été compris.</param>
        public progression(int progression_id, int utilisateur_id, int cours_id, bool compris)
        {
            this.progression_id = progression_id;
            this.utilisateur_id = utilisateur_id;
            this.cours_id = cours_id;
            this.compris = compris;
        }
        #endregion

        #region Property
        /// <summary>
        /// Obtient ou modifie l'identifiant de la progression.
        /// </summary>
        public int Progression_id
        {
            get { return progression_id; }
            set { progression_id = value; }
        }

        /// <summary>
        /// Obtient ou modifie l'identifiant de l'utilisateur associé à la progression.
        /// </summary>
        public int Utilisateur_id
        {
            get { return utilisateur_id; }
            set { utilisateur_id = value; }
        }

        /// <summary>
        /// Obtient ou modifie l'identifiant du cours associé à la progression.
        /// </summary>
        public int Cours_id
        {
            get { return cours_id; }
            set { cours_id = value; }
        }

        /// <summary>
        /// Obtient ou modifie l'état de compréhension du cours.
        /// </summary>
        public bool Compris
        {
            get { return compris; }
            set { compris = value; }
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Ajoute une nouvelle progression à la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void AjouterProgression(MySqlConnection connection)
        {
            string query = "INSERT INTO progression (utilisateur_id, cours_id, compris) VALUES (@utilisateur_id, @cours_id, @compris)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@utilisateur_id", this.Utilisateur_id);
                command.Parameters.AddWithValue("@cours_id", this.Cours_id);
                command.Parameters.AddWithValue("@compris", this.Compris);
                command.ExecuteNonQuery();
            }
        }
        #endregion
    }
}
