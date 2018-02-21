using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxGrahamScan
{
    public partial class Control : Form
    {
        Game1 parent;

        public Control(Game1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void Control_Load(object sender, EventArgs e)
        {

        }

        private void generateN_Click(object sender, EventArgs e)
        {
            parent.Generate((int)n.Value);
        }

        private void generateRandom_Click(object sender, EventArgs e)
        {
            parent.Generate();
        }
    }
}
