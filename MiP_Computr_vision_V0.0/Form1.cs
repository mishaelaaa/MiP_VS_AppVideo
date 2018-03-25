using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Drawing2D;

namespace MiP_Computr_vision_V0._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public System.Boolean mute { get; set; }
    #pragma warning disable CS1633 // Unrecognized #pragma directive
    #pragma the choose file of my doc
        private void Coose_File_Click(object sender, EventArgs e)
    #pragma warning restore CS1633 // Unrecognized #pragma directive
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            if(openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.textBox1.Text = openFileDialog1.FileName;
            }
        }
    #pragma warning disable CS1633 // Unrecognized #pragma directive
        private void Play_Click(object sender, EventArgs e)
    #pragma warning restore CS1633 // Unrecognized #pragma directive
        {
            axWindowsMediaPlayer1.URL = textBox1.Text;
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    #pragma warning disable CS1633 // Unrecognized #pragma directive
        private void Pause_Click(object sender, EventArgs e)
    #pragma warning restore CS1633 // Unrecognized #pragma directive
        {
            axWindowsMediaPlayer1.Ctlcontrols.pause();
        }
    #pragma warning disable CS1633 // Unrecognized #pragma directive
        private void Stop_Click(object sender, EventArgs e)
    #pragma warning restore CS1633 // Unrecognized #pragma directive
        {
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void Mute_Click(object sender, EventArgs e)
        {
    #pragma warning disable CS8321 // Local function is declared but never used
            void Mute_CheckStateChanged(EventArgs @event)
    #pragma warning restore CS8321 // Local function is declared but never used
            {
                System.Windows.Forms.CheckBox Mute = (System.Windows.Forms.CheckBox)sender;

                // Change the check box text depending on the checked state.
                Mute.Text = Mute.Checked ? "Un-mute Audio" : Mute.Text = "Mute Audio";

                // Use the checked state to set the mute property. 
                axWindowsMediaPlayer1.settings.mute = Mute.Checked;
                axWindowsMediaPlayer1.Ctlcontrols.GetType();
            }
        }

        private void Graphics_Click(object sender, EventArgs e)
        {

        }
    }
}
