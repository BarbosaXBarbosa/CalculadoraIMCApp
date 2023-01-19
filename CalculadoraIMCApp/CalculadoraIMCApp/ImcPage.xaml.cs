using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CalculadoraIMCApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ImcPage : ContentPage
    {
        public ImcPage(double imc)
        {
            InitializeComponent();
            ExibirAlert(imc);
        }
        private void ExibirAlert(double imc)
        {
            string msg = $"O seu imc é de {imc.ToString()}";

            DisplayAlert("Resultado do imc", msg, "Ok");
        }
    }
}