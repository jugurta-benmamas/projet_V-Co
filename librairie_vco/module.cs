using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;

namespace librairie_vco
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

        #region Properties
        public int ModId
        {
            get { return mod_id; }
            set { mod_id = value; }
        }

        public string ModTitre
        {
            get { return mod_titre; }
            set { mod_titre = value; }
        }

        public string ModImage
        {
            get { return mod_image; }
            set { mod_image = value; }
        }
        #endregion

        public void AjouterModule(MySqlConnection connection)
        {
            string query = "INSERT INTO module (mod_titre, mod_image) VALUES (@titre, @image)";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@titre", this.mod_titre);
            command.Parameters.AddWithValue("@image", this.mod_image);
            command.ExecuteNonQuery();
            command.Dispose(); // Assurez-vous de libérer la commande
        }

        public void MettreAJourModule(MySqlConnection connection)
        {
            string query = "UPDATE module SET mod_titre = @titre, mod_image = @image WHERE mod_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", this.mod_id);
            command.Parameters.AddWithValue("@titre", this.mod_titre);
            command.Parameters.AddWithValue("@image", this.mod_image);
            command.ExecuteNonQuery();
            command.Dispose(); // Assurez-vous de libérer la commande
        }

        public void SupprimerModule(MySqlConnection connection)
        {
            string query = "DELETE FROM module WHERE mod_id = @id";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@id", this.mod_id);
            command.ExecuteNonQuery();
            command.Dispose(); // Assurez-vous de libérer la commande
        }

        public static List<module> RecupModules(MySqlConnection connection)
        {
            List<module> modules = new List<module>();
            string query = "SELECT mod_id, mod_titre, mod_image FROM module";
            MySqlCommand command = new MySqlCommand(query, connection);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                modules.Add(new module(
                    Convert.ToInt32(reader["mod_id"]),
                    reader["mod_titre"].ToString(),
                    reader["mod_image"].ToString()
                ));
            }
            reader.Close(); // Assurez-vous de fermer le lecteur
            command.Dispose(); // Assurez-vous de libérer la commande

            return modules;
        }
    }
}
