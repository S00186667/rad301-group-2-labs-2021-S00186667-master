using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ActivityTracker; 


namespace Rad3012020Week1Lab1
{
    class Program
    {
        static void Main(string[] args)
        {

            Activity.Track("Designing classes model"); 

        }


    }
    public class ProductModel
    {

        //Supplier
        public int SupplierID {get; set;} 
        public string SupplierName { get; set; }
        public string SupplierAddress1 { get; set; }
         
        public string SupplierAddress2 { get; set; }

        //Product
        public int ProductID { get; set; }

        public string Description { get; set; }

        public int QTYInStock { get; set; }

        public float UnitPrice { get; set; }

        public int CategoryID { get; set; }

        //Category

        public int ID { get; set; }

        //Supplier Product

        public DateTime DateFirstSupplied { get; set; }

        


    
    
    }

}
