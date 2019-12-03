using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasJugador
    {
        [TestMethod]
        //Prueba Alta
        public void TestAltaJugador()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador pepe = miBaseDatosJugadores.nuevoJugador("Pepe");
            Assert.IsNotNull(pepe);
        }
        [TestMethod]
        //Prueba Recuperacion
        public void TestRecuperacionJugador()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador pepe = miBaseDatosJugadores.getJugador("Pepe");
            Assert.IsNotNull(pepe);
        }
        [TestMethod]
        //Prueba Nombre
        public void TestPepeNombre()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador pepe = miBaseDatosJugadores.getJugador("Pepe");
            Assert.AreEqual(pepe.nombre, "Pepe");
        }

    }
}
