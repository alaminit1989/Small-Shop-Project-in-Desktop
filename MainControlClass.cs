using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SCM
{
    class MainControlClass
    {

        public static void showControl(Control control, Control pnlControl)
        {
            pnlControl.Controls.Clear();
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();

            pnlControl.Controls.Add(control);
        }
    }
}
