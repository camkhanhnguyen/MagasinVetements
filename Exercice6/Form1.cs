/**
 * titre: Magasin de Vêtements 
 * description: la liste des client dans un magasin de vêtements
 * date: 21/11/2022
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Exercice6
{
    public partial class frmMagasinVetements : Form
    {
        //déclaration
        private int indexItems;
        public int listItems = 9;

        /// <summary>
        /// créer la classe mère (Clients)
        /// </summary>
        public abstract class Clients
        {
            // propriéte
            protected string login = "INCONNU"; // si utilisateur ne rempli pas le login
            protected int prix; // le prix d'achat

            /// <summary>
            /// constructeur simple (inconnu)
            /// </summary>
            public Clients(int prix) 
            {
                this.prix = prix;
            }

            /// <summary>
            /// constructeur pour initialisation le login et le prix
            /// </summary>
            /// <param name="login"></param>
            public Clients(string login, int prix)
            {
                this.login = login;
                this.prix = prix;
            }

            /// <summary>
            /// permet de retourner les informations des clients
            /// </summary>
            /// <returns></returns>
            public abstract string info();

            /// <summary>
            /// getter le prix
            /// </summary>
            /// <returns></returns>
            public int getPrix()
            {
                return prix;
            }
        }

        /// <summary>
        /// créer la class fille de la class Clients
        /// </summary>
        public class Vetements : Clients
        {
            // propriétes
            private string vetements;

            /// <summary>
            /// contructeur pour initialisation le login
            /// </summary>
            public Vetements(string vetements, int prix): base(prix)
            {
                this.vetements = vetements;
            }

            /// <summary>
            /// constructeur pour initialisation le login, les vêtements et le prix
            /// </summary>
            /// <param name="login"></param>
            /// <param name="vetements"></param>
            /// <param name="prix"></param>
            public Vetements(string login, string vetements, int prix) : base(login, prix)
            {
                this.vetements = vetements;
            }

            /// <summary>
            /// retourne les informations d'un client
            /// </summary>
            /// <returns></returns>
            public override string info()
            {
                return login + " (vêtements: " + vetements + ", prix: " + prix + " €)";
            }
        }

        /// <summary>
        /// créer la classe fille de la classe Clients
        /// </summary>
        public class Chaussures : Clients
        {
            // propriétés
            string chaussures;

            /// <summary>
            /// constructeur pour initialisation le login
            /// </summary>
            public Chaussures(string chaussures, int prix): base(prix)
            {
                this.chaussures = chaussures;
            }

            /// <summary>
            /// constructeur pour initialisation le login, les chaussures et le prix
            /// </summary>
            /// <param name="login"></param>
            /// <param name="chaussures"></param>
            /// <param name="prix"></param>
            public Chaussures(string login, string chaussures, int prix) : base(login, prix)
            {
                this.chaussures = chaussures;
            }

            /// <summary>
            /// retourne le login
            /// </summary>
            /// <returns></returns>
            public override string info()
            {
                return login + " (chaussures: " + chaussures + " , prix : " + prix + " €)";
            }
        }

        /// <summary>
        /// créer la classe fille de la classe Clients
        /// </summary>
        public class Accessoires : Clients
        {
            // propriétes
            string accessoires;

            /// <summary>
            /// constructeur pour initialisation l'accesoire
            /// </summary>
            /// <param name="accessoire"></param>
            public Accessoires(string accessoires, int prix): base(prix)
            {
                this.accessoires = accessoires;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="login"></param>
            /// <param name="accessoires"></param>
            /// <param name="prix"></param>
            public Accessoires(string login, string accessoires, int prix) : base(login, prix)
            {
                this.accessoires = accessoires;
            }

            /// <summary>
            /// retourn le login
            /// </summary>
            /// <returns></returns>
            public override string info()
            {
                return login + " (accessoires : " + accessoires + " , prix : " + prix + " €)";
            }
        }

        // créer la list des clients
        private List<Clients> lesClients = new List<Clients>();

        /// <summary>
        /// initialisation le graphic
        /// </summary>
        public frmMagasinVetements()
        {
            InitializeComponent();
        }

        /// <summary>
        /// visible le bouton radio Vetements
        /// </summary>
        public void changeVisibleVetements()
        {
            lblVetements.Visible = rdbVetements.Checked;
            cmbVetements.Visible = rdbVetements.Checked;
        }

        /// <summary>
        /// visible le bouton radio Chaussures
        /// </summary>
        public void changeVisibleChaussures()
        {
            lblChaussures.Visible = rdbChaussures.Checked;
            cmbChaussures.Visible = rdbChaussures.Checked;
        }

        /// <summary>
        /// visible le bouton radio Accesoires
        /// </summary>
        public void changeVisibleAccessoires()
        {
            lblAccessoires.Visible = rdbAccessoires.Checked;
            cmbAccessoires.Visible = rdbAccessoires.Checked;
        }

        /// <summary>
        /// chargement la fenêtre
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmVetementsFemme_Load(object sender, EventArgs e)
        {
            // instaler un défault sur le bouton radio vetement
            rdbVetements.Checked = true;
            changeVisibleVetements();

            // mis 1re item à défault
            cmbVetements.SelectedIndex = 0;
            cmbChaussures.SelectedIndex = 0;
            cmbAccessoires.SelectedIndex = 0;

            // reposition sur le login
            txtLogin.Focus();

        }

        /// <summary>
        /// mis à jour la list client
        /// </summary>
        public void MisAJourListeClients()
        {
            // vider la liste
            lstClients.Items.Clear();

            // remplir les clients dans la liste
            for (int k = 0; k < lesClients.Count; k++)
            {
                lstClients.Items.Add(lesClients[k].info());
            }

        }

        /// <summary>
        /// recherche un prix maximal
        /// </summary>
        private void rechercherPrixMax()
        {
            int max = 0;
            // vider la zone prix max si la list clients est vidé
            if(lesClients.Count == 0)
            {
                txtPrixMax.Text = "";
            }
            else
            {
                for (int k = 0; k < lesClients.Count; k++)
                {
                    if (lesClients[k].getPrix() > lesClients[max].getPrix())
                    {
                        max = k;
                    }
                    txtPrixMax.Text = lesClients[max].info().ToUpper();
                }
            }
            txtPrixMax.Enabled = false;
        }

        /// <summary>
        /// clic sur bouton radio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjouter_Click(object sender, EventArgs e)
        {
            // si clic sur bouton radio Vêtements
            if (rdbVetements.Checked)
            {

                // affichage un photo des vêtements
                AffichagePhotoVetements(indexItems++);

                // si le login est vidé
                if (txtLogin.Text == "")
                {
                    lesClients.Add(new Vetements(cmbVetements.SelectedItem.ToString(), (int)nudPrix.Value));
                }
                else
                {
                    lesClients.Add(new Vetements(txtLogin.Text.ToUpper(), cmbVetements.SelectedItem.ToString(), (int)nudPrix.Value));
                }
            }
            // si clic sur le bouton radio Chaussures
            else if (rdbChaussures.Checked)
            {
                // affichage un photo des chaussures
                AffichagePhotoChaussures(indexItems++);

                // si le login est vidé
                if (txtLogin.Text == "")
                {
                    lesClients.Add(new Chaussures(cmbChaussures.SelectedItem.ToString(), (int)nudPrix.Value));
                }
                else
                {
                    lesClients.Add(new Chaussures(txtLogin.Text.ToUpper(), cmbChaussures.SelectedItem.ToString(), (int)nudPrix.Value));
                }
            }
            // si clic sur bouton radio Accessoires
            else
            {
                // affichage un photo des accessoires
                AffichagePhotoAccessoires(indexItems++);

                // si le login est vidé
                if (txtLogin.Text == "")
                {
                    lesClients.Add(new Accessoires(cmbAccessoires.SelectedItem.ToString(), (int)nudPrix.Value));
                }
                else
                {
                    lesClients.Add(new Accessoires(txtLogin.Text, cmbAccessoires.SelectedItem.ToString(), (int)nudPrix.Value));
                }

            }

            // mis à jour la list client
            MisAJourListeClients();

            // vider le login et se position sur le login
            txtLogin.Text = "";
            txtLogin.Focus();

            // recherche le plus grand prix
            rechercherPrixMax();

        }

        /// <summary>
        /// affichage photo des vêtements
        /// </summary>
        /// <param name="indexItems"></param>
        public void AffichagePhotoVetements(int indexItems)
        {
            for (int k = 0; k < listItems; k++)
            {
                indexItems = cmbVetements.SelectedIndex ;
                ptbPhoto.Image = (Image)Properties.Resources.ResourceManager.GetObject("v" + (indexItems+1));
            }
        }

        /// <summary>
        /// affichage photo des chaussures
        /// </summary>
        /// <param name="indexItems"></param>
        public void AffichagePhotoChaussures(int indexItems)
        {
            for (int k = 0; k < listItems; k++)
            {
                indexItems = cmbChaussures.SelectedIndex;
                ptbPhoto.Image = (Image)Properties.Resources.ResourceManager.GetObject("c" + (indexItems + 1));
            }
        }

        /// <summary>
        /// affichage photo des accessoires
        /// </summary>
        /// <param name="indexItems"></param>
        public void AffichagePhotoAccessoires(int indexItems)
        {
            for (int k = 0; k < listItems; k++)
            {
                indexItems = cmbAccessoires.SelectedIndex;
                ptbPhoto.Image = (Image)Properties.Resources.ResourceManager.GetObject("a" + (indexItems + 1));
            }
        }
        /// <summary>
        /// clic sur bouton radio Vetements
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbVetements_CheckedChanged(object sender, EventArgs e)
        {
            changeVisibleVetements();
        }

        /// <summary>
        /// clic sur bouton radio Chaussures
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbChaussures_CheckedChanged(object sender, EventArgs e)
        {
            changeVisibleChaussures();
        }

        /// <summary>
        /// clic sur bouton radio Accessoires
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rdbAccessoires_CheckedChanged(object sender, EventArgs e)
        {
            changeVisibleAccessoires();
        }
    }
}
