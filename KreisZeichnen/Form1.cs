using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KreisZeichnen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen stift = new Pen(Color.Black, 1);
            //Diameter der Kreises
            int kreisDiameter = 100;
            
            //Mittel Punkt des Kreis
            int kreisMittelPunkt = kreisDiameter / 2;

            //Punkt auf der Oberfläche, der das Zentrum des Kreises repräsentiert 
            Point kreisCenter = new Point(150, 150);
            
            kreisCenter = new Point(kreisCenter.X - kreisMittelPunkt, kreisCenter.Y - kreisMittelPunkt);

            e.Graphics.DrawEllipse(stift, kreisCenter.X, kreisCenter.Y,  kreisDiameter, kreisDiameter);

        }

        private void Btn_Beenden_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
