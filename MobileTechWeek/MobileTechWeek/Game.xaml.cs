using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileTechWeek
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Game : ContentPage
    {
        Random random = new Random();
        
        public Game()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            int eleccionComputador = random.Next(1, 4);

            //si es 1 => Piedra
            //si es 2 => Papel
            //si es 3 => Tijera

            if (eleccionComputador == 1) LabelComputadorEligio.Text = "Piedra";
            else if (eleccionComputador == 2) LabelComputadorEligio.Text = "Papel";
            else LabelComputadorEligio.Text = "Tijera";

            if (button.Text == "Piedra")
            {
                if (eleccionComputador == 2)
                {
                    DisplayAlert("Resultado", "Perdiste", "OK");
                    LabelPutosComputador.Text = (Convert.ToInt16(LabelPutosComputador.Text) + 1).ToString();
                }
                else if (eleccionComputador == 3)
                {
                    DisplayAlert("Resultado", "Ganaste", "OK");
                    LabelMisPuntos.Text = (Convert.ToInt16((LabelMisPuntos.Text) + 1)).ToString();
                }
                else
                {
                    DisplayAlert("Resultado", "Empate", "OK");
                }

            }

            if (button.Text == "Papel")
            {
                if (eleccionComputador == 3)
                {
                    DisplayAlert("Resultado", "Perdiste", "OK");
                    LabelPutosComputador.Text = (Convert.ToInt16(LabelPutosComputador.Text) + 1).ToString();
                }
                else if (eleccionComputador == 1)
                {
                    DisplayAlert("Resultado", "Ganaste", "OK");
                    LabelMisPuntos.Text = (Convert.ToInt16((LabelMisPuntos.Text) + 1)).ToString();
                }
                else
                {
                    DisplayAlert("Resultado", "Empate", "OK");
                }

            }
            if (button.Text == "Tijera")
            {
                if (eleccionComputador == 1)
                {
                    DisplayAlert("Resultado", "Perdiste", "OK");
                    LabelPutosComputador.Text = (Convert.ToInt16(LabelPutosComputador.Text) + 1).ToString();
                }
                else if (eleccionComputador == 2)
                {
                    DisplayAlert("Resultado", "Ganaste", "OK");
                    LabelMisPuntos.Text = (Convert.ToInt16((LabelMisPuntos.Text) + 1)).ToString();
                }
                else
                {
                    DisplayAlert("Resultado", "Empate", "OK");
                }

            }




        }
    }
}