using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeleteLines.Domain
{
    public sealed class DeleteLineUtil
    {

        private static DeleteLineUtil instance = null;

        private DeleteLineUtil()
        {
        }

        public static DeleteLineUtil Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new DeleteLineUtil();
                }
                return instance;
            }
        }

        public static bool PopulateListBoxWithFileNames(string folder, string extensions, ListBox listBox)
        {
            bool result = false;

            try
            {

                DirectoryInfo di = new DirectoryInfo(folder);

                string rawList = extensions;
                string[] splits = rawList.Split(',');

                listBox.Items.Clear();

                foreach (string split in splits)
                {
                    foreach (FileInfo fileInfo in di.GetFiles(split, SearchOption.TopDirectoryOnly))
                    {
                        listBox.Items.Add(fileInfo.Name);
                    }
                }


                result = true;
               
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
  
        public static bool PerformDelete(string folder, bool createBackup, List<String> fileNames, int lineNumber)
        {
            bool result = false;

            try
            {
                string backupLocation = folder + @"\backups";

                if (createBackup)
                {
                    System.IO.Directory.CreateDirectory(backupLocation);

                    foreach (string fileLocation in fileNames)
                    {
                        System.IO.File.Copy(folder + @"\" + fileLocation, backupLocation + @"\" + fileLocation, true);
                    }
                }

                foreach (string fileLocation in fileNames)
                {
                    string filename = folder + @"\" + fileLocation;

                    StringBuilder sb = new StringBuilder();
                    using (StreamReader sr = new StreamReader(filename))
                    {
                        int Countup = 0;
                        while (!sr.EndOfStream)
                        {
                            Countup++;
                            if (Countup != lineNumber)
                            {
                                using (StringWriter sw = new StringWriter(sb))
                                {
                                    sw.WriteLine(sr.ReadLine());
                                }
                            }
                            else
                            {
                                sr.ReadLine();
                            }
                        }
                    }

                    using (StreamWriter sw = new StreamWriter(filename))
                    {
                        sw.Write(sb.ToString());
                    }
                   
                }
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }
            return result;
        }
    }
}
