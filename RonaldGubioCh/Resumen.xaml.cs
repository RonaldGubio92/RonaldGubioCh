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
    public partial class Resumen : ContentPage
    {
        public Resumen(string usuario, double montoInicial, String estudiante)
        {
            InitializeComponent();
           lblUsuario.Text = "" + usuario;
          txtEstudiante.Text = "" + estudiante;
            txtTotal.Text = "" + montoInicial;
        }
    }
}