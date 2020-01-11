using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Gestion_Absences
{
    public partial class MainPage : ContentPage
    {
        private ProfsDataAccess dataAccess;

        public MainPage()
        {
            InitializeComponent();
            btnInscrp.Clicked += (sender, e) => { Navigation.PushAsync(new inscription()); };
            //btnLogin.Clicked += (sender, e) => { Navigation.PushAsync(new home()); };
        }

        public void ouvrir_inscrp(object sender , EventArgs e)
        {
            //Navigation.PushAsync(new inscription());
        }
        public void ouvrir_home(object sender, EventArgs e)
        {
            //Navigation.PushAsync(new inscription());
            //dataAccess = new ProfsDataAccess();
            Profs[] LesProfs = new Profs[20];
            var table = ConnexionDB.connexion().Table<Profs>();
            var i = 0;
            var j = 0;
            int ver = 0;
            String name = "null", pas = "null"; 
            foreach (var pr in table)
            {
                LesProfs[i] = pr;
                i++;
            }
            for (j=0;j< LesProfs.Length; j++)
            {
                if (LesProfs[j]!= null && LesProfs[j] != null)
                {
                    name = LesProfs[j].nom;
                    pas = LesProfs[j].mdp;
                }
                else
                    break;

                if ( name == log.Text && pas == pass.Text)
                {
                    ver = 1;
                    Navigation.PushAsync(new home());
                    break;
                }
                else
                    ver = 0;
                  
            }
            if(ver==0)
            DisplayAlert("Erreur", "login/pass incorrecte", "ok");


        }
    }
}
