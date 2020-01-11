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
	public partial class home : ContentPage
	{
        
        public home ()
		{
			InitializeComponent ();

            btnEtudiant.Clicked += (sender, e) => { Navigation.PushAsync(new AjouterEtudiant()); };
            btnCours.Clicked += (sender, e) => { Navigation.PushAsync(new AjouterCours()); };
            btnAbsence.Clicked += (sender, e) => { Navigation.PushAsync(new Absence()); };


        }

        
    }
}