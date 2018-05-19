using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1Dashboard
{
    class FuncoesForm
    {
        public FormBorderStyle FormBorderStyle { get; set; }

        public void voltarBarra(Form form)
        {
            // Create a new instance of the form.
            


            form.FormBorderStyle = FormBorderStyle.Sizable;
            form.WindowState = FormWindowState.Normal;
            form.TopMost = false;
            form.StartPosition = FormStartPosition.CenterScreen;



        }

        public void fullScreen(Form form)
        {

            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;
            form.TopMost = true;
            
        }
    }
}
