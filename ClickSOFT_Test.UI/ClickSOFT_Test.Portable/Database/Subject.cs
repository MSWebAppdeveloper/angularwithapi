using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickSOFT_Test.Portable.Database
{
    public class Subject
    {
        public Subject()
        {
            Id = 0;
            Name = "";
            Address = "";
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


    }
}
