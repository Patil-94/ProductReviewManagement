using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagementLinq
{
    class ReviewTable
    {

        public static DataTable table = new DataTable();

        /// UC8: Add data into data table.

        public static void AddDataIntoDataTable()
        {

            ///Adding column in DataTable
            table.Columns.Add("ProductId", typeof(Int32));
            table.Columns.Add("UserId", typeof(Int32));
            table.Columns.Add("Rating", typeof(double));
            table.Columns.Add("Review", typeof(string));
            table.Columns.Add("IsLike", typeof(bool));
            ///Adding rows in DataTable
            table.Rows.Add(101, 1, 1, "Low", true);
            table.Rows.Add(102, 2, 1, "Low", false );
            table.Rows.Add(103, 3, 4, "Good", true);
            table.Rows.Add(104, 4, 5, "Nice", true);
            table.Rows.Add(105, 5, 4, "Good", true);
            table.Rows.Add(106, 6, 3, "Average", true);
            table.Rows.Add(104, 7, 5, "Nice", true);
            table.Rows.Add(105, 8, 3, "Average", true);
            //Printing data
            Console.WriteLine("\nDataTable contents:");
            foreach (var list in table.AsEnumerable())
            {
                Console.WriteLine("Product Id :" + list.Field<int>("ProductId") + "\t" + "User Id :" + list.Field<int>("UserId") + "\t" + "Rating ;" + list.Field<double>("Rating") + "\t" + "Review :" + list.Field<string>("Review") + "\t" + "Is Like :" + list.Field<bool>("IsLike"));
            }
        }


        // UC12 Retrieves the records for given user Id sorted by rating.
        public static void RetrieveRecordsForGivenUserIdOrderByRating()
        {
            var retrievedData = from records in table.AsEnumerable()
                                where (records.Field<int>("UserId") == 1)
                                orderby records.Field<double>("Rating") descending
                                select records;
            Console.WriteLine("\nSorted records by rating  with userId=1:");
            foreach (var list in retrievedData)
            {
                Console.WriteLine("Product Id :" + list.Field<int>("ProductId") + "\t" + "User Id :" + list.Field<int>("UserId") + "\t" + "Rating ;" + list.Field<double>("Rating") + "\t" + "Review :" + list.Field<string>("Review") + "\t" + "Is Like :" + list.Field<bool>("IsLike"));
            }
        }
    }
}
