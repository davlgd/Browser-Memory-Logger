using System.IO;

namespace Browser_Memory_Logger
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
