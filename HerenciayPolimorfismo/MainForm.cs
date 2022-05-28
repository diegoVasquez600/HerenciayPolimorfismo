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

        private void ButtonProfesor_Click(object sender, EventArgs e)
        {
            UserControlProfesor profesor = new();
            CargarUserControl(profesor);
        }

        private void ButtonEstudiante_Click(object sender, EventArgs e)
        {
            UserControlEstudiante estudiante = new();
            CargarUserControl(estudiante);
        }

        private void ButtonServicio_Click(object sender, EventArgs e)
        {
            UserControlServicio servicio = new();
            CargarUserControl(servicio);
        }
    }
}