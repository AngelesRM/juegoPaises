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
            IBaseDatosGeografica miBaseDatosGeografica = IJuego.dameElJuego().baseDatosGeografica;
            //Juego.dameElJuego();
            //BaseDatosGeografica miBaseDatosGeografica = null;
            IPais españa = miBaseDatosGeografica.getPais ("España");
            Assert.AreEqual(españa.capital, "Madrid");
        }
        [TestMethod] 
        public void TestEspañaNombre()
        {
            IBaseDatosGeografica miBaseDatosGeografica = IJuego.dameElJuego().baseDatosGeografica;
            IPais españa = miBaseDatosGeografica.getPais("España");
            Assert.AreEqual(españa.nombre, "España");
        }
        [TestMethod]
        public void TestEspañaContinente()
        {
            IBaseDatosGeografica miBaseDatosGeografica = IJuego.dameElJuego().baseDatosGeografica;
            IPais españa = miBaseDatosGeografica.getPais("España");
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreEqual(españa.continente, europa);
        }
    }
}
