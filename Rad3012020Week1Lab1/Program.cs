using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;
using ActivityTracker;
using static System.Console; 


namespace Rad3012020Week1Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            Activity.Track("Designing classes model");
            Activity.Track("Starting Queries");

            ProductData PD = new ProductData();

            /*  foreach(var cat in PD.Category)
               {

                   Console.WriteLine(PD.Category); 

               }*/




            //8. List all the categories.
            var queryCategories = from cat in PD.Category
                        select cat;

            //9.List all the Products
            var queryProducts = from pro in PD.Products
                                select pro;

            //10.List Products with a Quantity <= 100 
            var queryQTY = from qty in PD.Products
                           where qty.QTYInStock <= 100
                           select qty;

            //11.	List all the Products together with their total value
            var queryTotalValue = from total in PD.Products
                                  select new
                                  {
                                      addingall = total.UnitPrice,
                                     // queryTotalValue 
                                  };
            //12.List all the Products in the Hardware Category
            var queryHardware = from hardW in PD.Category
                                where hardW.Description == "Hardware"
                                select hardW;

            //13.	List all the suppliers and their Parts ordered by supplier name


















        }


    }
    

}
