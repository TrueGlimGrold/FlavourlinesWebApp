using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace FlavourlinesWebApp.Models
{
    public class Review
    {

        public int ReviewId { get; set; }
        public int ProductId { get; set; } // Foreign key for Product
        public string UserId { get; set; } // Matches IdentityUser.Id
        public User User { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime CreatedAt { get; set; }

        public Product Product { get; set; }

        // Default Constructor
        public Review() { }

        // Parameterized Constructor
        public Review(int reviewId, int productId, string userId, int rating, string comment, DateTime createdAt)
        {
            ReviewId = reviewId;
            ProductId = productId;
            UserId = userId;
            Rating = rating;
            Comment = comment;
            CreatedAt = createdAt;
        }
    }
}
