using HepsiBurada.Domain.Common;

namespace HepsiBurada.Domain.Entities
{
    public class Product : EntityBase
    {
        public string Title {  get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal Discount {  get; set; }
        public int BrandId {  get; set; }
        public Brand Brand { get; set; }
        public ICollection<Category> Categories { get; set; }
        //public required string PhotoPath {  get; set; }
    }
}
