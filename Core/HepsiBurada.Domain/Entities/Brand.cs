using HepsiBurada.Domain.Common;

namespace HepsiBurada.Domain.Entities
{
    // Markalar
    public class Brand : EntityBase
    {
        public Brand()
        {
            
        }
        public Brand(string name)
        {
            Name = name;
        }
        public required string Name { get; set; }
    }
}
