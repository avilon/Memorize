using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memorize
{
    public partial class ConnectForm : Form
    {
        public ConnectForm()
        {
            InitializeComponent();
        }

        private void ConnectForm_Resize(object sender, EventArgs e)
        {
            pnlRight.Width = this.ClientRectangle.Width / 2;
        }
    }
}
