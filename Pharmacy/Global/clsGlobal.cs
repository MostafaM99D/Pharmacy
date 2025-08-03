using BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public class clsGlobal
    {
        public static clsUsers CurrentUser { get; set; }
        public static string FilePath = Path.Combine(
          Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName, "LoginUsers.txt");

        public static bool AddUsernameAndPasswordToFile(string username, string password)
        {

            using (StreamWriter writer = new StreamWriter(FilePath))
            {

                writer.WriteLine(username);
                writer.WriteLine(password);
            }
            return true;
        }

        public static bool GetSavedUsernameAndPassword(ref string username, ref string password)
        {
            if (!File.Exists(FilePath))
                return false;

            using (StreamReader reader = new StreamReader(FilePath))
            {
                username = reader.ReadLine();
                password = reader.ReadLine();
            }
            return true;
        }
        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        public static void WidthCorrector(DataGridView DgvName,int Height)
        {
            for (int i = 0; i < DgvName.Rows.Count; i++)
                DgvName.Rows[i].Height = Height;
        }
    }
}
