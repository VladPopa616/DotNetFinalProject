using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFinalProject
{
    public class Contact
    {
        public int ID { get; set; }
        public string fn { get; set; }
        public string ln { get; set; }
        public string email { get; set; }

        public string phone { get; set; }

        public override string ToString()
        {
            return fn + "," + ln + "," + email + "," + phone;
        }
    }

   
}
