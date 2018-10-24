using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather_Broadcast
{
    public partial class Main : Form
    {
        Weather weather;

        public Main()
        {
            weather = new Weather();
        }      
    }
}
