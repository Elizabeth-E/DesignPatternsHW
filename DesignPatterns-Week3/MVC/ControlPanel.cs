using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC
{
    public partial class ControlPanel : Form
    {
        public int displayNum = 1;
        private TrainJourney journey;
        private TrainController controller;

        public ControlPanel()
        {
            InitializeComponent();
            this.journey = new TrainJourney();
        }

        private void newDisplay_Click(object sender, EventArgs e)
        {
            TrainDisplay form = new TrainDisplay();
            form.Text = "trainDisplay #" + displayNum;

            
            this.journey.AddObserver(form);

            
            journey.NotifyObserver();
            form.Show();

            displayNum++;
        }

        private void nextStation_Click(object sender, EventArgs e)
        {
            controller = new TrainController();
            controller.NextStation(journey);
        }
    }
}
