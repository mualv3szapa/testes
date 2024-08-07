using APIparaTESTE.Domains;
using APIparaTESTE.Interfaces;
using Moq;

namespace APIs.Test
{
    public class ProductsTest
    {
        [Fact]
        public void Get()
        {
            //Arrange

            var products = new List<Product>
            {
                new() {IdProduct =Guid.NewGuid(), Name = "produtc1", Price = 90},
                new() {IdProduct =Guid.NewGuid(), Name = "produtc2", Price = 60},
                new() {IdProduct =Guid.NewGuid(), Name = "produtc3", Price = 30}
            };

            products.Remove(products.FirstOrDefault(x => x.Name == "produto1")!);

            //cria um objeto de simula��o do tipo ProductRepositoru
            var mockRepository = new Mock<IProductRepository>();

            //configura o m�todo de listar todos para que quando for acionado retorne a lista mockada
            mockRepository.Setup(x => x.Get()).Returns(products);

            //Act
            var result = mockRepository.Object.Get();

            var productsNames = result.Select(p => p.Name).ToList();

            //Assert
            mockRepository.Verify(x => x.Get(), Times.Once);
            Assert.Equal(2, result.Count);
            Assert.Contains("produto2", productsNames);
        }
        [Fact]
        public void Post()
        {
            var products = new List<Product>();

            var novoProduto = new Product { IdProduct = Guid.NewGuid(), Name = "Carro", Price = 100000 };

            var mockRepository = new Mock<IProductRepository>();

            mockRepository.Setup(x => x.Post(novoProduto)).Callback<Product>(x => products.Add(novoProduto));

            mockRepository.Object.Post(novoProduto);

            Assert.Contains(novoProduto, products);
        }

        [Fact]
        public void Delete()
        {
            var deleteProduct = new Product { IdProduct = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"), Name = "produto1", Price = 10 };
            var products = new List<Product>
            {
                deleteProduct,
                new Product{ IdProduct = Guid.NewGuid() , Name = "produto2", Price= 20 }
            };



            var mockRepository = new Mock<IProductRepository>();

            mockRepository.Setup(x => x.Delete(deleteProduct.IdProduct)).Callback(() => products.Remove(produtoparaapagar));

            mockRepository.Object.Delete(deleteProduct.IdProduct);

            Assert.DoesNotContain(deleteProduct, products);

        }

        [Fact]
        public void GetById()
        {
            var produtoparabuscar = new Product { IdProduct = Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"), Name = "produto1", Price = 10 };
            var products = new List<Product>
            {
                produtoparabuscar,
                new Product{ IdProduct = Guid.NewGuid() , Name = "produto2", Price= 20 }
            };
            var mockRepository = new Mock<IProductRepository>();

            mockRepository.Setup(x => x.Get(Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"))).Returns(produtoparabuscar);

            mockRepository.Object.Get(Guid.Parse("0f8fad5b-d9cb-469f-a165-70867728950e"));

            //Assert.True();
        }
    }
}