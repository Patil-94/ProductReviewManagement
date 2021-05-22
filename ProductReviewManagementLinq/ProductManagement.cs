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
        public static void SkipTopFiveRecords(List<ProductReview> list)
        {
            //using Query Syntax
            var recordedData = (from products in list select products).Skip(5);

            Console.WriteLine("\n Skiping the Top five records and Display others ");
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("Product Id :" + productReview.ProductId + "\t" + "User Id :" + productReview.UserId + "\t" + "Rating ;" + productReview.Rating + "\t" + "Review :" + productReview.Review + "\t" + "Is Like :" + productReview.isLike);
            }
        }
    }
}
