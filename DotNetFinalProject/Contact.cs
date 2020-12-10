using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetFinalProject
{
    public class Contact
    {
        private string text1;
        private string text2;
        private string text3;
        private string text4;

        public Contact(string text1, string text2, string text3, string text4)
        {
            this.text1 = text1;
            this.text2 = text2;
            this.text3 = text3;
            this.text4 = text4;
        }

        //public int ID { get; set; }
        public string fn { get; set; }
        public string ln { get; set; }
        public string email { get; set; }

        public string phone { get; set; }
    }
}
