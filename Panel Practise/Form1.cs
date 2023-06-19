using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Panel_Practise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); 

            //Sets default Locations and sizes for all panels
            panel1.Location = new Point(12, 12);
            panel1.Size = new Size(75, 22);
            panel2.Location = new Point(12, 32);
            panel2.Size = new Size(75, 22);
            btnExit.Location = new Point(12, 53);
            
        }

        private void btnFile_Click(object sender, EventArgs e) //execute when btnFile is clicked
        {
            if (panel1.Size.Width == 75 && panel1.Size.Height == 22 && panel2.Size.Width == 75 && panel2.Size.Height == 22) //If panel 1 and panel 2 are at default size execute:
            {
                panel1.Size = new Size(75, 62); //change panel 1 size
                panel2.Location = new Point(12, 72); //Change panel 2 location
                btnExit.Location = new Point(12, 92);
            }
            else if()//if panel 1 is not at default size execute:
            {
                panel1.Size = new Size(75, 22); //change panel 1 size back to default
                panel2.Location = new Point(12, 32);//change panel 2 location back to default
                btnExit.Location = new Point(12, 53);
            }

        }

        private void btnEdit_Click(object sender, EventArgs e) //execute when btnEdit is clicked
        {
            if (panel2.Size.Width == 75 && panel2.Size.Height == 22) //If panel 2 is at defautl size execute:
            {
                panel2.Size = new Size(75, 62); //change panel 2 size
                btnExit.Location = new Point(12, 102);
            }
            else if () //if panel 2 is not at default execute:
            {
                panel2.Size = new Size(75, 22); // change panel 2 size back to default
                btnExit.Location = new Point(12, 53);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
