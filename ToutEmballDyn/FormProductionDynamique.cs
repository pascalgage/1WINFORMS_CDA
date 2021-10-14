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
            sousMenuContinuer.Enabled = false;
            continuerToolStripMenuItem.DropDownItems.Add(sousMenuContinuer);
        }



        private void AjouterLesSousMenuAuMenuArreter(Production _prod)
        {
            ToolStripMenuItem sousMenuArreter = new ToolStripMenuItem();
            sousMenuArreter.Name = _prod.Produit;
            sousMenuArreter.Text = _prod.Produit;
            sousMenuArreter.Enabled = false;
            arreterToolStripMenuItem.DropDownItems.Add(sousMenuArreter);
        }



        private void AjouterLesSousMenuAuMenuDemarrer(Production _prod)
        {
            ToolStripMenuItem sousMenuDemarrer = new ToolStripMenuItem();
            sousMenuDemarrer.Name = _prod.Produit;
            sousMenuDemarrer.Text = _prod.Produit;
            demarrerToolStripMenuItem.DropDownItems.Add(sousMenuDemarrer);
        }

        private void commencerUneProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreationProd maProd=new CreationProd();
            maProd.Show();

        }

        
    }
}
