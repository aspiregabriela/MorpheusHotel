using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MorpheusHotel.View
{
    public class ContratacaoHospedagemcs : ContentView
    {
        public ContratacaoHospedagemcs()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Welcome to Xamarin.Forms!" }
                }
            };
        }
    }
}