using ClickSOFT_Test.Portable.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickSOFT_Test.Portable.Database
{
    public class Repository
    {


        static List<Sale> sales = new List<Sale>();
        public static List<Subject> GetSubjects()
        {
            return new List<Subject>{
                new Subject{ Id =1 , Name = "Filan Fisteku" , Address="Prishtina" },
                new Subject{ Id =2 , Name = "John Smith" , Address="New York" },
                new Subject{ Id =3 , Name = "Jorgen Schmidt" , Address="Düsseldorf" }
            };
        }

        public static List<Item> GetItems()
        {
            return new List<Item>{
                new Item{ Id =1 , Name = "Cheese-Burger" , IsProduct=true, IsService=false , PriceWithTax=2.00M,Disabled=false },
                new Item{ Id =2 , Name = "Chocolate ‘Milka’" , IsProduct=true, IsService=false , PriceWithTax=1.00M,Disabled=false },
                new Item{ Id =3 , Name = "Clothing cleanup" , IsProduct=false, IsService=true , PriceWithTax=10.00M,Disabled=false }
        };
        }

        public static void AddSale(Sale data)
        {
            sales.Add(data);
        }

        public static List<Sale> GetSubjectSale(int id)
        {
            return sales.Where(x => x.SubjectId == id).ToList();
        }

    }
}
