using GerenciamentoDeInventario;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace GerenciamentoDeInventarioUnitTest
{
    public class GerenciamentoDeInvetarioTest
    {
        [Fact]
        public void ValidateTheAddictionOfTheProductOnInventory()
        {
            List<Product> inventory = new List<Product>();

            Product.AddProductToInventory("video game",  inventory);
            Product.AddProductToInventory("video game", inventory);

            Product videoGame = inventory.FirstOrDefault(p => p.Name == "video game");

            Assert.Equal(1, inventory.Count);
            Assert.Equal(2, videoGame.Quantity);

        }

        [Fact]
        public void ValidateTheSearchOfTheQuantityOfTheProductInTheInventory()
        {
            List<Product> inventory = new List<Product>();

            inventory.Add(new Product()
            {
                Name = "notebook",
                Quantity = 4,
            });

            int quantity = Product.SearchQuantityOfAProductInTheInventory("notebook", inventory);

            Assert.Equal(4, quantity);


        }
    }
}
