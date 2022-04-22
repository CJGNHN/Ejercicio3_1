using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Ejercicio3_1.Models;

namespace Ejercicio3_1.Services
{
    public class MockDataStore : IDataStore<Item>
    {
        readonly List<Item> items;

        public MockDataStore()
        {
            items = new List<Item>()
            {
                new Item { Id = Guid.NewGuid().ToString(), Text = "Primer item", Descripcion="Esta es una descripcion." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Segundo item", Descripcion="Esta es una descripcion." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Tercer item", Descripcion="Esta es una descripcion." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Cuarto item", Descripcion="Esta es una descripcion." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Quinto item", Descripcion="Esta es una descripcion." },
                new Item { Id = Guid.NewGuid().ToString(), Text = "Sexto item", Descripcion="Esta es una descripcion." }
            };
        }

        public async Task<bool> AddItemAsync(Item item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Item item)
        {
            var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Item> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}