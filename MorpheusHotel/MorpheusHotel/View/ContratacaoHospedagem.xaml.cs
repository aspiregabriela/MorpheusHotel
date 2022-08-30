using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MorpheusHotel.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContratacaoHospedagem : ContentPage
    {

        App PropriedadesApp;
        public ContratacaoHospedagem()
        {
            InitializeComponent();

            PropriedadesApp = (App)Application.Current;

        }

        public async void Button_Clicked(object sender, EventArgs e)
        {
            bool confime = await DisplayAlert("Tem Certeza?",
                                              "Desconectar sua conta ?",
                                              "Sim", "Não");
            if (confime)
            {
                App.Current.Properties.Remove("usuario_logado");
                App.Current.MainPage = new Login();
            }

        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
    }
}