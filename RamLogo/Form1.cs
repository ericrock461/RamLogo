using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*Erich Rock
 September 12, 2018
 Mr. T
 Rams Logo; a made-up logo for the Central Rams*/

namespace RamLogo
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

        private void Form1_Click(object sender, EventArgs e)
        {
            //declare drawing tools
            Graphics g = this.CreateGraphics();
            Pen drawPen = new Pen(Color.Red, 6);
            SolidBrush drawBrush = new SolidBrush(Color.Red);
            Font drawFont = new Font("Arial", 35, FontStyle.Bold);

            //make background green and make a filled circle
            g.Clear(Color.Green);
            g.FillEllipse(drawBrush, this.Width / 2 - 125, this.Height / 2 - 125, 250, 250);

            //Make a C
            drawBrush = new SolidBrush(Color.White);
            drawFont = new Font("Verdana", 150, FontStyle.Bold);
            g.DrawString("C", drawFont, drawBrush, this.Width / 2 - 145, this.Height / 2 - 124);

            //Write "Rams"
            drawFont = new Font("Arial", 40, FontStyle.Bold);
            g.DrawString("Rams", drawFont, drawBrush, this.Width/2 - 50, this.Height/2 - 30);

            //Change font & add "Central Rams Arcade"
            drawFont = new Font("Microsoft Himalaya", 18, FontStyle.Regular);
            g.TranslateTransform(540, 300);
            g.RotateTransform(270);
            g.DrawString("Central Rams Arcade", drawFont, drawBrush, new Rectangle());
            g.ResetTransform();      
            
            
            //Ok, I think I'm done for real this time uwu
        }
    }
}
