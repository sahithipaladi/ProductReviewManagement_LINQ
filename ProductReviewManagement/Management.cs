using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductReviewManagement
{
    public class Management
    {
        /// <summary>
        /// UC 1 - Add values in list
        /// </summary>
        /// <param name="productReviews"></param>
        /// <returns></returns>
        public static int AddProductReviews(List<ProductReview> productReviews)
        {
            productReviews.Add(new ProductReview() { ProductID = 1, UserID = 1, Rating = 5, Review = "Excellent", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 2, UserID = 4, Rating = 4, Review = "VeryGood", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 2, UserID = 4, Rating = 5, Review = "Excellent", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 4, UserID = 4, Rating = 3, Review = "Good", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 5, UserID = 6, Rating = 2, Review = "Average", IsLike = false });
            productReviews.Add(new ProductReview() { ProductID = 9, UserID = 3, Rating = 4, Review = "VeryGood", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 12, UserID = 5, Rating = 5, Review = "Excellent", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 4, UserID = 4, Rating = 5, Review = "Excellent", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 3, UserID = 6, Rating = 4, Review = "VeryGood", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 5, UserID = 8, Rating = 1, Review = "Bad", IsLike = false });
            productReviews.Add(new ProductReview() { ProductID = 5, UserID = 10, Rating = 2, Review = "Average", IsLike = false });
            productReviews.Add(new ProductReview() { ProductID = 8, UserID = 15, Rating = 3, Review = "Good", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 16, UserID = 17, Rating = 5, Review = "Excellent", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 5, UserID = 16, Rating = 4, Review = "VeryGood", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 7, UserID = 7, Rating = 5, Review = "Excellent", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 6, UserID = 4, Rating = 3, Review = "Good", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 15, UserID = 5, Rating = 4, Review = "VeryGood", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 15, UserID = 6, Rating = 2, Review = "Average", IsLike = false });
            productReviews.Add(new ProductReview() { ProductID = 4, UserID = 17, Rating = 2, Review = "Average", IsLike = false });
            productReviews.Add(new ProductReview() { ProductID = 3, UserID = 16, Rating = 3, Review = "Good", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 5, UserID = 5, Rating = 5, Review = "Excellent", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 3, UserID = 2, Rating = 4, Review = "VeryGood", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 6, UserID = 4, Rating = 4, Review = "VeryGood", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 8, UserID = 5, Rating = 3, Review = "Good", IsLike = true });
            productReviews.Add(new ProductReview() { ProductID = 17, UserID = 19, Rating = 4, Review = "VeryGood", IsLike = true });
            return productReviews.Count;
        }

        //Display list of records
        public static void IterateList(List<ProductReview> productReviews)
        {
            foreach (ProductReview product in productReviews)
            {
                Console.Write("ProductId : " + product.ProductID + "\t");
                Console.Write("UserId : " + product.UserID + "\t");
                Console.Write("Rating : " + product.Rating + "\t");
                Console.Write("Review : " + product.Review + "\t");
                Console.Write("IsLike : " + product.IsLike + "\t");
                Console.WriteLine();
            }
        }

        /// <summary>
        /// UC 2 - Retrieve Top 3 Records from the list based on Rating
        /// </summary>
        /// <param name="productReviews"></param>
        public static void RetrieveTopThree(List<ProductReview> productReviews)
        {
            Console.WriteLine("---------Retrieve Top 3 records based on Rating---------");
            var result = (from product in productReviews orderby product.Rating descending select product).Take(3).ToList();
            IterateList(result);
        }

        /// <summary>
        /// UC 3 - Retrieve All Records Using Rating and ProductId
        /// </summary>
        /// <param name="productReviews"></param>
        public static void RetriveAllUsingRatingAndProductId(List<ProductReview> productReviews)
        {
            var result = (from product in productReviews
                          where (product.ProductID == 1 || product.ProductID == 4 || product.ProductID == 9)
                          && product.Rating > 3
                          select product).ToList();
            IterateList(result);
        }

        /// <summary>
        /// UC 4 - Retrieve Count of Product Review for each ProductId
        /// </summary>
        /// <param name="productReviews"></param>
        public static void CountOfRecords(List<ProductReview> productReviews)
        {
            var result = productReviews.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            Console.WriteLine("ProductID\tCount");
            foreach (var list in result)
            {
                Console.WriteLine(list.ProductID + "\t\t" + list.Count);
            }
        }

        /// <summary>
        /// UC 5 - Retrieve ProductId and Review
        /// </summary>
        /// <param name="productReviews"></param>
        public static void RetrieveProductIdAndReview(List<ProductReview> productReviews)
        {
            var result = from product in productReviews select new { product.ProductID, product.Review };
            Console.WriteLine("ProductId\tReview");
            foreach (var list in result)
            {
                Console.WriteLine(list.ProductID + "\t\t" + list.Review);
            }
        }

        /// <summary>
        /// UC 6 - Skip Top 5 Records
        /// </summary>
        /// <param name="productReviews"></param>
        public static void SkipTopFive(List<ProductReview> productReviews)
        {
            var result = (from product in productReviews select product).Skip(5).ToList();
            IterateList(result);
        }

        /// <summary>
        /// UC 7 - Retrieve ProductId and Review using Select operator
        /// </summary>
        /// <param name="productReviews"></param>
        public static void SelectProductIdAndReview(List<ProductReview> productReviews)
        {
            var result = productReviews.Select(x => new { x.ProductID, x.Review });
            Console.WriteLine("ProductId\tReview");
            foreach (var list in result)
            {
                Console.WriteLine(list.ProductID + "\t\t" + list.Review);
            }
        }
    }
}