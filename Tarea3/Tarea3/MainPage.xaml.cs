﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Altura.Text) && !string.IsNullOrEmpty(Peso.Text))
            {
                var altura = double.Parse(Altura.Text)/100;
                var peso = double.Parse(Peso.Text);
                var imc = peso / ((altura * altura));
                IMC.Text = imc.ToString();

                string resultado = "";

                if (imc < 18.5)
                {
                    resultado = "Tiene un peso bajo";
                }
                else if(imc >= 18.5 && imc <= 24.9)
                {
                    resultado = "Tiene un peso normal";

                }
                else if(imc >=25 && imc <= 29.9)
                {
                    resultado = "Tiene sobrepeso";
                }
                else
                {
                    resultado = "Tiene obesidad, debe cuidarse";
                }

                DisplayAlert("Resultado", resultado, "OK");
            }
            else
            {
                DisplayAlert("Datos erroneos", "Por favor llenar todos los datos","Ok");
            }
            
        }
    }
}
