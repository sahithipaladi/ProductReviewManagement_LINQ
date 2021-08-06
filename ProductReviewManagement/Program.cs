
using System;
using System.Collections.Generic;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------Product Review Management--------------");
            List<ProductReview> productReviewList = new List<ProductReview>();
            //Add into list
            Management.AddProductReviews(productReviewList);
            //Skip top 5 records and retrieve reamining
            Management.SkipTopFive(productReviewList);
        }
    }
}