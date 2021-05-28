
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
            (new respogestion()).ShowDialog();
        }

        /// <summary>
        /// Récupère et retourne les infos des personnels
        /// </summary>
        /// <returns>liste personnel</returns>
        public List<claspersonnel> Getclaspersonnel()
        {
            return classedal.Getclaspersonnel();
        }

        /// <summary>
        /// Récupère et retourne les infos de bdd
        /// </summary>
        /// <returns>liste des profils</returns>
        public List<claspersonnel> GetPersonnels()
        {
            return classedal.GetLesPersonnels();
        }

        /// <summary>
        /// Demande de suppression d'un personnel
        /// </summary>
        /// <param name="personnel">supprimer</param>
        public void Delclaspersonnel(claspersonnel personnel)
        {
            classedal.Delclaspersonnel(personnel);
        }

        /// <summary>
        /// Demande d'ajout d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void Addclaspersonnel(claspersonnel personnel)
        {
            classedal.Addclaspersonnel(personnel);
        }

        /// <summary>
        /// Demande de modification d'un personnel
        /// </summary>
        /// <param name="personnel"></param>
        public void Updateclaspersonnel(claspersonnel personnel)
        {
            classedal.Updateclaspersonnel(personnel);
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
