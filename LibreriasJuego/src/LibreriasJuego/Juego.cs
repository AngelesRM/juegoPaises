using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Juego
    {
         /*Patrón SINGLETON básico
          Permite tener una ÚNICA instancia de la clase*/
        private Juego()
        {
            baseDatosJugadores = null;

        }
       private static Juego elJuego;
        public static Juego dameElJuego ()
        {
            if (elJuego == null)
                elJuego = new Juego();
            return elJuego;
        }
    /*Fin patrón*/

        public BaseDatosJugadores baseDatosJugadores { get; }
        public BaseDatosGeografica baseDatosGeografica { get; }
    }
}
