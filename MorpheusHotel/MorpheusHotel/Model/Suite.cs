using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MorpheusHotel.Model
{
    public class Suite : ContentPage
    {
        public Suite();
        
        public string Nome { get; set; }
        public double DiariaAdulto { get; set; }
        public double DiariaCrianca { get; set; }
}
    }
