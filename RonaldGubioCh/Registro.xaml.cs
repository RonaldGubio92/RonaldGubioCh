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
    public partial class Registro : ContentPage
    {
        public Registro(string usuario, string contrasena)
        {
            InitializeComponent();

            lblUsuario.Text = "Usuario conectado es:" + usuario;
           
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {

           

            double TotalCurso = 3000;
            double MontoInicial =0;
            try
            {
                MontoInicial = Convert.ToDouble(txtMonto.Text);
            }catch(Exception)
            {
                DisplayAlert("ERROR", "No es un numero", "Aceptar");
                return;
            }

            double restante = TotalCurso - MontoInicial;
            double cuotas = Convert.ToDouble(5);
            double sinInteres = restante / cuotas;
            double interes = TotalCurso * 0.05;

            double cuotaTotalMensual = sinInteres + interes;

            double totalCuotas = cuotaTotalMensual * 5;

            double totalFinalPagar = MontoInicial + totalCuotas;

            txtPagoM.Text = cuotaTotalMensual.ToString();

           // DisplayAlert("Ops", "El total valor a pagar es : "+totalFinalPagar, "OK");


        }

        private async void txtPagoM_TextChanged(object sender, TextChangedEventArgs e)
        {
           
           
        }

        private void txtMonto_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                Entry ent = (sender as Entry);
                if (!String.IsNullOrEmpty(ent.Text))
                {
                    int valor = Convert.ToInt32(ent.Text);

                    if (valor < 1 || valor > 3000)
                    {
                        DisplayAlert("Alerta", "El valor es mayor al permitido", "Cerrar");
                        ent.Focus();
                        ent.Text = String.Empty;
                    }
                }

            }
            catch
            {
                DisplayAlert("Alerta", "Formato incorrecto", "Cerrar");
            }
           


           
        }

        private void btnResumen_Clicked(object sender, EventArgs e)
        {
            if(txtEstudiante.Text is null || txtEstudiante.Text.Length==0)
            {
                DisplayAlert("Alerta", "Estudiante no ha sido ingresado.", "Cerrar");
                return;
            }
            double TotalCurso = 3000;
            double MontoInicial = 0;
            try
            {
                MontoInicial = Convert.ToDouble(txtMonto.Text);
            }catch(Exception)
            {
                DisplayAlert("ERROR", "Monto inicial no es un numero", "Aceptar");
                return;
            }
    double restante = TotalCurso - MontoInicial;
            double cuotas = Convert.ToDouble(5);
            double sinInteres = restante / cuotas;
            double interes = TotalCurso * 0.05;

            double cuotaTotalMensual = sinInteres + interes;

            double totalCuotas = cuotaTotalMensual * 5;

            double totalFinalPagar = MontoInicial + totalCuotas;

            txtPagoM.Text = cuotaTotalMensual.ToString();


            double montoInicial;
            montoInicial = Convert.ToDouble(txtPagoM.Text);
            Navigation.PushAsync(new Resumen(lblUsuario.Text, totalFinalPagar, txtEstudiante.Text));
        }
    }
}