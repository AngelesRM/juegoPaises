using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPaises
    {
        [TestMethod]
        public void TestEspañaCapital()
        {
            Juego.dameElJuego();
            BaseDatosGeografica miBaseDatosGeografica = null;
            Pais españa = miBaseDatosGeografica.getPais ("España");
            Assert.AreEqual(españa.capital, "Madrid");
        }
        [TestMethod] 
        public void TestEspañaNombre()
        {
            Pais españa = null;
            Assert.AreEqual(españa.nombre, "España");
        }
        [TestMethod]
        public void TestEspañaContinente()
        {
            Pais españa = null;
            Continente europa = null;
            Assert.AreEqual(españa.continente, europa);
        }
    }
}
