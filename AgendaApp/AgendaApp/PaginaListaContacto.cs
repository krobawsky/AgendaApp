using System.Linq;
using Xamarin.Forms;

namespace AgendaApp
{
    public class PaginaListaContacto : MasterDetailPage
    {
        public PaginaListaContacto()
        {
            var lista = new ListView
            {
                ItemsSource = GeneradorDeContactos.CrearContactos().OrderBy(x => x.nombre)
            };

            lista.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Detail = new PaginaContacto(e.SelectedItem as Contacto);
                    IsPresented = false;
                }
            };

            Master = new ContentPage
            {
                Title = "Contactos",
                Content = lista
            };

            Detail = new PaginaContacto(GeneradorDeContactos.CrearContactos().First());
        }
    }
}
