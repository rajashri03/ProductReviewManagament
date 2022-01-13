using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductREview
{
    public class ProductManagement
    {
        /// <summary>
        ///  Retriving Top 3 Records from list
        /// </summary>
        /// <param name="listProductReview"></param>
        public static void Top3Records(List<ProductReview> productreviewlist)
        {
            var productData = (from productReviews in productreviewlist
                               select productReviews).Take(3);

            foreach (var list in productData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                     + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "IsLike:- " + list.Islike);
            }
        }
        /// <summary>
        /// Retrive all data from list whose rating greater than 3
        /// </summary>
        /// <param name="productreviewlist"></param>
        public static void RetriveRecords(List<ProductReview> productreviewlist)
        {
            var productData = (from productReviews in productreviewlist
                               where productReviews.ProductID == 1 ||  productReviews.ProductID == 4 || productReviews.ProductID == 9
                               && productReviews.Rating >3
                               select productReviews);

            foreach (var list in productData)
            {
                Console.WriteLine("ProductID:- " + list.ProductID + " " + "UserID:- " + list.UserID
                     + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "IsLike:- " + list.Islike);
            }
        }
        /// <summary>
        /// Retrive Count using group by
        /// </summary>
        /// <param name="productreviewlist"></param>
        public static void CountRecords(List<ProductReview> productreviewlist)
        {
            foreach (var line in productreviewlist.GroupBy(info => info.ProductID)
                           .Select(group => new {
                               products = group.Key,
                               Count = group.Count()
                           })
                           .OrderBy(x => x.products))
            {
                Console.WriteLine("Product Id:{0} => Count :{1}", line.products, line.Count);
            }
        }
        /// <summary>
        /// Retrive only product id and review
        /// </summary>
        /// <param name="productreviewlist"></param>
        public static void RetriveProductIDReview(List<ProductReview> productreviewlist)
        {
            foreach (var line in productreviewlist.Select(group => new {
                               products = group.ProductID,
                               productsreview=group.Review}))
            {
                Console.WriteLine("Product Id:{0} || Reviews:{1}", line.products, line.productsreview);
            }
        }
        /// <summary>
        /// Skip top 5 records
        /// </summary>
        /// <param name="productreviewlist"></param>
        public static void SkipTop5Records(List<ProductReview> productreviewlist)
        {
            foreach (var productData in (from productReviews in productreviewlist
                                         select productReviews).Skip(5))
            {
                Console.WriteLine("Product Id:{0} || UserID:{1} || Review:{2} ||Rating:{3} || IsLike:{4}", 
                    productData.ProductID,productData.UserID,productData.Review,productData.Rating,productData.Islike);
            }
        }
        /// <summary>
        /// Create datatable
        /// </summary>
        /// <param name="productreviewlist"></param>
        public static void Datatables()
        {
            //created datatable
            DataTable dt = new DataTable();
            dt.Columns.Add("ProductId");
            dt.Columns.Add("UserId");
            dt.Columns.Add("Review");
            dt.Columns.Add("Rating");
            dt.Columns.Add("Islike");
            //created row
            dt.Rows.Add("1","2","Good","4","True");
            dt.Rows.Add("1","2","Bad","5","False");
            dt.Rows.Add("2","1","Very Good","5","False");
            dt.Rows.Add("4", "2", "Good", "4", "True");
            dt.Rows.Add("3", "2", "Bad", "5", "False");
            dt.Rows.Add("5", "1", "Very Good", "5", "False");
            dt.Rows.Add("5", "2", "Good", "4", "True");
            dt.Rows.Add("6", "2", "Bad", "5", "False");
            dt.Rows.Add("7", "1", "Very Good", "5", "False");
            dt.Rows.Add("8", "2", "Good", "4", "True");
            dt.Rows.Add("9", "2", "Bad", "5", "False");
            dt.Rows.Add("10", "1", "Very Good", "5", "False");
            dt.Rows.Add("12", "2", "Good", "4", "True");
            dt.Rows.Add("12", "2", "Bad", "5", "False");
            dt.Rows.Add("11", "1", "Very Good", "5", "False");
            dt.Rows.Add("13", "2", "Good", "4", "True");
            dt.Rows.Add("14", "2", "Bad", "5", "False");
            dt.Rows.Add("15", "1", "Very Good", "5", "False");
            dt.Rows.Add("16", "2", "Good", "4", "True");
            dt.Rows.Add("17", "2", "Bad", "5", "False");
            dt.Rows.Add("18", "1", "Very Good", "5", "False");
            dt.Rows.Add("19", "2", "Good", "4", "True");
            dt.Rows.Add("20", "2", "Bad", "5", "False");
            dt.Rows.Add("1", "1", "Very Good", "5", "False");
            //All Data from datatable
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("------------All Data from the dataTable------------");
            Console.ResetColor();
            foreach (DataRow row in dt.Rows)
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine($"{row["ProductId"]}\t|{row["UserId"]}\t|{row["Review"]}\t|{row["Rating"]}\t|{row["Islike"]}");
            }
            //retrive Data from datatable who's islike value is true
            
            IEnumerable<DataRow> rows = dt.AsEnumerable().Where(r => r.Field<string>("Islike") == "True");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n-----------Data from datatable who's islike value is true------------");
            Console.ResetColor();
            foreach (DataRow row in rows)
            {
                Console.WriteLine("--------------------------------------------------------");
                Console.WriteLine($"{row["ProductId"]}\t|{row["UserId"]}\t|{row["Review"]}\t|{row["Rating"]}\t|{row["Islike"]}");
            }
        }
        /// <summary>
        /// Find average rating
        /// </summary>
        /// <param name="productreviewlist"></param>
        public static void AvgRating(List<ProductReview> productreviewlist)
        {
            //var res = productreviewlist.Average(a => a.Rating);
            //Console.WriteLine("Average rating :"+res);

            foreach (var line in productreviewlist.GroupBy(info => info.ProductID).Select(group => new
            {
                products = group.Key,
                Count = group.Average(a => a.Rating)
            }))
            {
                Console.WriteLine("Product Id:{0} => Average Rating :{1}", line.products, line.Count);
            }
        }
    }
}
