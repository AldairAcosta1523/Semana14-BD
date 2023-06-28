using Semana14.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Semana14.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListarProductos : ContentPage
    {
        public ListarProductos()
        {
            InitializeComponent();
            this.BindingContext = new ViewModelProducts();
        }
    }
}