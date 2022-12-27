using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hubstaf
{
    public partial class projectcontainer : UserControl
    {
        public projectcontainer()
        {
            InitializeComponent();
        }

        #region Properties
        private string _name;

        [Category("Custom Props")]
        public string nameproject
        {
            get { return _name; }
            set { _name = value;lblproject.Text = value; }
        }
        #endregion

        private void projectcontainer_Enter(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
        }

        private void projectcontainer_Leave(object sender, EventArgs e)
        {
            this.BackColor = Color.Silver;
        }
    }
}
