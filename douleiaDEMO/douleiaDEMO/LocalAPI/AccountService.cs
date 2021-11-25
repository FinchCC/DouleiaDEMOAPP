using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace douleiaDEMO.LocalAPI
{
    public class AccountService
    {
        public static bool getUser()
        {
            var text = File.ReadAllText(FIleHandler.dbUserData);

            if (string.IsNullOrEmpty(text))
                return false;

            return true;
        }
    }
}
