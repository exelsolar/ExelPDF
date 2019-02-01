using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecotiza.PDFBase.Domain.PDF
{
    public class QR
    {

        public QR()
        {
            this.width = 57;
            this.height = 57;
        }
        //56.68=2 -57
        //34.008?1.2 -35
        public string Name { get; set; }
        public string Data { get; set; }
        public string Path { get; set; }
        public bool ShowText { get; set; }
        public float width { get; set; }
        public float height { get; set; }
    }
}
