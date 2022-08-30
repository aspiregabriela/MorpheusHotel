using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MorpheusHotel.Model
{
    public class Hospedagem : ContentPage
    {
        public Hospedagem()
        {
            
        }
        int quantidade_adultos;
        Suite quarto_escolhido;

        public Suite QuartoEscolhido
        {
            get => quarto_escolhido;
            set
            {
                if (value == null)
                    throw new Exception("Por favor, selecione sua acomodação");

                quarto_escolhido = value;
            }
        }
        public int QntAdultos
        {
            get => quantidade_adultos;
            set
            {
                if (value == 0)
                    throw new Exception("Por favor, selecione a quantidade de adultos");

                quantidade_adultos = value;
            }
        }



        public int QntCriancas { get; set; }
        public DateTime DataCheckIn { get; set; }
        public DateTime DataCheckOut { get; set; }
        public int Estadia
        {
            get
            {
                return DataCheckOut.Subtract(DataCheckIn).Days;
            }
        }
        public double ValorTotal
        {
            get => ((QntAdultos * QuartoEscolhido.DiariaAdulto) +
                     (QntCriancas * QuartoEscolhido.DiariaCrianca)
                   ) * Estadia;
        }

    }

}
   
