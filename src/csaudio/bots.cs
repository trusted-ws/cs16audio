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
    public partial class bots : Form
    {
        public bots()
        {
            InitializeComponent();
        }

        private void bots_Load(object sender, EventArgs e)
        {
            if(!auxiliary.Functions.checkForBots())
            {
                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Nenhum BOT foi encontrado nos arquivos do seu Counter Strike 1.6";
                btnRemover.Enabled = false;
                btnInstalar.Enabled = true;
            } else
            {
                lblStatus.ForeColor = Color.Blue;
                lblStatus.Text = "Os BOTS já estão instalados no seu Counter Strike 1.6";
                btnRemover.Enabled = true;
                btnInstalar.Enabled = false;
            }
        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
