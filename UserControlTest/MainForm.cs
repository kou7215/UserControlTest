using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserControlTest
{
    public partial class MainForm : Form
    {
        public MainMenu mainMenuCtrl = null;
        public CountDown countDownCtrl = null;

        public MainForm()
        {
            InitializeComponent();
            mainMenuCtrl = new MainMenu(this);
            countDownCtrl = new CountDown(this);

            MainPanel.Controls.Add(mainMenuCtrl);
            MainPanel.Controls.Add(countDownCtrl);
            mainMenuCtrl.Visible = true;
            countDownCtrl.Visible = false;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // none
        }
    }
}
