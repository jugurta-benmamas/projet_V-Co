using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Data;

namespace lib_vco
{
    /// <summary>
    /// Représente un cours dans l'application.
    /// </summary>
    public class cours
    {
        #region Propriétés
        private int cours_id;
        private string cours_titre;
        private string cours_imageCouverture; // URL de l'image de couverture
        private string cours_contenu;
        private int theme_id; // Clé étrangère vers le thème
        #endregion

        #region Constructeur
        /// <summary>
        /// Initialise un nouveau cours avec ses propriétés.
        /// </summary>
        /// <param name="cours_id">L'identifiant du cours.</param>
        /// <param name="cours_titre">Le titre du cours.</param>
        /// <param name="cours_imageCouverture">L'URL de l'image de couverture du cours.</param>
        /// <param name="cours_contenu">Le contenu du cours.</param>
        /// <param name="theme_id">L'identifiant du thème associé au cours.</param>
        public cours(int cours_id, string cours_titre, string cours_imageCouverture, string cours_contenu, int theme_id)
        {
            this.cours_id = cours_id;
            this.cours_titre = cours_titre;
            this.cours_imageCouverture = cours_imageCouverture;
            this.cours_contenu = cours_contenu;
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
        /// Obtient ou modifie l'URL de l'image de couverture du cours.
        /// </summary>
        public string Cours_imageCouverture
        {
            get { return cours_imageCouverture; }
            set { cours_imageCouverture = value; }
        }

        /// <summary>
        /// Obtient ou modifie le contenu du cours.
        /// </summary>
        public string Cours_contenu
        {
            get { return cours_contenu; }
            set { cours_contenu = value; }
        }

        /// <summary>
        /// Obtient ou modifier l'id du theme
        /// </summary>
        public int Theme_id
        {
            get { return theme_id; }
            set { theme_id = value; }
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Ajoute un nouveau cours à la base de données en utilisant la procédure stockée `proc_ajouterCours`.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void AjouterCours(MySqlConnection connection)
        {
            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_ajouterCours", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Ajouter les paramètres requis pour la procédure
            command.Parameters.AddWithValue("@titre", this.Cours_titre);
            command.Parameters.AddWithValue("@imageCouverture", this.Cours_imageCouverture);
            command.Parameters.AddWithValue("@contenu", this.Cours_contenu);
            command.Parameters.AddWithValue("@themeID", this.theme_id);

            // Exécuter la commande
            command.ExecuteNonQuery();

            // Libérer la commande
            command.Dispose();
        }


        /// <summary>
        /// Met à jour les informations d'un cours dans la base de données en utilisant la procédure stockée `proc_modifierCours`.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void ModifierCours(MySqlConnection connection)
        {
            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_modifierCours", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Ajouter les paramètres requis pour la procédure
            command.Parameters.AddWithValue("@id_cours", this.Cours_id);
            command.Parameters.AddWithValue("@titre_cours", this.Cours_titre);
            command.Parameters.AddWithValue("@imageCouverture_cours", this.Cours_imageCouverture);
            command.Parameters.AddWithValue("@contenu_cours", this.Cours_contenu);

            // Exécuter la commande
            command.ExecuteNonQuery();

            // Libérer la commande
            command.Dispose();
        }


        /// <summary>
        /// Supprime un cours de la base de données en utilisant la procédure stockée `proc_supprimerCours.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        public void SupprimerCours(MySqlConnection connection)
        {
            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_supprimerCours", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Ajouter le paramètre requis pour la procédure
            command.Parameters.AddWithValue("@id_cours", this.Cours_id);

            // Exécuter la commande
            command.ExecuteNonQuery();

            // Libérer la commande
            command.Dispose();
        }


        /// <summary>
        /// Récupère les cours associés à un thème donné à partir de la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        /// <param name="themeId">L'identifiant du thème dont on souhaite récupérer les cours.</param>
        /// <returns>Une liste de cours associés au thème spécifié.</returns>
        public static List<cours> RecupCoursTheme(MySqlConnection connection, int themeId)
        {
            List<cours> coursList = new List<cours>();

            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_listeCoursTheme", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@id_theme", themeId); // Ajoute l'identifiant du thème

            MySqlDataReader reader = command.ExecuteReader(); // Exécution de la procédure et récupération des résultats

            // Lecture des résultats et ajout des cours à la liste
            while (reader.Read())
            {
                coursList.Add(new cours(
                    Convert.ToInt32(reader["cours_id"]), // Identifiant du cours
                    reader["cours_titre"].ToString(),    // Titre du cours
                    reader["cours_imageCouverture"].ToString(), // Image de couverture du cours
                    reader["cours_contenu"].ToString(),  // Contenu du cours
                    themeId // Identifiant du thème auquel le cours est associé
                ));
            }

            reader.Close(); // Fermer le DataReader
            command.Dispose(); // Libérer les ressources de la commande

            return coursList; // Retourne la liste des cours
        }

        /// <summary>
        /// Récupère tous les cours à partir de la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL utilisée pour accéder à la base de données.</param>
        /// <returns>Une liste de tous les cours disponibles dans la base de données.</returns>
        public static List<cours> RecupCours(MySqlConnection connection)
        {
            List<cours> coursList = new List<cours>();

            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_listeCours", connection);
            command.CommandType = CommandType.StoredProcedure;

            // Exécution de la procédure et récupération des résultats
            MySqlDataReader reader = command.ExecuteReader();

            // Lecture des résultats et ajout des cours à la liste
            while (reader.Read())
            {
                coursList.Add(new cours(
                    Convert.ToInt32(reader["cours_id"]), // Identifiant du cours
                    reader["cours_titre"].ToString(),    // Titre du cours
                    reader["cours_imageCouverture"].ToString(), // Image de couverture du cours
                    reader["cours_contenu"].ToString(),  // Contenu du cours
                    Convert.ToInt32(reader["theme_id"]) // Identifiant du thème auquel le cours est associé
                ));
            }

            reader.Close(); // Fermer le DataReader
            command.Dispose(); // Libérer les ressources de la commande

            return coursList; // Retourne la liste des cours
        }




        #endregion
    }
}
