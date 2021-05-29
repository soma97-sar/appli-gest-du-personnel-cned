

namespace appli_gest_du_personnel_cned.modele
{
  public  class Classabsence
    {

        private int idpersonnel;
        private string datedebut;
        private string datefin;
        private int idmotif;


        public int Idpersonnel { get => idpersonnel; }
        public string Datedebut{ get => datedebut; }
        public string Datefin { get => datefin; }
        public int Idmotif { get => idmotif; }
        public int V3 { get; }
        public int V4 { get; }



        /// <summary>
        /// Constructeur pour valorise les propriétés
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>

        public Classabsence (int idpersonnel, string datedebut , string datefin , int idmotif)
        {
            this.idpersonnel = idpersonnel;
            this.datedebut = datedebut ;
            this.datefin = datefin ;
            this.idmotif = idmotif ;

        }

       
    }
}
