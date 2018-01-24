using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApplication3
{
    public partial class FlightControl : Form
    {
        Thread topic;
        public FlightControl()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            Close();
            topic = new Thread(OpenGame);
            topic.SetApartmentState(ApartmentState.STA);
            topic.Start();
            
        }

        private void OpenGame()
        {
            Application.Run(new Game());
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

       
        
       
    }
}
