using System;
using System.Collections.Generic;
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
    }
}
