using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace CVBuilder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        
        }
        Person person = new Person();
        Education sch,col,uni;
        WorkHistory work;
        AdditionalCourse adc;
        Error d = new Error();
        ATemplate template;
        //string objective = "";       
       // int mouseX = 0, mouseY = 0;
        bool click = false;
        private void headerpanel_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
        }

        private void headerpanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
              //  mouseX = MousePosition.X - 10;
              //  mouseY = MousePosition.Y - 40;
                this.SetDesktopLocation(MousePosition.X - 433, MousePosition.Y - 40);
            }
        }

        private void headerpanel_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            person.SignOut(unameTB,pwdTB);
            tabControl1.SelectTab(0);
        }

        private void loginBTN_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
            template = new TraditionalTemplate();
            template.decentTemp = false;
            template.stylishTemp = false;
            template.traditionalTemp = true;
            MessageBox.Show("Traditional template selected.");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            template = new StylishTemplate();
            template.decentTemp = false;
            template.stylishTemp = true;
            template.traditionalTemp = false;
            MessageBox.Show("Stylish template selected.");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            template = new DecentTemplate();
            template.decentTemp = true;
            template.stylishTemp = false;
            template.traditionalTemp = false;
            MessageBox.Show("Decent template selected.");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
            template = new TraditionalTemplate();
            template.decentTemp = false;
            template.stylishTemp = false;
            template.traditionalTemp = true;
            MessageBox.Show("Traditional template selected.");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            template = new StylishTemplate();
            template.decentTemp = false;
            template.stylishTemp = true;
            template.traditionalTemp = false;
            MessageBox.Show("Stylish template selected.");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            template = new DecentTemplate();
            template.decentTemp = true;
            template.stylishTemp = false;
            template.traditionalTemp = false;
            MessageBox.Show("Decent template selected.");
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
            template = new TraditionalTemplate();
            template.decentTemp = false;
            template.stylishTemp = false;
            template.traditionalTemp = true;
            MessageBox.Show("Traditional template selected.");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
            template = new StylishTemplate();
            template.decentTemp = false;
            template.stylishTemp = true;
            template.traditionalTemp = false;
            MessageBox.Show("Stylish template selected.");
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button36_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button42_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button51_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button60_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
        }

        private void button35_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void button37_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(8);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(9);
        }

        private void button43_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(9);
        }

        private void button52_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(9);
        }

        private void button61_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(9);
        }

        private void button64_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(8);
        }

        private void button46_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(8);
        }

        private void button44_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void button53_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void button62_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void button45_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void button54_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void button63_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(6);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button41_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button50_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button59_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button73_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button78_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button82_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button86_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }

        private void button76_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void button79_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void button83_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }

        private void button87_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(4);
        }

        private void button72_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void button77_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void button81_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void button85_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(7);
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(PFname.Text) && !string.IsNullOrEmpty(PLName.Text) && !string.IsNullOrEmpty(PEmail.Text) && !string.IsNullOrEmpty(PNum.Text) && !string.IsNullOrEmpty(PCity.SelectedItem.ToString()) && !string.IsNullOrEmpty(AdrLine1.Text) && !string.IsNullOrEmpty(AdrLine2.Text) && !string.IsNullOrEmpty(AdrLine3.Text))
            {
                //person = new Person()
                //{
                person.name = PFname.Text + " " + PLName.Text;
                person.email = PEmail.Text;
                person.contactNum = PNum.Text;
                person.city = PCity.SelectedItem.ToString();
                person.address = AdrLine1.Text + " " + AdrLine2.Text + " " + AdrLine3.Text;
                person.objective = richTextBox1.Text;

               // };
                tabControl1.SelectTab(11);
            }
            else
            {
                d.ErrorSet(errorProvider1, "Enter your First Name", PFname);
                d.ErrorSet(errorProvider1, "Enter your Last Name", PLName);
                d.ErrorSet(errorProvider1, "Enter your Email", PEmail);
                d.ErrorSet(errorProvider1, "Enter your Number", PNum);
                d.ErrorSet(errorProvider1, "Select your City", PCity);
                d.ErrorSet(errorProvider1, "Enter your Address", AdrLine1);
                d.ErrorSet(errorProvider1, "Enter your Address", AdrLine2);
                d.ErrorSet(errorProvider1, "Enter your Address", AdrLine3);
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
             sch = new Education()
            {
                instituteName = SName.Text,
                startedFrom = S1FromMonth.SelectedItem.ToString() + ", " + S1FromYear.Text,
                endedOn = S1ToMonth.SelectedItem.ToString() + ", " + S1ToYear.Text,
                qualification = SClass.SelectedItem.ToString()
            };
            col = new Education()
            {
                instituteName = S2Name.Text,
                startedFrom = S2FromMonth.SelectedItem.ToString() + ", " + S2FromYear.Text,
                endedOn = S2ToMonth.SelectedItem.ToString() + ", " + S2ToYear.Text,
                qualification = S2Class.SelectedItem.ToString()
            };
            if (!string.IsNullOrEmpty(SName.Text) && !string.IsNullOrEmpty(SClass.SelectedItem.ToString()) && !string.IsNullOrEmpty(S1FromMonth.SelectedItem.ToString()) && !string.IsNullOrEmpty(S1FromYear.Text) && !string.IsNullOrEmpty(S1ToMonth.SelectedItem.ToString()) && !string.IsNullOrEmpty(S1ToYear.Text) && !string.IsNullOrEmpty(S2Name.Text) && !string.IsNullOrEmpty(S2Class.SelectedItem.ToString()) && !string.IsNullOrEmpty(S2FromMonth.SelectedItem.ToString()) && !string.IsNullOrEmpty(S2FromYear.Text) && !string.IsNullOrEmpty(S2FromMonth.SelectedItem.ToString()) && !string.IsNullOrEmpty(S2ToYear.Text))
            {
                tabControl1.SelectTab(12);
            }
            d.ErrorSet(errorProvider1, "This information is neccessary", SName);
            d.ErrorSet(errorProvider1, "This information is neccessary", SClass);
            d.ErrorSet(errorProvider1, "Select Month", S1FromMonth);
            d.ErrorSet(errorProvider1, "Enter a Year", S1FromYear);
            d.ErrorSet(errorProvider1, "Select Month", S1ToMonth);
            d.ErrorSet(errorProvider1, "Enter a year", S1ToYear);
            d.ErrorSet(errorProvider1, "This information is neccessary", S2Name);
            d.ErrorSet(errorProvider1, "This information is neccessary", S2Class);
            d.ErrorSet(errorProvider1, "Select Month", S2FromMonth);
            d.ErrorSet(errorProvider1, "Enter a Year", S2FromYear);
            d.ErrorSet(errorProvider1, "Select Month", S2ToMonth);
            d.ErrorSet(errorProvider1, "Enter a Year", S2ToYear);
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(IName.Text) && !string.IsNullOrEmpty(IProgram.SelectedItem.ToString()) && !string.IsNullOrEmpty(Iin.Text) && !string.IsNullOrEmpty(IFromMonth.SelectedItem.ToString()) && !string.IsNullOrEmpty(IfromYear.Text) && !string.IsNullOrEmpty(IToMonth.SelectedItem.ToString()) && !string.IsNullOrEmpty(IToYear.Text) && !string.IsNullOrEmpty(C1.Text))
            {
                uni = new Education()
                {
                    instituteName = IName.Text,
                    qualification = IProgram.SelectedItem.ToString() + " " + Iin.Text,
                    startedFrom = IFromMonth.SelectedItem.ToString() + ", " + IfromYear.Text,
                    endedOn = IToMonth.SelectedItem.ToString() + ", " + IToYear.Text
                };
                adc = new AdditionalCourse()
                {
                    courseName = C1.Text,
                    courseFrom = textBox4.Text
                };
                tabControl1.SelectTab(13);
            }
            else
            {
                d.ErrorSet(errorProvider1, "This Information is necessary", IName);
                d.ErrorSet(errorProvider1, "This Information is necessary", IProgram);
                d.ErrorSet(errorProvider1, "This information is necessary", Iin);
                d.ErrorSet(errorProvider1, "Select a Month", IFromMonth);
                d.ErrorSet(errorProvider1, "Enter a Year", IfromYear);
                d.ErrorSet(errorProvider1, "Select a Month", IToMonth);
                d.ErrorSet(errorProvider1, "Enter a year", IToYear);
                d.ErrorSet(errorProvider1, "This information is necessary", C1);
                //d.ErrorSet(errorProvider1, "This information is necessary", C2);
                //d.ErrorSet(errorProvider1, "This information is necessary", C3);
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(11);
        }

        private void button68_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void button67_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(12);
        }

        private void button84_Click(object sender, EventArgs e)
        {
            
            
            {
                
                work = new WorkHistory()
                {
                    employer = textBox17.Text,
                    position = textBox18.Text,
                    startedFrom = comboBox11.SelectedItem.ToString() + ", " + textBox19.Text,
                    endedOn = comboBox12.SelectedItem.ToString() + "," + textBox21.Text
                };
            if (!string.IsNullOrEmpty(textBox17.Text) && !string.IsNullOrEmpty(textBox18.Text) && !string.IsNullOrEmpty(comboBox11.SelectedItem.ToString()) && !string.IsNullOrEmpty(comboBox12.SelectedItem.ToString()) && !string.IsNullOrEmpty(textBox21.Text) && !string.IsNullOrEmpty(textBox19.Text))
            {

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    template.path = saveFileDialog1.FileName;
                }

                if (template.decentTemp == true)
                {
                    //    template = new DecentTemplate();
                    template.Design(person, sch, col, uni, work, adc);
                }
                if (template.stylishTemp == true)
                {
                    //  template = new StylishTemplate();
                    template.Design(person, sch, col, uni, work, adc);
                }
                if (template.traditionalTemp == true)
                {
                    //template = new TraditionalTemplate();
                    template.Design(person, sch, col, uni, work, adc);
                }
            }
            else
            {
                d.ErrorSet(errorProvider1, "This Information is necessary", textBox17);
                d.ErrorSet(errorProvider1, "This Information is necessary", textBox18);
                d.ErrorSet(errorProvider1, "Select Month", comboBox11);
                d.ErrorSet(errorProvider1, "Select Month", comboBox12);
                d.ErrorSet(errorProvider1, "Enter a Year", textBox21);
                d.ErrorSet(errorProvider1, "Enter a Year", textBox19);
            }
        }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(0);
            
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tabControl1.SelectTab(14);
        }

        private void button89_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text) && !string.IsNullOrEmpty(textBox2.Text) && !string.IsNullOrEmpty(textBox3.Text) && !string.IsNullOrEmpty(comboBox1.SelectedItem.ToString()) && !string.IsNullOrEmpty(comboBox2.SelectedItem.ToString()))
            {
                person.SignUp(textBox1, textBox2, textBox3, comboBox1, numericUpDown1, comboBox2, numericUpDown2);
                MessageBox.Show("Account Created.");
            }
            else
            {
                d.ErrorSet(errorProvider1, "This Field is necassary", textBox1);
                d.ErrorSet(errorProvider1, "This Field is necassary", textBox2);
                d.ErrorSet(errorProvider1, "This Field is necassary", textBox3);
                d.ErrorSet(errorProvider1, "Please select gender.", comboBox1);
                d.ErrorSet(errorProvider1, "Please select Month.", comboBox2);
            }

        }

        

        private void button29_Click(object sender, EventArgs e)
        {
            
            Button btn = (Button)sender;
            person.objective = btn.Text;
            richTextBox1.Text = person.objective;
            
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            person.objective = btn.Text;
            richTextBox1.Text = person.objective;
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            person.objective = btn.Text;
            richTextBox1.Text = person.objective;
        }

        private void button56_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            person.objective = btn.Text;
            richTextBox1.Text = person.objective;

        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button74_Click(object sender, EventArgs e)
        {
            
        }

        private void button75_Click(object sender, EventArgs e)
        {
            
        }

        private void button80_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            template = new DecentTemplate();
            template.decentTemp = true;
            template.stylishTemp = false;
            template.traditionalTemp = false;
        }

        private void loginBTN_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(unameTB.Text) || !string.IsNullOrEmpty(pwdTB.Text))
            {
                person.SignIn(unameTB, pwdTB, label9, label10, label11);
                if (Person.login == true)
                {
                    tabControl1.SelectTab(1);
                }
            }
            else
            {
                d.ErrorSet(errorProvider1, "This field is necassary.", unameTB);
                d.ErrorSet(errorProvider1, "This field is necassary.", pwdTB);
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            tabControl1.SelectTab(10);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            person.isExperienced = true;
            person.hasSkill = true;
            ComboBox[] cb = { PCity, comboBox1,comboBox11,comboBox12,comboBox13,comboBox14,comboBox2,SClass,S2FromMonth,S2ToMonth,S1FromMonth,S1ToMonth,S2Class,IProgram,IFromMonth,IToMonth, };
            foreach (ComboBox item in cb)
            {
                if (item.SelectedIndex == -1)
                {
                    item.SelectedIndex = 0;
                }
            }
        }

        private void loginBTN_Click_2(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(unameTB.Text) || !string.IsNullOrEmpty(pwdTB.Text))
            {
                person.SignIn(unameTB, pwdTB, label9, label10, label11);
                if (Person.login == true)
                {
                    tabControl1.SelectTab(1);
                }
            }
            else
            {
                d.ErrorSet(errorProvider1, "This field is necassary.", unameTB);
                d.ErrorSet(errorProvider1, "This field is necassary.", pwdTB);
            }
        }

        private void tabPage14_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button88_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                person.isExperienced = false;
                Control[] ctr = { textBox17, textBox18, textBox19, textBox21, textBox22, textBox23, comboBox11, comboBox12, comboBox13, comboBox14 };
                foreach (Control control in ctr)
                {

                    control.Enabled = false;
                }
            }
            else
            {
                person.isExperienced = true;
                Control[] ctr = { textBox17, textBox18, textBox19, textBox21, textBox22, textBox23, comboBox11, comboBox12, comboBox13, comboBox14 };
                foreach (Control control in ctr)
                {

                    control.Enabled = true;
                }
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                person.hasSkill = false;
                Control[] ctr = { C1,textBox4};
                foreach (Control control in ctr)
                {
                    control.Enabled = false;
                }
            }
            else
            {
                person.hasSkill = true;
                Control[] ctr = { C1, textBox4 };
                foreach (Control control in ctr)
                {
                    control.Enabled = true;
                }
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            template = new StylishTemplate();
            template.decentTemp = false;
            template.stylishTemp = true;
            template.traditionalTemp = false;
        }

        private void pictureBox17_Click(object sender, EventArgs e)
        {
            template = new TraditionalTemplate();
            template.decentTemp = false;
            template.stylishTemp = false;
            template.traditionalTemp = true;
        }
    }
    

}
