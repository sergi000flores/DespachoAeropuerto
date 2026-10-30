namespace DespachoAeropuerto
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grpRegistro = new System.Windows.Forms.GroupBox();
            this.lblVuelo = new System.Windows.Forms.Label();
            this.txtVuelo = new System.Windows.Forms.TextBox();
            this.lblAerolinea = new System.Windows.Forms.Label();
            this.cmbAerolinea = new System.Windows.Forms.ComboBox();
            this.lblPrioridad = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.lblOperacion = new System.Windows.Forms.Label();
            this.cmbOperacion = new System.Windows.Forms.ComboBox();
            this.lblPasajeros = new System.Windows.Forms.Label();
            this.numPasajeros = new System.Windows.Forms.NumericUpDown();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnAleatorio = new System.Windows.Forms.Button();
            this.grpPista = new System.Windows.Forms.GroupBox();
            this.lblPista = new System.Windows.Forms.Label();
            this.btnDespachar = new System.Windows.Forms.Button();
            this.btnAuto = new System.Windows.Forms.Button();
            this.grpEstadisticas = new System.Windows.Forms.GroupBox();
            this.lblEnCola = new System.Windows.Forms.Label();
            this.lblAtendidos = new System.Windows.Forms.Label();
            this.lblEsperaProm = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblTituloCola = new System.Windows.Forms.Label();
            this.dgvCola = new System.Windows.Forms.DataGridView();
            this.lblTituloHist = new System.Windows.Forms.Label();
            this.lstHistorial = new System.Windows.Forms.ListBox();
            this.tmrSimulacion = new System.Windows.Forms.Timer(this.components);
            this.grpRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPasajeros)).BeginInit();
            this.grpPista.SuspendLayout();
            this.grpEstadisticas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).BeginInit();
            this.SuspendLayout();
            //
            // grpRegistro
            //
            this.grpRegistro.Controls.Add(this.lblVuelo);
            this.grpRegistro.Controls.Add(this.txtVuelo);
            this.grpRegistro.Controls.Add(this.lblAerolinea);
            this.grpRegistro.Controls.Add(this.cmbAerolinea);
            this.grpRegistro.Controls.Add(this.lblPrioridad);
            this.grpRegistro.Controls.Add(this.cmbPrioridad);
            this.grpRegistro.Controls.Add(this.lblOperacion);
            this.grpRegistro.Controls.Add(this.cmbOperacion);
            this.grpRegistro.Controls.Add(this.lblPasajeros);
            this.grpRegistro.Controls.Add(this.numPasajeros);
            this.grpRegistro.Controls.Add(this.btnAgregar);
            this.grpRegistro.Controls.Add(this.btnAleatorio);
            this.grpRegistro.Location = new System.Drawing.Point(12, 12);
            this.grpRegistro.Name = "grpRegistro";
            this.grpRegistro.Size = new System.Drawing.Size(360, 250);
            this.grpRegistro.TabIndex = 0;
            this.grpRegistro.TabStop = false;
            this.grpRegistro.Text = "Registrar aeronave";
            //
            // lblVuelo
            //
            this.lblVuelo.AutoSize = true;
            this.lblVuelo.Location = new System.Drawing.Point(15, 30);
            this.lblVuelo.Name = "lblVuelo";
            this.lblVuelo.Size = new System.Drawing.Size(40, 15);
            this.lblVuelo.TabIndex = 0;
            this.lblVuelo.Text = "Vuelo:";
            //
            // txtVuelo
            //
            this.txtVuelo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVuelo.Location = new System.Drawing.Point(120, 27);
            this.txtVuelo.MaxLength = 10;
            this.txtVuelo.Name = "txtVuelo";
            this.txtVuelo.Size = new System.Drawing.Size(220, 23);
            this.txtVuelo.TabIndex = 1;
            //
            // lblAerolinea
            //
            this.lblAerolinea.AutoSize = true;
            this.lblAerolinea.Location = new System.Drawing.Point(15, 65);
            this.lblAerolinea.Name = "lblAerolinea";
            this.lblAerolinea.Size = new System.Drawing.Size(60, 15);
            this.lblAerolinea.TabIndex = 2;
            this.lblAerolinea.Text = "Aerolínea:";
            //
            // cmbAerolinea
            //
            this.cmbAerolinea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAerolinea.FormattingEnabled = true;
            this.cmbAerolinea.Location = new System.Drawing.Point(120, 62);
            this.cmbAerolinea.Name = "cmbAerolinea";
            this.cmbAerolinea.Size = new System.Drawing.Size(220, 23);
            this.cmbAerolinea.TabIndex = 3;
            //
            // lblPrioridad
            //
            this.lblPrioridad.AutoSize = true;
            this.lblPrioridad.Location = new System.Drawing.Point(15, 100);
            this.lblPrioridad.Name = "lblPrioridad";
            this.lblPrioridad.Size = new System.Drawing.Size(58, 15);
            this.lblPrioridad.TabIndex = 4;
            this.lblPrioridad.Text = "Prioridad:";
            //
            // cmbPrioridad
            //
            this.cmbPrioridad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Location = new System.Drawing.Point(120, 97);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(220, 23);
            this.cmbPrioridad.TabIndex = 5;
            //
            // lblOperacion
            //
            this.lblOperacion.AutoSize = true;
            this.lblOperacion.Location = new System.Drawing.Point(15, 135);
            this.lblOperacion.Name = "lblOperacion";
            this.lblOperacion.Size = new System.Drawing.Size(65, 15);
            this.lblOperacion.TabIndex = 6;
            this.lblOperacion.Text = "Operación:";
            //
            // cmbOperacion
            //
            this.cmbOperacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOperacion.FormattingEnabled = true;
            this.cmbOperacion.Location = new System.Drawing.Point(120, 132);
            this.cmbOperacion.Name = "cmbOperacion";
            this.cmbOperacion.Size = new System.Drawing.Size(220, 23);
            this.cmbOperacion.TabIndex = 7;
            //
            // lblPasajeros
            //
            this.lblPasajeros.AutoSize = true;
            this.lblPasajeros.Location = new System.Drawing.Point(15, 170);
            this.lblPasajeros.Name = "lblPasajeros";
            this.lblPasajeros.Size = new System.Drawing.Size(61, 15);
            this.lblPasajeros.TabIndex = 8;
            this.lblPasajeros.Text = "Pasajeros:";
            //
            // numPasajeros
            //
            this.numPasajeros.Location = new System.Drawing.Point(120, 167);
            this.numPasajeros.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            this.numPasajeros.Name = "numPasajeros";
            this.numPasajeros.Size = new System.Drawing.Size(100, 23);
            this.numPasajeros.TabIndex = 9;
            this.numPasajeros.Value = new decimal(new int[] { 150, 0, 0, 0 });
            //
            // btnAgregar
            //
            this.btnAgregar.Location = new System.Drawing.Point(15, 205);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(160, 30);
            this.btnAgregar.TabIndex = 10;
            this.btnAgregar.Text = "Agregar a la cola";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            //
            // btnAleatorio
            //
            this.btnAleatorio.Location = new System.Drawing.Point(180, 205);
            this.btnAleatorio.Name = "btnAleatorio";
            this.btnAleatorio.Size = new System.Drawing.Size(160, 30);
            this.btnAleatorio.TabIndex = 11;
            this.btnAleatorio.Text = "Generar aleatorio";
            this.btnAleatorio.UseVisualStyleBackColor = true;
            this.btnAleatorio.Click += new System.EventHandler(this.btnAleatorio_Click);
            //
            // grpPista
            //
            this.grpPista.Controls.Add(this.lblPista);
            this.grpPista.Controls.Add(this.btnDespachar);
            this.grpPista.Controls.Add(this.btnAuto);
            this.grpPista.Location = new System.Drawing.Point(12, 270);
            this.grpPista.Name = "grpPista";
            this.grpPista.Size = new System.Drawing.Size(360, 140);
            this.grpPista.TabIndex = 1;
            this.grpPista.TabStop = false;
            this.grpPista.Text = "Torre de control / Pista";
            //
            // lblPista
            //
            this.lblPista.BackColor = System.Drawing.Color.Honeydew;
            this.lblPista.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPista.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblPista.Location = new System.Drawing.Point(15, 25);
            this.lblPista.Name = "lblPista";
            this.lblPista.Size = new System.Drawing.Size(325, 55);
            this.lblPista.TabIndex = 0;
            this.lblPista.Text = "Pista libre";
            this.lblPista.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // btnDespachar
            //
            this.btnDespachar.Location = new System.Drawing.Point(15, 90);
            this.btnDespachar.Name = "btnDespachar";
            this.btnDespachar.Size = new System.Drawing.Size(160, 35);
            this.btnDespachar.TabIndex = 1;
            this.btnDespachar.Text = "Despachar siguiente";
            this.btnDespachar.UseVisualStyleBackColor = true;
            this.btnDespachar.Click += new System.EventHandler(this.btnDespachar_Click);
            //
            // btnAuto
            //
            this.btnAuto.Location = new System.Drawing.Point(180, 90);
            this.btnAuto.Name = "btnAuto";
            this.btnAuto.Size = new System.Drawing.Size(160, 35);
            this.btnAuto.TabIndex = 2;
            this.btnAuto.Text = "Iniciar automático";
            this.btnAuto.UseVisualStyleBackColor = true;
            this.btnAuto.Click += new System.EventHandler(this.btnAuto_Click);
            //
            // grpEstadisticas
            //
            this.grpEstadisticas.Controls.Add(this.lblEnCola);
            this.grpEstadisticas.Controls.Add(this.lblAtendidos);
            this.grpEstadisticas.Controls.Add(this.lblEsperaProm);
            this.grpEstadisticas.Location = new System.Drawing.Point(12, 418);
            this.grpEstadisticas.Name = "grpEstadisticas";
            this.grpEstadisticas.Size = new System.Drawing.Size(360, 110);
            this.grpEstadisticas.TabIndex = 2;
            this.grpEstadisticas.TabStop = false;
            this.grpEstadisticas.Text = "Estadísticas";
            //
            // lblEnCola
            //
            this.lblEnCola.AutoSize = true;
            this.lblEnCola.Location = new System.Drawing.Point(15, 25);
            this.lblEnCola.Name = "lblEnCola";
            this.lblEnCola.Size = new System.Drawing.Size(70, 15);
            this.lblEnCola.TabIndex = 0;
            this.lblEnCola.Text = "En espera: 0";
            //
            // lblAtendidos
            //
            this.lblAtendidos.AutoSize = true;
            this.lblAtendidos.Location = new System.Drawing.Point(15, 55);
            this.lblAtendidos.Name = "lblAtendidos";
            this.lblAtendidos.Size = new System.Drawing.Size(78, 15);
            this.lblAtendidos.TabIndex = 1;
            this.lblAtendidos.Text = "Atendidos: 0";
            //
            // lblEsperaProm
            //
            this.lblEsperaProm.AutoSize = true;
            this.lblEsperaProm.Location = new System.Drawing.Point(15, 85);
            this.lblEsperaProm.Name = "lblEsperaProm";
            this.lblEsperaProm.Size = new System.Drawing.Size(140, 15);
            this.lblEsperaProm.TabIndex = 2;
            this.lblEsperaProm.Text = "Espera promedio: 00:00";
            //
            // btnLimpiar
            //
            this.btnLimpiar.Location = new System.Drawing.Point(12, 540);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(360, 30);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Reiniciar simulación";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            //
            // lblTituloCola
            //
            this.lblTituloCola.AutoSize = true;
            this.lblTituloCola.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloCola.Location = new System.Drawing.Point(385, 15);
            this.lblTituloCola.Name = "lblTituloCola";
            this.lblTituloCola.Size = new System.Drawing.Size(240, 15);
            this.lblTituloCola.TabIndex = 4;
            this.lblTituloCola.Text = "Cola de espera (en orden de despacho)";
            //
            // dgvCola
            //
            this.dgvCola.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCola.Location = new System.Drawing.Point(385, 38);
            this.dgvCola.Name = "dgvCola";
            this.dgvCola.RowTemplate.Height = 25;
            this.dgvCola.Size = new System.Drawing.Size(590, 300);
            this.dgvCola.TabIndex = 5;
            //
            // lblTituloHist
            //
            this.lblTituloHist.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblTituloHist.AutoSize = true;
            this.lblTituloHist.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblTituloHist.Location = new System.Drawing.Point(385, 350);
            this.lblTituloHist.Name = "lblTituloHist";
            this.lblTituloHist.Size = new System.Drawing.Size(190, 15);
            this.lblTituloHist.TabIndex = 6;
            this.lblTituloHist.Text = "Historial de operaciones atendidas";
            //
            // lstHistorial
            //
            this.lstHistorial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHistorial.FormattingEnabled = true;
            this.lstHistorial.ItemHeight = 15;
            this.lstHistorial.Location = new System.Drawing.Point(385, 372);
            this.lstHistorial.Name = "lstHistorial";
            this.lstHistorial.Size = new System.Drawing.Size(590, 199);
            this.lstHistorial.TabIndex = 7;
            //
            // tmrSimulacion
            //
            this.tmrSimulacion.Interval = 2000;
            this.tmrSimulacion.Tick += new System.EventHandler(this.tmrSimulacion_Tick);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 585);
            this.Controls.Add(this.lstHistorial);
            this.Controls.Add(this.lblTituloHist);
            this.Controls.Add(this.dgvCola);
            this.Controls.Add(this.lblTituloCola);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.grpEstadisticas);
            this.Controls.Add(this.grpPista);
            this.Controls.Add(this.grpRegistro);
            this.MinimumSize = new System.Drawing.Size(1006, 624);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Despacho de aviones - Cola de prioridad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpRegistro.ResumeLayout(false);
            this.grpRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPasajeros)).EndInit();
            this.grpPista.ResumeLayout(false);
            this.grpEstadisticas.ResumeLayout(false);
            this.grpEstadisticas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.GroupBox grpRegistro;
        private System.Windows.Forms.Label lblVuelo;
        private System.Windows.Forms.TextBox txtVuelo;
        private System.Windows.Forms.Label lblAerolinea;
        private System.Windows.Forms.ComboBox cmbAerolinea;
        private System.Windows.Forms.Label lblPrioridad;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.Label lblOperacion;
        private System.Windows.Forms.ComboBox cmbOperacion;
        private System.Windows.Forms.Label lblPasajeros;
        private System.Windows.Forms.NumericUpDown numPasajeros;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnAleatorio;
        private System.Windows.Forms.GroupBox grpPista;
        private System.Windows.Forms.Label lblPista;
        private System.Windows.Forms.Button btnDespachar;
        private System.Windows.Forms.Button btnAuto;
        private System.Windows.Forms.GroupBox grpEstadisticas;
        private System.Windows.Forms.Label lblEnCola;
        private System.Windows.Forms.Label lblAtendidos;
        private System.Windows.Forms.Label lblEsperaProm;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblTituloCola;
        private System.Windows.Forms.DataGridView dgvCola;
        private System.Windows.Forms.Label lblTituloHist;
        private System.Windows.Forms.ListBox lstHistorial;
        private System.Windows.Forms.Timer tmrSimulacion;
    }
}
