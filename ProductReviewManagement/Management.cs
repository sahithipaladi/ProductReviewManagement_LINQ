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
            productReviews.Add(new ProductReview() { ProductID = 14, UserID = 3, Rating = 4, Review = "VeryGood", IsLike = true });
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
    }
}