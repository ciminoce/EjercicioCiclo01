namespace EjercicioCiclo50.Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            InicializarControles();
        }

        private void InicializarControles()
        {
            txtCelsiusInicial.Clear();
            txtCelsiusFinal.Clear();
            txtCelsiusInicial.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            lsbCelsius.Items.Clear();
            lsbFahrenheit.Items.Clear();
            InicializarControles();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Salida del Programa", "Mensaje Final",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            Application.Exit();

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                int celsiusInicial = int.Parse(txtCelsiusInicial.Text);
                int celsiusFinal=int.Parse(txtCelsiusFinal.Text);
                GenerarTablaDeConversion(celsiusInicial, celsiusFinal);
            }
        }

        private void GenerarTablaDeConversion(int celsiusInicial, int celsiusFinal)
        {
            for (int celsius = celsiusInicial; celsius <= celsiusFinal; celsius++)
            {
                var fahrenheit = ConvertirCelsiusFahrenheit(celsius);
                lsbCelsius.Items.Add(celsius);
                lsbFahrenheit.Items.Add(fahrenheit.ToString("##.##"));
            }
        }

        private double ConvertirCelsiusFahrenheit(int celsius) => 1.8 * celsius + 32;
        

        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtCelsiusInicial.Text, out int celsiusInicial))
            {
                valido = false;
                errorProvider1.SetError(txtCelsiusInicial, "Número mal ingresado");

            }
            if (!int.TryParse(txtCelsiusFinal.Text, out int celsiusFinal))
            {
                valido = false;
                errorProvider1.SetError(txtCelsiusFinal, "Número mal ingresado");
            }
            return valido;
        }
    }
}