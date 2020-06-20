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
    class Error
    {
      public void ErrorSet(ErrorProvider ep1,string error,Control control)
        {
            if (string.IsNullOrEmpty(control.Text))
            {
                ep1.SetError(control,error);
            }
        }
        
        
        
    }
}
