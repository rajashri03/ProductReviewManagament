// See https://aka.ms/new-console-template for more information
using System.Data;
using ProductREview;

Console.WriteLine("***************Product Review Management********************");
//List for product review
List<ProductReview> productReviewList = new List<ProductReview>()
{
    new ProductReview(){ProductID=1,UserID=1,Rating=9,Review="Bad",Islike=false},
    new ProductReview(){ProductID=1,UserID=1,Rating=4,Review="Nice",Islike=true},
    new ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Good",Islike=true},
    new ProductReview(){ProductID=3,UserID=1,Rating=6,Review="Nice",Islike=false},
    new ProductReview(){ProductID=3,UserID=1,Rating=5,Review="Very Good",Islike=true},
    new ProductReview(){ProductID=6,UserID=1,Rating=1,Review="Bad",Islike=false},
    new ProductReview(){ProductID=7,UserID=1,Rating=10,Review="Good",Islike=false},
    new ProductReview(){ProductID=8,UserID=1,Rating=9,Review="Nice",Islike=true},
    new ProductReview(){ProductID=10,UserID=1,Rating=10,Review="Nice",Islike=true},
    new ProductReview(){ProductID=10,UserID=1,Rating=10,Review="Nice",Islike=true},
    new ProductReview(){ProductID=10,UserID=1,Rating=3,Review="Bad",Islike=false},
    new ProductReview(){ProductID=10,UserID=1,Rating=4,Review="Nice",Islike=true},
    new ProductReview(){ProductID=10,UserID=1,Rating=5,Review="Nice",Islike=true},
    new ProductReview(){ProductID=10,UserID=1,Rating=8,Review="Nice",Islike=true},
};

Console.WriteLine("Select \n1)CreateProductReview\n2)Retrive Top 3 Review\n3)retrive record whose rating >3\n" +
    "4)GroupBy\n5)Retrive ProductId and review\n6)SkipTop5Records\n7)Datatable\n8)Find average rating\n9)Find Nice review Data\n10)Retrive data who's Id is 10");
int option = Convert.ToInt16(Console.ReadLine());
switch(option)
{
    case 1:
        //Display list
        foreach (var product in productReviewList)
        {
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(product.ProductID + " | " + product.UserID + " | " + product.Rating + " | " + product.Review + " | " + product.Islike);
        }
        break;
    case 2:
        ProductManagement.Top3Records(productReviewList);
        break;
    case 3:
        ProductManagement.RetriveRecords(productReviewList);
        break;
    case 4:
        ProductManagement.CountRecords(productReviewList);
        break;
    case 5:
        ProductManagement.RetriveProductIDReview(productReviewList);
        break;
    case 6:
        ProductManagement.SkipTop5Records(productReviewList);
        break;
    case 7:
        ProductManagement.Datatables();
        break;
    case 8:
        ProductManagement.AvgRating(productReviewList);
        break;
    case 9:
        ProductManagement.NiceReview(productReviewList);
        break;
    case 10:
        ProductManagement.OneIdData(productReviewList);
        break;
    default:
        Console.WriteLine("Wrong Choice");
        break;
}
