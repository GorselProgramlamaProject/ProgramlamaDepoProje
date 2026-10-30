using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
namespace ProgramlamaDepoProje
{
    public static class atstart
    {
        public static void atstartwith(Form form)
        {
            // Formun kenarlıklarını ve kontrol kutularını kaldır
            form.FormBorderStyle = FormBorderStyle.None;
            form.ControlBox = false;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ShowIcon = false;
            form.Text = string.Empty;
            // Arka plan siyah
            form.BackColor = Color.Black;
            // Tam ekran
            form.StartPosition = FormStartPosition.Manual;
            form.Location = new Point(0, 0);
            form.WindowState = FormWindowState.Maximized;
        }
        public static void ortalaPanel(Panel panel1, int x, int y) //kullanim sekli atstart.ortalaPanel(panel1, this.ClientSize.Width, this.ClientSize.Height);
        {
            panel1.Location = new Point(
              (x - panel1.Width) / 2,
                (y - panel1.Height) / 2
);
        }


    }

    public class atstartnotstatic
    {
        


    }


}
