using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace CVBuilder
{
    class Design
    {
        Information i;
        public Design()
        {
            i = new Information();
        }
        public void Generate()
        {
            Document doc = new Document(PageSize.A4);
            PdfWriter.GetInstance(doc, new FileStream("mypdf.pdf", FileMode.Append));
            doc.Open();
            Phrase p1 = new Phrase("Kelly\nBlackwell");
            Phrase p2 = new Phrase(i.objective);
            doc.Add(p1);
            doc.Add(p2);
           
            doc.Close();
            MessageBox.Show("Test");

           
            

        }
        //public void GetInfo(TextBox tbfname,TextBox tblname,TextBox ad1,TextBox ad2,TextBox ad3,TextBox objectives)
        //{
        //    i.fullname = tbfname.Text + "\n" + tblname.Text;
        //    i.address = ad1.Text + "\n" + ad2.Text + "\n" + ad3.Text;
        //    i.objective = objectives.Text;
        //}
        
    }
}
