using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DataBinding
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnEnviar.Clicked += BtnEnviar_Clicked;
		}

        private void BtnEnviar_Clicked(object sender, EventArgs e)
        {
            var perso = (Persona)Resources["personaUno"];
            perso.Nombre = "Adrian";
            perso.Pais = "Perú";
        }
    }
}
