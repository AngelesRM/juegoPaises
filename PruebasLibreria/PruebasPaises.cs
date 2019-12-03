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
            IBaseDatosGeografica miBaseDatosGeografica = IJuego.dameElJuego().baseDatosGeografica;
            //Juego.dameElJuego();
            //BaseDatosGeografica miBaseDatosGeografica = null;
            IPais espa�a = miBaseDatosGeografica.getPais ("Espa�a");
            Assert.AreEqual(espa�a.capital, "Madrid");
        }
        [TestMethod] 
        public void TestEspa�aNombre()
        {
            IBaseDatosGeografica miBaseDatosGeografica = IJuego.dameElJuego().baseDatosGeografica;
            IPais espa�a = miBaseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.nombre, "Espa�a");
        }
        [TestMethod]
        public void TestEspa�aContinente()
        {
            IBaseDatosGeografica miBaseDatosGeografica = IJuego.dameElJuego().baseDatosGeografica;
            IPais espa�a = miBaseDatosGeografica.getPais("Espa�a");
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreEqual(espa�a.continente, europa);
        }
    }
}
