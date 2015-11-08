using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickSOFT_Test.Portable.Objects
{
 public class SaleDetail
    {
        public SaleDetail()
        {
            ProductId = 0;
            Qty = 0;
            Price = 0;
            Amount = 0;
        }
        public Int32 ProductId { get; set; }
        public decimal Qty { get; set; }
        public decimal Price { get; set; }
        public decimal Amount { get; set; }
    }
}
