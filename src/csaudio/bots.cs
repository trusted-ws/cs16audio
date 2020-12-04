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
using System.IO.Compression;
using System.Threading;


namespace csaudio
{
    public partial class bots : Form
    {
        public bots()
        {
            InitializeComponent();
        }


        private void checkbot()
        {
            /* Check for cstrike, zbot, podbot structures for remove */
            /*     RETURN: 
             *          0 - null
             *          1 - csbot
             *          2 - zbot
             *          3 - podbot
             */

            int type = auxiliary.Functions.botsType();

            if (!auxiliary.Functions.checkForBots())
            {

                lblStatus.ForeColor = Color.Red;
                lblStatus.Text = "Nenhum BOT foi encontrado nos arquivos do seu Counter Strike 1.6";
                btnRemover.Enabled = false;
                btnInstalar.Enabled = true;
            }
            else
            {
                switch(type)
                {
                    case 1:
                        lblStatus.ForeColor = Color.Blue;
                        lblStatus.Text = "CSBOT já está instalado no seu Counter Strike 1.6";
                        break;
                    case 2:
                        lblStatus.ForeColor = Color.Blue;
                        lblStatus.Text = "Zbot já está instalado no seu Counter Strike 1.6";
                        break;
                    case 3:
                        lblStatus.ForeColor = Color.Blue;
                        lblStatus.Text = "PodBot já está instalado no seu Counter Strike 1.6";
                        break;
                    default:
                        lblStatus.ForeColor = Color.Blue;
                        lblStatus.Text = "Os BOTS já estão instalados no seu Counter Strike 1.6";
                        break;
                }

                btnRemover.Enabled = true;
                btnInstalar.Enabled = false;
            }
        }
        private void bots_Load(object sender, EventArgs e)
        {
            checkbot();
        }

        void extractCsfile()
        {
            try
            {
                string path = config.cstrike;

                if (!File.Exists(config.cstrike + @"\cstrike_csbot.zip"))
                    auxiliary.Functions.CopyResource(csaudio.Properties.Resources.cstrike_csbot, config.cstrike + @"\cstrike_csbot.zip");

                using (FileStream csfileS = new FileStream(config.cstrike + @"\cstrike_csbot.zip", FileMode.Open))
                {
                    using (ZipArchive csfile = new ZipArchive(csfileS, ZipArchiveMode.Update))
                    {
                        ZipArchiveExtensions.ExtractToDirectory(csfile, path, true);
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Ooops!");
            }

        }

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            string path = config.cstrike;

            if (!File.Exists(config.cstrike + @"\cstrike_csbot.zip"))
                auxiliary.Functions.CopyResource(csaudio.Properties.Resources.cstrike_csbot, config.cstrike + @"\cstrike_csbot.zip");

            try
            {
                button2.Enabled = false;
                btnInstalar.Enabled = false;
                btnRemover.Enabled = false;

                Thread extract = new Thread(extractCsfile);
                extract.Start();

                lblStatus.Text = "Aguarde...";
                lblStatus.ForeColor = Color.Black;
                timerMessage.Enabled = true;
                timerMessage.Start();
                lblStatus.Update();

                extract.Join();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro aqui carai");
            }

            /* Check if file .zip exists and delete it */
            if (File.Exists(config.cstrike + @"\cstrike_csbot.zip"))
                File.Delete(config.cstrike + @"\cstrike_csbot.zip");

            timerMessage.Stop();
            checkbot();

            /* Enable Buttons */
            button2.Enabled = true;

            MessageBox.Show("Instalação do CSBOT concluída!", "Instalação Concluída!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if(auxiliary.Functions.removeBots() != 0)
            {
                /* Error during removeBots() */
                checkbot();

            } else
            {
                /* Normal execution flow */
                checkbot();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        int timerMessageCounter = 0;
        private void timerMessage_Tick(object sender, EventArgs e)
        {
            lblStatus.Update();
            switch(timerMessageCounter)
            {
                case 0:
                    lblStatus.Text = "Aguarde";
                    lblStatus.Update();
                    timerMessageCounter++;
                    break;
                case 1:
                    lblStatus.Text = "Aguarde.";
                    lblStatus.Update();
                    timerMessageCounter++;
                    break;
                case 2:
                    lblStatus.Text = "Aguarde..";
                    lblStatus.Update();
                    timerMessageCounter++;
                    break;
                case 3:
                    lblStatus.Text = "Aguarde...";
                    lblStatus.Update();
                    timerMessageCounter = 0;
                    break;
            }
        }
    }

    public static class ZipArchiveExtensions
    {
        public static void ExtractToDirectory(this ZipArchive archive, string destinationDirectoryName, bool overwrite)
        {
            if (!overwrite)
            {
                archive.ExtractToDirectory(destinationDirectoryName);
                return;
            }

            DirectoryInfo di = Directory.CreateDirectory(destinationDirectoryName);
            string destinationDirectoryFullPath = di.FullName;

            foreach (ZipArchiveEntry file in archive.Entries)
            {
                string completeFileName = Path.GetFullPath(Path.Combine(destinationDirectoryFullPath, file.FullName));

                if (!completeFileName.StartsWith(destinationDirectoryFullPath, StringComparison.OrdinalIgnoreCase))
                {
                    throw new IOException("Trying to extract file outside of destination directory. See this link for more info: https://snyk.io/research/zip-slip-vulnerability");
                }

                if (file.Name == "")
                {   // Assuming Empty for Directory
                    Directory.CreateDirectory(Path.GetDirectoryName(completeFileName));
                    continue;
                }
                file.ExtractToFile(completeFileName, true);
            }
        }
    }
}
