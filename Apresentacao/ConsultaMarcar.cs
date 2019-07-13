using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class ConsultaMarcar : Form
    {
        public ConsultaMarcar()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = monthCalendar1.SelectionStart.Day.ToString() + "/" +
                monthCalendar1.SelectionStart.Month.ToString() + "/" + monthCalendar1.SelectionStart.Year.ToString();
            ConsultaMarcar2 marcar2 = new ConsultaMarcar2(data);
            marcar2.Show();
                
        }
    }
}
