using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Gestion_Absences
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
    
    public partial class AjouterEtudiant : ContentPage
	{
        private EtudiantsDataAccess dataAccess;
        private InscrisDataAccess dataAccessInscris;
        private String[] Cours = {"C","Java","Php","CCNA"};
        private String[] Filieres = { "informatique", "gtr","indus","gpmc"};

        public AjouterEtudiant ()
		{
			InitializeComponent ();

            this.dataAccess = new EtudiantsDataAccess();
            this.dataAccessInscris = new InscrisDataAccess();

            
            MesCours.ItemsSource = Cours;
            MesFilieres.ItemsSource = Filieres;
        }

        public void Ajouter_Etudiant(object sender, EventArgs e)
        {

            dataAccess.AjouterEtudiant(cne.Text,nomEtud.Text,prenomEtud.Text,email.Text,tele.Text,(String)MesFilieres.SelectedItem);

            dataAccessInscris.AjouterInscris(cne.Text, (String)MesCours.SelectedItem);

            DisplayAlert("Ajout Etudiant", "Bien ajouté"+ (String)MesCours.SelectedItem, "ok");

            cne.Text = "";
            nomEtud.Text = "";
            prenomEtud.Text = "";
            email.Text = "";
            tele.Text = "";   
        }
    }
}