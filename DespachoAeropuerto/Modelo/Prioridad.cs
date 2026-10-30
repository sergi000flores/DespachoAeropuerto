namespace DespachoAeropuerto.Modelo
{
    /// <summary>
    /// Nivel de prioridad de una aeronave. Un valor numérico MENOR significa
    /// MAYOR prioridad (1 = se atiende primero).
    /// </summary>
    public enum Prioridad
    {
        Emergencia = 1,
        CombustibleCritico = 2,
        Comercial = 3,
        Carga = 4,
        Privado = 5
    }
}
