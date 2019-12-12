using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    //Clase abstracta solo permite instanciarla, algo así como una interfaz pero con código

    //where obliga a que la clase extienda de IJuego
    public abstract class IJuego <T> where T:IJuego<T>    
    {
       //    /*Patrón SINGLETON básico
        //      Permite tener una ÚNICA instancia de la clase*/
         private static IJuego<T> instancia;
        private static readonly object testigo = new object();

        //A las bases de datos se les puede indicar cual queremos usar. Por eso hemos añadido el set (protected para que no lo pueda usar cualquiera)
        public IBaseDatosJugadores baseDatosJugadores { get; protected set; }
        public IBaseDatosGeografica baseDatosGeografica { get; protected set; }

        public static IJuego<T> dameElJuego()
        {
            // lock: la instancia coge el testigo y bloquea. Una vez que está cogido el testigo los demás que intentan entrar
            //se quedan encolados esperando hasta que el testigo se libera. El primer if lo que hace es no encolar y crear
            //problemas de bloqueos, si la instancia ya existe sale sin enconlar en el bloqueo
            if (instancia == null)
            {
                lock (testigo)
                {
                    if (instancia == null)
                    {
                        //equivale a un new de la clase que nos han pasado de forma dinámica
                        instancia = Activator.CreateInstance(typeof(T), true) as T;
                    }
                }
            }
            return instancia;
        }


        //    private Juego()
        //    {
        //        baseDatosJugadores = new BaseDatosJugadoresCutre();
        //        baseDatosGeografica = new BaseDatosGeografica();

        //    }
        //    private static Juego elJuego;
        //    public static Juego dameElJuego ()
        //    {
        //        if (elJuego == null)
        //            elJuego = new Juego();
        //        return elJuego;
        //    }
        ///*Fin patrón*/

        //    public IBaseDatosJugadores baseDatosJugadores { get; }
        //    public IBaseDatosGeografica baseDatosGeografica { get; }
    }
}
