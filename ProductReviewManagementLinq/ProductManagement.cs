using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLinq
{
    class ProductManagement
    {

        //********** UC3******
        // UC4 Retrieves the count of reviews for each productID.
        public static void RetrieveCountOfReviewForEachProductId(List<ProductReview> list)
        {
            var recordedData = (list.GroupBy(p => p.ProductId).Select(x => new { ProductId = x.Key, Count = x.Count() }));
            Console.WriteLine("\n Count group by ProductId");
            foreach (var productReview in recordedData)
            {
                Console.WriteLine("ProductId : " + productReview.ProductId + "  Count : " + productReview.Count);
            }
        }
    }
}
