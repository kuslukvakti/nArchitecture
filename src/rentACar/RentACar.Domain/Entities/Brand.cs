namespace RentACar.Domain.Entities
{
    using Core.Persistence.Repositories;
    using System.Collections.Generic;

    public class Brand : Entity
    {
        public string Name { get; set; }

        public virtual ICollection<Model> Models { get; set; }

        public Brand()
        {
        }

        public Brand(int id, string name) : this()
        {
            Id = id;
            Name = name;
        }
    }
}
