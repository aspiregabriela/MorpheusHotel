using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using MorpheusHotel.View;
using System.Collections;
using MorpheusHotel.Model;
using System.Collections.Generic;

namespace MorpheusHotel
{
    public partial class App : Application
    {
       
        public List<Suite> suites = new List<Suite>
        {
            new Suite()
            {
               Nome = "Luxo",
               DiariaAdulto = 110.0,
               DiariaCrianca = 55.0
            },
            new Suite()
            {
               Nome = "Executiva",
               DiariaAdulto = 90.0,
               DiariaCrianca = 45.0
            },
            new Suite()
            {
               Nome = "Econômica",
               DiariaAdulto = 45.0,
               DiariaCrianca = 20.0
            }
        };
       

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
