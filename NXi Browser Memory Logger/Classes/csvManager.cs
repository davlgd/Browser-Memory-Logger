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

using System.IO;

namespace NXi_Browser_Memory_Logger
{
    class csvManager
    {

        private string basePath;
        private string appName;
        private string separator = ";";
        private string extension = ".csv";

        // Le constructeur. Le nom de l'application est nécessaire, il sera utilisé pour le nom des fichiers CSV
        public csvManager(string app)
        {
            this.basePath = Path.GetTempPath() + app;
            this.appName = app;
        }

        // La fonction qui supprime les anciens fichiers CSV
        public void cleanFiles()
        {
            // On récupère la liste des fichiers concernés, s'ils existent, on les supprime
            string[] csvFiles = Directory.GetFiles(Path.GetTempPath(), "*" + extension);
            foreach (string f in csvFiles)
            {
                if (File.Exists(f)) File.Delete(f);
            }
        }

        // La fonction qui écrit dans le fichier CSV
        public void appendCSV(long memUsed, string process)
        {
            // On récupère le nom du fichier
            string logFile = composeCSVFileName(process);

            // On rajoute la variable récupérée puis le séparateur
            using (StreamWriter sw = File.AppendText(logFile))
            {
                sw.Write(memUsed.ToString() + separator);
            }

        }

        // La fonction qui renvoie le nom du fichier CSV
        public string getCSVFileName(string process)
        {
            return composeCSVFileName(process);
        }

        // La fonction interne qui construit le nom du fichier CSV
        private string composeCSVFileName(string process)
        {
            return basePath + "_" + process + extension;
        }
    }
}
