using appli_gest_du_personnel_cned.controleur;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using appli_gest_du_personnel_cned.modele;
using System.Drawing;
using System.Linq;
using appli_gest_du_personnel_cned.connexion;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appli_gest_du_personnel_cned.vue
{
    public partial class respogestion : Form
    {
        
        private Clcontrole classecontroleur;
        
        private Boolean modification = false;
        BindingSource bdgpersonnel = new BindingSource();
        BindingSource bdgabsence = new BindingSource();

        public respogestion()
        {
            InitializeComponent();
        }
        public respogestion(Clcontrole classecontroleur)
        {
            InitializeComponent();
            this.classecontroleur = classecontroleur;
            

        }
 
        private void respogestion_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        internal class ShowDialog
        {
            public ShowDialog()
            {
            }
        }

        private void afficherToolStripperso_Click(object sender, EventArgs e)
        {
            List<claspersonnel> lesPersonnels = classecontroleur.Getpersonnel();
            bdgpersonnel.DataSource = lesPersonnels;
            dataGridViewperso.DataSource = bdgpersonnel;
            dataGridViewperso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void supprimerToolStriperso_Click(object sender, EventArgs e)
        {
            if (dataGridViewperso.SelectedRows.Count > 0)
            {
                claspersonnel personnel  = (claspersonnel)bdgpersonnel.List[bdgpersonnel.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer " + personnel.Nom + " " + personnel.Prenom + " ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    classecontroleur.Delpersonnel(personnel);
                   // remlirListepersonnels();
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void modifierToolStriperso_Click(object sender, EventArgs e)
        {
            if (dataGridViewperso.SelectedRows.Count > 0)
            {
                modification = true;
                claspersonnel personnel  = (claspersonnel)bdgpersonnel.List[bdgpersonnel.Position];
                textBoxnom.Text = personnel.Nom;
                textBoxprenom.Text = personnel.Prenom;
                textBoxtel.Text = personnel.Tel;
                textBoxmail.Text = personnel.Mail;
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void ajouterToolStripperso_Click(object sender, EventArgs e)
        {
            if (!textBoxnom.Text.Equals("") && !textBoxprenom.Text.Equals("") && !textBoxtel.Text.Equals("") && !textBoxmail.Text.Equals("") )
            {

                int idpersonnel = 0, idservice = 0;
                if (modification)
                {
                    idpersonnel= (int)dataGridViewperso.SelectedRows[0].Cells["idpersonnel"].Value;
                    idservice = (int)dataGridViewperso.SelectedRows[0].Cells["idservice"].Value;
                }
                claspersonnel personnel  = new claspersonnel(idpersonnel, idservice, textBoxmail.Text, textBoxnom.Text, textBoxprenom.Text, textBoxtel.Text);
                if (modification)
                {
                    classecontroleur.Updatepersonnel(personnel);
                    modification= false;
                   
                }
                else
                {
                    classecontroleur.Addpersonnel(personnel);
                }
                
                
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void btnpersonnelannuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {         
                modification = false;
                textBoxnom.Text = "";
                textBoxprenom.Text = "";
                textBoxtel.Text = "";
                textBoxmail.Text = "";
                
            }
        }

        private void cobboxmotif_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Classabsence> absence = classecontroleur.Getabsence();
            bdgabsence.DataSource = absence;
            cobboxmotif.DataSource = bdgabsence;
            if (cobboxmotif.Items.Count > 0)
            {
                cobboxmotif.SelectedIndex = 0;
            }
        }

        private void afficherToolStripabsence_Click(object sender, EventArgs e)
        {
            List<Classabsence> absence  = classecontroleur.Getabsence();
            bdgabsence.DataSource = absence;
            dataGridVabsence.DataSource = bdgabsence;
            dataGridVabsence.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void supprimerToolStripabs_Click(object sender, EventArgs e)
        {
            if (dataGridVabsence.SelectedRows.Count > 0)
            {
                Classabsence absence  = (Classabsence)bdgabsence.List[bdgabsence.Position];
                if (MessageBox.Show("Voulez-vous vraiment supprimer ?", "Confirmation de suppression", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    classecontroleur.Delabsence(absence);
                    
                }
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void modifierToolStripabs_Click(object sender, EventArgs e)
        {
            Classabsence  motif = (Classabsence)bdgabsence.List[bdgabsence.Position];
            if (dataGridVabsence.SelectedRows.Count > 0)
            {
                modification = true;
                Classabsence absence = (Classabsence)bdgabsence.List[bdgabsence.Position];
                textBoxddebut.Text = absence.Datedebut;
                textBoxdfin.Text = absence.Datefin;
            }
            else
            {
                MessageBox.Show("Une ligne doit être sélectionnée.", "Information");
            }
        }

        private void ajouterToolStrabs_Click(object sender, EventArgs e)
        {

            if (!textBoxddebut.Text.Equals("") && !textBoxdfin.Text.Equals("")  && cobboxmotif.SelectedIndex != -1)
            {

                int idmotif = 0, idpersonnel=0;
                if (modification)
                {
                    idmotif = (int)dataGridVabsence.SelectedRows[0].Cells["idmotif"].Value;
                   
                }
                Classabsence absence = new Classabsence (idpersonnel, textBoxddebut.Text, textBoxdfin.Text,idmotif );
                if (modification)
                {
                    classecontroleur.Updateabsence(absence);
                    modification = false;

                }
                else
                {
                    classecontroleur.Addabsence(absence);
                }


            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }

        private void btnabsenceannuler_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voulez-vous vraiment annuler ?", "Confirmation", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                textBoxddebut.Text = "";
                textBoxdfin.Text = "";
                modification = false;
            }
        }

        private void btnabsenceenregistrer_Click(object sender, EventArgs e)
        {
            if (!textBoxddebut.Text.Equals("") && !textBoxdfin.Text.Equals("") &&  cobboxmotif.SelectedIndex != -1)
            {
                Classabsence motif = (Classabsence)bdgabsence.List[bdgabsence.Position];
                int idmotif = 0, idpersonnel = 0;
                if (modification)
                {
                    idmotif = (int)dataGridVabsence.SelectedRows[0].Cells["idmotif"].Value;
                }
                Classabsence  absence = new Classabsence (idpersonnel, textBoxddebut.Text, textBoxdfin.Text,idmotif);
                if (modification)
                {
                    classecontroleur.Updateabsence(absence);
                    modification = false;
                   
                }
                else
                {
                    classecontroleur.Addabsence(absence);
                }
             
            }
            else
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Information");
            }
        }
    }
}
