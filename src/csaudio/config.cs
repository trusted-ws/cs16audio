using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csaudio
{
    public static class config
    {
        ////////////////////////
        // Controles (NÃO MODIFICAR)
        ////////////////////////
        
        /* Trigger para resetar os audios */
        public static bool reset = false;

        /* Trigger para realizar backup */
        public static bool performBackup = false;

        /* Trigger para exit no Form 'locateCstrike' */
        public static bool locateSair = false;

        /* Caso haja bots na estrutura de diretórios do cstrike isto será definido como true */
        public static bool haveBots = false;

        ////////////////////////
        // Definições
        ////////////////////////

        /* Diretório padrão Steam */
        public static string steamDir = @"Program Files (x86)\Steam\steamapps\common\Half-Life\cstrike";

        /* Diretório de backup de audio e localização do cstrike */
        public static string backupDir = @"\cs16_audio_backup";

        /* Audio backup */
        public static string backupAudioDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + backupDir;

        /* Arquivo com localização do cstrike */
        public static string cstrikeDir = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + backupDir + @"\cstrike_location";

        /* cstrike */
        public static string cstrike = "";

    }
}
