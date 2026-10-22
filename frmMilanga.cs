using System.Globalization;

namespace ejercicioFinal_mammanoJuan
{
    public partial class frmMilanga : Form
    {
        private readonly string[] _nombresMozos = ["Julio", "Esteban", "Javier", "Gonzalo", "Alberto"];
        private float[,] _ventas = new float[5, 4];
        private bool _datosValidados;

        /// <summary>
        /// Inicializa la ventana, configura las filas con los nombres de los mozos y registra el cambio de datos.
        /// </summary>
        public frmMilanga()
        {
            InitializeComponent();
            dgvVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVentas.Rows.Add(_nombresMozos.Length);

            for (int fila = 0; fila < _nombresMozos.Length; fila++)
            {
                dgvVentas.Rows[fila].HeaderCell.Value = _nombresMozos[fila];
            }

            dgvVentas.CellValueChanged += dgvVentas_CellValueChanged;
        }

        /// <summary>
        /// Comprueba que cada celda contenga un número válido y almacena las ventas si toda la grilla es correcta.
        /// </summary>
        private void btnValidar_Click(object? sender, EventArgs e)
        {
            dgvVentas.EndEdit();
            _datosValidados = false;
            btnMozoDelDia.Enabled = false;
            btnTotales.Enabled = false;
            LimpiarResultados();

            float[,] ventasCargadas = new float[_nombresMozos.Length, 4];
            string? primerError = null;

            for (int fila = 0; fila < dgvVentas.Rows.Count; fila++)
            {
                for (int columna = 0; columna < dgvVentas.Columns.Count; columna++)
                {
                    object? valorCelda = dgvVentas.Rows[fila].Cells[columna].Value;
                    string texto = Convert.ToString(valorCelda, CultureInfo.CurrentCulture)?.Trim() ?? string.Empty;

                    if (float.TryParse(texto, NumberStyles.Float | NumberStyles.AllowThousands,
                        CultureInfo.CurrentCulture, out float importe) && float.IsFinite(importe))
                    {
                        ventasCargadas[fila, columna] = importe;
                    }
                    else if (primerError is null)
                    {
                        primerError = $"El importe de {_nombresMozos[fila]} en la categoría «{dgvVentas.Columns[columna].HeaderText}» no es un número válido.";
                    }
                }
            }

            if (primerError is not null)
            {
                MessageBox.Show(primerError, "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _ventas = ventasCargadas;
            _datosValidados = true;
            btnMozoDelDia.Enabled = true;
            btnTotales.Enabled = true;
            MessageBox.Show("Todos los datos son válidos.", "Validación correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Invalida la validación anterior cuando el usuario modifica una celda de ventas.
        /// </summary>
        private void dgvVentas_CellValueChanged(object? sender, DataGridViewCellEventArgs e)
        {
            if (!_datosValidados)
            {
                return;
            }

            _datosValidados = false;
            btnMozoDelDia.Enabled = false;
            btnTotales.Enabled = false;
            LimpiarResultados();
        }

        /// <summary>
        /// Borra los resultados de las consultas para evitar mostrar valores de una carga anterior.
        /// </summary>
        private void LimpiarResultados()
        {
            txtMozoDelDia.Clear();
            txtTotalMozo.Clear();
            txtTotalComidas.Clear();
            txtTotalBebidasSinAlcohol.Clear();
            txtTotalBebidasConAlcohol.Clear();
            txtTotalPostres.Clear();
            txtTotalGeneral.Clear();
        }

        /// <summary>
        /// Suma las cuatro categorías por mozo y muestra quién obtuvo el mayor importe de ventas.
        /// </summary>
        private void btnMozoDelDia_Click(object? sender, EventArgs e)
        {
            if (!_datosValidados)
            {
                return;
            }

            int indiceDelMayor = 0;
            float mayorImporte = float.NegativeInfinity;

            for (int fila = 0; fila < _nombresMozos.Length; fila++)
            {
                float totalMozo = 0;

                for (int columna = 0; columna < 4; columna++)
                {
                    totalMozo += _ventas[fila, columna];
                }

                if (totalMozo > mayorImporte)
                {
                    mayorImporte = totalMozo;
                    indiceDelMayor = fila;
                }
            }

            txtMozoDelDia.Text = _nombresMozos[indiceDelMayor];
            txtTotalMozo.Text = mayorImporte.ToString("N2", CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Calcula el total de cada categoría y el total general de ventas de todos los mozos.
        /// </summary>
        private void btnTotales_Click(object? sender, EventArgs e)
        {
            if (!_datosValidados)
            {
                return;
            }

            float[] totalesPorCategoria = new float[4];
            float totalGeneral = 0;

            for (int fila = 0; fila < _nombresMozos.Length; fila++)
            {
                for (int columna = 0; columna < totalesPorCategoria.Length; columna++)
                {
                    totalesPorCategoria[columna] += _ventas[fila, columna];
                    totalGeneral += _ventas[fila, columna];
                }
            }

            txtTotalComidas.Text = totalesPorCategoria[0].ToString("N2", CultureInfo.CurrentCulture);
            txtTotalBebidasSinAlcohol.Text = totalesPorCategoria[1].ToString("N2", CultureInfo.CurrentCulture);
            txtTotalBebidasConAlcohol.Text = totalesPorCategoria[2].ToString("N2", CultureInfo.CurrentCulture);
            txtTotalPostres.Text = totalesPorCategoria[3].ToString("N2", CultureInfo.CurrentCulture);
            txtTotalGeneral.Text = totalGeneral.ToString("N2", CultureInfo.CurrentCulture);
        }

        /// <summary>
        /// Cierra el formulario principal y finaliza la aplicación.
        /// </summary>
        private void btnSalir_Click(object? sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
