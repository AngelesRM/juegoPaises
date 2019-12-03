using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class IJuego
    {
         /*Patrón SINGLETON básico
          Permite tener una ÚNICA instancia de la clase*/
        private IJuego()
        {
            baseDatosJugadores = null;
            baseDatosGeografica = null;

        }
        private static IJuego elJuego;
        public static IJuego dameElJuego ()
        {
            if (elJuego == null)
                elJuego = new IJuego();
            return elJuego;
        }
    /*Fin patrón*/

        public IBaseDatosJugadores baseDatosJugadores { get; }
        public IBaseDatosGeografica baseDatosGeografica { get; }
    }
}
