﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalculadoraIMCApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            IniciarCampos();
        }

        private void btnCancelar_Clicked(object sender, EventArgs e)
        {
            IniciarCampos();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            
            var exAltura = double.TryParse(txtAltura.Text, out double altura);
            var exPeso = double.TryParse(txtPeso.Text, out double peso);

            if(!exAltura || !exPeso)
            {
                string msg = "Não foi possível converter! Valores incorretos nos parâmetros.";
                DisplayAlert("Erro ao calcular!", msg, "Ok");
                IniciarCampos();
            }else
            {
                double imc = CalcularIMC(altura, peso);
                Navigation.PushAsync(new ImcPage(imc));
                IniciarCampos();
            }

        }

        private void IniciarCampos()
        {     
            txtAltura.VerticalTextAlignment = TextAlignment.End;
            txtPeso.VerticalTextAlignment = TextAlignment.End;
            txtAltura.Focus();
        }

        private double CalcularIMC(double altura, double peso)
        {
            double imc = peso / (altura * altura);
            return imc;
        }


    }
}
