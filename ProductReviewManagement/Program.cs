﻿using System;
using System.Collections.Generic;
using System.Data;

namespace ProductReviewManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prodcut Review Management!!!!!!!!");
            Console.WriteLine("Adding a Prodcut Review In list");
            int option = Convert.ToInt32(Console.ReadLine());
            //Creating a list for Product Review
            List<ProductReview> productReviews = new List<ProductReview>();
            switch(option)
            {
                case 1:
                    ProductReviewManager.AddingProductReview(productReviews);
                    break;
                case 2:
                    ProductReviewManager.RetrieveTopThreeRating(productReviews);
                    break;
                    case 3:
                    ProductReviewManager.RetrieveRecordsBasedOnRatingAndProductId(productReviews);
                    break;
                case 4:
                    ProductReviewManager.CountingProductId(productReviews);
                    break;
                case 5:
                    ProductReviewManager.RetrieveOnlyProductIdAndReviews(productReviews);
                    break;
                case 6:
                    ProductReviewManager.SkipTopFiveRecords(productReviews);
                    break;

                case 7:
                    ProductReviewManager.AddingProductReview(productReviews);
                    ProductReviewManager.CreateDataTable(productReviews);
                    break;
                case 8:
             
                    ProductReviewManager.ReturnsOnlyIsLikeFieldAsTrue();
                    ProductReviewManager.AverageOfRating();
                    break;
                case 9:
                    ProductReviewManager.ReturnsReviewMessageContainsGood();
                    break;
                //case 10:
                //    ProductReviewManager.RetrieverecordsParticularUserIdAndPrderByRating(1);
                //    break;
                case 11:
                   // DataTable dataTable = new DataTable();
                    ProductReviewManager.RetrieveRecordBasedOnRatingAndUserId();
                    break;
            }
        }
    }
}
