using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace imc23
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            float p = float.Parse(Peso.Text);
            float a = float.Parse(Altura.Text);
            float imc = p / (a * a);
            string r;

            if (imc < 18.5)
            {
                r = "ABAIXO DO PESO";
            }
            else if (imc < 24.9)
            {
                r = "PESO NORMAL";
            }
            else if (imc > 25)
            {
                r = "SOBREPESO";
            }
            else if (imc > 29.9) 
            {
                r = "OBESIDADE GRAU1";
            }
            else if (imc > 30)
            {
                r = "OBESIDADE GRAU2";
            }
            else
            {
                r = "OBESIDADE MÓRBIDA";
            }
            DisplayAlert("Calculo", r.ToString(), "ok");
        }
    }
}
