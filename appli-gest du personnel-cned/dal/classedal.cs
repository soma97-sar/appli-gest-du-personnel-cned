

using System;
using MySql.Data.MySqlClient;
using appli_gest_du_personnel_cned.connexion;
using appli_gest_du_personnel_cned.modele;
using System.Collections.Generic;
using System.Windows.Forms;


namespace appli_gest_du_personnel_cned.dal
{
    public  class classedal
    {
        /// <summary>
        /// chaine de connexion à la bdd
        /// </summary>
        private static string connectionString = "server=localhost;user id=root;database=gestioperso;port=3306;";

        /// <summary>
        /// Récupère et retourne les personnels provenant de la BDD
        /// </summary>
        /// <returns>liste des personnels</returns>
        public static List<claspersonnel> Getpersonnel()
        {
            List<claspersonnel> LesPersonnels = new List<claspersonnel>();
            string req = "select p.idpersonnel as idpersonnel, p.nom as nom, p.prenom as prenom, p.tel as tel, p.mail as mail, s.idservice as idservice ";
            // req += "from personnel p join service s on (p.idservice = s.idservice) ";
            req += "order by idpersonnel;";
            connexiondatabase curseur = connexiondatabase.GetInstance(connectionString);
            curseur.ReqSelect(req);
            while (curseur.Read())
            {
                claspersonnel personnel = new claspersonnel((int)curseur.Field("idpersonnel"), (string)curseur.Field("nom"), (string)curseur.Field("prenom"), (string)curseur.Field("tel"), (string)curseur.Field("mail"), (int)curseur.Field("idservice"));
                LesPersonnels.Add(personnel);
            }
            curseur.Close();
            return LesPersonnels;
        }

        internal static List<ClassResponsable> GetResponsable()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Récupèrer et retourner la liste des absences de la bdd
        /// </summary>
        /// <returns>liste des absences</returns>
        public static List<Classabsence> Getabsence()
        {
            List<Classabsence> LesAbsences = new List<Classabsence>();
            string req = "select * from absence order by datedebut ;";
            connexiondatabase curseur = connexiondatabase.GetInstance(connectionString);
            curseur.ReqSelect(req);
            while (curseur.Read())
            {//c'est quoi le probleme????
                Classabsence absence = new Classabsence((int)curseur.Field("datedebut"), (string)curseur.Field("datefin"), (string)curseur.Field("idpersonnel"), (int)curseur.Field("idmotif"));
                LesAbsences.Add(absence);
            }
            curseur.Close();
            return LesAbsences;
        }

        /// <summary>
        /// Suppression d'un personnel
        /// </summary>
        /// <param name="personnel">supprimer personnel</param>
        public static void Delpersonnel(claspersonnel personnel)
        {
            string req = "delete from personnel where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            connexiondatabase connec = connexiondatabase.GetInstance(connectionString);
            connec.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Ajoute un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void Addpersonnel(claspersonnel personnel)
        {
            string req = "insert into personnel (nom, prenom, tel, mail) ";
            req += "values (@nom, @prenom, @tel, @mail);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);

            connexiondatabase connec = connexiondatabase.GetInstance(connectionString);
            connec.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// Modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public static void Updatepersonnel(claspersonnel personnel)
        {
            string req = "update personnel set nom = @nom, prenom = @prenom, tel = @tel, mail = @mail ";
            req += "where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", personnel.Idpersonnel);
            parameters.Add("@nom", personnel.Nom);
            parameters.Add("@prenom", personnel.Prenom);
            parameters.Add("@tel", personnel.Tel);
            parameters.Add("@mail", personnel.Mail);
            connexiondatabase connec = connexiondatabase.GetInstance(connectionString);
            connec.ReqUpdate(req, parameters);
        }
        /// <summary>
        /// ajouter une absence 
        /// </summary>
        /// <param name="absence"></param>
        public static void Addabsence(Classabsence absence)
        {
            string req = "insert into absence (datedebut, datefin, idmotif, idpersonnel) ";
            req += "values (@datedebut, @datefin, @idmotif, @idpersonnel);";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@datefin", absence.Datefin);
            parameters.Add("@idmotif", absence.Idmotif);
            parameters.Add("@idpersonnel", absence.Idpersonnel);

            connexiondatabase connec = connexiondatabase.GetInstance(connectionString);
            connec.ReqUpdate(req, parameters);
        }

        /// <summary>
        /// supprimer une absence 
        /// </summary>
        /// <param name="absence"></param>
        public static void Delabsence(Classabsence absence)
        {
            string req = "delete from absence where idpersonnel = @idpersonnel and idmotif = @idmotif;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@idpersonnel", absence.Idpersonnel);
            parameters.Add("@idmotif", absence.Idmotif);
            connexiondatabase connec = connexiondatabase.GetInstance(connectionString);
            connec.ReqUpdate(req, parameters);

        }
        /// <summary>
        /// Modification d'une absence
        /// </summary>
        /// <param name="absence"></param>
        public static void Updateabsence(Classabsence absence)
        {
            string req = "update absence set datedebut = @datedebut, datefin = @datefin, idpersonnel = @idpersonnel, idmotif = @idmotif ";
            req += "where idpersonnel = @idpersonnel;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@datedebut", absence.Datedebut);
            parameters.Add("@datefin", absence.Datefin);
            parameters.Add("@idpersonnel", absence.Idpersonnel);
            parameters.Add("@idmotif", absence.Idmotif);
            connexiondatabase connec = connexiondatabase.GetInstance(connectionString);
            connec.ReqUpdate(req, parameters);
        }
        public static Boolean Controlelogin(string login, string pwd)
        {
            string cod = GetStringSha256Hash(pwd);
            string req = "select login ,pwd from responsable where login=@login and pwd=@pwd ;";
            Dictionary<string, object> parameters = new Dictionary<string, object>();
            parameters.Add("@login", login);
            parameters.Add("@pwd", cod);
            connexiondatabase curs = connexiondatabase.GetInstance(connectionString);
            curs.ReqSelect(req, parameters);
            if (curs.Read())
            {
                curs.Close();
                return true;
            }
            else
            {
                curs.Close();
                return false;
            }
        }
        internal static string GetStringSha256Hash(string text)
        {
            if (string.IsNullOrEmpty(text))
                return string.Empty;

            using (var sha = new System.Security.Cryptography.SHA256Managed())
            {
                byte[] textData = System.Text.Encoding.UTF8.GetBytes(text);
                byte[] hash = sha.ComputeHash(textData);
                return BitConverter.ToString(hash).Replace("-", string.Empty);
            }
        }
    }
}    
   



    
       