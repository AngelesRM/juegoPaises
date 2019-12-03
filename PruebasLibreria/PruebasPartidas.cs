using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPartidas
    {
        [TestMethod]
        public void TestRecuperarListaPartidas()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador pepe = miBaseDatosJugadores.getJugador("Pepe");
            Assert.IsNotNull(pepe.historicoPartidas);
        }
        [TestMethod]
        public void TestNuevaPartida1()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador pepe = miBaseDatosJugadores.getJugador("Pepe");
            IContinente europa = IJuego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = pepe.nuevaPartida(europa);
            Assert.IsNotNull(partida);
        }
        [TestMethod]
        public void TestNuevaPartida2()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador pepe = miBaseDatosJugadores.getJugador("Pepe");
            
            int cuantasLlevaba = pepe.historicoPartidas.Count;
            IContinente europa = IJuego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = pepe.nuevaPartida(europa);

            int cuantasLleva = pepe.historicoPartidas.Count;
            //Comprueba que se ha añadido una partida a la lista
            Assert.AreEqual(cuantasLlevaba + 1, cuantasLleva);
            //Comprueba que la partida añadida es la última
            Assert.AreEqual (pepe.historicoPartidas[pepe.historicoPartidas.Count - 1], partida);
        }
    }
}
