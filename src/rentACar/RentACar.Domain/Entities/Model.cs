﻿namespace RentACar.Domain.Entities
{
    using Core.Persistence.Repositories;

    public class Model : Entity
    {
        public int BrandId { get; set; }    
        public string Name { get; set; }    
        public decimal DailyPrice { get; set; }
        public string ImageUrl { get; set; }    
        public Brand? Brand { get; set; }

        public Model()
        {
        }

        public Model(int id, int brandId, string name, decimal dailyPrice, string imageUrl): this()
        {
            Id = id;
            BrandId = brandId;
            Name = name;
            DailyPrice = dailyPrice;
            ImageUrl = imageUrl;
        }
    }
}
