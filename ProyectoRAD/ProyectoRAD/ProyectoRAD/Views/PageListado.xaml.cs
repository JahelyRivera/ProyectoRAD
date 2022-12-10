using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProyectoRAD.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageListado : ContentPage
    {
        public PageListado()
        {
            InitializeComponent();
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListadoA_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnEditar_Clicked(object sender, EventArgs e)
        {

        }

        private void BtnEliminar_Clicked(object sender, EventArgs e)
        {

        }
    }
}