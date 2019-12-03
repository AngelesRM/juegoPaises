using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasLibreria
{
    class PruebasContinentes
    {
        [TestMethod]
        public void TestEuropaNombre()
        {
            IBaseDatosGeografica miBaseDatosGeografica = IJuego.dameElJuego().baseDatosGeografica;
            //Juego.dameElJuego();
            //BaseDatosGeografica miBaseDatosGeografica = null;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreEqual(europa.nombre, "Europa");
        }
        [TestMethod]
        public void TestEuropaEspaña()
        {
            IBaseDatosGeografica miBaseDatosGeografica = IJuego.dameElJuego().baseDatosGeografica;
            IPais españa = miBaseDatosGeografica.getPais("España");
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.IsNotNull(españa);
        }
        [TestMethod]
        public void TestEuropaNewZeland()
        {
            IBaseDatosGeografica miBaseDatosGeografica = IJuego.dameElJuego().baseDatosGeografica;
            IPais newzeland = miBaseDatosGeografica.getPais("New Zeland");
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.IsNotNull(newzeland);
        }
        [TestMethod]
        public void TestEuropaPaises()
        {
            IBaseDatosGeografica miBaseDatosGeografica = IJuego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreNotEqual(europa.paises.Count, 0);
        }
    }
}
