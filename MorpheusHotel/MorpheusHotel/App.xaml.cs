using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MorpheusHotel.View;
using System.Collections;

namespace MorpheusHotel
{
    public partial class App : Application
    {
        internal IList lista_suites;

        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new NavigationPage(new View.ContratacaoHospedagem());
            else
                MainPage = new View.Login();
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
