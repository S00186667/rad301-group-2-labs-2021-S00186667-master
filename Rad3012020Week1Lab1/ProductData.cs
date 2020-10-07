using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rad3012020Week1Lab1
{
    class ProductData
    {


        public List<ProductModel> Suppliers = new List<ProductModel>
        {
            new ProductModel{SupplierID =1,
            SupplierName = "Parts1", SupplierAddress1 = "Addr11", SupplierAddress2 = "Addr21"},

            new ProductModel{SupplierID = 2, SupplierName = "Parts2", SupplierAddress1 = "Addr1", SupplierAddress2 = "Addr21"
            },
        };

        public List<ProductModel> Products = new List<ProductModel>
        {

            new ProductModel{ProductID = 1, Description = "9' Nails",
                QTYInStock = 200, UnitPrice = 10, CategoryID = 1},

             new ProductModel{ProductID = 2, Description = "9' Bolts",
                QTYInStock = 120, UnitPrice = 20, CategoryID = 1},

              new ProductModel{ProductID = 3, Description = "Chimmney Hoover",
                QTYInStock = 10, UnitPrice = 10059, CategoryID = 2},

               new ProductModel{ProductID = 4, Description = "Washing Machine",
                QTYInStock = 7, UnitPrice = 39999, CategoryID = 2
               },



        };

        public List<ProductModel> Category = new List<ProductModel>
        {
            new ProductModel{CategoryID = 1, Description = "Hardware"}, 

            new ProductModel{CategoryID = 2, Description = "Eletrical Appliences"}


        };

        public List<ProductModel> SupplierProducts = new List<ProductModel>
        {
            new ProductModel{SupplierID = 1, ProductID = 1, DateFirstSupplied = 2012},

            new ProductModel{SupplierID = 1, ProductID = 2, DateFirstSupplied = 2013},

            new ProductModel{SupplierID = 2, ProductID = 3, DateFirstSupplied = 2017},




        };
            

       

        public class ProductModel
        {

            //Supplier
            public int SupplierID { get; set; }
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

            public int DateFirstSupplied { get; set; }



        }
















    }
}
