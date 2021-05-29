
namespace appli_gest_du_personnel_cned
{
    partial class appGestPers
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.gestperso = new System.Windows.Forms.Label();
            this.lbllogin = new System.Windows.Forms.Label();
            this.labelpwd = new System.Windows.Forms.Label();
            this.labconnect = new System.Windows.Forms.Label();
            this.txtboxlogin = new System.Windows.Forms.TextBox();
            this.txtboxpwd = new System.Windows.Forms.TextBox();
            this.btnconnecter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gestperso
            // 
            this.gestperso.AutoSize = true;
            this.gestperso.BackColor = System.Drawing.Color.Transparent;
            this.gestperso.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestperso.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gestperso.Location = new System.Drawing.Point(71, 4);
            this.gestperso.Name = "gestperso";
            this.gestperso.Size = new System.Drawing.Size(598, 36);
            this.gestperso.TabIndex = 0;
            this.gestperso.Text = "APPLICATION GESTION DU PERSONNEL";
            // 
            // lbllogin
            // 
            this.lbllogin.AutoSize = true;
            this.lbllogin.BackColor = System.Drawing.Color.Transparent;
            this.lbllogin.Location = new System.Drawing.Point(499, 317);
            this.lbllogin.Name = "lbllogin";
            this.lbllogin.Size = new System.Drawing.Size(38, 17);
            this.lbllogin.TabIndex = 1;
            this.lbllogin.Text = "login";
            // 
            // labelpwd
            // 
            this.labelpwd.AutoSize = true;
            this.labelpwd.BackColor = System.Drawing.Color.Transparent;
            this.labelpwd.Location = new System.Drawing.Point(499, 373);
            this.labelpwd.Name = "labelpwd";
            this.labelpwd.Size = new System.Drawing.Size(33, 17);
            this.labelpwd.TabIndex = 2;
            this.labelpwd.Text = "pwd";
            // 
            // labconnect
            // 
            this.labconnect.AutoSize = true;
            this.labconnect.BackColor = System.Drawing.Color.Transparent;
            this.labconnect.Location = new System.Drawing.Point(447, 442);
            this.labconnect.Name = "labconnect";
            this.labconnect.Size = new System.Drawing.Size(90, 17);
            this.labconnect.TabIndex = 3;
            this.labconnect.Text = "se connecter";
            // 
            // txtboxlogin
            // 
            this.txtboxlogin.Location = new System.Drawing.Point(575, 314);
            this.txtboxlogin.Name = "txtboxlogin";
            this.txtboxlogin.Size = new System.Drawing.Size(248, 22);
            this.txtboxlogin.TabIndex = 8;
            // 
            // txtboxpwd
            // 
            this.txtboxpwd.Location = new System.Drawing.Point(575, 370);
            this.txtboxpwd.Name = "txtboxpwd";
            this.txtboxpwd.Size = new System.Drawing.Size(248, 22);
            this.txtboxpwd.TabIndex = 9;
            // 
            // btnconnecter
            // 
            this.btnconnecter.Image = global::appli_gest_du_personnel_cned.Properties.Resources.login;
            this.btnconnecter.Location = new System.Drawing.Point(575, 408);
            this.btnconnecter.Name = "btnconnecter";
            this.btnconnecter.Size = new System.Drawing.Size(248, 73);
            this.btnconnecter.TabIndex = 10;
            this.btnconnecter.UseVisualStyleBackColor = true;
            this.btnconnecter.Click += new System.EventHandler(this.btnconnecter_Click);
            // 
            // appGestPers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.BackgroundImage = global::appli_gest_du_personnel_cned.Properties.Resources.gestion_du_personnel;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(848, 493);
            this.Controls.Add(this.btnconnecter);
            this.Controls.Add(this.txtboxpwd);
            this.Controls.Add(this.txtboxlogin);
            this.Controls.Add(this.labconnect);
            this.Controls.Add(this.labelpwd);
            this.Controls.Add(this.lbllogin);
            this.Controls.Add(this.gestperso);
            this.Name = "appGestPers";
            this.Text = "application gestion du personnel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gestperso;
        private System.Windows.Forms.Label lbllogin;
        private System.Windows.Forms.Label labelpwd;
        private System.Windows.Forms.Label labconnect;
        private System.Windows.Forms.TextBox txtboxlogin;
        private System.Windows.Forms.TextBox txtboxpwd;
        private System.Windows.Forms.Button btnconnecter;
    }
}

