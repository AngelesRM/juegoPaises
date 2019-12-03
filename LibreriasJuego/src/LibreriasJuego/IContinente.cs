using System.Collections.Generic;

namespace LibreriasJuego
{
    public interface IContinente
    {
        public string nombre { get; }
        public List<IPais> paises { get; }
        public IPais getPais(string nombrePais);

    }
}