using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasContinentes
    {
        [TestMethod]
        public void TestEuropaNombre()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            //Juego.dameElJuego();
            //BaseDatosGeografica miBaseDatosGeografica = null;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreEqual(europa.nombre, "Europa");
        }
        [TestMethod]
        public void TestEuropaEspaña()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IPais españa = miBaseDatosGeografica.getPais("España");
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.IsNotNull(españa);
        }
        [TestMethod]
        public void TestEuropaNewZeland()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            //IPais newzeland = europa.getPais("Nueva Zelanda");
            Action funcionalaquesellama = recuperarNuevaZelanda;
            //Assert.ThrowsException<KeyNotFoundException>(funcionalaquesellama);
            Assert.ThrowsException<KeyNotFoundException>(()=>europa.getPais("Nueva Zelanda"));
        }
        void recuperarNuevaZelanda()
        {
            throw new KeyNotFoundException("Nueva Zelanda no existe");
        }
        [TestMethod]
        public void TestEuropaPaises()
        {
            IBaseDatosGeografica miBaseDatosGeografica = Juego.dameElJuego().baseDatosGeografica;
            IContinente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreNotEqual(europa.paises.Count, 0);
        }
    }
}
