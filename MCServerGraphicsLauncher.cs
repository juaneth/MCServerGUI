using System;
using System.Windows.Forms;

namespace MCServer_Graphics
{
    public partial class MCServerGraphicsLauncher : Form
    {
        public MCServerGraphicsLauncher()
        {
            InitializeComponent();
        }

        public string appPath = Application.StartupPath;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void run1_MouseHover(object sender, EventArgs e)
        {
            run1.BackgroundImage = MCServer_Graphics_Launcher.Properties.Resources.mcbuttonhover;
        }

        private void run1_MouseLeave(object sender, EventArgs e)
        {
            run1.BackgroundImage = MCServer_Graphics_Launcher.Properties.Resources.mcbutton;
        }
    }
}
