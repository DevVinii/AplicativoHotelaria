﻿using AplicativoHotel_correto_.Models;
using AplicativoHotel_correto_.Resources.View;

namespace AplicativoHotel_correto_
{
    public partial class App : Application
    {
        public List<Quarto> lista_quartos = new List<Quarto>()
        {
            new Quarto()
            {
                Descricao = "Suíte super luxo",
                ValorDiariaAdulto = 110.0,
                ValorDiariaCrianca = 55.0,
            },
            new Quarto()
            {
                Descricao = "Suíte luxo",
                ValorDiariaAdulto = 90.0,
                ValorDiariaCrianca = 40.0,
            },
            new Quarto()
            {
                Descricao = "Suíte Single",
                ValorDiariaAdulto = 50.0,
                ValorDiariaCrianca = 40.0,
            },
             new Quarto()
            {
                Descricao = "Suíte da Crise",
                ValorDiariaAdulto = 25.0,
                ValorDiariaCrianca = 5.0,
            }
        };

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new ContratacaoDeHospedagem());
        }

        protected override Window CreateWindow(IActivationState? activationState)

        {

            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 600;

            return window; 
        }
    }
}
