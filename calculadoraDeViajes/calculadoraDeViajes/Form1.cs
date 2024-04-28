namespace calculadoraDeViajes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcular_Click(object sender, EventArgs e)
        {
            double puntoInicioX1 = double.Parse(puntoOrigen.Text);
            double puntoFinalX2 = double.Parse(puntoDestino.Text);
            double velocidad = double.Parse(velocidadConstante.Text);


            double calcularTiempo =Math.Abs( (puntoFinalX2 - puntoInicioX1) / velocidad)f;

            label2.Text = calcularTiempo.ToString();
            MessageBox.Show(calcularTiempo.ToString());
                
        }
    }
}
