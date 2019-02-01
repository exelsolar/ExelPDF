using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecotiza.PDFBase.Domain.PDF
{
    public class Content : DrawText
    {
        public Dictionary<string, string> DiccionaryContent { get; set; }
        public int DataDrawing { get; set; }
        public decimal DataCount
        {
            get
            {
                return DiccionaryContent.Count();
            }
        }
        private decimal TotalPageCount { get; set; }

        public int PageTotal { get; set; }


        public float pointXData1 { get; set; }
        public float pointYData1 { get; set; }
        public float pointXData2 { get; set; }
        public float pointYData2 { get; set; }

        public float pointSpaceYData1 { get; set; }
        public float pointSpaceYData2 { get; set; }

        public float pointYData1Temp { get; set; }
        public float pointYData2Temp { get; set; }


        public int PageProcess()
        {
            TotalPageCount = DataCount / DataDrawing;
            PageTotal = (int)Math.Round(TotalPageCount);
            if (TotalPageCount > PageTotal)
                PageTotal += 1;

            return PageTotal;

        }

        public void AssingDefaultPointSign()
        {
            this.pointXData1 = 50;
            this.pointYData1 = 80;
            this.pointXData2 = 50;
            this.pointYData2 = 105;

            this.pointSpaceYData1 = 120;
            this.pointSpaceYData2 = 120;
        }
        public void AssingDefaultPointIndex()
        {
            this.pointXData1 = 80;
            this.pointYData1 = 80;
            this.pointXData2 = 500;
            this.pointYData2 = 80;

            this.pointSpaceYData1 = 30;
            this.pointSpaceYData2 = 30;
        }
        public void AssigTemp()
        {
            this.pointYData1Temp = this.pointYData1;
            this.pointYData2Temp = this.pointYData2;
        }

    }
}
