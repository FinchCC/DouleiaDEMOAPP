using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace douleiaDEMO.LocalAPI
{
    public class FIleHandler
    {
        public static readonly string dbPath = Path.Combine(Environment.SpecialFolder.MyDocuments.ToString(), "DouleiaData");
        public static readonly string dbUserData = Path.Combine(dbPath, "userdbdata.txt");
        public static async Task<Task> createDB()
        {
            if (Directory.Exists(dbPath))
                return Task.CompletedTask;

            Directory.CreateDirectory(dbPath);
            File.Create(dbUserData);

            return Task.CompletedTask;
                
        }
    }
}
