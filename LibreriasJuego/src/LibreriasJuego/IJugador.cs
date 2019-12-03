using System;
using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IJugador
    {
        string nombre { get; }
        public List <IPartida> historicoPartidas { get; }
        public IPartida nuevaPartida(IContinente continenteElegido);
    }
}
