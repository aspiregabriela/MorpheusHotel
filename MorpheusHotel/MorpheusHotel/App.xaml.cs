using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MorpheusHotel.View;

namespace MorpheusHotel
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Login();

            MainPage = new NavigationPage(new View.ContratacaoHospedagem());
            //MainPage = new NavigationPage(new View.ContratacaoHospedagem());

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new NavigationPage(new View.ContratacaoHospedagem());
            else
                MainPage = new NavigationPage(new View.Login());


        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
