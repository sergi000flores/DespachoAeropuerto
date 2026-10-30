using System;
using System.Collections.Generic;

namespace DespachoAeropuerto.Estructuras
{
    /// <summary>
    /// Cola de prioridad con niveles discretos: un arreglo de colas FIFO,
    /// una por nivel (1 = mayor prioridad). Dentro de un mismo nivel se respeta
    /// el orden de llegada.
    /// Encolar: O(1). Desencolar: O(k), con k = número de niveles (constante).
    /// </summary>
    public class ColaPrioridad<T>
    {
        private readonly ColaSimple<T>[] colas;

        public int Niveles { get; }

        public ColaPrioridad(int niveles)
        {
            if (niveles <= 0)
                throw new ArgumentOutOfRangeException(nameof(niveles), "Debe haber al menos un nivel.");

            Niveles = niveles;
            colas = new ColaSimple<T>[niveles];
            for (int i = 0; i < niveles; i++)
                colas[i] = new ColaSimple<T>();
        }

        public int Cantidad
        {
            get
            {
                int total = 0;
                for (int i = 0; i < Niveles; i++)
                    total += colas[i].Cantidad;
                return total;
            }
        }

        public bool EstaVacia
        {
            get { return Cantidad == 0; }
        }

        /// <param name="prioridad">Nivel de 1 (más urgente) a Niveles (menos urgente).</param>
        public void Encolar(T dato, int prioridad)
        {
            colas[IndiceDe(prioridad)].Encolar(dato);
        }

        /// <summary>Extrae el elemento más urgente (y más antiguo de su nivel).</summary>
        public T Desencolar()
        {
            for (int i = 0; i < Niveles; i++)
            {
                if (!colas[i].EstaVacia)
                    return colas[i].Desencolar();
            }
            throw new InvalidOperationException("La cola de prioridad está vacía.");
        }

        /// <summary>Consulta el siguiente elemento a atender sin extraerlo.</summary>
        public T Frente()
        {
            for (int i = 0; i < Niveles; i++)
            {
                if (!colas[i].EstaVacia)
                    return colas[i].Frente();
            }
            throw new InvalidOperationException("La cola de prioridad está vacía.");
        }

        public int CantidadEnNivel(int prioridad)
        {
            return colas[IndiceDe(prioridad)].Cantidad;
        }

        public void Limpiar()
        {
            for (int i = 0; i < Niveles; i++)
                colas[i].Limpiar();
        }

        /// <summary>Recorre los elementos en el orden exacto en que serán atendidos.</summary>
        public IEnumerable<T> Recorrer()
        {
            for (int i = 0; i < Niveles; i++)
            {
                foreach (T dato in colas[i].Recorrer())
                    yield return dato;
            }
        }

        private int IndiceDe(int prioridad)
        {
            if (prioridad < 1 || prioridad > Niveles)
                throw new ArgumentOutOfRangeException(nameof(prioridad),
                    "La prioridad debe estar entre 1 y " + Niveles + ".");
            return prioridad - 1;
        }
    }
}
