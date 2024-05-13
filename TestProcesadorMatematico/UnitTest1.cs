using Xunit;


namespace TestProcesadorMatematico
{
    public class UnitTest1
    {
        
     

        [Theory]
        [InlineData(9, 5, 14)]
        [InlineData(9, 4, 13)]
        [InlineData(9, 3, 12)]
        public void TestSumar(int numero1, int numero2, int resultadoEsperado)
        {
            // Crea una instancia válida de ProcesadorMatematico
            var procesadorMatematico = new primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico();

            // Act
            procesadorMatematico.Sumar(numero1, numero2);

            // Assert
            Assert.Equal(procesadorMatematico._resultado, resultadoEsperado);
        }




        [Theory]

        [InlineData(9, 3, 3)]
        [InlineData(12, -3, 0)]
        [InlineData(15, 3, 5)]
        public void TestDividir(int numero1, int numero2, int resultadoEsperado)
        {

            var procesadorMatematico = new primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico();

            //Act
            procesadorMatematico.Dividir(numero1, numero2);

            //Assert
            Assert.Equal(procesadorMatematico._resultado, resultadoEsperado);
        }

        

        [Theory]
        [InlineData(9, 5, 9)]
        [InlineData(9, 4, 9)]
        [InlineData(9, 3, 9)]
        public void TestCalcularMayor(int numero1, int numero2, int resultadoEsperado)
        {

            var procesadorMatematico = new primer_parcial_unit_test_procesador_matematico.ProcesadorMatematico();

            //Act
            procesadorMatematico.CalcularMayor(numero1, numero2);

            //Assert
            Assert.Equal(procesadorMatematico._resultado, resultadoEsperado);

        }







    }
}