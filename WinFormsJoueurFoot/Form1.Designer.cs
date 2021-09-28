
namespace WinFormsJoueurFoot
{
    partial class frmListPlayer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdAjouter = new System.Windows.Forms.Button();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.cmdModifier = new System.Windows.Forms.Button();
            this.cmdSupprimer = new System.Windows.Forms.Button();
            this.cmdQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmdAjouter
            // 
            this.cmdAjouter.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.cmdAjouter.Location = new System.Drawing.Point(226, 12);
            this.cmdAjouter.Name = "cmdAjouter";
            this.cmdAjouter.Size = new System.Drawing.Size(92, 45);
            this.cmdAjouter.TabIndex = 0;
            this.cmdAjouter.Text = "Ajouter";
            this.cmdAjouter.UseVisualStyleBackColor = true;
            this.cmdAjouter.Click += new System.EventHandler(this.cmdAjouter_Click);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 15;
            this.lstListe.Location = new System.Drawing.Point(12, 12);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(197, 424);
            this.lstListe.TabIndex = 3;
            // 
            // cmdModifier
            // 
            this.cmdModifier.Location = new System.Drawing.Point(226, 75);
            this.cmdModifier.Name = "cmdModifier";
            this.cmdModifier.Size = new System.Drawing.Size(92, 45);
            this.cmdModifier.TabIndex = 5;
            this.cmdModifier.Text = "Modifier";
            this.cmdModifier.UseVisualStyleBackColor = true;
            // 
            // cmdSupprimer
            // 
            this.cmdSupprimer.Location = new System.Drawing.Point(226, 138);
            this.cmdSupprimer.Name = "cmdSupprimer";
            this.cmdSupprimer.Size = new System.Drawing.Size(92, 45);
            this.cmdSupprimer.TabIndex = 6;
            this.cmdSupprimer.Text = "Supprimer";
            this.cmdSupprimer.UseVisualStyleBackColor = true;
            // 
            // cmdQuitter
            // 
            this.cmdQuitter.Location = new System.Drawing.Point(226, 202);
            this.cmdQuitter.Name = "cmdQuitter";
            this.cmdQuitter.Size = new System.Drawing.Size(92, 45);
            this.cmdQuitter.TabIndex = 7;
            this.cmdQuitter.Text = "Quitter";
            this.cmdQuitter.UseVisualStyleBackColor = true;
            // 
            // frmListPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 450);
            this.Controls.Add(this.cmdQuitter);
            this.Controls.Add(this.cmdSupprimer);
            this.Controls.Add(this.cmdModifier);
            this.Controls.Add(this.lstListe);
            this.Controls.Add(this.cmdAjouter);
            this.Name = "frmListPlayer";
            this.Text = "Liste";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdAjouter;
        private System.Windows.Forms.ListBox lstListe;
        private System.Windows.Forms.Button cmdModifier;
        private System.Windows.Forms.Button cmdSupprimer;
        private System.Windows.Forms.Button cmdQuitter;
    }
}

