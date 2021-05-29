
using System.Collections.Generic;
using appli_gest_du_personnel_cned.dal;
using appli_gest_du_personnel_cned.vue;
using appli_gest_du_personnel_cned.modele;
using System.Windows.Forms;
using System;


namespace appli_gest_du_personnel_cned.controleur
{
   public class classecontroleur
    {
        /// <summary>
        /// Ouverture de la fenêtre
        /// </summary>
        public classecontroleur()
        {
            new respogestion().ShowDialog();
        }
       

        /// <summary>
        /// Récupère et retourne les infos des personnels
        /// </summary>
        /// <returns>liste personnel</returns>
        public List<claspersonnel> Getpersonnel()
        {
            return classedal.Getpersonnel();
        }
        public List<Classabsence> Getabsence()
        {
            return classedal.Getabsence();
        }

        /// <summary>
        /// Récupère et retourne les infos de bdd
        /// </summary>
        /// <returns>liste des profils</returns>
        //public List<claspersonnel> GetPersonnel()
        //{
        //    return classedal.GetPersonnel();
        //}

        /// <summary>
        /// Demande de suppression d'un personnel ou d'une absence
        /// </summary>
        /// <param name="personnel">supprimer</param>
        public void Delpersonnel(claspersonnel personnel)
        {
            classedal.Delpersonnel(personnel);
        }
        public void Delabsence(Classabsence absence )
        {
            classedal.Delabsence(absence);
        }

        /// <summary>
        /// Demande d'ajout d'un personnel ou d'une absence
        /// </summary>
        /// <param name="personnel"></param>
        public void Addpersonnel(claspersonnel personnel)
        {
            classedal.Addpersonnel(personnel);
        }
        public void Addabsence (Classabsence absence )
        {
            classedal.Addabsence (absence);
        }

        /// <summary>
        /// Demande de modification d'un personnel ou d'une absence
        /// </summary>
        /// <param name="personnel"></param>
        public void Updatepersonnel(claspersonnel personnel)
        {
            classedal.Updatepersonnel(personnel);
        }
        public void Updateabsence (Classabsence absence)
            
        {
            classedal.Updateabsence(absence);
        }
        /// <summary>
        /// la connexion du responsable 
        /// Si correct la fenêtre principale s'ouvre
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
        /// <returns></returns>


        public Boolean Controlelogin(string login, string pwd) 
           
        {
            if (classedal.Controlelogin(login, pwd))
            {
                //appGestPers app1 = new appGestPers();
                appGestPers.Hide();
                new respogestion(this).showdialog();
                //respogestion resp1 = new respogestion();
                //resp1.Show();
                //new respogestion(this).ShowDialog();
                return true;           
            }
            else
            {
                return false;
            }



        }
    }
}
