using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginContracts;
using System.IO;
using System.Security.Cryptography;
namespace PluginControlSum
{
    public class ControlSum : IControlSum
    {
        public string SumFile(string path)
        {
            using (FileStream fileStream = System.IO.File.OpenRead(path))
            {
                SHA1 sha1 = new SHA1CryptoServiceProvider();
                byte[] fileData = new byte[fileStream.Length];
                fileStream.Read(fileData, 0, (int)fileStream.Length);
                byte[] ControlSum = sha1.ComputeHash(fileData);
                return BitConverter.ToString(ControlSum).Replace("-", "");
            }
        }
    }
}
