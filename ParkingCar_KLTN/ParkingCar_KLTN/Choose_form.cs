using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingCar_KLTN
{
    class Choose_form
    {
        public static int getLeggee()
        {
            return leggee;
        }

        public static void setLeggee(int leggee)
        {
            Choose_form.leggee = leggee;
        }

        public Choose_form()
        {
        }
        private static int leggee;
    }
}
