namespace RentACar.Domain.Entities
{
    using Core.Persistence.Repositories;

    public class Brand : Entity
    {
        public string Name { get; set; }

        public Brand()
        {
        }

        public Brand(int id, string name) : this() //this() parametresiz constructor calistirir
        {
            Id = id;
            Name = name;
        }
    }
}
