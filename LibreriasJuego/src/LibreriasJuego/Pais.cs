namespace LibreriasJuego
{
    public interface Pais
    {
        public string nombre { get; }
        public string capital { get; }
        public Continente continente { get; }
    }
}