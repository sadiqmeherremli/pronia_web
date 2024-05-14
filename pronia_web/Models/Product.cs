﻿namespace pronia_web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int? CategorytId { get; set; }
        public Category? Category { get; set; }
        public string MainPhotoUrl { get; set; }
        public string PhotoUrl { get; set; }

    }
}