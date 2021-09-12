using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Zcode
{
    public partial class Command_Prompt : Form
    {
        public Command_Prompt()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                var process = new Process
                {
                    StartInfo =
                     {
                         FileName = "",
                         WorkingDirectory = @"C:\myproject",
                         Arguments = "fileWithCommands.js"
                     }
                }.Start();
            }
            }
        }
    }

