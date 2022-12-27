using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hubstaf.Resources
{
    public partial class projects : UserControl
    {
        public projects()
        {
            InitializeComponent();
        }

        private string _name;

        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set { _name = value; name.Text = value; }
        }
    }
}
