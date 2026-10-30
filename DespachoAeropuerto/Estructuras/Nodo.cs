namespace DespachoAeropuerto.Estructuras
{
    /// <summary>Nodo de una lista enlazada simple.</summary>
    public class Nodo<T>
    {
        public T Dato { get; set; }
        public Nodo<T> Siguiente { get; set; }

        public Nodo(T dato)
        {
            Dato = dato;
            Siguiente = null;
        }
    }
}
