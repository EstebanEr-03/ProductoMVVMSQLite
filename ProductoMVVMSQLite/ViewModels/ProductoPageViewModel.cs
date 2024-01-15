using ProductoMVVMSQLite.Models;
using ProductoMVVMSQLite.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProductoMVVMSQLite.ViewModels
{
    public class ProductoPageViewModel
    {
        ObservableCollection<Producto> ListaProductos{get;set;}
        public ProductoPageViewModel() {
            ListaProductos = new ObservableCollection<Producto>(App.productoRepositorio.GetAll());
        }


        public ICommand CreateProducto =>
            new Command(async () =>
            {
                App.Current.MainPage.Navigation.PushAsync(new NuevoProductoPage());
            });
    }
}
