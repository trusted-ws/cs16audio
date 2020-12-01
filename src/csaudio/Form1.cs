using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
                    string[] ver = File.ReadAllText(cst + "\\steam.inf").Split('=');
                    try
                    {
                        lblExe.ForeColor = Color.Black;
                        lblExe.Text = String.Format("Versão: (Steam) {0}", ver[1]);
                    }
                    catch (Exception ex)
                    {
                        lblExe.ForeColor = Color.Red;
                        lblExe.Text = String.Format("Versão: desconhecida (Steam)");
                    }
                }
                else
                {
                    lblExe.Text = "";
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

        private string ProcessAudio(string audioPath)
        {
            /* Copy the audio file to their respective directory */

            if(!File.Exists(audioPath)) { return ""; }

            string audioName = Path.GetFileName(audioPath.ToString());
            string basePath = config.cstrike + @"\sound";

            if(!Directory.Exists(basePath)) { return ""; }



            /* Biggest Switch */
            /////////////////////////////////
            /* Player - Weapons */
            /* Misc - Ambience */
            /*
              Issue: 
                   Os arquivos headshot2.wav estão em Player e Weapons
                   Os arquivos cow.wav e sheep.wav estão em Misc e Ambience
             */

            /////////////////////////////////

            switch (audioName)
            {
                /* Ambience */

                case "3dmbridge.wav":
                    basePath += @"\ambience";
                    break;

                case "3dmeagle.wav":
                    basePath += @"\ambience";
                    break;

                case "3dmstart.wav":
                    basePath += @"\ambience";
                    break;

                case "3dmthrill.wav":
                    basePath += @"\ambience";
                    break;

                case "alarm1.wav":
                    basePath += @"\ambience";
                    break;

                case "arabmusic.wav":
                    basePath += @"\ambience";
                    break;

                case "Birds1.wav":
                    basePath += @"\ambience";
                    break;

                case "Birds2.wav":
                    basePath += @"\ambience";
                    break;

                case "Birds3.wav":
                    basePath += @"\ambience";
                    break;

                case "Birds4.wav":
                    basePath += @"\ambience";
                    break;

                case "Birds5.wav":
                    basePath += @"\ambience";
                    break;

                case "Birds6.wav":
                    basePath += @"\ambience";
                    break;

                case "Birds7.wav":
                    basePath += @"\ambience";
                    break;

                case "Birds8.wav":
                    basePath += @"\ambience";
                    break;

                case "Birds9.wav":
                    basePath += @"\ambience";
                    break;

                case "car1.wav":
                    basePath += @"\ambience";
                    break;

                case "car2.wav":
                    basePath += @"\ambience";
                    break;

                case "cat1.wav":
                    basePath += @"\ambience";
                    break;

                case "chimes.wav":
                    basePath += @"\ambience";
                    break;

                case "cicada3.wav":
                    basePath += @"\ambience";
                    break;

                case "copter.wav":
                    basePath += @"\ambience";
                    break;

                case "cow.wav":
                    basePath += @"\ambience";
                    break;

                case "crow.wav":
                    basePath += @"\ambience";
                    break;

                case "dog1.wav":
                    basePath += @"\ambience";
                    break;

                case "dog2.wav":
                    basePath += @"\ambience";
                    break;

                case "dog3.wav":
                    basePath += @"\ambience";
                    break;

                case "dog4.wav":
                    basePath += @"\ambience";
                    break;

                case "dog5.wav":
                    basePath += @"\ambience";
                    break;

                case "dog6.wav":
                    basePath += @"\ambience";
                    break;

                case "dog7.wav":
                    basePath += @"\ambience";
                    break;

                case "doorbell.wav":
                    basePath += @"\ambience";
                    break;

                case "fallscream.wav":
                    basePath += @"\ambience";
                    break;

                case "guit1.wav":
                    basePath += @"\ambience";
                    break;

                case "kajika.wav":
                    basePath += @"\ambience";
                    break;

                case "lv1.wav":
                    basePath += @"\ambience";
                    break;

                case "lv2.wav":
                    basePath += @"\ambience";
                    break;

                case "lv3.wav":
                    basePath += @"\ambience";
                    break;

                case "lv4.wav":
                    basePath += @"\ambience";
                    break;

                case "lv5.wav":
                    basePath += @"\ambience";
                    break;

                case "lv6.wav":
                    basePath += @"\ambience";
                    break;

                case "lv_elvis.wav":
                    basePath += @"\ambience";
                    break;

                case "lv_fruit1.wav":
                    basePath += @"\ambience";
                    break;

                case "lv_fruit2.wav":
                    basePath += @"\ambience";
                    break;

                case "lv_fruitwin.wav":
                    basePath += @"\ambience";
                    break;

                case "lv_jubilee.wav":
                    basePath += @"\ambience";
                    break;

                case "lv_neon.wav":
                    basePath += @"\ambience";
                    break;

                case "Opera.wav":
                    basePath += @"\ambience";
                    break;

                case "rain.wav":
                    basePath += @"\ambience";
                    break;

                case "ratchant.wav":
                    basePath += @"\ambience";
                    break;

                case "rd_shipshorn.wav":
                    basePath += @"\ambience";
                    break;

                case "rd_waves.wav":
                    basePath += @"\ambience";
                    break;

                case "sheep.wav":
                    basePath += @"\ambience";
                    break;

                case "sparrow.wav":
                    basePath += @"\ambience";
                    break;

                case "thunder_clap.wav":
                    basePath += @"\ambience";
                    break;

                case "waterrun.wav":
                    basePath += @"\ambience";
                    break;

                case "wolfhowl01.wav":
                    basePath += @"\ambience";
                    break;

                case "wolfhowl02.wav":
                    basePath += @"\ambience";
                    break;

                /* de_torn */

                case "tk_steam.wav":
                    basePath += @"\de_torn";
                    break;

                case "tk_windStreet.wav":
                    basePath += @"\de_torn";
                    break;

                case "torn_AK-47.wav":
                    basePath += @"\de_torn";
                    break;

                case "torn_ambience.wav":
                    basePath += @"\de_torn";
                    break;

                case "torn_Bomb1.wav":
                    basePath += @"\de_torn";
                    break;

                case "torn_Bomb2.wav":
                    basePath += @"\de_torn";
                    break;

                case "torn_MGun1.wav":
                    basePath += @"\de_torn";
                    break;

                case "torn_Templewind.wav":
                    basePath += @"\de_torn";
                    break;

                case "torn_thndrstrike.wav":
                    basePath += @"\de_torn";
                    break;

                case "torn_water1.wav":
                    basePath += @"\de_torn";
                    break;

                case "torn_water2.wav":
                    basePath += @"\de_torn";
                    break;

                /*Events*/

                case "enemy_died.wav":
                    basePath += @"\events";
                    break;

                case "friend_died.wav":
                    basePath += @"\events";
                    break;

                case "task_complete.wav":
                    basePath += @"\events";
                    break;

                case "tutor_msg.wav":
                    basePath += @"\events";
                    break;

                /*Hostage*/

                case "hos1.wav":
                    basePath += @"\hostage";
                    break;

                case "hos2.wav":
                    basePath += @"\hostage";
                    break;

                case "hos3.wav":
                    basePath += @"\hostage";
                    break;

                case "hos4.wav":
                    basePath += @"\hostage";
                    break;

                case "hos5.wav":
                    basePath += @"\hostage";
                    break;

                /*Items*/

                case "equip_nvg.wav":
                    basePath += @"\items";
                    break;

                case "kevlar.wav":
                    basePath += @"\items";
                    break;

                case "nvg_off.wav":
                    basePath += @"\items";
                    break;

                case "nvg_on.wav":
                    basePath += @"\items";
                    break;

                case "tr_kevlar.wav":
                    basePath += @"\items";
                    break;

                /*Misc*/

/*                case "cow.wav":
                    basePath += @"\misc";
                    break;*/

                case "killChicken.wav":
                    basePath += @"\misc";
                    break;

                case "plane_drone.wav":
                    basePath += @"\misc";
                    break;

/*                case "sheep.wav":
                    basePath += @"\misc";
                    break;*/

                case "talk.wav":
                    basePath += @"\misc";
                    break;

                /*Plats*/

                case "vehicle1.wav":
                    basePath += @"\plats";
                    break;

                case "vehicle2.wav":
                    basePath += @"\plats";
                    break;

                case "vehicle3.wav":
                    basePath += @"\plats";
                    break;

                case "vehicle4.wav":
                    basePath += @"\plats";
                    break;

                case "vehicle6.wav":
                    basePath += @"\plats";
                    break;

                case "vehicle7.wav":
                    basePath += @"\plats";
                    break;

                case "vehicle_brake1.wav":
                    basePath += @"\plats";
                    break;

                case "vehicle_ignition.wav":
                    basePath += @"\plats";
                    break;

                case "vehicle_start1.wav":
                    basePath += @"\plats";
                    break;

                /* Player */

                case "bhit_flesh-1.wav":
                    basePath += @"\player";
                    break;

                case "bhit_flesh-2.wav":
                    basePath += @"\player";
                    break;

                case "bhit_flesh-3.wav":
                    basePath += @"\player";
                    break;

                case "bhit_helmet-1.wav":
                    basePath += @"\player";
                    break;

                case "bhit_kevlar-1.wav":
                    basePath += @"\player";
                    break;

                case "breathe1.wav":
                    basePath += @"\player";
                    break;

                case "breathe2.wav":
                    basePath += @"\player";
                    break;

                case "death6.wav":
                    basePath += @"\player";
                    break;

                case "die1.wav":
                    basePath += @"\player";
                    break;

                case "die2.wav":
                    basePath += @"\player";
                    break;

                case "die3.wav":
                    basePath += @"\player";
                    break;

                case "headshot1.wav":
                    basePath += @"\player";
                    break;

/*                case "headshot2.wav": 
                    basePath += @"\player";
                    break;*/

                case "headshot3.wav":
                    basePath += @"\player";
                    break;

                case "pl_die1.wav":
                    basePath += @"\player";
                    break;

                case "pl_dirt1.wav":
                    basePath += @"\player";
                    break;

                case "pl_dirt2.wav":
                    basePath += @"\player";
                    break;

                case "pl_dirt3.wav":
                    basePath += @"\player";
                    break;

                case "pl_dirt4.wav":
                    basePath += @"\player";
                    break;

                case "pl_duct1.wav":
                    basePath += @"\player";
                    break;

                case "pl_duct2.wav":
                    basePath += @"\player";
                    break;

                case "pl_duct3.wav":
                    basePath += @"\player";
                    break;

                case "pl_duct4.wav":
                    basePath += @"\player";
                    break;

                case "pl_fallpain1.wav":
                    basePath += @"\player";
                    break;

                case "pl_fallpain2.wav":
                    basePath += @"\player";
                    break;

                case "pl_fallpain3.wav":
                    basePath += @"\player";
                    break;

                case "pl_grate1.wav":
                    basePath += @"\player";
                    break;

                case "pl_grate2.wav":
                    basePath += @"\player";
                    break;

                case "pl_grate3.wav":
                    basePath += @"\player";
                    break;

                case "pl_grate4.wav":
                    basePath += @"\player";
                    break;

                case "pl_jump1.wav":
                    basePath += @"\player";
                    break;

                case "pl_jump2.wav":
                    basePath += @"\player";
                    break;

                case "pl_ladder1.wav":
                    basePath += @"\player";
                    break;

                case "pl_ladder2.wav":
                    basePath += @"\player";
                    break;

                case "pl_ladder3.wav":
                    basePath += @"\player";
                    break;

                case "pl_ladder4.wav":
                    basePath += @"\player";
                    break;

                case "pl_metal1.wav":
                    basePath += @"\player";
                    break;

                case "pl_metal2.wav":
                    basePath += @"\player";
                    break;

                case "pl_metal3.wav":
                    basePath += @"\player";
                    break;

                case "pl_metal4.wav":
                    basePath += @"\player";
                    break;

                case "pl_pain2.wav":
                    basePath += @"\player";
                    break;

                case "pl_pain4.wav":
                    basePath += @"\player";
                    break;

                case "pl_pain5.wav":
                    basePath += @"\player";
                    break;

                case "pl_pain6.wav":
                    basePath += @"\player";
                    break;

                case "pl_pain7.wav":
                    basePath += @"\player";
                    break;

                case "pl_shell1.wav":
                    basePath += @"\player";
                    break;

                case "pl_shot1.wav":
                    basePath += @"\player";
                    break;

                case "pl_slosh1.wav":
                    basePath += @"\player";
                    break;

                case "pl_slosh2.wav":
                    basePath += @"\player";
                    break;

                case "pl_slosh3.wav":
                    basePath += @"\player";
                    break;

                case "pl_slosh4.wav":
                    basePath += @"\player";
                    break;

                case "pl_snow1.wav":
                    basePath += @"\player";
                    break;

                case "pl_snow2.wav":
                    basePath += @"\player";
                    break;

                case "pl_snow3.wav":
                    basePath += @"\player";
                    break;

                case "pl_snow4.wav":
                    basePath += @"\player";
                    break;

                case "pl_snow5.wav":
                    basePath += @"\player";
                    break;

                case "pl_snow6.wav":
                    basePath += @"\player";
                    break;

                case "pl_step1.wav":
                    basePath += @"\player";
                    break;

                case "pl_step2.wav":
                    basePath += @"\player";
                    break;

                case "pl_step3.wav":
                    basePath += @"\player";
                    break;

                case "pl_step4.wav":
                    basePath += @"\player";
                    break;

                case "pl_swim1.wav":
                    basePath += @"\player";
                    break;

                case "pl_swim2.wav":
                    basePath += @"\player";
                    break;

                case "pl_swim3.wav":
                    basePath += @"\player";
                    break;

                case "pl_swim4.wav":
                    basePath += @"\player";
                    break;

                case "pl_tile1.wav":
                    basePath += @"\player";
                    break;

                case "pl_tile2.wav":
                    basePath += @"\player";
                    break;

                case "pl_tile3.wav":
                    basePath += @"\player";
                    break;

                case "pl_tile4.wav":
                    basePath += @"\player";
                    break;

                case "pl_tile5.wav":
                    basePath += @"\player";
                    break;

                case "pl_wade1.wav":
                    basePath += @"\player";
                    break;

                case "pl_wade2.wav":
                    basePath += @"\player";
                    break;

                case "pl_wade3.wav":
                    basePath += @"\player";
                    break;

                case "pl_wade4.wav":
                    basePath += @"\player";
                    break;

                case "sprayer.wav":
                    basePath += @"\player";
                    break;

                /*Radio*/

                case "blow.wav":
                    basePath += @"\radio";
                    break;

                case "bombdef.wav":
                    basePath += @"\radio";
                    break;

                case "bombpl.wav":
                    basePath += @"\radio";
                    break;

                case "circleback.wav":
                    basePath += @"\radio";
                    break;

                case "clear.wav":
                    basePath += @"\radio";
                    break;

                case "com_followcom.wav":
                    basePath += @"\radio";
                    break;

                case "com_getinpos.wav":
                    basePath += @"\radio";
                    break;

                case "com_go.wav":
                    basePath += @"\radio";
                    break;

                case "com_reportin.wav":
                    basePath += @"\radio";
                    break;

                case "ctwin.wav":
                    basePath += @"\radio";
                    break;

                case "ct_affirm.wav":
                    basePath += @"\radio";
                    break;

                case "ct_backup.wav":
                    basePath += @"\radio";
                    break;

                case "ct_coverme.wav":
                    basePath += @"\radio";
                    break;

                case "ct_enemys.wav":
                    basePath += @"\radio";
                    break;

                case "ct_fireinhole.wav":
                    basePath += @"\radio";
                    break;

                case "ct_imhit.wav":
                    basePath += @"\radio";
                    break;

                case "ct_inpos.wav":
                    basePath += @"\radio";
                    break;

                case "ct_point.wav":
                    basePath += @"\radio";
                    break;

                case "ct_reportingin.wav":
                    basePath += @"\radio";
                    break;

                case "elim.wav":
                    basePath += @"\radio";
                    break;

                case "enemydown.wav":
                    basePath += @"\radio";
                    break;

                case "fallback.wav":
                    basePath += @"\radio";
                    break;

                case "fireassis.wav":
                    basePath += @"\radio";
                    break;

                case "flankthem.wav":
                    basePath += @"\radio";
                    break;

                case "followme.wav":
                    basePath += @"\radio";
                    break;

                case "getout.wav":
                    basePath += @"\radio";
                    break;

                case "go.wav":
                    basePath += @"\radio";
                    break;

                case "hitassist.wav":
                    basePath += @"\radio";
                    break;

                case "hosdown.wav":
                    basePath += @"\radio";
                    break;

                case "letsgo.wav":
                    basePath += @"\radio";
                    break;

                case "locknload.wav":
                    basePath += @"\radio";
                    break;

                case "matedown.wav":
                    basePath += @"\radio";
                    break;

                case "meetme.wav":
                    basePath += @"\radio";
                    break;

                case "moveout.wav":
                    basePath += @"\radio";
                    break;

                case "negative.wav":
                    basePath += @"\radio";
                    break;

                case "position.wav":
                    basePath += @"\radio";
                    break;

                case "regroup.wav":
                    basePath += @"\radio";
                    break;

                case "rescued.wav":
                    basePath += @"\radio";
                    break;

                case "roger.wav":
                    basePath += @"\radio";
                    break;

                case "rounddraw.wav":
                    basePath += @"\radio";
                    break;

                case "sticktog.wav":
                    basePath += @"\radio";
                    break;

                case "stormfront.wav":
                    basePath += @"\radio";
                    break;

                case "takepoint.wav":
                    basePath += @"\radio";
                    break;

                case "terwin.wav":
                    basePath += @"\radio";
                    break;

                case "vip.wav":
                    basePath += @"\radio";
                    break;

                /*Storm*/

                case "thunder-theme.wav":
                    basePath += @"\storm";
                    break;

                /*Weapons*/

                case "ak47-1.wav":
                    basePath += @"\weapons";
                    break;

                case "ak47-2.wav":
                    basePath += @"\weapons";
                    break;

                case "ak47_boltpull.wav":
                    basePath += @"\weapons";
                    break;

                case "ak47_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "ak47_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "aug-1.wav":
                    basePath += @"\weapons";
                    break;

                case "aug_boltpull.wav":
                    basePath += @"\weapons";
                    break;

                case "aug_boltslap.wav":
                    basePath += @"\weapons";
                    break;

                case "aug_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "aug_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "aug_forearm.wav":
                    basePath += @"\weapons";
                    break;

                case "awp1.wav":
                    basePath += @"\weapons";
                    break;

                case "awp_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "awp_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "awp_deploy.wav":
                    basePath += @"\weapons";
                    break;

                case "boltdown.wav":
                    basePath += @"\weapons";
                    break;

                case "boltpull1.wav":
                    basePath += @"\weapons";
                    break;

                case "boltup.wav":
                    basePath += @"\weapons";
                    break;

                case "c4_beep1.wav":
                    basePath += @"\weapons";
                    break;

                case "c4_beep2.wav":
                    basePath += @"\weapons";
                    break;

                case "c4_beep3.wav":
                    basePath += @"\weapons";
                    break;

                case "c4_beep4.wav":
                    basePath += @"\weapons";
                    break;

                case "c4_beep5.wav":
                    basePath += @"\weapons";
                    break;

                case "c4_click.wav":
                    basePath += @"\weapons";
                    break;

                case "c4_disarm.wav":
                    basePath += @"\weapons";
                    break;

                case "c4_disarmed.wav":
                    basePath += @"\weapons";
                    break;

                case "c4_explode1.wav":
                    basePath += @"\weapons";
                    break;

                case "c4_plant.wav":
                    basePath += @"\weapons";
                    break;

                case "clipin1.wav":
                    basePath += @"\weapons";
                    break;

                case "clipout1.wav":
                    basePath += @"\weapons";
                    break;

                case "deagle-1.wav":
                    basePath += @"\weapons";
                    break;

                case "deagle-2.wav":
                    basePath += @"\weapons";
                    break;

                case "de_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "de_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "de_deploy.wav":
                    basePath += @"\weapons";
                    break;

                case "dryfire_pistol.wav":
                    basePath += @"\weapons";
                    break;

                case "dryfire_rifle.wav":
                    basePath += @"\weapons";
                    break;

                case "elite_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "elite_deploy.wav":
                    basePath += @"\weapons";
                    break;

                case "elite_fire.wav":
                    basePath += @"\weapons";
                    break;

                case "elite_leftclipin.wav":
                    basePath += @"\weapons";
                    break;

                case "elite_reloadstart.wav":
                    basePath += @"\weapons";
                    break;

                case "elite_rightclipin.wav":
                    basePath += @"\weapons";
                    break;

                case "elite_sliderelease.wav":
                    basePath += @"\weapons";
                    break;

                case "elite_twirl.wav":
                    basePath += @"\weapons";
                    break;

                case "famas-1.wav":
                    basePath += @"\weapons";
                    break;

                case "famas-2.wav":
                    basePath += @"\weapons";
                    break;

                case "famas-burst.wav":
                    basePath += @"\weapons";
                    break;

                case "famas_boltpull.wav":
                    basePath += @"\weapons";
                    break;

                case "famas_boltslap.wav":
                    basePath += @"\weapons";
                    break;

                case "famas_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "famas_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "famas_forearm.wav":
                    basePath += @"\weapons";
                    break;

                case "fiveseven-1.wav":
                    basePath += @"\weapons";
                    break;

                case "fiveseven_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "fiveseven_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "fiveseven_slidepull.wav":
                    basePath += @"\weapons";
                    break;

                case "fiveseven_sliderelease.wav":
                    basePath += @"\weapons";
                    break;

                case "flashbang-1.wav":
                    basePath += @"\weapons";
                    break;

                case "flashbang-2.wav":
                    basePath += @"\weapons";
                    break;

                case "g3sg1-1.wav":
                    basePath += @"\weapons";
                    break;

                case "g3sg1_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "g3sg1_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "g3sg1_slide.wav":
                    basePath += @"\weapons";
                    break;

                case "galil-1.wav":
                    basePath += @"\weapons";
                    break;

                case "galil-2.wav":
                    basePath += @"\weapons";
                    break;

                case "galil_boltpull.wav":
                    basePath += @"\weapons";
                    break;

                case "galil_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "galil_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "generic_reload.wav":
                    basePath += @"\weapons";
                    break;

                case "generic_shot_reload.wav":
                    basePath += @"\weapons";
                    break;

                case "glock18-1.wav":
                    basePath += @"\weapons";
                    break;

                case "glock18-2.wav":
                    basePath += @"\weapons";
                    break;

                case "grenade_hit1.wav":
                    basePath += @"\weapons";
                    break;

                case "grenade_hit2.wav":
                    basePath += @"\weapons";
                    break;

                case "grenade_hit3.wav":
                    basePath += @"\weapons";
                    break;

                case "headshot2.wav":
                    basePath += @"\weapons";
                    break;

                case "hegrenade-1.wav":
                    basePath += @"\weapons";
                    break;

                case "hegrenade-2.wav":
                    basePath += @"\weapons";
                    break;

                case "he_bounce-1.wav":
                    basePath += @"\weapons";
                    break;

                case "knife_deploy1.wav":
                    basePath += @"\weapons";
                    break;

                case "knife_hit1.wav":
                    basePath += @"\weapons";
                    break;

                case "knife_hit2.wav":
                    basePath += @"\weapons";
                    break;

                case "knife_hit3.wav":
                    basePath += @"\weapons";
                    break;

                case "knife_hit4.wav":
                    basePath += @"\weapons";
                    break;

                case "knife_hitwall1.wav":
                    basePath += @"\weapons";
                    break;

                case "knife_slash1.wav":
                    basePath += @"\weapons";
                    break;

                case "knife_slash2.wav":
                    basePath += @"\weapons";
                    break;

                case "knife_stab.wav":
                    basePath += @"\weapons";
                    break;

                case "m249-1.wav":
                    basePath += @"\weapons";
                    break;

                case "m249-2.wav":
                    basePath += @"\weapons";
                    break;

                case "m249_boxin.wav":
                    basePath += @"\weapons";
                    break;

                case "m249_boxout.wav":
                    basePath += @"\weapons";
                    break;

                case "m249_chain.wav":
                    basePath += @"\weapons";
                    break;

                case "m249_coverdown.wav":
                    basePath += @"\weapons";
                    break;

                case "m249_coverup.wav":
                    basePath += @"\weapons";
                    break;

                case "m3-1.wav":
                    basePath += @"\weapons";
                    break;

                case "m3_insertshell.wav":
                    basePath += @"\weapons";
                    break;

                case "m3_pump.wav":
                    basePath += @"\weapons";
                    break;

                case "m4a1-1.wav":
                    basePath += @"\weapons";
                    break;

                case "m4a1_boltpull.wav":
                    basePath += @"\weapons";
                    break;

                case "m4a1_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "m4a1_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "m4a1_deploy.wav":
                    basePath += @"\weapons";
                    break;

                case "m4a1_silencer_off.wav":
                    basePath += @"\weapons";
                    break;

                case "m4a1_silencer_on.wav":
                    basePath += @"\weapons";
                    break;

                case "m4a1_unsil-1.wav":
                    basePath += @"\weapons";
                    break;

                case "m4a1_unsil-2.wav":
                    basePath += @"\weapons";
                    break;

                case "mac10-1.wav":
                    basePath += @"\weapons";
                    break;

                case "mac10_boltpull.wav":
                    basePath += @"\weapons";
                    break;

                case "mac10_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "mac10_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "mp5-1.wav":
                    basePath += @"\weapons";
                    break;

                case "mp5-2.wav":
                    basePath += @"\weapons";
                    break;

                case "mp5_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "mp5_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "mp5_slideback.wav":
                    basePath += @"\weapons";
                    break;

                case "p228-1.wav":
                    basePath += @"\weapons";
                    break;

                case "p228_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "p228_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "p228_slidepull.wav":
                    basePath += @"\weapons";
                    break;

                case "p228_sliderelease.wav":
                    basePath += @"\weapons";
                    break;

                case "p90-1.wav":
                    basePath += @"\weapons";
                    break;

                case "p90_boltpull.wav":
                    basePath += @"\weapons";
                    break;

                case "p90_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "p90_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "p90_cliprelease.wav":
                    basePath += @"\weapons";
                    break;

                case "pinpull.wav":
                    basePath += @"\weapons";
                    break;

                case "ric_conc-1.wav":
                    basePath += @"\weapons";
                    break;

                case "ric_conc-2.wav":
                    basePath += @"\weapons";
                    break;

                case "ric_metal-1.wav":
                    basePath += @"\weapons";
                    break;

                case "ric_metal-2.wav":
                    basePath += @"\weapons";
                    break;

                case "scout_bolt.wav":
                    basePath += @"\weapons";
                    break;

                case "scout_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "scout_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "scout_fire-1.wav":
                    basePath += @"\weapons";
                    break;

                case "sg550-1.wav":
                    basePath += @"\weapons";
                    break;

                case "sg550_boltpull.wav":
                    basePath += @"\weapons";
                    break;

                case "sg550_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "sg550_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "sg552-1.wav":
                    basePath += @"\weapons";
                    break;

                case "sg552-2.wav":
                    basePath += @"\weapons";
                    break;

                case "sg552_boltpull.wav":
                    basePath += @"\weapons";
                    break;

                case "sg552_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "sg552_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "sg_explode.wav":
                    basePath += @"\weapons";
                    break;

                case "slideback1.wav":
                    basePath += @"\weapons";
                    break;

                case "sliderelease1.wav":
                    basePath += @"\weapons";
                    break;

                case "tmp-1.wav":
                    basePath += @"\weapons";
                    break;

                case "tmp-2.wav":
                    basePath += @"\weapons";
                    break;

                case "ump45-1.wav":
                    basePath += @"\weapons";
                    break;

                case "ump45_boltslap.wav":
                    basePath += @"\weapons";
                    break;

                case "ump45_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "ump45_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "usp1.wav":
                    basePath += @"\weapons";
                    break;

                case "usp2.wav":
                    basePath += @"\weapons";
                    break;

                case "usp_clipin.wav":
                    basePath += @"\weapons";
                    break;

                case "usp_clipout.wav":
                    basePath += @"\weapons";
                    break;

                case "usp_silencer_off.wav":
                    basePath += @"\weapons";
                    break;

                case "usp_silencer_on.wav":
                    basePath += @"\weapons";
                    break;

                case "usp_slideback.wav":
                    basePath += @"\weapons";
                    break;

                case "usp_sliderelease.wav":
                    basePath += @"\weapons";
                    break;

                case "usp_unsil-1.wav":
                    basePath += @"\weapons";
                    break;

                case "xm1014-1.wav":
                    basePath += @"\weapons";
                    break;

                case "zoom.wav":
                    basePath += @"\weapons";
                    break;
            }

            //Console.WriteLine("[DEBUG] {0} -> {1}", audioName,  basePath);
            return basePath + @"\" + audioName;
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
            foreach(string audio in listBoxFiles.Items)
            {
                string path = ProcessAudio(audio);
                if(!String.IsNullOrEmpty(path) || !String.IsNullOrWhiteSpace(path))
                {
                    /* Copy and replace the audio file */
                    //Console.WriteLine("Copying {0} para {1}", audio, path);
                    try
                    {
                        File.Copy(audio, path, true);
                    } catch(System.IO.IOException useExc)
                    {
                        MessageBox.Show("Não foi possível completar a operação pois os\narquivos estão sendo utilizados por outro processo!", "Falha na Operação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        //listBoxFiles.Items.Clear();
                        
                        return;
                    } catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Falha na Operação!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } 

            }
            listBoxFiles.Items.Clear();
            MessageBox.Show("Os arquivos de audio foram instalados com sucesso!", "Operação concluída!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            Execute();
        }

        private void button1_Click(object sender, EventArgs e)
        {
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
    }
}
