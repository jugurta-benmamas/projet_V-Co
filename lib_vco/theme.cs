using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Data;

namespace lib_vco
{
    /// <summary>
    /// Représente un thème d'apprentissage associé à un module.
    /// </summary>
    public class theme
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
        public theme(int theme_id, string theme_nom, int mod_id)
        {
            this.theme_id = theme_id;
            this.theme_nom = theme_nom;
            this.mod_id = mod_id;
        }
        #endregion

        #region Property

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
        /// Ajoute un nouveau thème à la base de données en utilisant la procédure stockée `proc_ajouterTheme`.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void AjouterTheme(MySqlConnection connection)
        {
            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_ajouterTheme", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Ajouter les paramètres de la procédure
            command.Parameters.AddWithValue("@nom_theme", this.Theme_nom);
            command.Parameters.AddWithValue("@moduleID", this.Mod_id);

            // Exécuter la procédure stockée
            command.ExecuteNonQuery();

            // Libérer les ressources manuellement
            command.Dispose();
        }


        /// <summary>
        /// Met à jour le nom d'un thème dans la base de données en utilisant la procédure stockée `proc_modifierTheme`.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void ModifierTheme(MySqlConnection connection)
        {
            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_modifierTheme", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Ajouter les paramètres requis pour la procédure
            command.Parameters.AddWithValue("@id_theme", this.Theme_id);
            command.Parameters.AddWithValue("@nom_theme", this.Theme_nom);

            // Exécuter la commande
            command.ExecuteNonQuery();

            // Libérer la commande
            command.Dispose();
        }


        /// <summary>
        /// Supprime un thème de la base de données en utilisant la procédure stockée `proc_supprimerTheme`.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        /// <param name="idTheme">L'identifiant du thème à supprimer.</param>
        public void SupprimerTheme(MySqlConnection connection, int idTheme)
        {
            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_supprimerTheme", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Ajouter le paramètre requis pour la procédure
            command.Parameters.AddWithValue("@id_theme", idTheme); // Correction du nom du paramètre

            // Exécuter la procédure stockée
            command.ExecuteNonQuery(); // Exécute la commande sans retourner de données

            // Libérer les ressources manuellement
            command.Dispose(); // Libération des ressources de la commande
        }


        /// <summary>
        /// Récupère tous les thèmes en utilisant la procédure stockée `proc_listeTheme`.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        /// <returns>Une liste de tous les thèmes.</returns>
        public static List<theme> RecupTheme(MySqlConnection connection)
        {
            List<theme> themes = new List<theme>(); // Liste pour stocker les thèmes récupérés

            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_listeTheme", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Exécuter la commande et récupérer les résultats
            MySqlDataReader reader = command.ExecuteReader(); // Exécution de la procédure et récupération des résultats

            while (reader.Read())
            {
                themes.Add(new theme(
                    Convert.ToInt32(reader["theme_id"]), // Identifiant du thème
                    reader["theme_nom"].ToString(),       // Nom du thème
                    Convert.ToInt32(reader["mod_id"])     // Identifiant du module auquel le thème est associé
                ));
            }

            reader.Close(); // Fermeture manuelle du lecteur
            command.Dispose(); // Libération des ressources de la commande

            return themes; // Retourne la liste des thèmes
        }


        /// <summary>
        /// Récupère tous les thèmes associés à un module spécifique en utilisant la procédure stockée `proc_listeThemesModule`.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        /// <param name="moduleId">L'identifiant du module.</param>
        /// <returns>Une liste de thèmes associés au module spécifié.</returns>
        public static List<theme> RecupThemeModule(MySqlConnection connection, int moduleId)
        {
            List<theme> themes = new List<theme>(); // Liste pour stocker les thèmes récupérés

            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_listeThemesModule", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Ajouter le paramètre requis pour la procédure
            command.Parameters.AddWithValue("@id_mod", moduleId); // Correction du nom du paramètre pour correspondre à la procédure

            // Exécuter la commande et récupérer les résultats
            using (MySqlDataReader reader = command.ExecuteReader()) // Utilisation de "using" pour gérer la fermeture
            {
                while (reader.Read())
                {
                    themes.Add(new theme(
                        Convert.ToInt32(reader["theme_id"]), // Identifiant du thème
                        reader["theme_nom"].ToString(),       // Nom du thème
                        moduleId                               // Identifiant du module auquel le thème est associé
                    ));
                }
            } // Le lecteur sera automatiquement fermé ici

            command.Dispose(); // Libération des ressources de la commande

            return themes; // Retourne la liste des thèmes
        }



        #endregion
    }
}
