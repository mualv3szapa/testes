using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculos.Test
{
    public class CalculoUnitTest
    {
        [Fact]
        public void SomarDoisNumeros()
        {
            var n1 = 3.3;
            var n2 = 2.2;
            var valorEsperado = 5.5;

            var soma = Calculo.Somar(n1,n2);

            Assert.Equal(valorEsperado, soma);

        }
        [Fact]
        public void SubtrairDoisNumeros()
        {
            var n1 = 3.3;
            var n2 = 2.2;
            var valorEsperado = 1.1;

            var subtrair = Calculo.Subtrair(n1,n2);

            Assert.Equal(valorEsperado, subtrair);

        }
        [Fact]
        public void MultiplicarDoisNumeros()
        {
            var n1 = 3.3;
            var n2 = 2.2;
            var valorEsperado = 6.6;

            var multiplicar = Calculo.Multiplicar(n1,n2);

            Assert.Equal(valorEsperado, multiplicar);

        }
        [Fact]
        public void DividirDoisNumeros()
        {
            var n1 = 6.6;
            var n2 = 2.2;
            var valorEsperado = 3.3;

            var dividir = Calculo.Dividir(n1,n2);

            Assert.Equal(valorEsperado, dividir);

        }
    }
}
