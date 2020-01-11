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
	public partial class Absence : ContentPage
	{
        private String[] Cours = {"C#", "java"};
        private String[] Filieres = { "informatique", "gtr","indus","gpmc"};
        private EtudiantsDataAccess dataAccess;

        public Absence ()
		{
			InitializeComponent ();

            MesCours.ItemsSource = Cours;
            MesFiliere.ItemsSource = Filieres;
		}

        public void Afficher_Etudiants(object sender, EventArgs e)
        {

            dataAccess = new EtudiantsDataAccess();
            String cour = (String)MesCours.SelectedItem;
            String filiere = (String)MesFiliere.SelectedItem;

            String[] NamesEtudiants = new String[10];
            var table = ConnexionDB.connexion().Table<Etudiants>();
            var i = 0;
            foreach (var cr in table)
            {
                NamesEtudiants[i] = cr.ToString();
                i++;
            }
            Etudiants.ItemsSource = NamesEtudiants;

       
        }
    }
}