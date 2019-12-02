using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface Pregunta
    {
        public Partida partida { get; }
        public Pais pais { get; }
        public bool proponerRespuesta(string capitalSugerida);
        public int intentosRestantes { get; }
        public List<string> respuestasPropuestas { get; }

        public bool acierto { get; }

    }
}
