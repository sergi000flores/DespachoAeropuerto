using System;
using System.Drawing;
using System.Windows.Forms;
using DespachoAeropuerto.Estructuras;
using DespachoAeropuerto.Modelo;

namespace DespachoAeropuerto
{
    public partial class Form1 : Form
    {
        // Cola de prioridad con 5 niveles (uno por cada valor del enum Prioridad).
        private readonly ColaPrioridad<Avion> cola = new ColaPrioridad<Avion>(5);
        private readonly Random azar = new Random();

        private int contadorId = 1;
        private int atendidos = 0;
        private double totalEsperaSegundos = 0;

        private static readonly string[] Aerolineas =
        {
            "Aeroméxico", "Volaris", "VivaAerobus", "Delta", "American Airlines",
            "Carga Express", "Aviación Privada"
        };

        private static readonly string[] Prefijos = { "AM", "Y4", "VB", "DL", "AA", "CX", "PV" };

        public Form1()
        {
            InitializeComponent();
            ConfigurarGrid();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbAerolinea.Items.AddRange(Aerolineas);
            cmbAerolinea.SelectedIndex = 0;

            cmbPrioridad.DataSource = Enum.GetValues(typeof(Prioridad));
            cmbPrioridad.SelectedItem = Prioridad.Comercial;

            cmbOperacion.DataSource = Enum.GetValues(typeof(Operacion));

            ActualizarVista();
        }

        private void ConfigurarGrid()
        {
            dgvCola.AllowUserToAddRows = false;
            dgvCola.AllowUserToDeleteRows = false;
            dgvCola.ReadOnly = true;
            dgvCola.RowHeadersVisible = false;
            dgvCola.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCola.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvCola.Columns.Add("colPos", "Turno");
            dgvCola.Columns.Add("colVuelo", "Vuelo");
            dgvCola.Columns.Add("colAerolinea", "Aerolínea");
            dgvCola.Columns.Add("colPrioridad", "Prioridad");
            dgvCola.Columns.Add("colOperacion", "Operación");
            dgvCola.Columns.Add("colPasajeros", "Pasajeros");
            dgvCola.Columns.Add("colEspera", "Espera");
            dgvCola.Columns["colPos"].FillWeight = 40;
            dgvCola.Columns["colPasajeros"].FillWeight = 60;
            dgvCola.Columns["colEspera"].FillWeight = 60;
        }

        // ---------------------------------------------------------------
        // Eventos
        // ---------------------------------------------------------------

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string vuelo = txtVuelo.Text.Trim().ToUpperInvariant();

            if (vuelo.Length == 0)
            {
                MessageBox.Show("Escribe el número de vuelo.", "Dato requerido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVuelo.Focus();
                return;
            }

            if (ExisteVuelo(vuelo))
            {
                MessageBox.Show("El vuelo " + vuelo + " ya está en la cola.", "Vuelo duplicado",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVuelo.Focus();
                return;
            }

            Avion avion = new Avion(
                contadorId++,
                vuelo,
                cmbAerolinea.SelectedItem.ToString(),
                (Prioridad)cmbPrioridad.SelectedItem,
                (Operacion)cmbOperacion.SelectedItem,
                (int)numPasajeros.Value);

            cola.Encolar(avion, (int)avion.Prioridad);

            txtVuelo.Clear();
            txtVuelo.Focus();
            ActualizarVista();
        }

        private void btnAleatorio_Click(object sender, EventArgs e)
        {
            int indiceAerolinea = azar.Next(Aerolineas.Length);
            string vuelo;
            do
            {
                vuelo = Prefijos[indiceAerolinea] + azar.Next(100, 1000);
            }
            while (ExisteVuelo(vuelo));

            // Las emergencias son raras: se generan con baja probabilidad.
            int sorteo = azar.Next(100);
            Prioridad prioridad;
            if (sorteo < 8) prioridad = Prioridad.Emergencia;
            else if (sorteo < 20) prioridad = Prioridad.CombustibleCritico;
            else if (sorteo < 70) prioridad = Prioridad.Comercial;
            else if (sorteo < 85) prioridad = Prioridad.Carga;
            else prioridad = Prioridad.Privado;

            Operacion operacion = azar.Next(2) == 0 ? Operacion.Aterrizaje : Operacion.Despegue;

            Avion avion = new Avion(contadorId++, vuelo, Aerolineas[indiceAerolinea],
                prioridad, operacion, azar.Next(0, 301));

            cola.Encolar(avion, (int)avion.Prioridad);
            ActualizarVista();
        }

        private void btnDespachar_Click(object sender, EventArgs e)
        {
            DespacharSiguiente();
        }

        private void btnAuto_Click(object sender, EventArgs e)
        {
            tmrSimulacion.Enabled = !tmrSimulacion.Enabled;
            btnAuto.Text = tmrSimulacion.Enabled ? "Detener automático" : "Iniciar automático";
        }

        private void tmrSimulacion_Tick(object sender, EventArgs e)
        {
            // En modo automático también llegan aviones nuevos (30% de probabilidad por ciclo).
            if (azar.Next(100) < 30)
                btnAleatorio_Click(sender, e);

            DespacharSiguiente();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tmrSimulacion.Enabled = false;
            btnAuto.Text = "Iniciar automático";

            cola.Limpiar();
            lstHistorial.Items.Clear();
            contadorId = 1;
            atendidos = 0;
            totalEsperaSegundos = 0;

            lblPista.Text = "Pista libre";
            lblPista.BackColor = Color.Honeydew;
            ActualizarVista();
        }

        // ---------------------------------------------------------------
        // Lógica de la simulación
        // ---------------------------------------------------------------

        private void DespacharSiguiente()
        {
            if (cola.EstaVacia)
            {
                lblPista.Text = "Pista libre\n(no hay aeronaves en espera)";
                lblPista.BackColor = Color.Honeydew;
                return;
            }

            Avion avion = cola.Desencolar();
            avion.HoraAtencion = DateTime.Now;

            atendidos++;
            totalEsperaSegundos += avion.TiempoEspera.TotalSeconds;

            lblPista.Text = string.Format("PISTA OCUPADA\n{0} - {1}", avion.Vuelo, avion.Operacion);
            lblPista.BackColor = ColorDe(avion.Prioridad);

            lstHistorial.Items.Insert(0, string.Format("{0:HH:mm:ss}  {1,-8} {2,-18} {3,-11} {4,-20} espera {5:mm\\:ss}",
                avion.HoraAtencion.Value, avion.Vuelo, avion.Aerolinea, avion.Operacion,
                avion.Prioridad, avion.TiempoEspera));

            ActualizarVista();
        }

        private bool ExisteVuelo(string vuelo)
        {
            foreach (Avion a in cola.Recorrer())
            {
                if (a.Vuelo == vuelo)
                    return true;
            }
            return false;
        }

        private void ActualizarVista()
        {
            dgvCola.Rows.Clear();

            int turno = 1;
            foreach (Avion a in cola.Recorrer())
            {
                int fila = dgvCola.Rows.Add(turno++, a.Vuelo, a.Aerolinea, a.Prioridad,
                    a.Operacion, a.Pasajeros, a.TiempoEspera.ToString("mm\\:ss"));
                dgvCola.Rows[fila].DefaultCellStyle.BackColor = ColorDe(a.Prioridad);
            }
            dgvCola.ClearSelection();

            lblEnCola.Text = "En espera: " + cola.Cantidad;
            lblAtendidos.Text = "Atendidos: " + atendidos;

            double promedio = atendidos == 0 ? 0 : totalEsperaSegundos / atendidos;
            TimeSpan t = TimeSpan.FromSeconds(promedio);
            lblEsperaProm.Text = "Espera promedio: " + t.ToString("mm\\:ss");
        }

        private static Color ColorDe(Prioridad prioridad)
        {
            switch (prioridad)
            {
                case Prioridad.Emergencia: return Color.LightCoral;
                case Prioridad.CombustibleCritico: return Color.Orange;
                case Prioridad.Comercial: return Color.LightYellow;
                case Prioridad.Carga: return Color.LightCyan;
                default: return Color.WhiteSmoke;
            }
        }
    }
}
