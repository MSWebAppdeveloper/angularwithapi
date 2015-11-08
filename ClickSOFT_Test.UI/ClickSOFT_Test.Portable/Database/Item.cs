using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickSOFT_Test.Portable.Database
{
    public class Item
    {
        public Item()
        {
            Id = 0;
            Name = "";
            IsProduct = false;
            IsService = false;
            PriceWithTax = 0;
            Disabled = false;
        }
        public int Id { get; set; }

        public string Name { get; set; }
        public bool IsProduct { get; set; }

        public bool IsService { get; set; }

        public decimal PriceWithTax { get; set; }

        public bool Disabled { get; set; }


    }
}
