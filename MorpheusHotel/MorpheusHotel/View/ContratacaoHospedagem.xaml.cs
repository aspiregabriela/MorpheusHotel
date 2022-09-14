using MorpheusHotel.Model;
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
            NavigationPage.SetHasNavigationBar(this, false);
            PropriedadesApp = (App)Application.Current;

            lbl_usuario.Text = App.Current.Properties["usuario_logado"].ToString();

            pck_suite.ItemsSource = PropriedadesApp.suites;

            dtpck_checkin.MinimumDate = DateTime.Now;
            dtpck_checkin.MaximumDate = DateTime.Now.AddMonths(6);

            dtpck_checkout.MinimumDate = DateTime.Now.AddDays(1);
            dtpck_checkout.MaximumDate = DateTime.Now.AddMonths(6).AddDays(1);

        }

        private void dtpck_checkin_DateSelected(object sender, DateChangedEventArgs e)
        {
            DatePicker elemento = (DatePicker)sender;

            dtpck_checkout.MinimumDate = elemento.Date.AddDays(1);
            dtpck_checkout.MaximumDate = elemento.Date.AddMonths(6).AddDays(1);
        }
          private void Button_Clicked(object sender, EventArgs e)
            { 
            try
            {
                Navigation.PushAsync(new HospedagemCalculada()
                {
                    BindingContext = new Hospedagem()
                    {
                        QntAdultos = Convert.ToInt32(lbl_qnt_adultos.Text),
                        QntCriancas = Convert.ToInt32(lbl_qnt_criancas.Text),
                        QuartoEscolhido = (Suite)pck_suite.SelectedItem,
                        DataCheckIn = dtpck_checkin.Date,
                        DataCheckOut = dtpck_checkout.Date
                    }
                });
            }
            catch (Exception ex)
            {
                DisplayAlert("Ops", ex.Message, "OK");
            }
        }

         private async void Button_Clicked_1(object sender, EventArgs e)
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

        
    }
}