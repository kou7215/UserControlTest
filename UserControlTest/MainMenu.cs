using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class MainMenu : UserControl
    {
        MainForm mainForm = null;
        public MainMenu(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void EasyButton_Click(object sender, EventArgs e)
        {
            mainForm.mainMenuCtrl.Visible = false;
            mainForm.countDownCtrl.Visible = true;
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
