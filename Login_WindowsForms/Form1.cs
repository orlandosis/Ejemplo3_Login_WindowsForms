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

            string usuario, contrase�a;

            usuario = txt_Usuario.Text.TrimEnd();
            contrase�a = txt_Contrase�a.Text.TrimEnd();

            //if (usuario == "User" && contrase�a == "programacion")
            //{
            //    MessageBox.Show("Bienvenido");

            //}
            //else
            //{
            //    MessageBox.Show("Acceso Negado");
            //}

            if (usuario.Equals("User") && contrase�a.Equals("programacion"))
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