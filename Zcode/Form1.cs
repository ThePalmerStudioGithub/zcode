using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace Zcode
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
    

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Open File";

            openFileDialog1.ShowDialog();
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            openFile();

        }
       
        public void openFile()
        {
            string text = System.IO.File.ReadAllText(openFileDialog1.FileName);

            filecontents.Text = text;
            this.Text = openFileDialog1.FileName + " - ZCode";
            if(openFileDialog1.FileName.EndsWith(".py"))
            {
                this.Text = openFileDialog1.FileName + " - ZCode - Python";

            }
            if (openFileDialog1.FileName.EndsWith(".js"))
            {
                this.Text = openFileDialog1.FileName + " - ZCode - JavaScript";
            }
            if (openFileDialog1.FileName.EndsWith(".html"))
            {
                this.Text = openFileDialog1.FileName + " - ZCode - HTML";
            }
        }
        public void openFileOnStartup()
        {
         
            string[] arguments = Environment.GetCommandLineArgs();
            var argumentsstring = String.Join(",", arguments);
           
            string[] splitted = argumentsstring.Split(',');
            foreach (var split in splitted)
            {
               if(!split.Contains("Zcode.exe"))
                {
                    string text = System.IO.File.ReadAllText(split);

                    filecontents.Text = text;
                    this.Text = split + " - ZCode";
                    if (split.EndsWith(".py"))
                    {
                        this.Text = split + " - ZCode - Python";

                    }
                    if(split.EndsWith(".js"))
                    {
                        this.Text = split + " - ZCode - JavaScript";
                    }
                    if(split.EndsWith(".html"))
                    {
                        this.Text = split + " - ZCode - HTML";
                    }
                }
            }



        }
        private void commandPromptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Command_Prompt command = new Command_Prompt();
            command.ShowDialog();
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            StreamWriter sw = new StreamWriter(saveFileDialog1.FileName);
            sw.Write(filecontents.Text);
            sw.Close();
            this.Text = saveFileDialog1.FileName + " - ZCode(saved)";
        }

        private void openFolderToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            }

        private void filesofdirectory_MouseEnter(object sender, EventArgs e)
        {
   
        }

        private void filesofdirectory_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openFileOnStartup();
           

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filecontents.CanUndo)
            {
                filecontents.Undo();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filecontents.CanRedo)
            {
                filecontents.Redo();
            }
        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo start = new System.Diagnostics.ProcessStartInfo();
            //python interprater location
            start.FileName = Application.LocalUserAppDataPath + @"\Programs\Python\Python39\python.exe";
            //argument with file name and input parameters
            start.Arguments = openFileDialog1.FileName;
            start.UseShellExecute = false;// Do not use OS shell
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
          if(filecontents.SelectedText != "")
            {
                filecontents.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (filecontents.SelectionLength > 0) { 
                // Copy the selected text to the Clipboard.
                filecontents.Copy();
        }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filecontents.Paste();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
    
        }

        private void filecontents_TextChanged(object sender, EventArgs e)
        {
            if (filecontents.Text.Contains("!") && openFileDialog1.FileName.EndsWith(".html"))
            {
                filecontents.Text = Properties.Resources.HTML_Boilerplate;
            }
        }

        private void filecontents_KeyPress(object sender, KeyPressEventArgs e)
        {
        
        }

        private void filecontents_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_ZCode about = new About_ZCode();
            about.ShowDialog();
        }
    }
    }
    