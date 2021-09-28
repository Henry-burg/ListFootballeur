
namespace WinFormsJoueurFoot
{
    partial class frmPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.lblPrenom = new System.Windows.Forms.Label();
            this.lblNom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.lblNBTelephone = new System.Windows.Forms.Label();
            this.txtNbTelephone = new System.Windows.Forms.TextBox();
            this.cmdAjouterModifier = new System.Windows.Forms.Button();
            this.cmdAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(12, 76);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(293, 44);
            this.txtPrenom.TabIndex = 0;
            // 
            // lblPrenom
            // 
            this.lblPrenom.AutoSize = true;
            this.lblPrenom.Location = new System.Drawing.Point(13, 58);
            this.lblPrenom.Name = "lblPrenom";
            this.lblPrenom.Size = new System.Drawing.Size(49, 15);
            this.lblPrenom.TabIndex = 1;
            this.lblPrenom.Text = "Prénom";
            // 
            // lblNom
            // 
            this.lblNom.AutoSize = true;
            this.lblNom.Location = new System.Drawing.Point(12, 124);
            this.lblNom.Name = "lblNom";
            this.lblNom.Size = new System.Drawing.Size(34, 15);
            this.lblNom.TabIndex = 2;
            this.lblNom.Text = "Nom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(12, 142);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(292, 47);
            this.txtNom.TabIndex = 3;
            // 
            // lblNBTelephone
            // 
            this.lblNBTelephone.AutoSize = true;
            this.lblNBTelephone.Location = new System.Drawing.Point(13, 192);
            this.lblNBTelephone.Name = "lblNBTelephone";
            this.lblNBTelephone.Size = new System.Drawing.Size(93, 15);
            this.lblNBTelephone.TabIndex = 4;
            this.lblNBTelephone.Text = "N° de téléphone";
            // 
            // txtNbTelephone
            // 
            this.txtNbTelephone.Location = new System.Drawing.Point(13, 210);
            this.txtNbTelephone.Multiline = true;
            this.txtNbTelephone.Name = "txtNbTelephone";
            this.txtNbTelephone.Size = new System.Drawing.Size(293, 49);
            this.txtNbTelephone.TabIndex = 5;
            // 
            // cmdAjouterModifier
            // 
            this.cmdAjouterModifier.Location = new System.Drawing.Point(12, 284);
            this.cmdAjouterModifier.Name = "cmdAjouterModifier";
            this.cmdAjouterModifier.Size = new System.Drawing.Size(122, 23);
            this.cmdAjouterModifier.TabIndex = 6;
            this.cmdAjouterModifier.Text = "Ajouter / Modifier";
            this.cmdAjouterModifier.UseVisualStyleBackColor = true;
            // 
            // cmdAnnuler
            // 
            this.cmdAnnuler.Location = new System.Drawing.Point(152, 284);
            this.cmdAnnuler.Name = "cmdAnnuler";
            this.cmdAnnuler.Size = new System.Drawing.Size(75, 23);
            this.cmdAnnuler.TabIndex = 7;
            this.cmdAnnuler.Text = "Annuler";
            this.cmdAnnuler.UseVisualStyleBackColor = true;
            // 
            // frmPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 450);
            this.Controls.Add(this.cmdAnnuler);
            this.Controls.Add(this.cmdAjouterModifier);
            this.Controls.Add(this.txtNbTelephone);
            this.Controls.Add(this.lblNBTelephone);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.lblNom);
            this.Controls.Add(this.lblPrenom);
            this.Controls.Add(this.txtPrenom);
            this.Name = "frmPlayer";
            this.Text = "Création / nodification d\'un joueur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label lblPrenom;
        private System.Windows.Forms.Label lblNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label lblNBTelephone;
        private System.Windows.Forms.TextBox txtNbTelephone;
        private System.Windows.Forms.Button cmdAjouterModifier;
        private System.Windows.Forms.Button cmdAnnuler;
    }
}