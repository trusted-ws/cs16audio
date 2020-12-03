using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csaudio
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void InitializeOpenFileDialog()
        {
            // Set the file dialog to filter for graphics files.
            this.openFileDialog1.Filter =
                "Audio (*.wav)|*.wav;*.WAV|" +
                "All files (*.*)|*.*";

            this.openFileDialog1.Multiselect = true;

            this.openFileDialog1.Title = "Selecione os arquivos de audio";
        }

        private void InitializeBackup()
        {
            
            string path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile); 

            if(!Directory.Exists(path + config.backupDir)) {
                try
                {
                    DirectoryInfo d = Directory.CreateDirectory(path + config.backupDir);
                    //Console.WriteLine("[LOG] Backup directory created."); 
                    FirstTime(true);
                } catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            } else
            {
                //Console.WriteLine("[LOG] Backup directory found!");
            }

        }

        private void writeCstrike(string cstrike)
        {
            if(!File.Exists(config.cstrikeDir))
            {
                using (StreamWriter w = File.AppendText(config.cstrikeDir)) { };
            }

            System.IO.File.WriteAllText(config.cstrikeDir, cstrike);
        }

        private void checkCstrike(string cst)
        {
            if (Directory.Exists(cst))
            {
                if (File.Exists(cst + "\\steam.inf"))
                {
                    string[] ver = File.ReadAllLines(cst + "\\steam.inf");
                    try
                    {
                        lblExe.ForeColor = Color.Black;
                        if(auxiliary.Functions.checkForBots())
                            lblExe.Text = String.Format("Versão: (Steam) {0} (com bots)", ver[0].Split('=')[1].Trim());
                        else
                            lblExe.Text = String.Format("Versão: (Steam) {0}", ver[0].Split('=')[1].Trim());
                    }
                    catch (Exception ex)
                    {
                        lblExe.ForeColor = Color.Black;
                        if(auxiliary.Functions.checkForBots())
                            lblExe.Text = String.Format("Versão: desconhecida (Steam) (com bots)");
                        else
                            lblExe.Text = String.Format("Versão: desconhecida (Steam)");
                    }
                }
                else
                {
                    lblExe.ForeColor = Color.Black;
                    if (auxiliary.Functions.checkForBots())
                        lblExe.Text = String.Format("Versão: desconhecida (com bots)");
                    else
                        lblExe.Text = String.Format("Versão: desconhecida");
                }
                textGameDir.ForeColor = Color.Green;
                textGameDir.Text = cst;

                /* Write location of cstrike on backup dir */
                writeCstrike(cst);

                /* Set config.cstrike */
                config.cstrike = cst;
            }
        }

        private string CounterStrikeDirectory()
        {
            string diretorio = "";

            // Get Logical Devices
            foreach(string device in Directory.GetLogicalDrives())
            {

                if(Directory.Exists(String.Format(@"{0}{1}", device, config.steamDir)))
                {
                    string dir = String.Format(@"{0}{1}", device, config.steamDir);
                    if(File.Exists(dir + "\\steam.inf"))
                    {
                        string[] ver = File.ReadAllText(dir + "\\steam.inf").Split('=');
                        try
                        {
                            lblExe.ForeColor = Color.Black;
                            lblExe.Text = String.Format("Versão: (Steam) {0}", ver[1]);
                        } catch(Exception ex)
                        {
                            lblExe.ForeColor = Color.Red;
                            lblExe.Text = String.Format("Versão: desconhecida (Steam)");
                        }
                    } else
                    {
                        lblExe.Text = "";
                    }
                    textGameDir.ForeColor = Color.Green;
                    textGameDir.Text = String.Format(@"{0}{1}", device, config.steamDir);

                    config.cstrike = String.Format(@"{0}{1}", device, config.steamDir);

                    /* Write to cstrike config */
                    writeCstrike(config.cstrike);

                    break;

                } else
                {
                    config.cstrike = "";
                }
                //Search(device);
            }

            if(String.IsNullOrEmpty(config.cstrike) || String.IsNullOrWhiteSpace(config.cstrike))
            {
                locateCstrike locate = new locateCstrike();
                locate.ShowDialog();
                if(config.locateSair)
                {
                    Application.Exit();
                }
                checkCstrike(config.cstrike);
            }

            diretorio = config.cstrike;

            return diretorio;
        }

        private void InitializeCstrike()
        {

            if (!File.Exists(config.cstrikeDir))
            {
                File.Create(config.cstrikeDir).Dispose();
                return;
            }

            string dirFromFile = System.IO.File.ReadAllText(config.cstrikeDir);
            checkCstrike(dirFromFile);
        }

        private List<string> ProcessAudio(string audioPath)
        {
            /* Copy the audio file to their respective directory */

            string audioName = Path.GetFileName(audioPath.ToString());
            string basePath = config.cstrike + @"\sound";
            List<string> output = auxiliary.Functions.SwitchPath(audioName, basePath);

            //Console.WriteLine("[DEBUG] {0} -> {1}", audioName,  basePath);
            return output;
        }

        public void WriteResourceToFile(string resourceName, string fileName)
        {
            using (var resource = Assembly.GetExecutingAssembly().GetManifestResourceStream(resourceName))
            {
                using (var file = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    resource.CopyTo(file);
                }
            }
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            // Get the subdirectories for the specified directory.
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            DirectoryInfo[] dirs = dir.GetDirectories();

            // If the destination directory doesn't exist, create it.       
            Directory.CreateDirectory(destDirName);

            // Get the files in the directory and copy them to the new location.
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string tempPath = Path.Combine(destDirName, file.Name);
                file.CopyTo(tempPath, false);
            }

            // If copying subdirectories, copy them and their contents to new location.
            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string tempPath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, tempPath, copySubDirs);
                }
            }
        }

        /* Create backup of entire audio folder to backup directory */
        private void PerformBackup()
        {
            string dst = config.backupAudioDir + @"\sound";
            string src = config.cstrike + @"\sound";

            //System.IO.File.WriteAllText(@"D:\path.txt", contents);

            Console.WriteLine("Performing backup {0} -> {1}", src, dst);


            if (Directory.Exists(src))
            {
                DirectoryCopy(src, dst, true);
                File.WriteAllText(config.backupAudioDir + @"\first_time", "0");
            }
        }

        private void Execute()
        {
            int concluido = 0;
            int ignorados = 0; // Quantidade de arquivos que foram ignorados.

            foreach(string audio in listBoxFiles.Items)
            {
                // TODO: Check if audio / cstrole/sound exists. [OK]
                if (!File.Exists(audio)) { continue; }                          /* Go to next element of foreach */
                if(!Directory.Exists(config.cstrike + @"\sound")) { return; }   /* If cstrike/sound doesn't exists then return */

                List<string> paths = ProcessAudio(audio);

                // TODO: Count paths and process each value. [OK]
                foreach (string path in paths)
                {
                    if (!String.IsNullOrEmpty(path) || !String.IsNullOrWhiteSpace(path))
                    {
                        /* Copy and replace the audio file */
                        //Console.WriteLine("Copying {0} para {1}", audio, path);
                        try
                        {
                            /* Check if cstrike have bots before perform copy */
                            auxiliary.Functions.checkForBots();
                            string[] subs = path.Split('\\');
                            if (String.Compare(subs[subs.Count() - 2], "bot") == 0)
                            {
                                if (config.haveBots)
                                    File.Copy(audio, path, true);
                                else
                                    ignorados++;
                            }
                            else
                            {
                                File.Copy(audio, path, true);
                            }

                            concluido++;
                        }
                        catch(System.IO.DirectoryNotFoundException dirExp)
                        {
                            string fn = Path.GetFileName(path);
                            string msg = "";

                            // Check if 'audio' path is the bot path.d
                            string[] subs = path.Split('\\');
                            
                            //Console.WriteLine(String.Format("{0}: {1}", path, subs[subs.Count() - 2]));
                            if(String.Compare(subs[subs.Count() - 2], "bot") == 0)
                            {
                                msg = String.Format("Não foi possível completar a operação, pois o seu Counter Strike não possuí bots.\n\nO arquivo '{0}'é um arquivo de áudio dos bots.", fn);
                            } else {
                                msg = String.Format("{0}", dirExp.Message.ToString());
                            }

                            MessageBox.Show(msg, "Falha na Operação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            
                        }
                        catch (System.IO.IOException useExc)
                        {
                            MessageBox.Show("Não foi possível completar a operação pois os\narquivos estão sendo utilizados por outro processo!", "Falha na Operação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            //listBoxFiles.Items.Clear();

                            return;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "Falha na Operação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }

            }
            listBoxFiles.Items.Clear();
            if (concluido > 0)
            {
                if(concluido > 1)
                    MessageBox.Show(String.Format("Operação concluída!\n\n{0} arquivos foram instalados com êxito.\n{1} arquivos ignorados.", concluido, ignorados), "Operação concluída!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show(String.Format("Operação concluída!\n\n{0} arquivo instalado com êxito.\n{1} arquivos ignorados.", concluido, ignorados), "Operação concluída!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            btnExecutar.Enabled = false;
            lblAudioName.Text = "";
        }

        private bool FirstTime(bool create)
        {
            if(create)
            {
                /* First time (Create backup) */
                Console.WriteLine("Creating first_time at {0}", config.backupAudioDir + @"\first_time");

                if (!File.Exists(config.backupAudioDir + @"\first_time"))
                {
                    using (StreamWriter w = File.AppendText(config.backupAudioDir + @"\first_time")) { };
                }
                System.IO.File.WriteAllText(config.backupAudioDir + @"\first_time", "1");

                // Perform backup
                config.performBackup = true;

                return true;
            }

            Console.WriteLine("Checking for first_time {0}", config.backupAudioDir + @"\first_time");

            if(File.Exists(config.backupAudioDir + @"\first_time"))
            {
                Console.WriteLine("File {0} not first time!", config.backupAudioDir + @"\first_time");
                return false;
            } else
            {
                Console.WriteLine("File {0} not first time!", config.backupAudioDir + @"\first_time");
                return true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timerCredits.Enabled = true;
            timerCredits.Interval = 1;
            timerCredits.Start();

            /* Create backup if doesn't exists */
            InitializeBackup();

            /* Create file for cstrike path location if doesn't exists */
            InitializeCstrike();

            /* If config.cstrike was not loaded then search for it */
            if (String.IsNullOrEmpty(config.cstrike) || String.IsNullOrWhiteSpace(config.cstrike))
            {
                CounterStrikeDirectory();
            }


            //InitializeBackup();

            /* Read first time (0 = not create backup / 1 = create backup) */
            if(File.Exists(config.backupAudioDir + @"\first_time"))
            {
                string content = File.ReadAllText(config.backupAudioDir + @"\first_time");
                if(String.Compare(content, "1") == 0)
                {
                    config.performBackup = true;
                } else
                {
                    config.performBackup = false;
                }
            }

            /* If first time then create the backup */
            if (config.performBackup)
            {
                PerformBackup();
            }

            /* Just setting up the file dialog for audio files */
            InitializeOpenFileDialog();

            listBoxFiles.AllowDrop = true;
            listBoxFiles.DragDrop += listBoxFiles_DragDrop;
            listBoxFiles.DragEnter += listBoxFiles_DragEnter;

            /* Disable btnExecutar */
            btnExecutar.Enabled = false;
        }

        private void listBoxFiles_DragEnter(object sender, DragEventArgs e)
        {
            /* Originals */
            //if (e.Data.GetDataPresent(DataFormats.FileDrop)) e.Effect = DragDropEffects.Copy;

            if (!e.Data.GetDataPresent(DataFormats.FileDrop)) return;
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (var file in files)
            {
                var ext = System.IO.Path.GetExtension(file);
                if (ext.Equals(".wav", StringComparison.CurrentCultureIgnoreCase) ||
                    ext.Equals(".WAV", StringComparison.CurrentCultureIgnoreCase))
                {
                    e.Effect = DragDropEffects.Copy;
                    return;
                }
            }
        }

        private void listBoxFiles_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string file in files)
            {
                listBoxFiles.Items.Add(file);
                listBoxFiles.SelectedIndex = 0;
            }
        }

        private void btnSelectFiles_Click(object sender, EventArgs e)
        {
            DialogResult dr = this.openFileDialog1.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {
                foreach(String file in openFileDialog1.FileNames)
                {
                    /* Add to listbox */
                    //listBoxFiles.Items.Clear();
                    listBoxFiles.Items.Add(file);
                    listBoxFiles.SelectedIndex = 0;

                    /* Process Audio Files */
                    
                    //////////////////////
                    /// TODO:
                    ///    - Copy and replace the audios files on their respectives directory.
                    ///    - Store the original audio files on the Resources Section.
                    ///    - Implement the 'reset audio to the originals' (Move the files on the Resource Sections to cstrike audio location
                    ///    - !
                }
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                if (String.Compare(Path.GetFileName(folderBrowserDialog1.SelectedPath), "cstrike") == 0)
                {
                    config.cstrike = folderBrowserDialog1.SelectedPath;
                }
                else
                {
                    DialogResult r = MessageBox.Show("Este diretório não possúi o nome cstrike.\nDeseja continuar?", "Aviso: cstrike", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (r == DialogResult.Yes)
                    {
                        config.cstrike = folderBrowserDialog1.SelectedPath;
                    }
                    else
                    {
                        // Pass...
                    }
                }
            }
            checkCstrike(config.cstrike);
        }

        int filesLoaded = 0;
        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* Count items */
            if(listBoxFiles.Items.Count > 0 && Directory.Exists(config.cstrike))
            {
                btnExecutar.Enabled = true;
            } else
            {
                btnExecutar.Enabled = false;
            }

            try
            {
                string audioName = "";
                if (listBoxFiles.SelectedItem != null) {
                    audioName = Path.GetFileName(listBoxFiles.SelectedItem.ToString());
                }

                lblAudioName.Text = audioName;
            } catch(Exception expx)
            {
                lblAudioName.Text = "";
            }
            

        }

        private void btnDeleteItem_Click(object sender, EventArgs e)
        {
            ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listBoxFiles);
            selectedItems = listBoxFiles.SelectedItems;

            if (listBoxFiles.SelectedIndex != -1)
            {
                for (int i = selectedItems.Count - 1; i >= 0; i--)
                {
                    listBoxFiles.Items.Remove(selectedItems[i]);
                }
            }
        }

        private void btnClearItems_Click(object sender, EventArgs e)
        {
            btnExecutar.Enabled = false;
            listBoxFiles.Items.Clear();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            /* Check if half-life is running */
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                if (String.Compare(theprocess.ProcessName, "hl") == 0)
                {
                    string p = String.Format("{0}.exe PID: {1}", theprocess.ProcessName, theprocess.Id);
                    MessageBox.Show("Por favor, feche o Counter Strike antes de continuar.\n" + p, "Counter Strike Aberto | " + p, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("HalfLife: {0}.exe PID: {1}", theprocess.ProcessName, theprocess.Id);
                    return;
                }
            }

            if(listBoxFiles.Items.Count != 0)
                Execute();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /* Check if half-life is running */
            Process[] processlist = Process.GetProcesses();
            foreach (Process theprocess in processlist)
            {
                if (String.Compare(theprocess.ProcessName, "hl") == 0)
                {
                    string p = String.Format("{0}.exe PID: {1}", theprocess.ProcessName, theprocess.Id);
                    MessageBox.Show("Por favor, feche o Counter Strike antes de continuar.\n" + p, "Counter Strike Aberto | " + p, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Console.WriteLine("HalfLife: {0}.exe PID: {1}", theprocess.ProcessName, theprocess.Id);
                    return;
                }
            }

            resetAudio reset = new resetAudio();
            reset.ShowDialog();

            if(config.reset)
            {
                string src = config.backupAudioDir + @"\sound";
                string dst = config.cstrike + @"\sound";

                /* Delete original sound directory */
                try
                {
                    Directory.Delete(dst, true);
                } catch(Exception expt)
                {
                    MessageBox.Show(expt.Message.ToString(), "Falha Durante a Operação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (Directory.Exists(src))
                {
                    Console.WriteLine("Performing reset {0} -> {1}", src, dst);
                    DirectoryCopy(src, dst, true);
                    MessageBox.Show("Os arquivos de áudio do Counter Strike 1.6 foram substituídos pelos originais.", "Operação Concluída!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    config.reset = false;
                }
            }
        }
        
        /* Credits RGB Effect */
        int R = 255;
        int G = 0;
        int B = 0;
        int stage = 0;
        private void timerCredits_Tick(object sender, EventArgs e)
        {
            
            if(stage == 0)
            {
                if (G < 255)
                    G++;
                else
                    stage = 1;
            } else if(stage == 1)
            {
                if (R > 0)
                    R--;
                else
                    stage = 2;
            } else if(stage == 2)
            {
                if (B < 255)
                    B++;
                else
                    stage = 3;
            } else if(stage == 3)
            {
                if (G > 0)
                    G--;
                else
                    stage = 4;
            } else if(stage == 4)
            {
                if (R < 255)
                    R++;
                else
                    stage = 5;
            } else if(stage == 5)
            {
                if (B > 0)
                    B--;
                else
                    stage = 6;
            } else if(stage == 6)
            {
                R = 255;
                G = 0;
                B = 0;
                stage = 0;
            }
            //Console.WriteLine("s:{0} - {1}, {2}, {3}", stage, R, G, B);
            lblCredits.ForeColor = Color.FromArgb(R, G, B);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bots b = new bots();
            b.ShowDialog();
        }
    }
}
