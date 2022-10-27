using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RonaldGubioCh
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

       


        private void Button_Clicked(object sender, EventArgs e)
        {
            string usuario = "ronaldgubio2022";
            string clave = "uisrael2022";

            string tUsuario = txtUsuario.Text;
            string tContrasenia = txtClave.Text;

            if (usuario == tUsuario & clave == tContrasenia)
            {
               // DisplayAlert("Ops", "es correcto", "OK");
                Navigation.PushAsync(new Registro(txtUsuario.Text, txtClave.Text));
              //  Navigation.PushAsync(new Resumen(txtUsuario.Text, txtClave.Text));
            }
            else
            {
                DisplayAlert("Ops", "Usuario  no contraseña incorrectos", "OK");

            }
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registro(txtUsuario.Text, txtClave.Text));
          //  Navigation.PushAsync(new Resumen(txtUsuario.Text, txtClave.Text));
        }

        }
    }
