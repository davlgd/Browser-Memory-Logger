using System.Diagnostics;
using System.Globalization;

namespace Browser_Memory_Logger
{
    class processManager
    {

        // La fonction qui récupère la quantité de mémoire consommée par un processus
        public static long[] getUsedMem(string processToCheck)
        {
            // On récupère la liste des processus et on met les compteurs à zéro
            Process[] processes = Process.GetProcesses();
            long totalMemUsed = 0;
            long pCount = 0;

            // Pour chaque processus, si le nom est reconnu, on incrémente les compteurs
            foreach (Process p in processes)
            {
                if (p.ProcessName.ToLower().Equals(processToCheck.ToLower()))
                {
                    totalMemUsed += p.PrivateMemorySize64;
                    pCount++;
                }
            }

            // On renvoie un tableau contenant la mémoire total en Mo et le nombre de processus détectés
            long[] rA = { totalMemUsed / 1024L / 1024L, pCount };

            return rA;
        }

        // La fonction qui compose la phrase affichée depuis les variables récupérées
        public static string getMemUsedString(long[] ProcessUsedMem)
        {
            // On modifie le séparateur des milliers
            NumberFormatInfo nfi = (NumberFormatInfo)
            CultureInfo.InvariantCulture.NumberFormat.Clone();
            nfi.NumberGroupSeparator = " ";

            // On récupère et on met en forme les deux variables utiles
            string memUsed = ProcessUsedMem[0].ToString("n", nfi).Split('.')[0];
            string pCount = ProcessUsedMem[1].ToString();

            return string.Format("{0} Mo ({1} processus)", memUsed, pCount);
        }
    }
}
