using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public class Partida:IPartida
    {
        static Random generadorNumerosAleatorios = new Random();
    /*  Ámbitos de aplicación
     *  public
        Puede obtener acceso al tipo o miembro cualquier otro código del mismo ensamblado o de otro ensamblado que haga referencia a éste.
        private
        Solamente el código de la misma clase o estructura puede acceder al tipo o miembro.
        protected
        Solamente el código de la misma clase, o de una clase derivada de esa clase, puede acceder al tipo o miembro.
        internal
        Puede obtener acceso al tipo o miembro cualquier código del mismo ensamblado, pero no de un ensamblado distinto.
        protected internal 
        Cualquier código del ensamblado en el que se ha declarado, o desde cualquier clase derivada de otro ensamblado, puede acceder al tipo o miembro.
        private protected 
        El código de la misma clase, o de un tipo derivado de esa clase, puede acceder al tipo o miembro solo dentro de su ensamblado que declara.*/
        internal Partida(IJugador jugador, IContinente continente)
        {
            this.jugador = jugador;
            this.continente = continente;
            this.historicoPregunta = new List<IPregunta>();

        }
        public IJugador jugador { get; }
        public IContinente continente { get; }
        public List <IPregunta> historicoPregunta { get; }
        public IPregunta nuevaPregunta()
        {
            IPais pais = null;
            int total = this.continente.paises.Count;
            double numeroAleatorio = generadorNumerosAleatorios.NextDouble();
            int elElegido = (int) (numeroAleatorio * total);
            pais = this.continente.paises[elElegido];
            IPregunta p = new Pregunta(this, pais);
            historicoPregunta.Add(p);
            return p;
        }
            
    }
}
