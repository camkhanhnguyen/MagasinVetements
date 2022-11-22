
namespace Exercice6
{
    partial class frmMagasinVetements
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
            this.rdbVetements = new System.Windows.Forms.RadioButton();
            this.rdbChaussures = new System.Windows.Forms.RadioButton();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.rdbAccessoires = new System.Windows.Forms.RadioButton();
            this.lblVetements = new System.Windows.Forms.Label();
            this.cmbVetements = new System.Windows.Forms.ComboBox();
            this.lblChaussures = new System.Windows.Forms.Label();
            this.cmbChaussures = new System.Windows.Forms.ComboBox();
            this.cmbAccessoires = new System.Windows.Forms.ComboBox();
            this.lblAccessoires = new System.Windows.Forms.Label();
            this.lstClients = new System.Windows.Forms.ListBox();
            this.lblPrix = new System.Windows.Forms.Label();
            this.nudPrix = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrixMax = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ptbPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbVetements
            // 
            this.rdbVetements.AutoSize = true;
            this.rdbVetements.Location = new System.Drawing.Point(22, 69);
            this.rdbVetements.Name = "rdbVetements";
            this.rdbVetements.Size = new System.Drawing.Size(140, 24);
            this.rdbVetements.TabIndex = 0;
            this.rdbVetements.TabStop = true;
            this.rdbVetements.Text = "VÊTEMENTS";
            this.rdbVetements.UseVisualStyleBackColor = true;
            this.rdbVetements.CheckedChanged += new System.EventHandler(this.rdbVetements_CheckedChanged);
            // 
            // rdbChaussures
            // 
            this.rdbChaussures.AutoSize = true;
            this.rdbChaussures.Location = new System.Drawing.Point(22, 123);
            this.rdbChaussures.Name = "rdbChaussures";
            this.rdbChaussures.Size = new System.Drawing.Size(156, 24);
            this.rdbChaussures.TabIndex = 1;
            this.rdbChaussures.TabStop = true;
            this.rdbChaussures.Text = "CHAUSSURES";
            this.rdbChaussures.UseVisualStyleBackColor = true;
            this.rdbChaussures.CheckedChanged += new System.EventHandler(this.rdbChaussures_CheckedChanged);
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(32, 51);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(43, 17);
            this.lblLogin.TabIndex = 2;
            this.lblLogin.Text = "Login";
            // 
            // txtLogin
            // 
            this.txtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(136, 45);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(377, 27);
            this.txtLogin.TabIndex = 3;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjouter.Location = new System.Drawing.Point(22, 217);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(156, 35);
            this.btnAjouter.TabIndex = 11;
            this.btnAjouter.Text = "AJOUTER";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // rdbAccessoires
            // 
            this.rdbAccessoires.AutoSize = true;
            this.rdbAccessoires.Location = new System.Drawing.Point(22, 178);
            this.rdbAccessoires.Name = "rdbAccessoires";
            this.rdbAccessoires.Size = new System.Drawing.Size(160, 24);
            this.rdbAccessoires.TabIndex = 2;
            this.rdbAccessoires.TabStop = true;
            this.rdbAccessoires.Text = "ACCESSOIRES";
            this.rdbAccessoires.UseVisualStyleBackColor = true;
            this.rdbAccessoires.CheckedChanged += new System.EventHandler(this.rdbAccessoires_CheckedChanged);
            // 
            // lblVetements
            // 
            this.lblVetements.AutoSize = true;
            this.lblVetements.Location = new System.Drawing.Point(32, 105);
            this.lblVetements.Name = "lblVetements";
            this.lblVetements.Size = new System.Drawing.Size(75, 17);
            this.lblVetements.TabIndex = 5;
            this.lblVetements.Text = "Vêtements";
            this.lblVetements.Visible = false;
            // 
            // cmbVetements
            // 
            this.cmbVetements.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbVetements.FormattingEnabled = true;
            this.cmbVetements.Items.AddRange(new object[] {
            "MANTEAU",
            "ROBE",
            "PULL ET GILET",
            "JEAN",
            "PANTALON",
            "T-SHIRT, POLO ET TOP",
            "VESTE ET BLAZER",
            "JUPE",
            "BLOUSE ET CHEMISE"});
            this.cmbVetements.Location = new System.Drawing.Point(136, 99);
            this.cmbVetements.Name = "cmbVetements";
            this.cmbVetements.Size = new System.Drawing.Size(377, 28);
            this.cmbVetements.TabIndex = 6;
            this.cmbVetements.Visible = false;
            // 
            // lblChaussures
            // 
            this.lblChaussures.AutoSize = true;
            this.lblChaussures.Location = new System.Drawing.Point(32, 161);
            this.lblChaussures.Name = "lblChaussures";
            this.lblChaussures.Size = new System.Drawing.Size(83, 17);
            this.lblChaussures.TabIndex = 7;
            this.lblChaussures.Text = "Chaussures";
            this.lblChaussures.Visible = false;
            // 
            // cmbChaussures
            // 
            this.cmbChaussures.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbChaussures.FormattingEnabled = true;
            this.cmbChaussures.Items.AddRange(new object[] {
            "BOOTS",
            "BOTTES",
            "DERBIES ET MOCASSINS",
            "SANDALES  PLATES",
            "CUISSARDES",
            "ESCARPINS",
            "BASKETS",
            "SANDALES À TALONS",
            "TONG"});
            this.cmbChaussures.Location = new System.Drawing.Point(136, 155);
            this.cmbChaussures.Name = "cmbChaussures";
            this.cmbChaussures.Size = new System.Drawing.Size(377, 28);
            this.cmbChaussures.TabIndex = 8;
            this.cmbChaussures.Visible = false;
            // 
            // cmbAccessoires
            // 
            this.cmbAccessoires.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAccessoires.FormattingEnabled = true;
            this.cmbAccessoires.Items.AddRange(new object[] {
            "SAC",
            "FOULARD ET ECHARPE",
            "CEINTURE",
            "CHAPEAU ET BONNET",
            "COLLANTS ET CHAUSSETTES",
            "PORTEFEUILLE",
            "GANTS ET MITAINES",
            "BIJOUX",
            "PARFUM ET COSMÉTIQUE"});
            this.cmbAccessoires.Location = new System.Drawing.Point(136, 210);
            this.cmbAccessoires.Name = "cmbAccessoires";
            this.cmbAccessoires.Size = new System.Drawing.Size(377, 28);
            this.cmbAccessoires.TabIndex = 9;
            this.cmbAccessoires.Visible = false;
            // 
            // lblAccessoires
            // 
            this.lblAccessoires.AutoSize = true;
            this.lblAccessoires.Location = new System.Drawing.Point(32, 216);
            this.lblAccessoires.Name = "lblAccessoires";
            this.lblAccessoires.Size = new System.Drawing.Size(84, 17);
            this.lblAccessoires.TabIndex = 10;
            this.lblAccessoires.Text = "Accessoires";
            this.lblAccessoires.Visible = false;
            // 
            // lstClients
            // 
            this.lstClients.AccessibleDescription = "";
            this.lstClients.FormattingEnabled = true;
            this.lstClients.HorizontalScrollbar = true;
            this.lstClients.ItemHeight = 16;
            this.lstClients.Location = new System.Drawing.Point(35, 306);
            this.lstClients.Name = "lstClients";
            this.lstClients.ScrollAlwaysVisible = true;
            this.lstClients.Size = new System.Drawing.Size(478, 196);
            this.lstClients.TabIndex = 11;
            this.lstClients.SelectedIndexChanged += new System.EventHandler(this.frmVetementsFemme_Load);
            // 
            // lblPrix
            // 
            this.lblPrix.AutoSize = true;
            this.lblPrix.Location = new System.Drawing.Point(32, 267);
            this.lblPrix.Name = "lblPrix";
            this.lblPrix.Size = new System.Drawing.Size(31, 17);
            this.lblPrix.TabIndex = 12;
            this.lblPrix.Text = "Prix";
            // 
            // nudPrix
            // 
            this.nudPrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPrix.Location = new System.Drawing.Point(136, 260);
            this.nudPrix.Name = "nudPrix";
            this.nudPrix.Size = new System.Drawing.Size(135, 27);
            this.nudPrix.TabIndex = 13;
            this.nudPrix.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "€";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 522);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Le client ayant plus dépensé";
            // 
            // txtPrixMax
            // 
            this.txtPrixMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrixMax.Location = new System.Drawing.Point(38, 552);
            this.txtPrixMax.Name = "txtPrixMax";
            this.txtPrixMax.Size = new System.Drawing.Size(726, 27);
            this.txtPrixMax.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbVetements);
            this.groupBox1.Controls.Add(this.btnAjouter);
            this.groupBox1.Controls.Add(this.rdbChaussures);
            this.groupBox1.Controls.Add(this.rdbAccessoires);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(534, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 258);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LA COLLECTION";
            // 
            // ptbPhoto
            // 
            this.ptbPhoto.Location = new System.Drawing.Point(534, 306);
            this.ptbPhoto.Name = "ptbPhoto";
            this.ptbPhoto.Size = new System.Drawing.Size(230, 196);
            this.ptbPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbPhoto.TabIndex = 19;
            this.ptbPhoto.TabStop = false;
            // 
            // frmMagasinVetements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 597);
            this.Controls.Add(this.ptbPhoto);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtPrixMax);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudPrix);
            this.Controls.Add(this.lblPrix);
            this.Controls.Add(this.lstClients);
            this.Controls.Add(this.lblAccessoires);
            this.Controls.Add(this.cmbAccessoires);
            this.Controls.Add(this.cmbChaussures);
            this.Controls.Add(this.lblChaussures);
            this.Controls.Add(this.cmbVetements);
            this.Controls.Add(this.lblVetements);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Name = "frmMagasinVetements";
            this.Text = "Magasin de Vêtements";
            this.Load += new System.EventHandler(this.frmVetementsFemme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudPrix)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbVetements;
        private System.Windows.Forms.RadioButton rdbChaussures;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.RadioButton rdbAccessoires;
        private System.Windows.Forms.Label lblVetements;
        private System.Windows.Forms.ComboBox cmbVetements;
        private System.Windows.Forms.Label lblChaussures;
        private System.Windows.Forms.ComboBox cmbChaussures;
        private System.Windows.Forms.ComboBox cmbAccessoires;
        private System.Windows.Forms.Label lblAccessoires;
        private System.Windows.Forms.ListBox lstClients;
        private System.Windows.Forms.Label lblPrix;
        private System.Windows.Forms.NumericUpDown nudPrix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrixMax;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox ptbPhoto;
    }
}

