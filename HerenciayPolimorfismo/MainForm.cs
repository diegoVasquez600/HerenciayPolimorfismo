using HerenciayPolimorfismo.View;

namespace HerenciayPolimorfismo
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAdminitrativo_Click(object sender, EventArgs e)
        {
            UserControlAdministrativo administrativo = new();
            CargarUserControl(administrativo);
        }

        private void buttonEmpleado_Click(object sender, EventArgs e)
        {
            UserControlEmpleado empleado = new();
            CargarUserControl(empleado);
        }


        private void CargarUserControl(UserControl userControl)
        {
            mainPanel.Controls.Clear();
            mainPanel.Controls.Add(userControl);
        }
    }
}