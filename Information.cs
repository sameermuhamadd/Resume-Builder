using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVBuilder
{
    class Information
    {
        public string fullname;
        public string objective;
        public string address;
        public Information(string fullname,string address)
        {
            this.fullname = fullname;
            this.address = address;
        }
        public Information(){}
        public string GetObj(string obj)
        {
            objective = obj;
            return objective;
        }
        public string GetName(TextBox fname,TextBox lname)
        {
            fullname = fname.Text + " " + lname.Text;
            return fullname;
        }
    }
}
