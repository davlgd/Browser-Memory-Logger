//  Copyright © 2011-2012 LEGRAND David <david@pcinpact.com>    
//  
//  This file is part of PC INpact Browser Memory Logger.
//
//  PC INpact Browser Memory Logger is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  PC INpact Browser Memory Logger is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with PC INpact Browser Memory Logger.  If not, see <http://www.gnu.org/licenses/>.

using System.Diagnostics;
using System.Globalization;

namespace NXi_Browser_Memory_Logger
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
