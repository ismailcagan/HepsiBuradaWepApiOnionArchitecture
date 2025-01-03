﻿using HepsiBurada.Domain.Common;

namespace HepsiBurada.Domain.Entities
{
    public class Category : EntityBase
    {
        public Category() {   }
        public Category(int parendId, string name, int priorty)
        {
            ParendId = parendId;
            Name = name;
            Priorty = priorty;
        }
        public int ParendId { get; set; }
        public string Name { get; set; }
        public int Priorty { get; set; }
        public ICollection<Detail> Details { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
