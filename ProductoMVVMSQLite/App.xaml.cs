using ProductoMVVMSQLite.Services;
using ProductoMVVMSQLite.Views;

namespace ProductoMVVMSQLite
{
    public partial class App : Application
    {
        public static ProductoRepositorio productoRepositorio { get; set; }
        public App()
        {
            InitializeComponent();
            productoRepositorio = new ProductoRepositorio();
            MainPage = new NavigationPage(new ProductoPage());
        }
    }
}
