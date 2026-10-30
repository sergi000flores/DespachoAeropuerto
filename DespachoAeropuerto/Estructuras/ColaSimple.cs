using System;
using System.Collections.Generic;

namespace DespachoAeropuerto.Estructuras
{
    /// <summary>
    /// Cola FIFO implementada con lista enlazada simple (punteros al primero y
    /// al último nodo). Encolar y Desencolar son O(1).
    /// </summary>
    public class ColaSimple<T>
    {
        private Nodo<T> primero;
        private Nodo<T> ultimo;

        public int Cantidad { get; private set; }

        public bool EstaVacia
        {
            get { return Cantidad == 0; }
        }

        public void Encolar(T dato)
        {
            Nodo<T> nuevo = new Nodo<T>(dato);
            if (ultimo == null)
            {
                primero = nuevo;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                ultimo = nuevo;
            }
            Cantidad++;
        }

        public T Desencolar()
        {
            if (EstaVacia)
                throw new InvalidOperationException("La cola está vacía.");

            T dato = primero.Dato;
            primero = primero.Siguiente;
            if (primero == null)
                ultimo = null;
            Cantidad--;
            return dato;
        }

        public T Frente()
        {
            if (EstaVacia)
                throw new InvalidOperationException("La cola está vacía.");
            return primero.Dato;
        }

        public void Limpiar()
        {
            primero = null;
            ultimo = null;
            Cantidad = 0;
        }

        /// <summary>Recorre los elementos de frente a final sin modificarlos.</summary>
        public IEnumerable<T> Recorrer()
        {
            Nodo<T> actual = primero;
            while (actual != null)
            {
                yield return actual.Dato;
                actual = actual.Siguiente;
            }
        }
    }
}
