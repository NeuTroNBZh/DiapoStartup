using System;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace DiapoStartup
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcul du numéro de semaine selon la norme ISO (première semaine avec au moins 4 jours)
            CultureInfo culture = CultureInfo.CurrentCulture;
            int semaine = culture.Calendar.GetWeekOfYear(
                DateTime.Now,
                CalendarWeekRule.FirstFourDayWeek,
                DayOfWeek.Monday);
            string semaineFormat = semaine.ToString("D2"); // toujours 2 chiffres

            // Construction du chemin du fichier vidéo (ici extension .mp4)
            string videoPath = $"F:\\Diapo_accueille_S{semaineFormat}.mp4";

            // Vérification que le fichier existe
            if (!File.Exists(videoPath))
            {
                Console.WriteLine($"Fichier introuvable : {videoPath}");
                return;
            }

            // Préparation des arguments pour Windows Media Player : lancement immédiat, mode plein écran, lecture en boucle
            string arguments = $"/play /fullscreen /repeat \"{videoPath}\"";

            // Lancement de Windows Media Player
            try
            {
                Process.Start("wmplayer.exe", arguments);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erreur lors du lancement de Windows Media Player : " + ex.Message);
            }
        }
    }
}
