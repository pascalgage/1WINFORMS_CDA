using ClassLibraryProduction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToutEmballDyn
{
    public partial class FormProductionDynamique : Form
    {
        //Déclarer une liste de production 
        List<Production> mesProductions;

        public delegate void DelegateMettreAJour(Production _prod);
        public FormProductionDynamique()
        {
            InitializeComponent();
            //Assigner la liste de production à une liste vide
            mesProductions = new List<Production>();

            //Créer les trois productions 
            Production maProdA = new Production("A", 10000, 1000);
            Production maProdB = new Production("B", 25000, 5000);
            Production maProdC = new Production("C", 120000, 10000);

            //Ajouter les productions à la liste 
            mesProductions.Add(maProdA);
            mesProductions.Add(maProdB);
            mesProductions.Add(maProdC);

            foreach (Production _prod in mesProductions)
            {
                InitialiserUneProduction(_prod);

            }


        }
        private void InitialiserUneProduction(Production _prod)
        {
            //Ajouter les boutons concernant les prod dans le menu démarer (peut être séparé dans une fonction)
            AjouterLesSousMenuAuMenuDemarrer(_prod);
            //Idem pour le menu arrêter
            AjouterLesSousMenuAuMenuArreter(_prod);
            //Idem pour le menu continuer
            AjouterLesSousMenuAuMenuContinuer(_prod);
            //Ajouter une tab dans le tabcontrol pour chaque production
            AjouterTabPageDansTabControl(_prod);
            //Ajouter les UCpanelTypeProd dans la bonne tabPage
            AjouterUCpanelTypeProdDansTabPage(_prod);
            //Ajouter les UCprogressBarProduction dans le flowlayoutPanel
            AjouterUcprogressBarAuFlowLayout(_prod);

            //S'abonner à l'évènement...
            _prod.CaisseProduite += _prod_CaisseProduite;
        }

        private void _prod_CaisseProduite(Production sender)
        {

            this.Invoke(new DelegateMettreAJour(MettreAJourIHM),new object[] {sender });
        }

        private void MettreAJourIHM(Production _prod)
        {
            //Aller récupérer le bon UC qui correspond à la production...
            UCprogressBarProduction uCprogressBarProduction = (UCprogressBarProduction)flowLayoutPanel.Controls[_prod.Produit];
            //Aller modifier la valeur de la progressBar
            uCprogressBarProduction.ProgressBarProdValue = _prod.QuantiteDeCaisseDepuisdemarrage;

            //Aller récupérer le bon Uc panel prod...
            UCpanelTypeProd uCpanelTypeProd= (UCpanelTypeProd)tabControl.Controls[_prod.Produit].Controls[_prod.Produit];
            //Aller modifier la quantité de caisse produite
            uCpanelTypeProd.NombreDeCaisseProduite= _prod.QuantiteDeCaisseDepuisdemarrage.ToString();
            //Aller modifier le taux d'erreur
            uCpanelTypeProd.NombreDefautDepuisDem = _prod.TauxErreur().ToString();

            


            if (_prod.EtatCourant == Production.StatutProd.Demarree)
            {
                //Aller récupérer le sous-menu de démarrer correspondant à la prod....
                demarrerToolStripMenuItem.DropDownItems[_prod.Produit].Enabled =false;
                arreterToolStripMenuItem.DropDownItems[_prod.Produit].Enabled = true;
                continuerToolStripMenuItem.DropDownItems[_prod.Produit].Enabled = true; //a voir true or false


            }



            if (_prod.EtatCourant == Production.StatutProd.Suspendue)
            {
                demarrerToolStripMenuItem.DropDownItems[_prod.Produit].Enabled = false;
                arreterToolStripMenuItem.DropDownItems[_prod.Produit].Enabled = false;
                continuerToolStripMenuItem.DropDownItems[_prod.Produit].Enabled = true;


            }
            


            if (_prod.EtatCourant == Production.StatutProd.NonDemarree)
            {
                demarrerToolStripMenuItem.DropDownItems[_prod.Produit].Enabled = true;
                arreterToolStripMenuItem.DropDownItems[_prod.Produit].Enabled = false;
                continuerToolStripMenuItem.DropDownItems[_prod.Produit].Enabled = true;


            }



        }

        private void AjouterUcprogressBarAuFlowLayout(Production prod)
        {
            //creer une progressBar
            UCprogressBarProduction maUCprogressbar = new UCprogressBarProduction();
            //Remplir les propriétés
            maUCprogressbar.Name = prod.Produit;
            maUCprogressbar.LabelProductionAText = "Production "+prod.Produit;
            maUCprogressbar.ProgressBarProdValue = prod.QuantiteDeCaisseDepuisdemarrage;
            maUCprogressbar.ProgressBarProdMaximum = prod.QuantiteAProduire;
            //Ajouter leUCprogressBar au FlowLayoutPanel
            flowLayoutPanel.Controls.Add(maUCprogressbar);

        }

        private void AjouterUCpanelTypeProdDansTabPage(Production prod)
        {
            //Creer un UCpanel
            UCpanelTypeProd monUCpanelTypeProd = new UCpanelTypeProd();


            //Remplir les propriétés
            monUCpanelTypeProd.Name = prod.Produit;
            monUCpanelTypeProd.NombreDeCaisseProduite = prod.QuantiteDeCaisseDepuisdemarrage.ToString();
            monUCpanelTypeProd.NombreDefaut = "0";
            monUCpanelTypeProd.NombreDefautDepuisDem = prod.TauxErreur().ToString();
            //Ajouter le UCpanel à la tabPage tabPage[prod.Produit]
            tabControl.TabPages[prod.Produit].Controls.Add(monUCpanelTypeProd);
            
        }

        private void AjouterTabPageDansTabControl(Production prod)
        {
            //Creer une tabPage
            TabPage maTabPage = new TabPage();
            maTabPage.Name = prod.Produit;
            maTabPage.Text = "Type " + prod.Produit;
            //Ajouter la tabPage au tabControl
            tabControl.Controls.Add(maTabPage);
        }

        private void AjouterLesSousMenuAuMenuContinuer(Production _prod)
        {
            ToolStripMenuItem sousMenuContinuer = new ToolStripMenuItem();
            sousMenuContinuer.Name = _prod.Produit;
            sousMenuContinuer.Text = _prod.Produit;
            //sousMenuContinuer.Enabled = false;
            continuerToolStripMenuItem.DropDownItems.Add(sousMenuContinuer);
            sousMenuContinuer.Tag = _prod;
            sousMenuContinuer.Click += SousMenuContinuer_Click;
        }

        private void SousMenuContinuer_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem sousMenuContinuer = (ToolStripMenuItem)sender;
            Production prod = (Production)sousMenuContinuer.Tag;
            prod.ReprendreLaProduction();
        }

        private void AjouterLesSousMenuAuMenuArreter(Production _prod)
        {
            ToolStripMenuItem sousMenuArreter = new ToolStripMenuItem();
            sousMenuArreter.Name = _prod.Produit;
            sousMenuArreter.Text = _prod.Produit;
            sousMenuArreter.Enabled = false;
            arreterToolStripMenuItem.DropDownItems.Add(sousMenuArreter);
            sousMenuArreter.Tag = _prod;
            sousMenuArreter.Click += SousMenuArreter_Click1;
        }

        private void SousMenuArreter_Click1(object sender, EventArgs e)
        {
            ToolStripMenuItem sousMenuArr = (ToolStripMenuItem)sender;
            Production prod = (Production)sousMenuArr.Tag;
            prod.MettreEnPause();
        }

       


        private void AjouterLesSousMenuAuMenuDemarrer(Production _prod)
        {
            ToolStripMenuItem sousMenuDemarrer = new ToolStripMenuItem();
            sousMenuDemarrer.Name = _prod.Produit;
            sousMenuDemarrer.Text = _prod.Produit;
            //Passer la production dans le tag

            //on met la production dans le tag pour pouvoir y accéder par l'évènement click
            sousMenuDemarrer.Tag = _prod;


            demarrerToolStripMenuItem.DropDownItems.Add(sousMenuDemarrer);
            //Ajouter un évènement au click sur le bouton
            sousMenuDemarrer.Click += SousMenuDemarrer_Click;
        }

        private void SousMenuDemarrer_Click(object sender, EventArgs e)
        {
            //caster le sender en toolstripmenuItem
            ToolStripMenuItem sousMenuDem = (ToolStripMenuItem)sender;
            //récupérer la production dans le tag
            Production prod=(Production)sousMenuDem.Tag;
            //production a demarrer
            prod.Demarrer();
        }
        


        private void commencerUneProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNouvelleProd formNouvelleProd=new FormNouvelleProd();
            formNouvelleProd.ShowDialog();
            if (formNouvelleProd.DialogResult == DialogResult.Yes)
            {
                //Parser quantité à produire et production par heure (à déplacer plus tard dans formNouvelleProd)

                int quantiteAproduire = int.Parse(formNouvelleProd.QuantiteAprod);
                int productionParHeure = int.Parse(formNouvelleProd.QuantiteParHeure);
                //creer une nouvelle production
                Production nouvelleProd = new Production(formNouvelleProd.Produit, quantiteAproduire, productionParHeure);

                //ajouter cette production à la liste de production
                mesProductions.Add(nouvelleProd);

                //utiliser la méthode Initialiserlapoduction()
                InitialiserUneProduction(nouvelleProd);
            }

        }



        
    }
}
