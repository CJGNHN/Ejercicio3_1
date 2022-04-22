using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Ejercicio3_1.Models;
using Xamarin.Forms;

namespace Ejercicio3_1.ViewModels
{
    [QueryProperty(nameof(ItemId), nameof(ItemId))]
    public class ItemDetailViewModel : BaseViewModel
    {
        private string itemId;
        private string text;
        private string descripcion;
        public string Id { get; set; }

        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        public string Descripcion
        {
            get => descripcion;
            set => SetProperty(ref descripcion, value);
        }

        public string ItemId
        {
            get
            {
                return itemId;
            }
            set
            {
                itemId = value;
                LoadItemId(value);
            }
        }

        public async void LoadItemId(string itemId)
        {
            try
            {
                var item = await DataStore.GetItemAsync(itemId);
                Id = item.Id;
                Text = item.Text;
                Descripcion = item.Descripcion;
            }
            catch (Exception)
            {
                Debug.WriteLine("Error al cargar el Item");
            }
        }
    }
}
