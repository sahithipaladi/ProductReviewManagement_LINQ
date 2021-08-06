
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
            Management.AddProductReviews(productReviewList);
            Management.IterateList(productReviewList);
        }
    }
}