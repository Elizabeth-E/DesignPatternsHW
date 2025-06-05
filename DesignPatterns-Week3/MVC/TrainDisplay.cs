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
    public partial class TrainDisplay : Form, ITrainDisplay
    {
        public TrainDisplay()
        {
            InitializeComponent();
        }

        private void StationDisplay_Load(object sender, EventArgs e)
        {

        }

        private void displayCurrentStation_Click(object sender, EventArgs e)
        {

        }

        private void currentStation_Click(object sender, EventArgs e)
        {

        }

        private void spoor_Click(object sender, EventArgs e)
        {

        }

        private void arrivalTime_Click(object sender, EventArgs e)
        {

        }

        public void Update(TrainStation Station)
        {
            this.displayCurrentStation.Text = Station.Name;
            this.displaySpoor.Text = Station.ArrivalTrack;
            this.displayArrivalTime.Text = Station.ArrivalTime;
            this.displayDepartureTime.Text = Station.DepatureTime;

        }
     
    }
}
