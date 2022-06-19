namespace NumeroFaltantePrueba
{
    [TestClass]
    public class NumeroFaltanteUnitTest
    {
        [TestMethod]
        public void Prueba2315Regresa4()
        {
            //Arrange = Arreglar o adecuar la prueba unitaria
            Algoritmo AlgNumFaltante = new Algoritmo();
            int[] A_evaluada = {2,3,1,5};
            int obtenido;
            int esperado = 4;
            //Act = Actuar o realizar la prueba unitaria
            obtenido = AlgNumFaltante.EncuentraFaltante(A_evaluada);
            //Assert = Verificar que la prueba cumplio con la condicion
            Assert.AreEqual(obtenido, esperado);
        }
    }
}