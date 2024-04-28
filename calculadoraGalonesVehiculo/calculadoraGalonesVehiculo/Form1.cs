namespace calculadoraGalonesVehiculo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float distancia = float.Parse(DISTANCIA.Text);
            float kilometrosRecorridos = float.Parse(RENDIMIENTO.Text);
            float resultado = distancia / kilometrosRecorridos;
            barraProgreso.Visible = true;
            barradeProgeso(barraProgreso);


            label2.Text = resultado.ToString();





        }

        private void RENDIMIENTO_TextChanged(object sender, EventArgs e)
        {

        }


        private void barradeProgeso(System.Windows.Forms.ProgressBar barra)
        {
            barra.Maximum = 100000;
            barra.Step = 1;

            for (int j = 0; j < 100000; j++)
            {
                double pow = Math.Pow(j, j); //Calculation
                barra.PerformStep();
            }

        }

        private void barraProgreso_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
