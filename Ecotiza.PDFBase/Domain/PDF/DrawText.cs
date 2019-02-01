using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecotiza.PDFBase.Domain.PDF
{
    public class DrawText
    {
        public DrawText()
        {

        }
        public string Text { get; set; }
        public SolidBrush SolidBrush { get; set; }
        public Font FontText { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public float degree { get; set; }

        public void Title()
        {
            this.Text = "Contenido";
            this.SolidBrush = new SolidBrush(Color.FromArgb(23, 0, 0));
            this.FontText = new Font("Segoe UI", 40, FontStyle.Bold);
            this.X = 220;
            this.Y = 10;
            this.degree = 0;

        }
        public void Default(string str)
        {
            this.Text = str.Trim();
            this.SolidBrush = new SolidBrush(Color.FromArgb(23, 0, 0));
            this.FontText = new Font("Segoe UI", 9, FontStyle.Regular);
            this.X = 0;
            this.Y = 0;
            this.degree = 0;

        }
        public void WaterMark()
        {
            this.X = 80;
            this.Y = 230;
            this.degree = 0;
        }

        public void circle()
        {
            Brush elip = Brushes.LightBlue;
            
        }
    }
}
