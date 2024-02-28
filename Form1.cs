namespace Crud
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ventana_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            Usuarios.PrimerNombre = txtPrimer;
            Usuarios.SegundoNombre = txtSegundo;
            Usuarios.ApellidoPaterno = txtPaterno;
            Usuarios.ApellidoMaterno = txtMaterno;
            Usuarios.NumTelefonico = txtTelefonico;
            Usuarios.Correo = txtCorreo;
            Usuarios.NumeroCasa = txtCasa;
            Usuarios.DuenoArrendatario = txtDUEÑO;
            int result = Usuarios.AgregarUsuarios(usuarios);
            if (result > 0)
            {
                MessageBox.show("Exito al guardar");
            }
            else
            {
                MessageBox.Show("Error al guardar")
            }
        }
    }
}