using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Continente:IContinente
    {
        internal Continente(string nombre) 
        {
            this.nombre = nombre;
            this.paises = new List<IPais>();
            this.misPaises = new Dictionary<string, IPais>();

        }

        private Dictionary<string , IPais> misPaises { get; }
        public string nombre { get; }
        /*Expresion lambda
         * Es una función sin nombre
         * (x)=>x*x
         * la función devuelve el cuadrado del número pasado como parámetro de entrada.
         * En una función inline 
         * se puede asignar una función a una variable*/
        public List<IPais> paises { get=> {return X;}}
        public IPais getPais(string nombrePais)
        {
            return this.misPaises[nombrePais];
        }

        internal void asignarPais (IPais nuevoPais)
        {
            this.misPaises.Add(nuevoPais.nombre, nuevoPais);
        }
    }
}