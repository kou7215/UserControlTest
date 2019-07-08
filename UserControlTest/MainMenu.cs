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
    public partial class MainMenu : UserControl, IObservable
    {
        // member variables
        MainForm mainForm = null;
        private List<IObserver> observers = new List<IObserver>();

        public MainMenu(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        // observable methods
        public void Add(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Notify()
        {
            this.observers.ForEach(observer => observer.Update(this)); // this.Visible?
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
