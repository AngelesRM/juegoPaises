using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPreguntas
    {

        [TestMethod]
        public void TestNuevaPregunta()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador pepe = miBaseDatosJugadores.getJugador("Pepe");
            IContinente europa = IJuego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = pepe.nuevaPartida(europa);
            IPregunta pregunta =partida.nuevaPregunta();
            Assert.IsNotNull(pregunta);
            Assert.IsNotNull(pregunta.pais);

        }
        [TestMethod]
        public void TestRespuestaFallida()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador pepe = miBaseDatosJugadores.getJugador("Pepe");
            IContinente europa = IJuego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = pepe.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            bool resultado = pregunta.proponerRespuesta("Paris");
            Assert.IsFalse(resultado);
        }
        [TestMethod]
        public void TestRespuestasMultiplesFallidas()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador pepe = miBaseDatosJugadores.getJugador("Pepe");
            IContinente europa = IJuego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = pepe.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            int intentos = pregunta.intentosRestantes;
            Assert.AreEqual(intentos, 3);

            pregunta.proponerRespuesta("Desconocida");
            pregunta.proponerRespuesta("Desconocida");
            pregunta.proponerRespuesta("Desconocida");
            intentos = pregunta.intentosRestantes;
            Assert.AreEqual(intentos, 0);
            //pregunta.proponerRespuesta("Desconocida");
        }
        [TestMethod]
        public void TestRespuestaCorrecta()
        {
            IBaseDatosJugadores miBaseDatosJugadores = IJuego.dameElJuego().baseDatosJugadores;
            IJugador pepe = miBaseDatosJugadores.getJugador("Pepe");
            IContinente europa = IJuego.dameElJuego().baseDatosGeografica.getContinente("Europa");
            IPartida partida = pepe.nuevaPartida(europa);
            IPregunta pregunta = partida.nuevaPregunta();
            bool resultado = pregunta.proponerRespuesta(pregunta.pais.capital);
            Assert.IsTrue(resultado);
        }
    }
}
