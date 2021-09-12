using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zcode
{
    public partial class About_ZCode : Form
    {
        public About_ZCode()
        {
            InitializeComponent();
        }

        private void About_ZCode_Load(object sender, EventArgs e)
        {
            version.Text = "Version " + Application.ProductVersion;
            description.Text = "Code editing made easy.";
        }
    }
}
