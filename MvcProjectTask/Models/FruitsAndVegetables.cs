using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcProjectTask.Models
{
    public class FruitsAndVegetables
    {



        public int Id { get; set; }

        //[Column(TypeName = "varchar")]
        //[StringLength(50)]

        public string ProductName { get; set; }

        public int Price { get; set; }
        public string PackSize { get; set; }

        public int Quantity { get; set; }

        public int Discount { get; set; }

        public int TotalPrice { get; set; }
        public string Category { get; set; }


        //public Category Category { get; set;}

      //  public Pack Pack { get; set; }

      //  public int CategoryId { get; set; }

        //public int PackId { get; set; }


        public List<FruitsAndVegetables> GetFruitsAndVegetables()
        {
            return new List<FruitsAndVegetables>
            {
                new FruitsAndVegetables{Id = 1,ProductName = "Tamoto",Price = 10,Quantity = 1,Discount = 2,Category = "Fruits",PackSize= "Small", TotalPrice = (Price*Quantity)*((Price*Quantity) - Discount/100)}
            };
        }

    }

}

public enum Catrgory1
{
    Fruits,
    Vegetables
}
