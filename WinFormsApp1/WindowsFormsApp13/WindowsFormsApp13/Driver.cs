using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    internal class Driver
    {
        public void Drive(Car car)
        {
            MessageBox.Show("Driving a " + car.Model);
        }
    }
}
