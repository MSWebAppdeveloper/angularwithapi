using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickSOFT_Test.Portable.Objects
{
  public  class Sale
    {
        public Sale()
        {
            Date =null;
            InvoiceNo ="";
            SubjectId = null;
            Details = new List<SaleDetail>();
        }
        public DateTime? Date { get; set; }
        public string InvoiceNo { get; set; }
        public Int32? SubjectId { get; set; }
        public List<SaleDetail> Details { get; set; }
    }
}
