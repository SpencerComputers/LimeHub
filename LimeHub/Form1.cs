using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using EasyTabs;
using System.Diagnostics;

namespace LimeHub
{
    public partial class Window : Form
    {

        protected TitleBarTabs ParentTabs
        {
            get
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public Window()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void discordIcon_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/HqUYKrD");
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            OpenFileDialog openDialogFile = new OpenFileDialog();
            openDialogFile.Filter = "Lua File (*.lua)|*.lua";
            openDialogFile.FilterIndex = 1;
            openDialogFile.RestoreDirectory = true;
            if (openDialogFile.ShowDialog() != DialogResult.OK)
                return;
            try
            {
                fastColoredTextBox1.Text = "";
                System.IO.Stream stream;
                if ((stream = openDialogFile.OpenFile()) == null)
                    return;
                using (stream)
                    this.fastColoredTextBox1.Text = System.IO.File.ReadAllText(openDialogFile.FileName);
            }
            catch (Exception ex)
            {
                int num = (int)MessageBox.Show("An unexpected error has occured with LimeHub.", "Error 3 - FILE_INVALID", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void lightgreyBG_Click(object sender, EventArgs e)
        {

        }

        private void fastColoredTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void twitterIcon_Click(object sender, EventArgs e)
        {
            Process.Start("https://twitter.com/LimeHubExploit");
        }
    }
}