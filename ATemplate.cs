using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVBuilder
{
    abstract class ATemplate
    {
        public bool stylishTemp, decentTemp, traditionalTemp;
        public string path { get; set; }
        public abstract void Design(Person person, Education sch, Education col, Education uni, WorkHistory work,AdditionalCourse adc);
    }
}
