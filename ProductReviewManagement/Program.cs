
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
            //Retrieve top 3 from list
            Management.RetrieveTopThree(productReviewList);
        }
    }
}