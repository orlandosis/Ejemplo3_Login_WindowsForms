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

            string usuario, contraseña;

            usuario = txt_Usuario.Text.TrimEnd();
            contraseña = txt_Contraseña.Text.TrimEnd();

            //if (usuario == "User" && contraseña == "programacion")
            //{
            //    MessageBox.Show("Bienvenido");

            //}
            //else
            //{
            //    MessageBox.Show("Acceso Negado");
            //}

            if (usuario.Equals("User") && contraseña.Equals("programacion"))
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