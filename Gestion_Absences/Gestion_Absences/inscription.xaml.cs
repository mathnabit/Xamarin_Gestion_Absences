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
	public partial class inscription : ContentPage
	{
        private ProfsDataAccess dataAccess;

        public inscription ()
		{
			InitializeComponent ();
            this.dataAccess = new ProfsDataAccess();
        }

        public void Add_Prof(object sender, EventArgs e)
        {
            this.dataAccess.AjouterProf(nom.Text,mdp.Text);
            DisplayAlert("title", "bien inscris", "ok");
            nom.Text = "";
            mdp.Text = "";
            mdp2.Text = "";
        }
    }
}