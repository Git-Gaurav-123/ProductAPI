﻿namespace ProductAPI.Data.Entities
{
    public class Product
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }

        public string ProductCode { get; set; }

        public string ReleaseDate { get; set; }

        public double Price { get; set; }

        public string Description { get; set; }

        public double StarRating { get; set; }

        public string ImageUrl { get; set; }
    }
}
