using System;
using System.Collections.Generic;
using System.Text;

namespace douleiaDEMO.Models
{
    public class MyProfile
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> Skills { get; set; }
        public string AboutMe { get; set; }
    }
}
