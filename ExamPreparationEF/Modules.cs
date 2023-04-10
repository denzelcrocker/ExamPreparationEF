using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationEF
{
    internal class Modules
    {
        public static string OpenDialog()
        {
            string path = null;
            Microsoft.Win32.OpenFileDialog openFileDialog = new Microsoft.Win32.OpenFileDialog();
            Nullable<bool> result = openFileDialog.ShowDialog();
            if (result == true)
            {
                path = openFileDialog.FileName;
            }
            return path;
        }
        public static void WriteChildrens(List<Children> childrens, string path)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(path))
                {
                    foreach (Children item in childrens)
                    {
                        string line = $"{item.Name},{item.Birthday},{item.Gender}";
                        writer.WriteLine(line);
                    }
                }
            }
            catch { }
        }
    }
}
