﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LibreriasJuego
{
    public interface IPregunta
    {
        public IPartida partida { get; }
        public IPais pais { get; }
        public bool proponerRespuesta(string capitalSugerida);
        public int intentosRestantes { get; }
        public List<string> respuestasPropuestas { get; }

        public bool acierto { get; }

    }
}
