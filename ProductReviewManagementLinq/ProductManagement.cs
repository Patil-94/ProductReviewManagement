using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLinq
{
    class ProductManagement
    {

        //********** UC5******
        // UC5 Retrieves only the product id and review of all records.
        public static void RetrieveProductIDAndReviewOfAllRecords(List<ProductReview> list)
        {
            //using Query Syntax
            var recordedData = (from products in list
                                select new { ProductId = products.ProductId, Review = products.Review });

            Console.WriteLine("\n Retrieving Product and Review from list");
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product ID : " + productReview.ProductId + "\t" + "Review : " + productReview.Review);
            }
        }
    }
}
