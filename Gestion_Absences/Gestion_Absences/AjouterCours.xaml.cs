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
	public partial class AjouterCours : ContentPage
	{
        private CoursDataAccess dataAccess;

        public AjouterCours ()
		{
			 InitializeComponent ();

             dataAccess = new CoursDataAccess();
             String[] NamesCours = new String[6];
             var table = ConnexionDB.connexion().Table<Cours>();
             var i = 0;
             foreach(var cr in table)
             {
                 NamesCours[i] = cr.ToString();
                 i++;
             }
             //ProfsView.ItemsSource = ConnexionDB.connexion().Table<Profs>().ToList();
             ListeCours.ItemsSource = NamesCours;
            //ListeCours.ItemTemplate.
        }

        public void Ajouter_Cours(object sender, EventArgs e)
        {
            dataAccess.AjouterCours(nomCours.Text,Convert.ToInt32(nbreSeances.Text));
            
            DisplayAlert("Ajout Cours", "Bien ajouté", "ok");

            nomCours.Text = "";
            nbreSeances.Text = "";
            

        }
    }
}