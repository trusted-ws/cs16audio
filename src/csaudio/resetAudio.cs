using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csaudio
{
    public partial class resetAudio : Form
    {
        public resetAudio()
        {
            InitializeComponent();
        }

        private void resetAudio_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            config.reset = false;
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            config.reset = true;
            this.Close();
        }
    }
}
