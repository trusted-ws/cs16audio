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


namespace csaudio
{
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
                {// Assuming Empty for Directory
                    Directory.CreateDirectory(Path.GetDirectoryName(completeFileName));
                    continue;
                }
                file.ExtractToFile(completeFileName, true);
            }
        }
    }

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
            //debug
            //auxiliary.Functions.removeBots();
            checkbot();
            ////////
            

        }

/*        public void UnzipFile(string zipPath, string folderPath)
        {

            try
            {
                if (!File.Exists(zipPath))
                {
                    throw new FileNotFoundException();
                }
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                Shell32.Shell objShell = new Shell32.Shell();
                Shell32.Folder destinationFolder = objShell.NameSpace(folderPath);
                Shell32.Folder sourceFile = objShell.NameSpace(zipPath);
                foreach (var file in sourceFile.Items())
                {
                    destinationFolder.CopyHere(file, 4 | 16);
                }
            }
            catch (Exception e)
            {
                //handle error
            }
        }*/

        private void btnInstalar_Click(object sender, EventArgs e)
        {
            // Next implementation...
            // filename: cstrike_csbot.zip 
            
            //string path = config.cstrike + @"\cstrike_csbot";
            string path = config.cstrike;

            if (!File.Exists(config.cstrike + @"\cstrike_csbot.zip"))
                auxiliary.Functions.CopyResource(csaudio.Properties.Resources.cstrike_csbot, config.cstrike + @"\cstrike_csbot.zip");

            try
            {
                MessageBox.Show("Continue!", "debuuuuug");

                // open filestream
                using (FileStream csfileS = new FileStream(config.cstrike + @"\cstrike_csbot.zip", FileMode.Open))
                {
                    using (ZipArchive csfile = new ZipArchive(csfileS, ZipArchiveMode.Update))
                    {
                        ZipArchiveExtensions.ExtractToDirectory(csfile, path, true);
                    }
                }
                // ZipArchiveExtensions.ExtractToDirectory(config.cstrike + @"\cstrike_csbot.zip", path, true);

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Erro aqui carai");
            }

            checkbot();
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
    }
}
