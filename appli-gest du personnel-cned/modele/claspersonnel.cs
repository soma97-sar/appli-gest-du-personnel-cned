

namespace appli_gest_du_personnel_cned.modele
{
   public class claspersonnel
    {
        private int idpersonnel;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
       
        private int idservice;
       

        public int Idpersonnel { get => idpersonnel; }
        public string Nom { get => nom; }
        public string Prenom { get => prenom; }
        public string Tel { get => tel; }
        public string Mail { get => mail; }
        
        public int Idservice  { get => idservice; }
        
       

        /// <summary>
        /// Constructeur pour valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
       
        public claspersonnel(int idpersonnel, int idservice, string mail, string nom, string prenom, string tel)  
        {
            this.idpersonnel = idpersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idservice = idservice;
           
        }

    }
}
    

