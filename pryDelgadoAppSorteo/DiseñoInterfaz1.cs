namespace pryDelgadoAppSorteo
{
    public partial class Dise�oInterfaz1 : Form
    {
        public Dise�oInterfaz1()
        {
            InitializeComponent();
        }

        private void LimpiarControles()
        {
            txtNombre.Text = "";
            lstFecha.Text = "";
            mtbParticipantes.Text = "";
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            lstbResultados.Items.Add("Nombre del Sorteo: " + txtNombre.Text);
            lstbResultados.Items.Add("Cantidad de participantes : " + mtbParticipantes.Text);
            lstbResultados.Items.Add("Fecha del sorteo: " + lstFecha.Text);
          
            LimpiarControles();
        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles();
        }
    }
}
