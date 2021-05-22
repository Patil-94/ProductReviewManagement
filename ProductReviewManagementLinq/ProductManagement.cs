using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLinq
{
    class ProductManagement
    {

        //********** UC6******
        /// UC6 Skip top five records from the list and display other records.
        // UC7 Retrieving reviews and productId using the lambda expression syntax

        public static void RetrieveProductIDAndReviewUsingLambdaSyntax(List<ProductReview> list)
        {
            //Query Syntax using lambda
            var recordedData = list.Select(reviews => new { ProductId = reviews.ProductId, Review = reviews.Review });
            Console.WriteLine("\n Retrieving Product and Review from list");
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product ID : " + productReview.ProductId + "\t" + "Review : " + productReview.Review);
            }
        }
    }
}
