using System;
using System.Collections.Generic; 
using MySql.Data.MySqlClient;

namespace librairie_vco
{
    /// <summary>
    /// Représente un thème d'apprentissage associé à un module.
    /// </summary>
    public class Theme
    {
        #region Propriétés
        private int theme_id;
        private string theme_nom;
        private int mod_id; // Clé étrangère vers le module
        #endregion

        #region Constructeur
        /// <summary>
        /// Initialise un nouveau thème avec ses propriétés.
        /// </summary>
        /// <param name="theme_id">L'identifiant du thème.</param>
        /// <param name="theme_nom">Le nom du thème.</param>
        /// <param name="mod_id">L'identifiant du module auquel le thème est associé.</param>
        public Theme(int theme_id, string theme_nom, int mod_id)
        {
            this.theme_id = theme_id;
            this.theme_nom = theme_nom;
            this.mod_id = mod_id;
        }
        #endregion

        #region Properties
        /// <summary>
        /// Obtient ou modifie la valeur de l'identifiant du thème.
        /// </summary>
        public int Theme_id
        {
            get { return theme_id; }
            set { theme_id = value; }
        }

        /// <summary>
        /// Obtient ou modifie la valeur du nom du thème.
        /// </summary>
        public string Theme_nom
        {
            get { return theme_nom; }
            set { theme_nom = value; }
        }

        /// <summary>
        /// Obtient ou modifie la valeur de l'identifiant du module associé.
        /// </summary>
        public int Mod_id
        {
            get { return mod_id; }
            set { mod_id = value; }
        }
        #endregion

        #region Méthodes
        /// <summary>
        /// Ajoute un nouveau thème à la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void AjouterTheme(MySqlConnection connection)
        {
            string query = "INSERT INTO theme (theme_nom, mod_id) VALUES (@nom, @mod_id)";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@nom", this.Theme_nom);
                command.Parameters.AddWithValue("@mod_id", this.Mod_id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Met à jour les informations d'un thème dans la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void MettreAJourTheme(MySqlConnection connection)
        {
            string query = "UPDATE theme SET theme_nom = @nom, mod_id = @mod_id WHERE theme_id = @id";
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", this.Theme_id);
                command.Parameters.AddWithValue("@nom", this.Theme_nom);
                command.Parameters.AddWithValue("@mod_id", this.Mod_id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Supprime un thème de la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void SupprimerTheme(MySqlConnection connection)
        {
            string query = "DELETE FROM theme WHERE theme_id = @id"; // Correction ici
            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@id", this.Theme_id);
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Récupère tous les thèmes associés à un module spécifique.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        /// <param name="moduleId">L'identifiant du module.</param>
        /// <returns>Une liste de thèmes associés au module spécifié.</returns>
        public static List<Theme> GetThemesByModuleId(MySqlConnection connection, int moduleId)
        {
            List<Theme> themes = new List<Theme>();
            string query = "SELECT theme_id, theme_nom FROM theme WHERE mod_id = @mod_id";

            using (MySqlCommand command = new MySqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@mod_id", moduleId);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        themes.Add(new Theme(
                            Convert.ToInt32(reader["theme_id"]),
                            reader["theme_nom"].ToString(),
                            moduleId
                        ));
                    }
                }
            }

            return themes; 
        }
        #endregion
    }
}
