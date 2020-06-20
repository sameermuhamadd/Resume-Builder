using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CVBuilder
{
    class Person
    {
        public string name;
        public string objective;
        public string contactNum;
        public string email;
        public string city;
        public string address;

        public static bool login = false;
        public bool isExperienced = false, hasSkill = false;
        public void Error()
        {
            MessageBox.Show("You need to be logged in first.");
            
        }
        
        public void SignIn(TextBox unametxbx, TextBox passtxbx, Label lname, Label ldob, Label lgender)
            {
                int NumberOfLines = File.ReadAllLines(@"..\Debug\users.txt").Length;
                StreamReader sr = new StreamReader(@"..\Debug\users.txt");
                string[] ListLines = new string[NumberOfLines];
                for (int i = 0; i < NumberOfLines; i++)
                {
                    ListLines[i] = sr.ReadLine();
                    string[] lines = ListLines[i].Split(':');
                    if (lines[0] == unametxbx.Text && lines[1] == passtxbx.Text)
                    {
                        login = true;
                        lname.Text = lines[2];
                        lgender.Text = lines[4];
                        ldob.Text = lines[3];
                    }
                }
                if (login == false) {
                	MessageBox.Show("Please enter correct username and password.");
                }
                sr.Close();

            }
        public void SignOut(TextBox unametxbx, TextBox passtxbx)
        {
            login = false;
            unametxbx.Clear();
            passtxbx.Clear();
        }
        public void SignUp(TextBox fname, TextBox lname,TextBox pass, ComboBox gender,NumericUpDown day,ComboBox months,NumericUpDown year)
        {
            using (StreamWriter sw = new StreamWriter(@"..\Debug\users.txt",true))
            {
                sw.WriteLine("{0}:{1}:{2} {3}:{4}:{5} {6},{7}",fname.Text,pass.Text,fname.Text,lname.Text,gender.SelectedItem,day.Value,months.SelectedItem,year.Value);
            }
        }
    }
}
