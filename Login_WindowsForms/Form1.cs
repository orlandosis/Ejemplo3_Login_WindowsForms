namespace Login_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string usuario, contraseņa;

            usuario = txt_Usuario.Text.TrimEnd();
            contraseņa = txt_Contraseņa.Text.TrimEnd();

            //if (usuario == "User" && contraseņa == "programacion")
            //{
            //    MessageBox.Show("Bienvenido");

            //}
            //else
            //{
            //    MessageBox.Show("Acceso Negado");
            //}

            if (usuario.Equals("User") && contraseņa.Equals("programacion"))
            {
                MessageBox.Show("Bienvenido");

            }
            else
            {
                MessageBox.Show("Acceso Negado");
            }




        }
    }
}