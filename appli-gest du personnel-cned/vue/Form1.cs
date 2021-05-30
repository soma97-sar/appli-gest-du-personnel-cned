using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using appli_gest_du_personnel_cned.vue;
using System.Linq;
using System.Text;
using appli_gest_du_personnel_cned.controleur;
using System.Windows.Forms;

namespace appli_gest_du_personnel_cned
{
    public partial class appGestPers : Form
    {
        private Clcontrole control;
        public appGestPers()
        {
            InitializeComponent();
        }
        public appGestPers(Clcontrole control)
        {
            InitializeComponent();
            this.control = control;
        }

        private void btnconnecter_Click(object sender, EventArgs e)
        {
           
            if(!Clcontrole.Controlelogin(txtboxlogin.Text, txtboxpwd.Text))
               {
                MessageBox.Show("erreur!!!");
                txtboxlogin.Text = "";
                txtboxpwd.Text = "";

            }
            else
            {
                respogestion resp1 = new respogestion();
                resp1.Show();
                this.Hide();
                
            }
        }
    }
}
