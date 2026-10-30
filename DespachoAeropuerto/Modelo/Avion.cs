using System;

namespace DespachoAeropuerto.Modelo
{
    /// <summary>
    /// Representa una aeronave que espera pista para aterrizar o despegar.
    /// </summary>
    public class Avion
    {
        public int Id { get; }
        public string Vuelo { get; }
        public string Aerolinea { get; }
        public Prioridad Prioridad { get; }
        public Operacion Operacion { get; }
        public int Pasajeros { get; }
        public DateTime HoraLlegada { get; }
        public DateTime? HoraAtencion { get; set; }

        public Avion(int id, string vuelo, string aerolinea, Prioridad prioridad,
                     Operacion operacion, int pasajeros)
        {
            if (string.IsNullOrWhiteSpace(vuelo))
                throw new ArgumentException("El número de vuelo es obligatorio.", nameof(vuelo));
            if (pasajeros < 0)
                throw new ArgumentOutOfRangeException(nameof(pasajeros), "Los pasajeros no pueden ser negativos.");

            Id = id;
            Vuelo = vuelo.Trim().ToUpperInvariant();
            Aerolinea = aerolinea;
            Prioridad = prioridad;
            Operacion = operacion;
            Pasajeros = pasajeros;
            HoraLlegada = DateTime.Now;
        }

        /// <summary>Tiempo que lleva esperando (o esperó hasta ser atendido).</summary>
        public TimeSpan TiempoEspera
        {
            get { return (HoraAtencion ?? DateTime.Now) - HoraLlegada; }
        }

        public override string ToString()
        {
            return string.Format("{0} ({1}) - {2} - {3}", Vuelo, Aerolinea, Prioridad, Operacion);
        }
    }
}
