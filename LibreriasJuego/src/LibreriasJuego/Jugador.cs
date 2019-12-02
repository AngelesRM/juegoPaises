using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface Jugador
    {
        string nombre { get; }
        public List <Partida> historicoPartidas { get; }
        public Partida nuevaPartida(Continente continenteElegido);
    }
}
