using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingApiAppWinforms
{
    public partial class KursUserControl : UserControl
    {
        public KursUserControl()
        {
            InitializeComponent();
        }
        private string _KursName;
        private string _KursRate;

        public string KursName
        {
            get { return _KursName; }
            set { _KursName = value; Lblname.Text = _KursName; }
        }
        public string KursRate
        {
            get { return _KursRate; }
            set { _KursRate = value; LblValue.Text = _KursRate; }
        }

        private void KursUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
