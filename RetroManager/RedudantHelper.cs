using System.IO;
using System.Windows.Forms;

namespace RetroManager
{
    public static class RedudantHelper
    {
        public static bool DirectoryCheck(string text)
        {
            if (string.IsNullOrWhiteSpace(text))
            {
                MessageBox.Show(@"Directory field can not be empty");
                return false;
            }

            if (!Directory.Exists(text))
            {
                MessageBox.Show(@"Please enter a valid directory.");
                return false;
            }
            return true;
        }
    }
}
