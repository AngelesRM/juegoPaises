using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPaises
    {
        [TestMethod]
        public void TestEspa�aCapital()
        {
            Juego.dameElJuego();
            BaseDatosGeografica miBaseDatosGeografica = null;
            Pais espa�a = miBaseDatosGeografica.getPais ("Espa�a");
            Assert.AreEqual(espa�a.capital, "Madrid");
        }
        [TestMethod] 
        public void TestEspa�aNombre()
        {
            Pais espa�a = null;
            Assert.AreEqual(espa�a.nombre, "Espa�a");
        }
        [TestMethod]
        public void TestEspa�aContinente()
        {
            Pais espa�a = null;
            Continente europa = null;
            Assert.AreEqual(espa�a.continente, europa);
        }
    }
}
