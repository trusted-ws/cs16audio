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

namespace csaudio
{
    public partial class locateCstrike : Form
    {
        public locateCstrike()
        {
            InitializeComponent();
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            int sair = 0;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (String.Compare(Path.GetFileName(folderBrowserDialog1.SelectedPath), "cstrike") == 0)
                {
                    config.cstrike = folderBrowserDialog1.SelectedPath;
                    sair = 1;
                    this.Close();
                }
                else
                {
                    DialogResult r = MessageBox.Show("Este diretório não possúi o nome cstrike.\nDeseja continuar?", "Aviso: cstrike", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        config.cstrike = folderBrowserDialog1.SelectedPath;
                        sair = 1;
                        this.Close();
                    }
                    else
                    {
                        // Pass...
                    }
                }
            }

            if (sair > 0)
                this.Close();
        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            config.locateSair = true;
            Application.Exit();
        }
    }
}
