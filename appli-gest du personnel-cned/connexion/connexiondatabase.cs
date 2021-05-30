using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
    
/// <summary>
/// connecter à la base de données et l'exécution des requêtes 
/// </summary>

namespace appli_gest_du_personnel_cned.connexion
{
    public class connexiondatabase
    {
        /// <summary>
        /// Unique instance de la classe
        /// </summary>
        private static connexiondatabase instance = null;
        /// <summary>
        /// creation d'un objet
        /// </summary>
        private MySqlConnection connection;
        /// <summary>
        /// objet SQL pour l'exucution 
        /// </summary>
        private MySqlCommand command;
        /// <summary>
        /// objet conntient  le résultat d'une requête "select" (curseur)
        /// </summary>
        private MySqlDataReader reader;

        /// <summary>
        /// Constructeur privé 
        /// </summary>
        /// <param name="stringConnect">chaine de connexion</param>
        private connexiondatabase (string stringConnect)
        {
            try
            {
                connection = new MySqlConnection(stringConnect);
                connection.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Application.Exit();
            }
        }

        //internal void ReqSelect(string req)
        //{
        //    throw new NotImplementedException();
        //}

        
        public static connexiondatabase GetInstance(string stringConnect)
        {
            if (instance is null)
            {
                instance = new connexiondatabase(stringConnect);
            }
            return instance;
        }
        internal void ReqSelect(string req)
        { 
            try
            {
                command = new MySqlCommand(req, connection);
                command.Prepare();
                reader = command.ExecuteReader();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Exécution d'une requête 
        /// </summary>
        /// <param name="stringQuery">requête </param>
        /// <param name="parameters">dictionnire contenant les parametres</param>
        public void ReqUpdate(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Exécute une requête 
        /// </summary>
        /// <param name="stringQuery">requête </param>
        public void ReqSelect(string stringQuery, Dictionary<string, object> parameters)
        {
            try
            {
                command = new MySqlCommand(stringQuery, connection);
                if (!(parameters is null))
                {
                    foreach (KeyValuePair<string, object> parameter in parameters)
                    {
                        command.Parameters.Add(new MySqlParameter(parameter.Key, parameter.Value));
                    }
                }
                command.Prepare();
                reader = command.ExecuteReader();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Tente de lire la ligne suivante du curseur
        /// </summary>
        /// <returns>false si fin de curseur atteinte</returns>
        public bool Read()
        {
            if (reader is null)
            {
                return false;
            }
            try
            {
                return reader.Read();
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Retourne le contenu d'un champ dont le nom est passé en paramètre
        /// </summary>
        /// <param name="nameField">nom du champ</param>
        /// <returns>valeur du champ</returns>
        public object Field(string nameField)
        {
            if (reader is null)
            {
                return null;
            }
            try
            {
                return reader[nameField];
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Fermeture du curseur
        /// </summary>
        public void Close()
        {
            if (!(reader is null))
            {
                reader.Close();
            }
        }

    }
} 
            
        
            


    

