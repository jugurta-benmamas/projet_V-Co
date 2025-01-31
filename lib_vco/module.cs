using System;
using System.Collections.Generic;
using System.Data;
using MySql.Data.MySqlClient;

namespace lib_vco
{
    /// <summary>
    /// Représente un module d'apprentissage.
    /// </summary>
    public class module
    {
        #region Propriétés
        private int mod_id;
        private string mod_titre;
        private string mod_image;
        #endregion

        #region Constructeur
        /// <summary>
        /// Initialise un nouveau module avec ses propriétés.
        /// </summary>
        /// <param name="mod_id">L'identifiant du module.</param>
        /// <param name="mod_titre">Le titre du module.</param>
        /// <param name="mod_image">Le chemin de l'image du module.</param>
        public module(int mod_id, string mod_titre, string mod_image)
        {
            this.mod_id = mod_id;
            this.mod_titre = mod_titre;
            this.mod_image = mod_image;
        }
        #endregion

        #region Property
        /// <summary>
        /// Obtient ou définit l'identifiant du module.
        /// </summary>
        public int ModId
        {
            get { return mod_id; }
            set { mod_id = value; }
        }

        /// <summary>
        /// Obtient ou définit le titre du module.
        /// </summary>
        public string ModTitre
        {
            get { return mod_titre; }
            set { mod_titre = value; }
        }

        /// <summary>
        /// Obtient ou définit le chemin de l'image du module.
        /// </summary>
        public string ModImage
        {
            get { return mod_image; }
            set { mod_image = value; }
        }
        #endregion

        #region Methodes
        /// <summary>
        /// Ajoute un nouveau module à la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL à la base de données.</param>
        public void AjouterModule(MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand("proc_ajouterModule", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("titre_mod", mod_titre);
            command.Parameters.AddWithValue("image_mod", mod_image);

            // Exécuter la commande
            command.ExecuteNonQuery();

            // Libérer la commande
            command.Dispose();
        }


        /// <summary>
        /// Met à jour les propriétés d'un module existant dans la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL à la base de données.</param>
        public void ModifierModule(MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand("proc_modifierModule", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("id_mod", mod_id);
            command.Parameters.AddWithValue("titre_mod", mod_titre);
            command.Parameters.AddWithValue("image_mod", mod_image);

            // Exécuter la commande
            command.ExecuteNonQuery();

            // Libérer la commande
            command.Dispose();
        }


        /// <summary>
        /// Supprime un module de la base de données.
        /// </summary>
        /// <param name="connection">La connexion MySQL à la base de données.</param>
        public void SupprimerModule(MySqlConnection connection)
        {
            MySqlCommand command = new MySqlCommand("proc_supprimerModule", connection);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("id_mod", mod_id);

            // Exécuter la commande
            command.ExecuteNonQuery();

            // Libérer la commande
            command.Dispose();
        }


        /// <summary>
        /// Récupère tous les modules de la base de données en utilisant la procédure stockée `proc_listerModules`.
        /// </summary>
        /// <param name="connection">La connexion MySQL à la base de données.</param>
        /// <returns>Une liste de modules.</returns>
        public static List<module> RecupModules(MySqlConnection connection)
        {
            List<module> modules = new List<module>(); // Liste pour stocker les modules récupérés

            // Créer la commande pour appeler la procédure stockée
            MySqlCommand command = new MySqlCommand("proc_listerModules", connection);
            command.CommandType = CommandType.StoredProcedure; // Indiquer que c'est une procédure stockée

            MySqlDataReader reader = command.ExecuteReader(); // Exécution de la procédure et récupération des résultats

            // Lecture des résultats et ajout des modules à la liste
            while (reader.Read())
            {
                modules.Add(new module(
                    Convert.ToInt32(reader["mod_id"]), // Conversion et ajout de l'identifiant du module
                    reader["mod_titre"].ToString(),    // Ajout du titre du module
                    reader["mod_image"].ToString()     // Ajout de l'image du module
                ));
            }

            reader.Close(); // Fermeture du lecteur de données
            command.Dispose(); // Libération des ressources

            return modules; // Retourne la liste des modules
        }

        #endregion
    }
}
