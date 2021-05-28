

namespace appli_gest_du_personnel_cned.modele
{
   public class ClassResponsable
    {

        
        private string login ;
        private string pwd ;
        

        public string Login { get => login ; }
        public string Pwd { get => pwd ; }
 
        /// <summary>
        /// Constructeur pour valorise les propriétés
        /// </summary>
        /// <param name="login"></param>
        /// <param name="pwd"></param>
       

        public ClassResponsable (string login , string pwd)
        {
           
            this.login = login ;
            this.pwd = pwd ;
        

        }

    }
}
    

