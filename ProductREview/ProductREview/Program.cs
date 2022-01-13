// See https://aka.ms/new-console-template for more information
using System.Data;
using ProductREview;

Console.WriteLine("***************Product Review Management********************");
//List for product review
List<ProductReview> productReviewList = new List<ProductReview>()
{
    new ProductReview(){ProductID=1,UserID=1,Rating=5,Review="Bad",Islike=false},
    new ProductReview(){ProductID=2,UserID=1,Rating=4,Review="Good",Islike=true},
    new ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Good",Islike=true},
    new ProductReview(){ProductID=4,UserID=1,Rating=6,Review="Good",Islike=false},
    new ProductReview(){ProductID=5,UserID=1,Rating=2,Review="Very Good",Islike=true},
    new ProductReview(){ProductID=6,UserID=1,Rating=1,Review="Bad",Islike=false},
    new ProductReview(){ProductID=7,UserID=1,Rating=10,Review="Good",Islike=false},
    new ProductReview(){ProductID=8,UserID=1,Rating=9,Review="Very Nice",Islike=true},
    new ProductReview(){ProductID=9,UserID=1,Rating=10,Review="Nice",Islike=true},
    new ProductReview(){ProductID=10,UserID=1,Rating=8,Review="Nice",Islike=true},
};
//Display list
foreach (var product in productReviewList)
{
    Console.WriteLine("----------------------------------------");
    Console.WriteLine(product.ProductID +" | " +product.UserID + " | " +product.Rating + " | " +product.Review + " | " +product.Islike );
}