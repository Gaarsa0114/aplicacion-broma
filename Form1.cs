using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplicacion_broma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }
        public void MoverBoton()
        {
            Random r  = new Random();
            int x = r.Next(0,this.Width - btnno.Width);
            int y = r.Next(0,this.Height - btnno.Height);
            btnno.Location = new Point(x, y); 

        }

        private void btnno_MouseMove(object sender, MouseEventArgs e)
        {
            MoverBoton();
            if(btnno.Location == btnsi.Location || btnno.Location == lbl1.Location )
            {
                MoverBoton();
            }
        }
    }
}
