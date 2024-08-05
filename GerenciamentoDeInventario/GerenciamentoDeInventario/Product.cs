using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeInventario
{
    public class Product
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; }
        public int Quantity { get; set; }

        public static void AddProductToInventory(string productName, List<Product> inventory)
        {
            Product produtcSearch = inventory.FirstOrDefault(product => product.Name == productName)!;

            if (produtcSearch != null) 
            {
                produtcSearch.Quantity++;
            } else
            {
                inventory.Add(new Product()
                {
                    Name = productName,
                    Quantity = 1
                });
            }
        }

        public static int SearchQuantityOfAProductInTheInventory(string productName, List<Product> inventory)
        {
            Product searchProduct = inventory.Find(p => p.Name == productName)!;

            return 3;
        }
    }
}
