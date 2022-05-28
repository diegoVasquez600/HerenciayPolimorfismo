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
            mainPanel.Controls.Add(administrativo);
        }
    }
}