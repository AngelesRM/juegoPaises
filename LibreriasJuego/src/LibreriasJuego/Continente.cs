using System.Collections.Generic;

namespace LibreriasJuego
{
    public class Continente:IContinente
    {
        public Continente(string nombre) 
        {
            this.nombre = nombre;
            //this.paises = new IList<IPais>();
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
        public IList<IPais> paises { get => new List<IPais>(this.misPaises.Values).AsReadOnly(); } //Al no haber set no se puede redefinir la lista, al poner readonly no permite modificarla
    
        public IPais getPais(string nombrePais)
        {
            return this.misPaises[nombrePais];
        }

        public void asignarPais (IPais nuevoPais)
        {
               this.misPaises.Add(nuevoPais.nombre, nuevoPais);
            
        }
    }
}